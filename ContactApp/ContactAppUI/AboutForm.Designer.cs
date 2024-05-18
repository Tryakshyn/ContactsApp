namespace ContactApp
{
    partial class AboutForm
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
            this.labelContactsAppAbout = new System.Windows.Forms.Label();
            this.labelVersionContactsApp = new System.Windows.Forms.Label();
            this.labeAuthorContactsApp = new System.Windows.Forms.Label();
            this.labelEmailAuthorContactsApp = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelContactsAppAbout
            // 
            this.labelContactsAppAbout.AutoSize = true;
            this.labelContactsAppAbout.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelContactsAppAbout.Location = new System.Drawing.Point(37, 42);
            this.labelContactsAppAbout.Name = "labelContactsAppAbout";
            this.labelContactsAppAbout.Size = new System.Drawing.Size(167, 31);
            this.labelContactsAppAbout.TabIndex = 0;
            this.labelContactsAppAbout.Text = "ContactsApp";
            // 
            // labelVersionContactsApp
            // 
            this.labelVersionContactsApp.AutoSize = true;
            this.labelVersionContactsApp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVersionContactsApp.Location = new System.Drawing.Point(44, 82);
            this.labelVersionContactsApp.Name = "labelVersionContactsApp";
            this.labelVersionContactsApp.Size = new System.Drawing.Size(46, 15);
            this.labelVersionContactsApp.TabIndex = 1;
            this.labelVersionContactsApp.Text = "v.  1.0.0";
            // 
            // labeAuthorContactsApp
            // 
            this.labeAuthorContactsApp.AutoSize = true;
            this.labeAuthorContactsApp.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeAuthorContactsApp.Location = new System.Drawing.Point(40, 113);
            this.labeAuthorContactsApp.Name = "labeAuthorContactsApp";
            this.labeAuthorContactsApp.Size = new System.Drawing.Size(160, 17);
            this.labeAuthorContactsApp.TabIndex = 2;
            this.labeAuthorContactsApp.Text = "Author: Tryakshin Andrey";
            // 
            // labelEmailAuthorContactsApp
            // 
            this.labelEmailAuthorContactsApp.AutoSize = true;
            this.labelEmailAuthorContactsApp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmailAuthorContactsApp.Location = new System.Drawing.Point(40, 145);
            this.labelEmailAuthorContactsApp.Name = "labelEmailAuthorContactsApp";
            this.labelEmailAuthorContactsApp.Size = new System.Drawing.Size(110, 15);
            this.labelEmailAuthorContactsApp.TabIndex = 3;
            this.labelEmailAuthorContactsApp.Text = "e-mail for feedback:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(146, 145);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(156, 15);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "andreyka.tryakshin@mail.ru";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "GitHub:";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel2.Location = new System.Drawing.Point(83, 170);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(168, 15);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://github.com/Tryakshyn";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 288);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelEmailAuthorContactsApp);
            this.Controls.Add(this.labeAuthorContactsApp);
            this.Controls.Add(this.labelVersionContactsApp);
            this.Controls.Add(this.labelContactsAppAbout);
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelContactsAppAbout;
        private System.Windows.Forms.Label labelVersionContactsApp;
        private System.Windows.Forms.Label labeAuthorContactsApp;
        private System.Windows.Forms.Label labelEmailAuthorContactsApp;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}