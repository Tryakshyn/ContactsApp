namespace ContactApp
{
    partial class AddEditContactForm
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
            this.birthdayTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelVkId = new System.Windows.Forms.Label();
            this.vkidBox = new System.Windows.Forms.TextBox();
            this.ButtonAddCancel = new System.Windows.Forms.Button();
            this.ButtonAddOk = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.lastnameBox = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.firstnameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // birthdayTimePicker
            // 
            this.birthdayTimePicker.Location = new System.Drawing.Point(79, 70);
            this.birthdayTimePicker.Name = "birthdayTimePicker";
            this.birthdayTimePicker.Size = new System.Drawing.Size(121, 20);
            this.birthdayTimePicker.TabIndex = 40;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(24, 73);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(48, 13);
            this.labelBirthday.TabIndex = 39;
            this.labelBirthday.Text = "Birthday:";
            // 
            // labelVkId
            // 
            this.labelVkId.AutoSize = true;
            this.labelVkId.Location = new System.Drawing.Point(37, 151);
            this.labelVkId.Name = "labelVkId";
            this.labelVkId.Size = new System.Drawing.Size(35, 13);
            this.labelVkId.TabIndex = 38;
            this.labelVkId.Text = "VK id:";
            // 
            // vkidBox
            // 
            this.vkidBox.Location = new System.Drawing.Point(78, 148);
            this.vkidBox.Name = "vkidBox";
            this.vkidBox.Size = new System.Drawing.Size(180, 20);
            this.vkidBox.TabIndex = 37;
            // 
            // ButtonAddCancel
            // 
            this.ButtonAddCancel.Location = new System.Drawing.Point(154, 188);
            this.ButtonAddCancel.Name = "ButtonAddCancel";
            this.ButtonAddCancel.Size = new System.Drawing.Size(104, 31);
            this.ButtonAddCancel.TabIndex = 36;
            this.ButtonAddCancel.Text = "Cancel";
            this.ButtonAddCancel.UseVisualStyleBackColor = true;
            this.ButtonAddCancel.Click += new System.EventHandler(this.ButtonAddCancel_Click);
            // 
            // ButtonAddOk
            // 
            this.ButtonAddOk.Location = new System.Drawing.Point(40, 188);
            this.ButtonAddOk.Name = "ButtonAddOk";
            this.ButtonAddOk.Size = new System.Drawing.Size(104, 31);
            this.ButtonAddOk.TabIndex = 35;
            this.ButtonAddOk.Text = "OK";
            this.ButtonAddOk.UseVisualStyleBackColor = true;
            this.ButtonAddOk.Click += new System.EventHandler(this.ButtonAddOk_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(37, 125);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 34;
            this.labelEmail.Text = "Email:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(32, 99);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(41, 13);
            this.labelPhone.TabIndex = 33;
            this.labelPhone.Text = "Phone:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(11, 50);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 13);
            this.labelLastName.TabIndex = 32;
            this.labelLastName.Text = "Last Name:";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(78, 122);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(180, 20);
            this.emailBox.TabIndex = 31;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(78, 96);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(180, 20);
            this.phoneBox.TabIndex = 30;
            // 
            // lastnameBox
            // 
            this.lastnameBox.Location = new System.Drawing.Point(78, 47);
            this.lastnameBox.Name = "lastnameBox";
            this.lastnameBox.Size = new System.Drawing.Size(180, 20);
            this.lastnameBox.TabIndex = 29;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(12, 24);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(60, 13);
            this.labelFirstName.TabIndex = 28;
            this.labelFirstName.Text = "First Name:";
            // 
            // firstnameBox
            // 
            this.firstnameBox.Location = new System.Drawing.Point(78, 21);
            this.firstnameBox.Name = "firstnameBox";
            this.firstnameBox.Size = new System.Drawing.Size(180, 20);
            this.firstnameBox.TabIndex = 27;
            // 
            // AddEditContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 242);
            this.Controls.Add(this.birthdayTimePicker);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelVkId);
            this.Controls.Add(this.vkidBox);
            this.Controls.Add(this.ButtonAddCancel);
            this.Controls.Add(this.ButtonAddOk);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.lastnameBox);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.firstnameBox);
            this.Name = "AddEditContactForm";
            this.Text = "Создать/изменить контакт";
            this.Shown += new System.EventHandler(this.AddEditContactForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker birthdayTimePicker;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelVkId;
        private System.Windows.Forms.TextBox vkidBox;
        private System.Windows.Forms.Button ButtonAddCancel;
        private System.Windows.Forms.Button ButtonAddOk;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox lastnameBox;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox firstnameBox;
    }
}