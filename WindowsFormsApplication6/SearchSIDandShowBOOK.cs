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
    public partial class SearchSIDandShowBOOK : Form
    {
        public SearchSIDandShowBOOK()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            SqlCommand com = new SqlCommand(@"Select StudentID from Members where StudentID like @studentid", SQLConnection.Connection);
            com.Parameters.AddWithValue("@studentid", "%" + textBox1.Text + "%");
            com.Connection.Open();
            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                listBox1.Items.Add(dr.GetInt32(0).ToString());
            }
            SQLConnection.Connection.Close();

        }

        private void SearchSIDandShowBOOK_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowEverything.Items.Clear();

            SqlCommand com = new SqlCommand("Select StudentID,BookID,LendedDate from LendedBOOKS where StudentID=@studentid and IsReturnedBack=0", SQLConnection.Connection);
            com.Parameters.AddWithValue("@studentid", listBox1.SelectedItem.ToString());
            com.Connection.Open();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {

                {
                    string[] items = { dr.GetInt32(0).ToString(),
                                       dr.GetInt32(1).ToString(), 
                                       dr.GetDateTime(2).ToShortDateString()
                                     };
                    ListViewItem item = new ListViewItem(items);

                    ShowEverything.Items.Add(item);
                }

            }
            SQLConnection.Connection.Close();
        }

        private void chkDelivered_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               
                string komut = "SELECT * FROM BooksInfo Where bookISBN = @ID;";
                SqlCommand kom = new SqlCommand(komut, SQLConnection.Connection);
                kom.Parameters.AddWithValue("@ID", srchBook.Text);
                kom.Connection.Open();
                SqlDataReader re = kom.ExecuteReader();
                if (srchBook.Text == "")
                {
                    shwBook.Text = "The book could not be found.";
                }
                else
                {
                    while (re.Read())
                    {



                        Books b = new Books();
                        shwBook.Text = re.GetString(2);
                    }

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { SQLConnection.Connection.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (chkDelivered.Checked)
                {
                    string commString = "UPDATE LendedBOOKS SET IsReturnedBack = 1 WHERE StudentID=@SID AND BookID=@BID;";
                    SqlCommand comm = new SqlCommand(commString, SQLConnection.Connection);
                    comm.Parameters.AddWithValue("@SID", listBox1.SelectedItem.ToString());
                    comm.Parameters.AddWithValue("@BID", Convert.ToInt32(ShowEverything.SelectedItems[0].SubItems[1].Text));
                    comm.Connection.Open();
                    int sonuc = comm.ExecuteNonQuery();
                    if (sonuc >= 1)
                    {
                        string comString = "UPDATE BooksInfo SET Quantity = Quantity+1 WHERE BookISBN=@BID";
                        SqlCommand com = new SqlCommand(comString, SQLConnection.Connection);
                        com.Parameters.AddWithValue("@BID", Convert.ToInt32(ShowEverything.SelectedItems[0].SubItems[1].Text));
                        com.Connection.Open();
                        com.ExecuteNonQuery();
                        MessageBox.Show("Updated");
                        ShowEverything.Refresh();

                    }
                    else //if(!chkDelivered.Checked)
                    {
                        MessageBox.Show("Error");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Please Select a book.");
            }
            finally { SQLConnection.Connection.Close(); }
        }

        private void srchBook_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            srchBook.Clear();
            shwBook.ResetText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            this.Hide();
            obj.ShowDialog();
        }
    }
}
