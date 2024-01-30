namespace MyStoreWinApp
{
    partial class FormMemberDetail
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
            lbPassword = new System.Windows.Forms.Label();
            txtID = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            cbxCity = new System.Windows.Forms.ComboBox();
            cbxCountry = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.ForeColor = System.Drawing.Color.Black;
            lbPassword.Location = new System.Drawing.Point(31, 76);
            lbPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(22, 20);
            lbPassword.TabIndex = 0;
            lbPassword.Text = "Id";
            // 
            // txtID
            // 
            txtID.Location = new System.Drawing.Point(121, 74);
            txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(336, 27);
            txtID.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(121, 135);
            txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(336, 27);
            txtName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(31, 137);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(121, 196);
            txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(336, 27);
            txtEmail.TabIndex = 5;
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(31, 198);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 20);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(121, 258);
            txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(336, 27);
            txtPassword.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(31, 259);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 20);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(31, 321);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(34, 20);
            label4.TabIndex = 8;
            label4.Text = "City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(31, 382);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 20);
            label5.TabIndex = 10;
            label5.Text = "Country";
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.ForeColor = System.Drawing.Color.Black;
            btnSave.Location = new System.Drawing.Point(129, 459);
            btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(100, 40);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // button2
            // 
            button2.ForeColor = System.Drawing.Color.Black;
            button2.Location = new System.Drawing.Point(299, 459);
            button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(100, 40);
            button2.TabIndex = 13;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cbxCity
            // 
            cbxCity.FormattingEnabled = true;
            cbxCity.Items.AddRange(new object[] { "Hanoi ", "Ho Chi Minh City ", "Da Nang", "Hai Phong", "Can Tho", "Nha Trang", "Hue", "Vinh", "Qui Nhon", "Ha Long" });
            cbxCity.Location = new System.Drawing.Point(121, 316);
            cbxCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            cbxCity.Name = "cbxCity";
            cbxCity.Size = new System.Drawing.Size(336, 28);
            cbxCity.TabIndex = 14;
            // 
            // cbxCountry
            // 
            cbxCountry.FormattingEnabled = true;
            cbxCountry.Location = new System.Drawing.Point(121, 382);
            cbxCountry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            cbxCountry.Name = "cbxCountry";
            cbxCountry.Size = new System.Drawing.Size(336, 28);
            cbxCountry.TabIndex = 15;
            // 
            // FormMemberDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(492, 534);
            Controls.Add(cbxCountry);
            Controls.Add(cbxCity);
            Controls.Add(button2);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(lbPassword);
            ForeColor = System.Drawing.Color.Cornsilk;
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "FormMemberDetail";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Car Detail";
            Load += FormMemberDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.ComboBox cbxCountry;
    }
}