namespace oracleTest.forms
{
    partial class FsearchCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FsearchCustomer));
            this.LWelcome = new System.Windows.Forms.Label();
            this.LFName = new System.Windows.Forms.Label();
            this.TBFName = new System.Windows.Forms.TextBox();
            this.Bfind = new System.Windows.Forms.Button();
            this.BClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucPrintCustomerFromSearch = new oracleTest.forms.UCPrintCustomer();
            this.ucAddCustomerSearch = new oracleTest.forms.UCAddCustomer();
            this.customerGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customerGV)).BeginInit();
            this.SuspendLayout();
            // 
            // LWelcome
            // 
            this.LWelcome.AutoSize = true;
            this.LWelcome.Location = new System.Drawing.Point(40, 33);
            this.LWelcome.Name = "LWelcome";
            this.LWelcome.Size = new System.Drawing.Size(316, 13);
            this.LWelcome.TabIndex = 0;
            this.LWelcome.Text = "Please enter the firstName and lastName to search for a customer";
            // 
            // LFName
            // 
            this.LFName.AutoSize = true;
            this.LFName.Location = new System.Drawing.Point(43, 86);
            this.LFName.Name = "LFName";
            this.LFName.Size = new System.Drawing.Size(35, 13);
            this.LFName.TabIndex = 1;
            this.LFName.Text = "Name";
            // 
            // TBFName
            // 
            this.TBFName.Location = new System.Drawing.Point(82, 84);
            this.TBFName.Name = "TBFName";
            this.TBFName.Size = new System.Drawing.Size(100, 20);
            this.TBFName.TabIndex = 2;
            // 
            // Bfind
            // 
            this.Bfind.Location = new System.Drawing.Point(317, 168);
            this.Bfind.Name = "Bfind";
            this.Bfind.Size = new System.Drawing.Size(96, 44);
            this.Bfind.TabIndex = 3;
            this.Bfind.Text = "Search";
            this.Bfind.UseVisualStyleBackColor = true;
            this.Bfind.Click += new System.EventHandler(this.BFind_Click);
            // 
            // BClose
            // 
            this.BClose.Location = new System.Drawing.Point(652, 269);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(86, 40);
            this.BClose.TabIndex = 4;
            this.BClose.Text = "OK";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(419, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 233);
            this.panel1.TabIndex = 5;
            // 
            // ucPrintCustomerFromSearch
            // 
            this.ucPrintCustomerFromSearch.Location = new System.Drawing.Point(39, 3);
            this.ucPrintCustomerFromSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ucPrintCustomerFromSearch.Name = "ucPrintCustomerFromSearch";
            this.ucPrintCustomerFromSearch.Size = new System.Drawing.Size(699, 259);
            this.ucPrintCustomerFromSearch.TabIndex = 6;
            // 
            // ucAddCustomerSearch
            // 
            this.ucAddCustomerSearch.AllIsGood = false;
            this.ucAddCustomerSearch.Enabled = false;
            this.ucAddCustomerSearch.Location = new System.Drawing.Point(11, 11);
            this.ucAddCustomerSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ucAddCustomerSearch.Name = "ucAddCustomerSearch";
            this.ucAddCustomerSearch.Size = new System.Drawing.Size(443, 268);
            this.ucAddCustomerSearch.TabIndex = 7;
            this.ucAddCustomerSearch.Visible = false;
            // 
            // customerGV
            // 
            this.customerGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGV.Location = new System.Drawing.Point(42, 84);
            this.customerGV.Margin = new System.Windows.Forms.Padding(2);
            this.customerGV.Name = "customerGV";
            this.customerGV.RowTemplate.Height = 24;
            this.customerGV.Size = new System.Drawing.Size(538, 196);
            this.customerGV.TabIndex = 8;
            this.customerGV.Visible = false;
            // 
            // FsearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 315);
            this.Controls.Add(this.ucPrintCustomerFromSearch);
            this.Controls.Add(this.customerGV);
            this.Controls.Add(this.ucAddCustomerSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.Bfind);
            this.Controls.Add(this.TBFName);
            this.Controls.Add(this.LFName);
            this.Controls.Add(this.LWelcome);
            this.Name = "FsearchCustomer";
            this.Text = "FsearchCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.customerGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LWelcome;
        private System.Windows.Forms.Label LFName;
        private System.Windows.Forms.TextBox TBFName;
        private System.Windows.Forms.Button Bfind;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.Panel panel1;
        private UCAddCustomer ucAddCustomerSearch;
        private UCPrintCustomer ucPrintCustomerFromSearch;
        private System.Windows.Forms.DataGridView customerGV;
    }
}

      