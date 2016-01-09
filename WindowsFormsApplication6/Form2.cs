using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnABook_Click(object sender, EventArgs e)
        {
            AddBook addbook = new AddBook();
            this.Hide();
            addbook.Show();
        }

        private void btnBBook_Click(object sender, EventArgs e)
        {
            Lending obj = new Lending();
            this.Hide();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMember addmember = new AddMember();
            this.Hide();
            addmember.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EditMember Edit = new EditMember();
            this.Hide();
            Edit.Show(); 
        }

        private void btnShowSIDBOOK_Click(object sender, EventArgs e)
        {
            SearchSIDandShowBOOK obj = new SearchSIDandShowBOOK();
            this.Hide();
            obj.Show();
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            EditBook obj = new EditBook();
            this.Hide();
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchByLanguage obj = new SearchByLanguage();
            this.Hide();
            obj.Show();
        }
    }
}
