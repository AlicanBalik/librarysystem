using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication6
{
    public partial class EditBook : Form
    {
        public EditBook()
        {
            InitializeComponent();
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void EditBook_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                cmbQuantity.Items.Add(i);
            }
            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                cmbYear.Items.Add(i);
            }

            string commString = "SELECT * FROM BooksInfo";
            SqlCommand comm = new SqlCommand(commString, SQLConnection.Connection);
            comm.Connection.Open();

            SqlDataReader zaList = comm.ExecuteReader();
            while (zaList.Read())
            {
                BookEdit b = new BookEdit();

                b.ISBN = zaList.GetInt32(0);
                b.BookName = zaList.GetString(1);
                b.Author = zaList.GetString(2);
                b.Year = zaList.GetInt32(3);
                b.Language = zaList.GetInt32(4);
                b.Category = zaList.GetInt32(5);
                b.Quantity = zaList.GetInt32(6);

                listBookID.Items.Add(b);

            }
            SQLConnection.Connection.Close();

            string forCategory = "Select CategoryID, Description from Categories";
            SqlDataAdapter adapter = new SqlDataAdapter(forCategory, SQLConnection.Connection);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);

            cmbCategory.DataSource = dtable;
            cmbCategory.DisplayMember = "Description";
            cmbCategory.ValueMember = "CategoryID";


            string zaLanguage = "Select ID, Language from Language";
            SqlDataAdapter da = new SqlDataAdapter(zaLanguage, SQLConnection.Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbLanguage.DataSource = dt;
            cmbLanguage.DisplayMember = "Language";
            cmbLanguage.ValueMember = "ID";
        }

        private void listBookID_SelectedIndexChanged(object sender, EventArgs e)
        {



            if (listBookID.SelectedIndex != -1)
            {
                BookEdit obj = (BookEdit)listBookID.SelectedItem;
                txtISBN.Text = obj.ISBN.ToString();
                txtAuthor.Text = obj.Author.ToString();
                txtName.Text = obj.BookName.ToString();
                cmbYear.Text = obj.Year.ToString();
                cmbCategory.SelectedValue = obj.Category.ToString();
                cmbLanguage.SelectedValue = obj.Language.ToString();
                cmbQuantity.Text = obj.Quantity.ToString();

            }

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            this.Hide();
            obj.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtISBN.Text != "" && txtName.Text != "" && txtAuthor.Text != "" && cmbYear.SelectedIndex != -1 && cmbLanguage.SelectedIndex != -1 && cmbCategory.SelectedIndex != -1)
            {
                try
                {

                    string commString = @"UPDATE BooksInfo SET bookISBN=@ISBN, bookName=@Name, bookAuthor=@Author, PublishedYear=@Year, Language=@Language, CategoryID=@Category, Quantity=@Quantity WHERE bookISBN = @ListISBN";
                    SqlCommand comm = new SqlCommand(commString, SQLConnection.Connection);

                    comm.Parameters.AddWithValue("@ListISBN", listBookID.SelectedItem.ToString());
                    comm.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                    comm.Parameters.AddWithValue("@Name", txtName.Text);
                    comm.Parameters.AddWithValue("@Author", txtAuthor.Text);
                    comm.Parameters.AddWithValue("@Year", cmbYear.Text);
                    comm.Parameters.AddWithValue("@Language", cmbLanguage.SelectedValue);
                    comm.Parameters.AddWithValue("@Category", cmbCategory.SelectedValue);
                    comm.Parameters.AddWithValue("@Quantity", cmbQuantity.Text);
                    comm.Connection.Open();
                    int result = comm.ExecuteNonQuery();
                    if (result != -1)
                    {
                        MessageBox.Show("Book has been successfully editted.");
                    }
                    else
                    {
                        MessageBox.Show("HATA");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


                finally { SQLConnection.Connection.Close(); }
            }
            else
            {
                MessageBox.Show("Make sure that you have filled all blanks.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtISBN.Text != "" && txtName.Text != "" && txtAuthor.Text != "" && cmbYear.SelectedIndex != -1 && cmbLanguage.SelectedIndex != -1 && cmbCategory.SelectedIndex != -1)
            {
                
                string komut = "DELETE BooksInfo WHERE bookISBN = @ISBN";
                SqlCommand ko = new SqlCommand(komut, SQLConnection.Connection);
                
                ko.Parameters.AddWithValue("@ISBN", listBookID.Text);
                ko.Connection.Open();
                int result = ko.ExecuteNonQuery();
                if (result != -1)
                {
                    MessageBox.Show("Book has been deleted.");
                    txtName.Clear();
                    txtAuthor.Clear();
                    txtISBN.Clear();
                    cmbCategory.ResetText();
                    cmbLanguage.ResetText();
                    cmbYear.ResetText();
                    listBookID.Items.RemoveAt(listBookID.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("User cannot be deleted.");
                }

                SQLConnection.Connection.Close();
            }
            else
            {
                MessageBox.Show("Select a student");
            }
        }
    }
}
