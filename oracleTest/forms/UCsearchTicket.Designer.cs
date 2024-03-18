namespace oracleTest.forms
{
    partial class UCsearchTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCsearchTicket));
            this.LFindTicket = new System.Windows.Forms.Label();
            this.LTicketId = new System.Windows.Forms.Label();
            this.TBFindTicketById = new System.Windows.Forms.TextBox();
            this.BFindTicket = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ucPrintTicketFromFindTicket = new oracleTest.forms.UCPrintTicket();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LFindTicket
            // 
            this.LFindTicket.AutoSize = true;
            this.LFindTicket.Location = new System.Drawing.Point(31, 30);
            this.LFindTicket.Name = "LFindTicket";
            this.LFindTicket.Size = new System.Drawing.Size(251, 13);
            this.LFindTicket.TabIndex = 0;
            this.LFindTicket.Text = "Please enter the Customer Name to find thier tickets";
            // 
            // LTicketId
            // 
            this.LTicketId.AutoSize = true;
            this.LTicketId.Location = new System.Drawing.Point(34, 83);
            this.LTicketId.Name = "LTicketId";
            this.LTicketId.Size = new System.Drawing.Size(82, 13);
            this.LTicketId.TabIndex = 1;
            this.LTicketId.Text = "Customer Name";
            // 
            // TBFindTicketById
            // 
            this.TBFindTicketById.Location = new System.Drawing.Point(120, 75);
            this.TBFindTicketById.Name = "TBFindTicketById";
            this.TBFindTicketById.Size = new System.Drawing.Size(162, 20);
            this.TBFindTicketById.TabIndex = 2;
            // 
            // BFindTicket
            // 
            this.BFindTicket.Location = new System.Drawing.Point(333, 65);
            this.BFindTicket.Name = "BFindTicket";
            this.BFindTicket.Size = new System.Drawing.Size(88, 32);
            this.BFindTicket.TabIndex = 3;
            this.BFindTicket.Text = "Find";
            this.BFindTicket.UseVisualStyleBackColor = true;
            this.BFindTicket.Click += new System.EventHandler(this.BFindTicket_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 142);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(494, 206);
            this.dataGridView1.TabIndex = 5;
            // 
            // ucPrintTicketFromFindTicket
            // 
            this.ucPrintTicketFromFindTicket.Enabled = false;
            this.ucPrintTicketFromFindTicket.IndexForTable = 0;
            this.ucPrintTicketFromFindTicket.Location = new System.Drawing.Point(23, 30);
            this.ucPrintTicketFromFindTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucPrintTicketFromFindTicket.Name = "ucPrintTicketFromFindTicket";
            this.ucPrintTicketFromFindTicket.Size = new System.Drawing.Size(725, 293);
            this.ucPrintTicketFromFindTicket.TabIndex = 4;
            this.ucPrintTicketFromFindTicket.Visible = false;
            // 
            // UCsearchTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ucPrintTicketFromFindTicket);
            this.Controls.Add(this.BFindTicket);
            this.Controls.Add(this.TBFindTicketById);
            this.Controls.Add(this.LTicketId);
            this.Controls.Add(this.LFindTicket);
            this.Name = "UCsearchTicket";
            this.Size = new System.Drawing.Size(752, 371);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LFindTicket;
        private System.Windows.Forms.Label LTicketId;
        private System.Windows.Forms.TextBox TBFindTicketById;
        private System.Windows.Forms.Button BFindTicket;
        private UCPrintTicket ucPrintTicketFromFindTicket;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
