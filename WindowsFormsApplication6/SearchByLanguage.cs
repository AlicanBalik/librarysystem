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
    public partial class SearchByLanguage : Form
    {
        public SearchByLanguage()
        {
            InitializeComponent();
        }
        SqlConnection Conn;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            listLanguage.Items.Clear();
            Conn = new SqlConnection(@"Data Source = (Localdb)\v11.0; Initial Catalog = Library System; Integrated Security = true;");
            string com = "Select Language from BookInfoo where Language like @Language";
            SqlCommand ko = new SqlCommand(com, Conn);
            ko.Parameters.AddWithValue("@Language", "%" + txtLanguage.Text + "%");
            Conn.Open();
            SqlDataReader dr = ko.ExecuteReader();
            //string comm = "Select Language from BooksInfo where Language = @Language;";
            //SqlCommand komut = new SqlCommand(comm, Conn);
            //komut.Parameters.AddWithValue("@Language", txtLanguage.Text);
            //SqlDataAdapter adapter = new SqlDataAdapter(comm, Conn);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //listLanguage.DataSource = dt;
            //listLanguage.DisplayMember = "Language";
            //listLanguage.ValueMember = "ID";
            //SqlDataReader dr = komut.ExecuteReader();

            

            while (dr.Read())
            {
                listLanguage.Items.Add(dr.GetString(0).ToString());
            }
            Conn.Close();
        }

        private void listLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            showList.Items.Clear();
            Conn = new SqlConnection(@"Data Source = (Localdb)\v11.0; Initial Catalog = Library System; Integrated Security = true;");
            string commString = "Select BookName, Language from BookInfoo where Language=@Language";
            SqlCommand com = new SqlCommand(commString, Conn);
            com.Parameters.AddWithValue("@Language", listLanguage.SelectedItem.ToString());
            Conn.Open();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                {
                    string[] items = { dr.GetString(0).ToString(),
                                       dr.GetString(1).ToString() 
                                     };
                    ListViewItem item = new ListViewItem(items);

                    showList.Items.Add(item);
                }
            }
            Conn.Close();
        }

        private void showSve_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchByLanguage_Load(object sender, EventArgs e)
        {

        }
    }
}
