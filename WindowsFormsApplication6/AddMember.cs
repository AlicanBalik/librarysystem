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
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 mainmenu = new Form2();
            this.Hide();
            mainmenu.ShowDialog();
        }
        //resetting all blanks
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEMail.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtTelephone.Clear();
            txtSID.Clear();

        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtSID.Text!="" && txtEMail.Text != "" && txtName.Text!= "" && txtSurname.Text!="" && txtTelephone.Text!="" && cmbDepartment.SelectedIndex!=-1 && cmbYear.SelectedIndex!=-1)
            {
               
                if (true)
                {
                    try
                    {
                       
                        string commString = "ADD_NEW_USER";
                        SqlCommand comm = new SqlCommand(commString, SQLConnection.Connection);
                        comm.CommandType = CommandType.StoredProcedure; // // // //
                        DateTime dTime = DateTime.Now;
                        string str = dTime.ToString("dd-MM-yyy HH:mm");
                        comm.Parameters.AddWithValue("@SID", txtSID.Text);
                        comm.Parameters.AddWithValue("@Name", txtName.Text);
                        comm.Parameters.AddWithValue("@Surname", txtSurname.Text);
                        comm.Parameters.AddWithValue("@DepartmentID", cmbDepartment.SelectedValue);
                        comm.Parameters.AddWithValue("@UnivYear", cmbYear.Text);
                        comm.Parameters.AddWithValue("@Telephone", txtTelephone.Text);
                        comm.Parameters.AddWithValue("@EMail", txtEMail.Text);
                        comm.Parameters.AddWithValue("@Date", dTime);
                        comm.Connection.Open();
                        int result = Convert.ToInt32(comm.ExecuteScalar());

                        if (result == 1)
                        {
                            MessageBox.Show("User has been registered successfully");
                        }
                        else if (result == 0)
                        {
                            MessageBox.Show("This User ID already exists");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Integer Error ! \n Student ID and Telephone cannot contain letters");
                        
                    }

                    finally
                    { SQLConnection.Connection.Close(); }
                }
                else
                {
                    MessageBox.Show("Phone number cannot contain characters.");
                }
            }
            else
            {
                MessageBox.Show("Make sure you have filled all blanks");
            }
        }



        private void AddMember_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++)
            {
                cmbYear.Items.Add(i);
            }

            try
            {
               
                string commString = ("Select ID, DepartmentName from Department");

                SqlDataAdapter da = new SqlDataAdapter(commString, SQLConnection.Connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbDepartment.DataSource = dt;
                cmbDepartment.DisplayMember = "DepartmentName";
                cmbDepartment.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
