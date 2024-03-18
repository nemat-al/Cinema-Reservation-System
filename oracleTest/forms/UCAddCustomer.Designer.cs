namespace oracleTest.forms
{
    partial class UCAddCustomer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LFirstName = new System.Windows.Forms.Label();
            this.TBFirstName = new System.Windows.Forms.TextBox();
            this.TBLastNAme = new System.Windows.Forms.TextBox();
            this.LLastName = new System.Windows.Forms.Label();
            this.TBPhoneNumber = new System.Windows.Forms.TextBox();
            this.LPhoneNumber = new System.Windows.Forms.Label();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.LEmail = new System.Windows.Forms.Label();
            this.TBPoints = new System.Windows.Forms.TextBox();
            this.LPoints = new System.Windows.Forms.Label();
            this.BAddCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LFirstName
            // 
            this.LFirstName.AutoSize = true;
            this.LFirstName.Location = new System.Drawing.Point(26, 30);
            this.LFirstName.Name = "LFirstName";
            this.LFirstName.Size = new System.Drawing.Size(57, 13);
            this.LFirstName.TabIndex = 0;
            this.LFirstName.Text = "First Name";
            this.LFirstName.Click += new System.EventHandler(this.LFirstName_Click);
            // 
            // TBFirstName
            // 
            this.TBFirstName.Location = new System.Drawing.Point(106, 27);
            this.TBFirstName.Name = "TBFirstName";
            this.TBFirstName.Size = new System.Drawing.Size(253, 20);
            this.TBFirstName.TabIndex = 1;
            // 
            // TBLastNAme
            // 
            this.TBLastNAme.Location = new System.Drawing.Point(106, 68);
            this.TBLastNAme.Name = "TBLastNAme";
            this.TBLastNAme.Size = new System.Drawing.Size(253, 20);
            this.TBLastNAme.TabIndex = 3;
            // 
            // LLastName
            // 
            this.LLastName.AutoSize = true;
            this.LLastName.Location = new System.Drawing.Point(26, 71);
            this.LLastName.Name = "LLastName";
            this.LLastName.Size = new System.Drawing.Size(58, 13);
            this.LLastName.TabIndex = 2;
            this.LLastName.Text = "Last Name";
            this.LLastName.Click += new System.EventHandler(this.LLastName_Click);
            // 
            // TBPhoneNumber
            // 
            this.TBPhoneNumber.Location = new System.Drawing.Point(106, 108);
            this.TBPhoneNumber.Name = "TBPhoneNumber";
            this.TBPhoneNumber.Size = new System.Drawing.Size(253, 20);
            this.TBPhoneNumber.TabIndex = 5;
            // 
            // LPhoneNumber
            // 
            this.LPhoneNumber.AutoSize = true;
            this.LPhoneNumber.Location = new System.Drawing.Point(22, 111);
            this.LPhoneNumber.Name = "LPhoneNumber";
            this.LPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.LPhoneNumber.TabIndex = 4;
            this.LPhoneNumber.Text = "Phone Number";
            this.LPhoneNumber.Click += new System.EventHandler(this.LPhoneNumber_Click);
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(106, 146);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(253, 20);
            this.TBEmail.TabIndex = 7;
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Location = new System.Drawing.Point(26, 149);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(32, 13);
            this.LEmail.TabIndex = 6;
            this.LEmail.Text = "Email";
            this.LEmail.Click += new System.EventHandler(this.LEmail_Click);
            // 
            // TBPoints
            // 
            this.TBPoints.Location = new System.Drawing.Point(106, 189);
            this.TBPoints.Name = "TBPoints";
            this.TBPoints.Size = new System.Drawing.Size(253, 20);
            this.TBPoints.TabIndex = 9;
            // 
            // LPoints
            // 
            this.LPoints.AutoSize = true;
            this.LPoints.Location = new System.Drawing.Point(26, 192);
            this.LPoints.Name = "LPoints";
            this.LPoints.Size = new System.Drawing.Size(36, 13);
            this.LPoints.TabIndex = 8;
            this.LPoints.Text = "Points";
            this.LPoints.Click += new System.EventHandler(this.LPoints_Click);
            // 
            // BAddCustomer
            // 
            this.BAddCustomer.Location = new System.Drawing.Point(343, 225);
            this.BAddCustomer.Name = "BAddCustomer";
            this.BAddCustomer.Size = new System.Drawing.Size(108, 31);
            this.BAddCustomer.TabIndex = 10;
            this.BAddCustomer.Text = "Add";
            this.BAddCustomer.UseVisualStyleBackColor = true;
            this.BAddCustomer.Click += new System.EventHandler(this.BAddCustomer_Click);
            // 
            // UCAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BAddCustomer);
            this.Controls.Add(this.TBPoints);
            this.Controls.Add(this.LPoints);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.TBPhoneNumber);
            this.Controls.Add(this.LPhoneNumber);
            this.Controls.Add(this.TBLastNAme);
            this.Controls.Add(this.LLastName);
            this.Controls.Add(this.TBFirstName);
            this.Controls.Add(this.LFirstName);
            this.Name = "UCAddCustomer";
            this.Size = new System.Drawing.Size(465, 268);
            this.Load += new System.EventHandler(this.UCAddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LFirstName;
        private System.Windows.Forms.TextBox TBFirstName;
        private System.Windows.Forms.TextBox TBLastNAme;
        private System.Windows.Forms.Label LLastName;
        private System.Windows.Forms.TextBox TBPhoneNumber;
        private System.Windows.Forms.Label LPhoneNumber;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.TextBox TBPoints;
        private System.Windows.Forms.Label LPoints;
        private System.Windows.Forms.Button BAddCustomer;
    }
}
