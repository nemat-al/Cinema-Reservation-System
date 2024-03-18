namespace oracleTest.forms
{
    partial class UCtable
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
            this.DGVShowTables = new System.Windows.Forms.DataGridView();
            this.BShowData = new System.Windows.Forms.Button();
            this.ds = new System.Data.DataSet();
            this.BconfirmUpdate = new System.Windows.Forms.Button();
            this.uCaddTicketfromShows = new oracleTest.forms.UCaddTicket();
            this.ucAddOfferOverShowfromTables = new oracleTest.forms.ucAddOfferOverShow();
            this.ucAddShowfromDGV = new oracleTest.UCAddShow();
            this.ucEmployeeStatis1 = new oracleTest.UCEmployeeStatis();
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVShowTables
            // 
            this.DGVShowTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVShowTables.Location = new System.Drawing.Point(26, 41);
            this.DGVShowTables.Name = "DGVShowTables";
            this.DGVShowTables.Size = new System.Drawing.Size(687, 369);
            this.DGVShowTables.TabIndex = 0;
            this.DGVShowTables.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVShowTables_CellValueChanged);
            // 
            // BShowData
            // 
            this.BShowData.Location = new System.Drawing.Point(301, 6);
            this.BShowData.Margin = new System.Windows.Forms.Padding(4);
            this.BShowData.Name = "BShowData";
            this.BShowData.Size = new System.Drawing.Size(244, 28);
            this.BShowData.TabIndex = 1;
            this.BShowData.Text = "Show Data/ Refresh";
            this.BShowData.UseVisualStyleBackColor = true;
            this.BShowData.Click += new System.EventHandler(this.BShowData_Click);
            // 
            // ds
            // 
            this.ds.DataSetName = "DS";
            // 
            // BconfirmUpdate
            // 
            this.BconfirmUpdate.Location = new System.Drawing.Point(720, 348);
            this.BconfirmUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.BconfirmUpdate.Name = "BconfirmUpdate";
            this.BconfirmUpdate.Size = new System.Drawing.Size(132, 47);
            this.BconfirmUpdate.TabIndex = 4;
            this.BconfirmUpdate.Text = "Confirm updates";
            this.BconfirmUpdate.UseVisualStyleBackColor = true;
            this.BconfirmUpdate.Click += new System.EventHandler(this.BconfirmUpdate_Click);
            // 
            // uCaddTicketfromShows
            // 
            this.uCaddTicketfromShows.Enabled = false;
            this.uCaddTicketfromShows.Location = new System.Drawing.Point(0, 0);
            this.uCaddTicketfromShows.Margin = new System.Windows.Forms.Padding(5);
            this.uCaddTicketfromShows.Name = "uCaddTicketfromShows";
            this.uCaddTicketfromShows.Size = new System.Drawing.Size(939, 462);
            this.uCaddTicketfromShows.TabIndex = 2;
            this.uCaddTicketfromShows.UpdateTic = false;
            this.uCaddTicketfromShows.User = null;
            this.uCaddTicketfromShows.Visible = false;
            // 
            // ucAddOfferOverShowfromTables
            // 
            this.ucAddOfferOverShowfromTables.AutoSize = true;
            this.ucAddOfferOverShowfromTables.Done = true;
            this.ucAddOfferOverShowfromTables.Enabled = false;
            this.ucAddOfferOverShowfromTables.Location = new System.Drawing.Point(16, 41);
            this.ucAddOfferOverShowfromTables.Margin = new System.Windows.Forms.Padding(4);
            this.ucAddOfferOverShowfromTables.MovieName = null;
            this.ucAddOfferOverShowfromTables.Name = "ucAddOfferOverShowfromTables";
            this.ucAddOfferOverShowfromTables.Size = new System.Drawing.Size(675, 354);
            this.ucAddOfferOverShowfromTables.TabIndex = 5;
            this.ucAddOfferOverShowfromTables.Visible = false;
            // 
            // ucAddShowfromDGV
            // 
            this.ucAddShowfromDGV.Enabled = false;
            this.ucAddShowfromDGV.Location = new System.Drawing.Point(26, 0);
            this.ucAddShowfromDGV.Margin = new System.Windows.Forms.Padding(5);
            this.ucAddShowfromDGV.Name = "ucAddShowfromDGV";
            this.ucAddShowfromDGV.Size = new System.Drawing.Size(789, 448);
            this.ucAddShowfromDGV.TabIndex = 3;
            this.ucAddShowfromDGV.Visible = false;
            // 
            // ucEmployeeStatis1
            // 
            this.ucEmployeeStatis1.CertainEmployee = null;
            this.ucEmployeeStatis1.Enabled = false;
            this.ucEmployeeStatis1.Location = new System.Drawing.Point(0, 0);
            this.ucEmployeeStatis1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucEmployeeStatis1.Name = "ucEmployeeStatis1";
            this.ucEmployeeStatis1.Size = new System.Drawing.Size(939, 493);
            this.ucEmployeeStatis1.TabIndex = 5;
            this.ucEmployeeStatis1.Visible = false;
            // 
            // UCtable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucEmployeeStatis1);
            this.Controls.Add(this.BconfirmUpdate);
            this.Controls.Add(this.ucAddShowfromDGV);
            this.Controls.Add(this.uCaddTicketfromShows);
            this.Controls.Add(this.BShowData);
            this.Controls.Add(this.DGVShowTables);
            this.Controls.Add(this.ucAddOfferOverShowfromTables);
            this.Enabled = false;
            this.Name = "UCtable";
            this.Size = new System.Drawing.Size(863, 441);
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVShowTables;
        private System.Windows.Forms.Button BShowData;
        private System.Data.DataSet ds;
        private UCaddTicket uCaddTicketfromShows;
        private System.Windows.Forms.Button BconfirmUpdate;
        private ucAddOfferOverShow ucAddOfferOverShowfromTables;
        private UCAddShow ucAddShowfromDGV;
        private UCEmployeeStatis ucEmployeeStatis1;
    }
}