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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void btnABookMMenu_Click(object sender, EventArgs e)
        {
            Form2 mainmenu = new Form2();
            this.Hide();
            mainmenu.ShowDialog();


        }
        private void btnAddBookAdd_Click(object sender, EventArgs e)
        {
            if (txtISBN.Text != "" && txtName.Text != "" && txtAuthor.Text != "" && cmbYear.SelectedIndex != -1 && cmbLanguage.SelectedIndex != -1 && cmbCategory.SelectedIndex != -1)
            {
                try
                {
                    
                    string commString = "INSERT INTO BooksInfo (bookISBN, bookName, bookAuthor, PublishedYear, Language, CategoryID, Quantity) VALUES(@ISBN, @Name, @Author,@Year, @Language, @CategoryID, @Miktar);";
                    SqlCommand comm = new SqlCommand(commString, SQLConnection.Connection);
                    comm.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                    comm.Parameters.AddWithValue("@Name", txtName.Text);
                    comm.Parameters.AddWithValue("@Author", txtAuthor.Text);
                    comm.Parameters.AddWithValue("@Year", cmbYear.Text);
                    comm.Parameters.AddWithValue("@Language", cmbLanguage.SelectedValue);
                    comm.Parameters.AddWithValue("@CategoryID", cmbCategory.SelectedValue);
                    comm.Parameters.AddWithValue("@Miktar", cmbQuantity.Text);
                    comm.Connection.Open();
                    int result = comm.ExecuteNonQuery();
                    if (result != -1)
                    {

                        MessageBox.Show("Book has been added successfully");
                    }
                    else
                    {
                        MessageBox.Show("All blanks has to be filled.");
                    }
                }
                catch (Exception )
                {

                    MessageBox.Show("lnternational Standart Book Number does not contain characters.");
                  
                }
                finally
                {
                    SQLConnection.Connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Make sure that you have filled all blanks.");
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddBook_Load(object sender, EventArgs e)
        {

            for (int i = 20; i > 0; i--)
            {
                cmbQuantity.Items.Add(i.ToString());
            }
            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                cmbYear.Items.Add(i.ToString());
            }
            
            string ccommString = "Select ID, Language FROM Language;";
            SqlDataAdapter AAdapteEt = new SqlDataAdapter(ccommString, SQLConnection.Connection);
            DataTable ddt = new DataTable();
            AAdapteEt.Fill(ddt);
            cmbLanguage.DataSource = ddt;
            cmbLanguage.DisplayMember = "Language";
            cmbLanguage.ValueMember = "ID";

            string commString = "Select CategoryID, Description from Categories;";
            SqlDataAdapter AdapteEt = new SqlDataAdapter(commString, SQLConnection.Connection);
            DataTable dt = new DataTable();
            AdapteEt.Fill(dt);
            cmbCategory.DataSource = dt;
            cmbCategory.DisplayMember = "Description";
            cmbCategory.ValueMember = "CategoryID";


        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {

        }

    }

}

