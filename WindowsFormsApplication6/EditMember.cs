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

        SqlConnection Conn;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtEMail.Text != "" && txtName.Text != "" && txtSurname.Text != "" && txtTelephone.Text != "" && cmbDepartment.SelectedIndex != -1 && cmbYear.SelectedIndex != -1)
            {
                try
                {
                    Conn = new SqlConnection(@"Data Source = (localdb)\v11.0; Initial Catalog = Library System; Integrated security = true;");
                    string commString = "UPDATE Members SET StudentID=@SID,Name=@Name,Surname=@Surname,Department=@Department,Year=@Year,Telephone=@Telephone,Email=@Email WHERE StudentID=@SID;";
                    SqlCommand comm = new SqlCommand(commString, Conn);
                    comm.Parameters.AddWithValue("@Name", txtName.Text);
                    comm.Parameters.AddWithValue("@SID", listStudentID.Text);
                    comm.Parameters.AddWithValue("@Surname", txtSurname.Text);
                    comm.Parameters.AddWithValue("@Department", cmbDepartment.SelectedValue); // selectedvalue
                    comm.Parameters.AddWithValue("@Year", cmbYear.Text);
                    comm.Parameters.AddWithValue("@Telephone", txtTelephone.Text);
                    comm.Parameters.AddWithValue("@Email", txtEMail.Text);
                    Conn.Open();
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
                { Conn.Close(); }
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
            Conn = new SqlConnection(@"Data Source = (Localdb)\v11.0; Initial Catalog = Library System; Integrated Security = true;");
            string comString = ("Select DepartmentName from Department;");
            SqlCommand com = new SqlCommand(comString, Conn);
            Conn.Open();
            SqlDataReader departmentread = com.ExecuteReader();
            while (departmentread.Read())
            {
                cmbDepartment.Items.Add(departmentread.GetString(0));
            }
            Conn.Close();

            Conn = new SqlConnection(@"Data Source = (Localdb)\v11.0; Initial Catalog = Library System; Integrated Security = true;");
            string commaString = "SELECT * FROM Members;";
            SqlCommand comm = new SqlCommand(commaString, Conn);
            Conn.Open();
            SqlDataReader liststd = comm.ExecuteReader();


            while (liststd.Read())
            {
                EditMemberClass zdravo = new EditMemberClass();
                zdravo.StudentID = liststd.GetInt32(0);
                zdravo.Name = liststd.GetString(1);
                zdravo.Surname = liststd.GetString(2);
                zdravo.Department = liststd.GetInt32(3);
                zdravo.Year = liststd.GetInt32(4);
                zdravo.Telephone = liststd.GetInt32(5); // // 
                zdravo.Email = liststd.GetString(6);

                listStudentID.Items.Add(zdravo);
            }

            Conn.Close();

            string commString = ("Select ID, DepartmentName from Department");

            SqlDataAdapter da = new SqlDataAdapter(commString, Conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbDepartment.DataSource = dt;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtEMail.Text != "" && txtName.Text != "" && txtSurname.Text != "" && txtTelephone.Text != "" && cmbDepartment.SelectedIndex != -1 && cmbYear.SelectedIndex != -1)
            {
                Conn = new SqlConnection(@"Data Source = (Localdb)\v11.0; Initial Catalog = Library System; Integrated Security = True;");
                string komut = "DELETE Members WHERE StudentID = @SID";
                SqlCommand ko = new SqlCommand(komut, Conn);
                Conn.Open();
                ko.Parameters.AddWithValue("@SID", listStudentID.Text);
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

                Conn.Close();
            }
            else
            {
                MessageBox.Show("Select a student");
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
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
