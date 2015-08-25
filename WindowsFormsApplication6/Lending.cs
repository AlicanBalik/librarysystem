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
        SqlConnection Conn;
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(@"Data source = (localdb)\v11.0; Initial Catalog = Library System; Integrated Security = true;");
            SqlCommand strComm = new SqlCommand("SELECT * FROM lendedBOOKS WHERE StudentID = @StdID AND BookID = @BkID AND IsReturnedBack = '0';", Conn);
            strComm.Parameters.AddWithValue("@StdID", listBox1.SelectedIndex); 
            strComm.Parameters.AddWithValue("@BkID", listBName.SelectedIndex);
            Conn.Open();
            object obj = strComm.ExecuteScalar();
            if (obj == null)
            {
                // int alican = Convert.ToInt32(obj);
                if (listBox1.SelectedIndex != -1)//&& alican != 0)
                {
                    try
                    {
                        Conn = new SqlConnection(@"Data Source = (Localdb)\v11.0; Initial Catalog = Library System; Integrated Security = true;");
                        string comString = "Select Quantity FROM BooksInfo WHERE bookISBN = @BISBN";
                        SqlCommand com = new SqlCommand(comString, Conn);
                        com.Parameters.AddWithValue("@BISBN", label8.Text);
                        Conn.Open();
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
                                Conn = new SqlConnection(@"Data Source = (Localdb)\v11.0; Initial Catalog = Library System; Integrated Security = true;");
                                string commString = "INSERT INTO lendedBOOKS (StudentID, BookID, lendedDate, IsReturnedBack) VALUES (@SID,@BID ,@LDATE,0);";
                                SqlCommand comm = new SqlCommand(commString, Conn);
                                comm.Parameters.AddWithValue("@SID", listBox1.Text);
                                comm.Parameters.AddWithValue("@BID", label8.Text);
                                DateTime shisha = DateTime.Now;
                                string zaString = shisha.ToString();
                                comm.Parameters.AddWithValue("@LDATE", shisha);
                                Conn.Open();
                                int result = comm.ExecuteNonQuery();
                                if (result != -1)
                                {
                                    string coString = @"UPDATE BooksInfo SET Quantity = Quantity-1 WHERE BookISBN=@BID";
                                    SqlCommand co = new SqlCommand(coString, Conn);
                                    co.Parameters.AddWithValue("@BID", label8.Text);
                                    co.ExecuteNonQuery();
                                    MessageBox.Show("Book has been lent successfully.");
                                }
                                else
                                {
                                    MessageBox.Show("Check the form again.");
                                }
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { Conn.Close(); }
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
            Conn.Close();
        }

        private void listBName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBName.SelectedIndex != -1) // prevents to get an error when clicking an empty area
            {
                Books b = (Books)listBName.SelectedItem;
                label8.Text = b.ISBN.ToString();
                label9.Text = b.Author.ToString();
                label10.Text = b.PublishedYear.ToString();
                


            }
        }

        private void Lending_Load(object sender, EventArgs e)
        {
            Conn = new SqlConnection(@"Data Source = (Localdb)\v11.0; Initial Catalog = Library System; Integrated Security = true;");
            string commString = "SELECT * FROM BooksInfo;";
            SqlCommand comm = new SqlCommand(commString, Conn);
            Conn.Open();
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
            Conn.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Form2 Form = new Form2();
            Form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Conn = new SqlConnection(@"Data Source = (Localdb)\v11.0; Initial Catalog = Library System; Integrated Security = true;");
            SqlCommand com = new SqlCommand("Select StudentID from Members where StudentID like  @studentid", Conn);
            com.Parameters.AddWithValue("@studentid", "%" + textBox1.Text + "%");
            Conn.Open();
            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                listBox1.Items.Add(dr.GetInt32(0).ToString());
            }
            Conn.Close();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
