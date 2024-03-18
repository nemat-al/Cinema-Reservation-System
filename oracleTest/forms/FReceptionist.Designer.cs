namespace oracleTest.forms
{
    partial class FReceptionist
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
            this.BViewShows = new System.Windows.Forms.Button();
            this.BPrintTicket = new System.Windows.Forms.Button();
            this.BPrintCustumer = new System.Windows.Forms.Button();
            this.BAddCustomer = new System.Windows.Forms.Button();
            this.BShowTickets = new System.Windows.Forms.Button();
            this.uCtableShow = new oracleTest.forms.UCtable();
            this.ucAddCustomerIn = new oracleTest.forms.UCAddCustomer();
            this.uCsearchTicketfromReceptionist = new oracleTest.forms.UCsearchTicket();
            this.BaddTicket = new System.Windows.Forms.Button();
            this.uCaddTicketfromRecep = new oracleTest.forms.UCaddTicket();
            this.SuspendLayout();
            // 
            // BViewShows
            // 
            this.BViewShows.Location = new System.Drawing.Point(33, 41);
            this.BViewShows.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BViewShows.Name = "BViewShows";
            this.BViewShows.Size = new System.Drawing.Size(172, 52);
            this.BViewShows.TabIndex = 0;
            this.BViewShows.Text = "View Shows";
            this.BViewShows.UseVisualStyleBackColor = true;
            this.BViewShows.Click += new System.EventHandler(this.BShowMovies_Click);
            // 
            // BPrintTicket
            // 
            this.BPrintTicket.Location = new System.Drawing.Point(32, 159);
            this.BPrintTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BPrintTicket.Name = "BPrintTicket";
            this.BPrintTicket.Size = new System.Drawing.Size(173, 54);
            this.BPrintTicket.TabIndex = 1;
            this.BPrintTicket.Text = "Search /Print Ticket";
            this.BPrintTicket.UseVisualStyleBackColor = true;
            this.BPrintTicket.Click += new System.EventHandler(this.BPrintTicket_Click);
            // 
            // BPrintCustumer
            // 
            this.BPrintCustumer.Location = new System.Drawing.Point(32, 220);
            this.BPrintCustumer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BPrintCustumer.Name = "BPrintCustumer";
            this.BPrintCustumer.Size = new System.Drawing.Size(173, 54);
            this.BPrintCustumer.TabIndex = 2;
            this.BPrintCustumer.Text = "Search /Print Custumer";
            this.BPrintCustumer.UseVisualStyleBackColor = true;
            this.BPrintCustumer.Click += new System.EventHandler(this.BPrintCustumer_Click);
            // 
            // BAddCustomer
            // 
            this.BAddCustomer.Location = new System.Drawing.Point(33, 282);
            this.BAddCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BAddCustomer.Name = "BAddCustomer";
            this.BAddCustomer.Size = new System.Drawing.Size(172, 59);
            this.BAddCustomer.TabIndex = 3;
            this.BAddCustomer.Text = "Add Customer";
            this.BAddCustomer.UseVisualStyleBackColor = true;
            this.BAddCustomer.Click += new System.EventHandler(this.BAddCustomer_Click);
            // 
            // BShowTickets
            // 
            this.BShowTickets.Location = new System.Drawing.Point(33, 100);
            this.BShowTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BShowTickets.Name = "BShowTickets";
            this.BShowTickets.Size = new System.Drawing.Size(172, 52);
            this.BShowTickets.TabIndex = 4;
            this.BShowTickets.Text = "Show Tickets";
            this.BShowTickets.UseVisualStyleBackColor = true;
            this.BShowTickets.Click += new System.EventHandler(this.BShowTickets_Click);
            // 
            // uCtableShow
            // 
            this.uCtableShow.Enabled = false;
            this.uCtableShow.Location = new System.Drawing.Point(244, 27);
            this.uCtableShow.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uCtableShow.Name = "uCtableShow";
            this.uCtableShow.Size = new System.Drawing.Size(932, 459);
            this.uCtableShow.TabIndex = 7;
            this.uCtableShow.User = null;
            this.uCtableShow.Visible = false;
            // 
            // ucAddCustomerIn
            // 
            this.ucAddCustomerIn.AllIsGood = false;
            this.ucAddCustomerIn.Enabled = false;
            this.ucAddCustomerIn.Location = new System.Drawing.Point(275, 27);
            this.ucAddCustomerIn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucAddCustomerIn.Name = "ucAddCustomerIn";
            this.ucAddCustomerIn.Size = new System.Drawing.Size(645, 332);
            this.ucAddCustomerIn.TabIndex = 5;
            this.ucAddCustomerIn.Visible = false;
            // 
            // uCsearchTicketfromReceptionist
            // 
            this.uCsearchTicketfromReceptionist.Enabled = false;
            this.uCsearchTicketfromReceptionist.Location = new System.Drawing.Point(237, 27);
            this.uCsearchTicketfromReceptionist.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uCsearchTicketfromReceptionist.Name = "uCsearchTicketfromReceptionist";
            this.uCsearchTicketfromReceptionist.Size = new System.Drawing.Size(1020, 468);
            this.uCsearchTicketfromReceptionist.TabIndex = 8;
            this.uCsearchTicketfromReceptionist.Visible = false;
            // 
            // BaddTicket
            // 
            this.BaddTicket.Location = new System.Drawing.Point(32, 351);
            this.BaddTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BaddTicket.Name = "BaddTicket";
            this.BaddTicket.Size = new System.Drawing.Size(172, 55);
            this.BaddTicket.TabIndex = 9;
            this.BaddTicket.Text = "Add Ticket";
            this.BaddTicket.UseVisualStyleBackColor = true;
            this.BaddTicket.Click += new System.EventHandler(this.BaddTicket_Click);
            // 
            // uCaddTicketfromRecep
            // 
            this.uCaddTicketfromRecep.Enabled = false;
            this.uCaddTicketfromRecep.Location = new System.Drawing.Point(244, 27);
            this.uCaddTicketfromRecep.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uCaddTicketfromRecep.Name = "uCaddTicketfromRecep";
            this.uCaddTicketfromRecep.Size = new System.Drawing.Size(999, 466);
            this.uCaddTicketfromRecep.TabIndex = 10;
            this.uCaddTicketfromRecep.UpdateTic = false;
            this.uCaddTicketfromRecep.User = null;
            this.uCaddTicketfromRecep.Visible = false;
            // 
            // FReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 554);
            this.Controls.Add(this.uCaddTicketfromRecep);
            this.Controls.Add(this.BaddTicket);
            this.Controls.Add(this.uCsearchTicketfromReceptionist);
            this.Controls.Add(this.uCtableShow);
            this.Controls.Add(this.ucAddCustomerIn);
            this.Controls.Add(this.BShowTickets);
            this.Controls.Add(this.BAddCustomer);
            this.Controls.Add(this.BPrintCustumer);
            this.Controls.Add(this.BPrintTicket);
            this.Controls.Add(this.BViewShows);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FReceptionist";
            this.Text = "FReceptionist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FReceptionist_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BViewShows;
        private System.Windows.Forms.Button BPrintTicket;
        private System.Windows.Forms.Button BPrintCustumer;
        private System.Windows.Forms.Button BAddCustomer;
        private System.Windows.Forms.Button BShowTickets;
        private UCAddCustomer ucAddCustomerIn;
        // private 

        private UCtable uCtableShow;
        private UCsearchTicket uCsearchTicketfromReceptionist;
        private System.Windows.Forms.Button BaddTicket;
        private UCaddTicket uCaddTicketfromRecep;
    }
}