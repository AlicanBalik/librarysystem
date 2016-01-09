namespace WindowsFormsApplication6
{
    partial class Form2
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
            this.btnABook = new System.Windows.Forms.Button();
            this.btnBBook = new System.Windows.Forms.Button();
            this.btnEnrollment = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnShowSIDBOOK = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnABook
            // 
            this.btnABook.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABook.Location = new System.Drawing.Point(9, 10);
            this.btnABook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnABook.Name = "btnABook";
            this.btnABook.Size = new System.Drawing.Size(110, 19);
            this.btnABook.TabIndex = 1;
            this.btnABook.Text = "Add Book";
            this.btnABook.UseVisualStyleBackColor = true;
            this.btnABook.Click += new System.EventHandler(this.btnABook_Click);
            // 
            // btnBBook
            // 
            this.btnBBook.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBBook.Location = new System.Drawing.Point(66, 57);
            this.btnBBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBBook.Name = "btnBBook";
            this.btnBBook.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBBook.Size = new System.Drawing.Size(110, 19);
            this.btnBBook.TabIndex = 2;
            this.btnBBook.Text = "Give a Book";
            this.btnBBook.UseVisualStyleBackColor = true;
            this.btnBBook.Click += new System.EventHandler(this.btnBBook_Click);
            // 
            // btnEnrollment
            // 
            this.btnEnrollment.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnrollment.Location = new System.Drawing.Point(126, 10);
            this.btnEnrollment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnrollment.Name = "btnEnrollment";
            this.btnEnrollment.Size = new System.Drawing.Size(110, 19);
            this.btnEnrollment.TabIndex = 0;
            this.btnEnrollment.Text = "Enroll Student";
            this.btnEnrollment.UseVisualStyleBackColor = true;
            this.btnEnrollment.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(94, 120);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 19);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(126, 33);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 19);
            this.button1.TabIndex = 3;
            this.button1.Text = "Edit Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnShowSIDBOOK
            // 
            this.btnShowSIDBOOK.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSIDBOOK.Location = new System.Drawing.Point(66, 87);
            this.btnShowSIDBOOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowSIDBOOK.Name = "btnShowSIDBOOK";
            this.btnShowSIDBOOK.Size = new System.Drawing.Size(110, 24);
            this.btnShowSIDBOOK.TabIndex = 4;
            this.btnShowSIDBOOK.Text = "Search User";
            this.btnShowSIDBOOK.UseVisualStyleBackColor = true;
            this.btnShowSIDBOOK.Click += new System.EventHandler(this.btnShowSIDBOOK_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Location = new System.Drawing.Point(9, 33);
            this.btnEditBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(110, 19);
            this.btnEditBook.TabIndex = 6;
            this.btnEditBook.Text = "Edit Book";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 166);
            this.Controls.Add(this.btnEditBook);
            this.Controls.Add(this.btnShowSIDBOOK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnrollment);
            this.Controls.Add(this.btnBBook);
            this.Controls.Add(this.btnABook);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnABook;
        private System.Windows.Forms.Button btnBBook;
        private System.Windows.Forms.Button btnEnrollment;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnShowSIDBOOK;
        private System.Windows.Forms.Button btnEditBook;
    }
}