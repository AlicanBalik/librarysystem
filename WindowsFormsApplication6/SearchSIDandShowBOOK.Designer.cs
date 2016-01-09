namespace WindowsFormsApplication6
{
    partial class SearchSIDandShowBOOK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.ShowEverything = new System.Windows.Forms.ListView();
            this.StudentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LendedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkDelivered = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.srchBook = new System.Windows.Forms.TextBox();
            this.shwBook = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(110, 9);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 19);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Show";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ShowEverything
            // 
            this.ShowEverything.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StudentID,
            this.BookID,
            this.LendedDate});
            this.ShowEverything.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowEverything.FullRowSelect = true;
            this.ShowEverything.GridLines = true;
            this.ShowEverything.Location = new System.Drawing.Point(170, 11);
            this.ShowEverything.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowEverything.Name = "ShowEverything";
            this.ShowEverything.Size = new System.Drawing.Size(242, 175);
            this.ShowEverything.TabIndex = 3;
            this.ShowEverything.UseCompatibleStateImageBehavior = false;
            this.ShowEverything.View = System.Windows.Forms.View.Details;
            this.ShowEverything.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // StudentID
            // 
            this.StudentID.Text = "Student ID";
            this.StudentID.Width = 118;
            // 
            // BookID
            // 
            this.BookID.Text = "Book ID";
            this.BookID.Width = 97;
            // 
            // LendedDate
            // 
            this.LendedDate.Text = "Lent Date";
            this.LendedDate.Width = 100;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(9, 34);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(158, 148);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.MaxLength = 9;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 20);
            this.textBox1.TabIndex = 6;
            // 
            // chkDelivered
            // 
            this.chkDelivered.AutoSize = true;
            this.chkDelivered.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDelivered.Location = new System.Drawing.Point(416, 144);
            this.chkDelivered.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkDelivered.Name = "chkDelivered";
            this.chkDelivered.Size = new System.Drawing.Size(80, 17);
            this.chkDelivered.TabIndex = 7;
            this.chkDelivered.Text = "Delivered";
            this.chkDelivered.UseVisualStyleBackColor = true;
            this.chkDelivered.CheckedChanged += new System.EventHandler(this.chkDelivered_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(416, 166);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 19);
            this.button1.TabIndex = 8;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // srchBook
            // 
            this.srchBook.Location = new System.Drawing.Point(417, 9);
            this.srchBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.srchBook.MaxLength = 6;
            this.srchBook.Name = "srchBook";
            this.srchBook.Size = new System.Drawing.Size(100, 20);
            this.srchBook.TabIndex = 9;
            this.srchBook.TextChanged += new System.EventHandler(this.srchBook_TextChanged);
            // 
            // shwBook
            // 
            this.shwBook.AutoSize = true;
            this.shwBook.Location = new System.Drawing.Point(422, 70);
            this.shwBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shwBook.Name = "shwBook";
            this.shwBook.Size = new System.Drawing.Size(0, 13);
            this.shwBook.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(424, 34);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 22);
            this.button2.TabIndex = 11;
            this.button2.Text = "Search Book";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(520, 10);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 19);
            this.button3.TabIndex = 12;
            this.button3.Text = "Reset Name";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(520, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SearchSIDandShowBOOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 192);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.shwBook);
            this.Controls.Add(this.srchBook);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkDelivered);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ShowEverything);
            this.Controls.Add(this.btnSearch);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchSIDandShowBOOK";
            this.Text = "SearchSIDandShowBOOK";
            this.Load += new System.EventHandler(this.SearchSIDandShowBOOK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView ShowEverything;
        private System.Windows.Forms.ColumnHeader StudentID;
        private System.Windows.Forms.ColumnHeader BookID;
        private System.Windows.Forms.ColumnHeader LendedDate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chkDelivered;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox srchBook;
        private System.Windows.Forms.Label shwBook;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;


    }
}