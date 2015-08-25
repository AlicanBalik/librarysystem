namespace WindowsFormsApplication6
{
    partial class SearchByLanguage
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
            this.listLanguage = new System.Windows.Forms.ListBox();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.showList = new System.Windows.Forms.ListView();
            this.Language = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listLanguage
            // 
            this.listLanguage.FormattingEnabled = true;
            this.listLanguage.ItemHeight = 16;
            this.listLanguage.Location = new System.Drawing.Point(12, 113);
            this.listLanguage.Name = "listLanguage";
            this.listLanguage.Size = new System.Drawing.Size(137, 164);
            this.listLanguage.TabIndex = 6;
            this.listLanguage.SelectedIndexChanged += new System.EventHandler(this.listLanguage_SelectedIndexChanged);
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(13, 13);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(100, 22);
            this.txtLanguage.TabIndex = 7;
            // 
            // showList
            // 
            this.showList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Language,
            this.BookName});
            this.showList.Location = new System.Drawing.Point(211, 146);
            this.showList.Name = "showList";
            this.showList.Size = new System.Drawing.Size(253, 188);
            this.showList.TabIndex = 8;
            this.showList.UseCompatibleStateImageBehavior = false;
            this.showList.View = System.Windows.Forms.View.Details;
            // 
            // Language
            // 
            this.Language.Text = "Book name";
            this.Language.Width = 115;
            // 
            // BookName
            // 
            this.BookName.Text = "language";
            this.BookName.Width = 134;
            // 
            // SearchByLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 466);
            this.Controls.Add(this.showList);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.listLanguage);
            this.Controls.Add(this.btnSearch);
            this.Name = "SearchByLanguage";
            this.Text = "SearchByLanguage";
            this.Load += new System.EventHandler(this.SearchByLanguage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox listLanguage;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.ListView showList;
        private System.Windows.Forms.ColumnHeader Language;
        private System.Windows.Forms.ColumnHeader BookName;

    }
}