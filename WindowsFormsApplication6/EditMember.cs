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
    public partial class EditMember : Form
    {
        public EditMember()
        {
            InitializeComponent();
        }

        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtEMail.Text != "" && txtName.Text != "" && txtSurname.Text != "" && txtTelephone.Text != "" && cmbDepartment.SelectedIndex != -1 && cmbYear.SelectedIndex != -1 && IsValidPhone(txtTelephone.Text))
            {
                try
                {
                    
                    string commString = "UPDATE Members SET StudentID=@SID,Name=@Name,Surname=@Surname,Department=@Department,Year=@Year,Telephone=@Telephone,Email=@Email WHERE StudentID=@SID;";
                    SqlCommand comm = new SqlCommand(commString, SQLConnection.Connection);
                    comm.Parameters.AddWithValue("@Name", txtName.Text);
                    comm.Parameters.AddWithValue("@SID", listStudentID.Text);
                    comm.Parameters.AddWithValue("@Surname", txtSurname.Text);
                    comm.Parameters.AddWithValue("@Department", cmbDepartment.SelectedValue); // selectedvalue
                    comm.Parameters.AddWithValue("@Year", cmbYear.Text);
                    comm.Parameters.AddWithValue("@Telephone", txtTelephone.Text);
                    comm.Parameters.AddWithValue("@Email", txtEMail.Text);
                    comm.Connection.Open();
                    int result = comm.ExecuteNonQuery();
                    if (result != -1)
                    {
                        MessageBox.Show("User has been edited");
                    }
                    else
                    {
                        MessageBox.Show("All blanks has to be filled");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                { SQLConnection.Connection.Close(); }
            }
            else
            {
                MessageBox.Show("Make sure that you have filled all blanks.");
            }
        }

        private void listStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listStudentID.SelectedIndex != -1)
            {
                EditMemberClass zdravo = (EditMemberClass)listStudentID.SelectedItem;
                listStudentID.Text = zdravo.StudentID.ToString();
                txtName.Text = zdravo.Name.ToString();
                txtSurname.Text = zdravo.Surname.ToString();
                cmbDepartment.SelectedValue = zdravo.Department.ToString(); //
                cmbYear.Text = zdravo.Year.ToString();
                txtTelephone.Text = zdravo.Telephone.ToString();
                txtEMail.Text = zdravo.Email.ToString();
            }
        }

        private void EditMember_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++)
            {
                cmbYear.Items.Add(i);
            }
            // //
            
            string comString = ("Select DepartmentName from Department;");
            SqlCommand com = new SqlCommand(comString, SQLConnection.Connection);
            com.Connection.Open();
            SqlDataReader departmentread = com.ExecuteReader();
            while (departmentread.Read())
            {
                cmbDepartment.Items.Add(departmentread.GetString(0));
            }
            com.Connection.Close();

            
            string commaString = "SELECT * FROM Members;";
            SqlCommand comm = new SqlCommand(commaString, SQLConnection.Connection);
            comm.Connection.Open();
            SqlDataReader liststd = comm.ExecuteReader();

            while (liststd.Read())
            {
                EditMemberClass zdravo = new EditMemberClass();
                zdravo.StudentID = liststd.GetInt32(0);
                zdravo.Name = liststd.GetString(1);
                zdravo.Surname = liststd.GetString(2);
                zdravo.Department = liststd.GetInt32(3);
                zdravo.Year = liststd.GetInt32(4);
                zdravo.Telephone = liststd.GetString(5);
                zdravo.Email = liststd.GetString(6);
                listStudentID.Items.Add(zdravo); 
            }

            SQLConnection.Connection.Close();
            string commString = ("Select ID, DepartmentName from Department");

            SqlDataAdapter da = new SqlDataAdapter(commString, SQLConnection.Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbDepartment.DataSource = dt;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";

        }

        public bool IsValidPhone(string Phone)
        { // http://stackoverflow.com/questions/18091324/regex-to-match-all-us-phone-number-formats
            try
            {
                if (string.IsNullOrEmpty(Phone))
                    return false;
                var r = new System.Text.RegularExpressions.Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{3}");
                return r.IsMatch(Phone);

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtEMail.Text != "" && txtName.Text != "" && txtSurname.Text != "" && txtTelephone.Text != "" && cmbDepartment.SelectedIndex != -1 && cmbYear.SelectedIndex != -1)
            {
                
                string komut = "DELETE Members WHERE StudentID = @SID";
                SqlCommand ko = new SqlCommand(komut, SQLConnection.Connection);
                
                ko.Parameters.AddWithValue("@SID", listStudentID.Text);
                ko.Connection.Open();
                int result = ko.ExecuteNonQuery();
                if (result != -1)
                {
                    MessageBox.Show("User has been deleted.");
                    txtName.Clear();
                    txtSurname.Clear();
                    txtEMail.Clear();
                    txtTelephone.Clear();
                    listStudentID.Items.RemoveAt(listStudentID.SelectedIndex);
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

        private void btnMain_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            this.Hide();
            obj.ShowDialog();
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTelephone_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
