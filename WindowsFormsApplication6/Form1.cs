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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        { 
            try
            {

                SqlCommand comm = new SqlCommand("SELECT Name FROM Admin WHERE Username = @username AND Password = @password;", SQLConnection.Connection);
                comm.Parameters.AddWithValue("@username", txtLoginID.Text);
                comm.Parameters.AddWithValue("@password", txtLoginPass.Text);
                comm.Connection.Open();
                object result = comm.ExecuteScalar();
                // scalar select icin- nonquery tsql kodlari icin
                if (result!=null) // checks value    
                {
                    // lf it has                                        
                    MessageBox.Show("Welcome " + result.ToString()); // tostring()  converts variable which comes as object to string
                    Form2 form2 = new Form2();
                    this.Hide();
                    form2.ShowDialog();
                   
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password.");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally {
                SQLConnection.Connection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
