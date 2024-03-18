namespace oracleTest
{
    partial class FWelcome
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.rBReceptionist = new System.Windows.Forms.RadioButton();
            this.rBManager = new System.Windows.Forms.RadioButton();
            this.Blogin = new System.Windows.Forms.Button();
            this.tBUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rBReceptionist);
            this.panel2.Controls.Add(this.rBManager);
            this.panel2.Controls.Add(this.Blogin);
            this.panel2.Controls.Add(this.tBUserName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tBPassword);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(73, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 418);
            this.panel2.TabIndex = 11;
            // 
            // rBReceptionist
            // 
            this.rBReceptionist.AutoSize = true;
            this.rBReceptionist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rBReceptionist.Location = new System.Drawing.Point(139, 194);
            this.rBReceptionist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBReceptionist.Name = "rBReceptionist";
            this.rBReceptionist.Size = new System.Drawing.Size(134, 28);
            this.rBReceptionist.TabIndex = 9;
            this.rBReceptionist.TabStop = true;
            this.rBReceptionist.Text = "Receptionist";
            this.rBReceptionist.UseVisualStyleBackColor = true;
            // 
            // rBManager
            // 
            this.rBManager.AutoSize = true;
            this.rBManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rBManager.Location = new System.Drawing.Point(335, 194);
            this.rBManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBManager.Name = "rBManager";
            this.rBManager.Size = new System.Drawing.Size(106, 28);
            this.rBManager.TabIndex = 8;
            this.rBManager.TabStop = true;
            this.rBManager.Text = "Manager";
            this.rBManager.UseVisualStyleBackColor = true;
            // 
            // Blogin
            // 
            this.Blogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Blogin.Location = new System.Drawing.Point(261, 262);
            this.Blogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Blogin.Name = "Blogin";
            this.Blogin.Size = new System.Drawing.Size(83, 50);
            this.Blogin.TabIndex = 0;
            this.Blogin.Text = "Log In";
            this.Blogin.UseVisualStyleBackColor = true;
            this.Blogin.Click += new System.EventHandler(this.Blogin_Click);
            // 
            // tBUserName
            // 
            this.tBUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tBUserName.Location = new System.Drawing.Point(261, 76);
            this.tBUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBUserName.Name = "tBUserName";
            this.tBUserName.Size = new System.Drawing.Size(220, 30);
            this.tBUserName.TabIndex = 3;
            this.tBUserName.Text = "nina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(115, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // tBPassword
            // 
            this.tBPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tBPassword.Location = new System.Drawing.Point(261, 126);
            this.tBPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.PasswordChar = '*';
            this.tBPassword.Size = new System.Drawing.Size(220, 30);
            this.tBPassword.TabIndex = 4;
            this.tBPassword.Text = "nina";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "User Name";
            // 
            // FWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 479);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FWelcome";
            this.Text = "Welcome";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rBReceptionist;
        private System.Windows.Forms.RadioButton rBManager;
        private System.Windows.Forms.Button Blogin;
        private System.Windows.Forms.TextBox tBUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBPassword;
        private System.Windows.Forms.Label label6;
    }
}

