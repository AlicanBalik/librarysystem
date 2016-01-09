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
    public partial class Lending : Form
    {
        public Lending()
        {
            InitializeComponent();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {

            SqlCommand strComm = new SqlCommand("SELECT * FROM lendedBOOKS WHERE StudentID = @StdID AND BookID = @BkID AND IsReturnedBack = '0';", SQLConnection.Connection);
            strComm.Parameters.AddWithValue("@StdID", listBox1.SelectedIndex);
            strComm.Parameters.AddWithValue("@BkID", listBName.SelectedIndex);
            strComm.Connection.Open();
            object obj = strComm.ExecuteScalar();
            if (obj == null)
            {
                // int alican = Convert.ToInt32(obj);
                if (listBox1.SelectedIndex != -1)//&& alican != 0)
                {
                    try
                    {

                        string comString = "Select Quantity FROM BooksInfo WHERE bookISBN = @BISBN";
                        SqlCommand com = new SqlCommand(comString, SQLConnection.Connection);
                        com.Parameters.AddWithValue("@BISBN", label8.Text);
                        com.Connection.Open();
                        object WantToPassTheCourse = com.ExecuteScalar();
                        if (WantToPassTheCourse != null)
                        {
                            int sonuc = Convert.ToInt32(WantToPassTheCourse);
                            if (sonuc == 0)
                            {
                                MessageBox.Show("Quantity of Book you selected is 0 in the Library");
                            }
                            else
                            {



                                string commString = "RENT_BOOK";
                                SqlCommand comm = new SqlCommand(commString, SQLConnection.Connection);
                                comm.CommandType = CommandType.StoredProcedure;
                                comm.Parameters.AddWithValue("@StudentID", listBox1.Text);
                                comm.Parameters.AddWithValue("@BookID", label8.Text);
                                comm.Parameters.AddWithValue("@DueDate", dtDueDate.Text);
                                DateTime shisha = DateTime.Now;
                                string zaString = shisha.ToString();
                                comm.Parameters.AddWithValue("@LDATE", shisha);
                                comm.Connection.Open();
                                int result = Convert.ToInt32(comm.ExecuteScalar());
                                if (result == 1)
                                {
                                    MessageBox.Show("Book has been lent successfully.");
                                }
                                else
                                {
                                    MessageBox.Show("3 books");
                                }
                                // tertemiz mis 
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        // MessageBox.Show("Error occured. Call us.");
                    }
                    finally { SQLConnection.Connection.Close(); }
                }
                else
                {
                    MessageBox.Show("Choose a student");
                }
            }
            else
            {
                MessageBox.Show("The student cannot take the same book 2 times.");
            }
            SQLConnection.Connection.Close();
        }

        private void listBName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBName.SelectedIndex != -1) // prevents to get an error when clicking empty area
            {
                Books b = (Books)listBName.SelectedItem;
                label8.Text = b.ISBN.ToString();
                label9.Text = b.Author.ToString();
                label10.Text = b.PublishedYear.ToString();
            }
        }

        private void Lending_Load(object sender, EventArgs e)
        {

            string commString = "SELECT * FROM BooksInfo;";
            SqlCommand comm = new SqlCommand(commString, SQLConnection.Connection);
            comm.Connection.Open();
            SqlDataReader listreader = comm.ExecuteReader();
            while (listreader.Read())
            {
                Books b = new Books();

                b.ISBN = listreader.GetInt32(0);
                b.BookName = listreader.GetString(1);
                b.Author = listreader.GetString(2);
                b.PublishedYear = listreader.GetInt32(3);

                listBName.Items.Add(b);
            }
            SQLConnection.Connection.Close();

            dtDueDate.MinDate = DateTime.Now;
            dtDueDate.MaxDate = DateTime.Now.AddDays(31);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Form2 Form = new Form2();
            this.Hide();
            Form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            SqlCommand com = new SqlCommand("Select StudentID from Members where StudentID like  @studentid", SQLConnection.Connection);
            com.Parameters.AddWithValue("@studentid", "%" + textBox1.Text + "%");
            com.Connection.Open();
            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                listBox1.Items.Add(dr.GetInt32(0).ToString());
            }
            SQLConnection.Connection.Close();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
