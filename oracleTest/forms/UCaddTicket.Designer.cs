using System.Windows.Forms;

namespace oracleTest.forms
{
    partial class UCaddTicket
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
            System.Windows.Forms.Label LHallId;
            this.LWayReserved = new System.Windows.Forms.Label();
            this.LDateReserved = new System.Windows.Forms.Label();
            this.LDatePayed = new System.Windows.Forms.Label();
            this.rBPhone = new System.Windows.Forms.RadioButton();
            this.rBPerson = new System.Windows.Forms.RadioButton();
            this.LSeatId = new System.Windows.Forms.Label();
            this.cBHall = new System.Windows.Forms.ComboBox();
            this.LCustomerId = new System.Windows.Forms.Label();
            this.LReservedEmployee = new System.Windows.Forms.Label();
            this.LREservedEmployeeVslue = new System.Windows.Forms.Label();
            this.LEmployeeWhoRecevedPaymentValue = new System.Windows.Forms.Label();
            this.LEmployeeWhoRecevedPayment = new System.Windows.Forms.Label();
            this.BAdd = new System.Windows.Forms.Button();
            this.LDateReserveValue = new System.Windows.Forms.Label();
            this.nUDSeat = new System.Windows.Forms.NumericUpDown();
            this.BCustomer = new System.Windows.Forms.Button();
            this.LStatus = new System.Windows.Forms.Label();
            this.LStatusValue = new System.Windows.Forms.Label();
            this.LMovieShowId = new System.Windows.Forms.Label();
            this.TBMovieShowId = new System.Windows.Forms.TextBox();
            this.wayReserved = new System.Windows.Forms.GroupBox();
            this.LDatePAymentValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nUDRow = new System.Windows.Forms.NumericUpDown();
            this.RBCancel = new System.Windows.Forms.RadioButton();
            this.RB = new System.Windows.Forms.RadioButton();
            this.GBupdate = new System.Windows.Forms.GroupBox();
            this.chooseOffers = new System.Windows.Forms.GroupBox();
            this.findOffersButtom = new System.Windows.Forms.Button();
            LHallId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSeat)).BeginInit();
            this.wayReserved.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDRow)).BeginInit();
            this.GBupdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // LHallId
            // 
            LHallId.AutoSize = true;
            LHallId.Location = new System.Drawing.Point(76, 361);
            LHallId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LHallId.Name = "LHallId";
            LHallId.Size = new System.Drawing.Size(32, 17);
            LHallId.TabIndex = 14;
            LHallId.Text = "Hall";
            LHallId.Visible = false;
            // 
            // LWayReserved
            // 
            this.LWayReserved.AutoSize = true;
            this.LWayReserved.Location = new System.Drawing.Point(72, 48);
            this.LWayReserved.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LWayReserved.Name = "LWayReserved";
            this.LWayReserved.Size = new System.Drawing.Size(101, 17);
            this.LWayReserved.TabIndex = 0;
            this.LWayReserved.Text = "Way Reserved";
            // 
            // LDateReserved
            // 
            this.LDateReserved.AutoSize = true;
            this.LDateReserved.Location = new System.Drawing.Point(72, 91);
            this.LDateReserved.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDateReserved.Name = "LDateReserved";
            this.LDateReserved.Size = new System.Drawing.Size(103, 17);
            this.LDateReserved.TabIndex = 1;
            this.LDateReserved.Text = "Date Reserved";
            // 
            // LDatePayed
            // 
            this.LDatePayed.AutoSize = true;
            this.LDatePayed.Location = new System.Drawing.Point(72, 130);
            this.LDatePayed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDatePayed.Name = "LDatePayed";
            this.LDatePayed.Size = new System.Drawing.Size(82, 17);
            this.LDatePayed.TabIndex = 2;
            this.LDatePayed.Text = "Date Payed";
            // 
            // rBPhone
            // 
            this.rBPhone.AutoSize = true;
            this.rBPhone.Location = new System.Drawing.Point(8, 23);
            this.rBPhone.Margin = new System.Windows.Forms.Padding(4);
            this.rBPhone.Name = "rBPhone";
            this.rBPhone.Size = new System.Drawing.Size(70, 21);
            this.rBPhone.TabIndex = 3;
            this.rBPhone.TabStop = true;
            this.rBPhone.Text = "Phone";
            this.rBPhone.UseVisualStyleBackColor = true;
            // 
            // rBPerson
            // 
            this.rBPerson.AutoSize = true;
            this.rBPerson.Location = new System.Drawing.Point(181, 23);
            this.rBPerson.Margin = new System.Windows.Forms.Padding(4);
            this.rBPerson.Name = "rBPerson";
            this.rBPerson.Size = new System.Drawing.Size(74, 21);
            this.rBPerson.TabIndex = 4;
            this.rBPerson.TabStop = true;
            this.rBPerson.Text = "Person";
            this.rBPerson.UseVisualStyleBackColor = true;
            // 
            // LSeatId
            // 
            this.LSeatId.AutoSize = true;
            this.LSeatId.Location = new System.Drawing.Point(75, 177);
            this.LSeatId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LSeatId.Name = "LSeatId";
            this.LSeatId.Size = new System.Drawing.Size(52, 17);
            this.LSeatId.TabIndex = 12;
            this.LSeatId.Text = "Seat Id";
            // 
            // cBHall
            // 
            this.cBHall.Location = new System.Drawing.Point(251, 361);
            this.cBHall.Margin = new System.Windows.Forms.Padding(4);
            this.cBHall.Name = "cBHall";
            this.cBHall.Size = new System.Drawing.Size(247, 24);
            this.cBHall.TabIndex = 15;
            this.cBHall.Visible = false;
            // 
            // LCustomerId
            // 
            this.LCustomerId.AutoSize = true;
            this.LCustomerId.Location = new System.Drawing.Point(72, 256);
            this.LCustomerId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCustomerId.Name = "LCustomerId";
            this.LCustomerId.Size = new System.Drawing.Size(68, 17);
            this.LCustomerId.TabIndex = 16;
            this.LCustomerId.Text = "Customer";
            // 
            // LReservedEmployee
            // 
            this.LReservedEmployee.AutoSize = true;
            this.LReservedEmployee.Location = new System.Drawing.Point(76, 292);
            this.LReservedEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LReservedEmployee.Name = "LReservedEmployee";
            this.LReservedEmployee.Size = new System.Drawing.Size(135, 17);
            this.LReservedEmployee.TabIndex = 18;
            this.LReservedEmployee.Text = "Reserved Employee";
            // 
            // LREservedEmployeeVslue
            // 
            this.LREservedEmployeeVslue.AutoSize = true;
            this.LREservedEmployeeVslue.Location = new System.Drawing.Point(247, 292);
            this.LREservedEmployeeVslue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LREservedEmployeeVslue.Name = "LREservedEmployeeVslue";
            this.LREservedEmployeeVslue.Size = new System.Drawing.Size(135, 17);
            this.LREservedEmployeeVslue.TabIndex = 19;
            this.LREservedEmployeeVslue.Text = "Reserved Employee";
            // 
            // LEmployeeWhoRecevedPaymentValue
            // 
            this.LEmployeeWhoRecevedPaymentValue.AutoSize = true;
            this.LEmployeeWhoRecevedPaymentValue.Location = new System.Drawing.Point(363, 328);
            this.LEmployeeWhoRecevedPaymentValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LEmployeeWhoRecevedPaymentValue.Name = "LEmployeeWhoRecevedPaymentValue";
            this.LEmployeeWhoRecevedPaymentValue.Size = new System.Drawing.Size(71, 17);
            this.LEmployeeWhoRecevedPaymentValue.TabIndex = 21;
            this.LEmployeeWhoRecevedPaymentValue.Text = "LPayment";
            // 
            // LEmployeeWhoRecevedPayment
            // 
            this.LEmployeeWhoRecevedPayment.AutoSize = true;
            this.LEmployeeWhoRecevedPayment.Location = new System.Drawing.Point(76, 328);
            this.LEmployeeWhoRecevedPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LEmployeeWhoRecevedPayment.Name = "LEmployeeWhoRecevedPayment";
            this.LEmployeeWhoRecevedPayment.Size = new System.Drawing.Size(222, 17);
            this.LEmployeeWhoRecevedPayment.TabIndex = 20;
            this.LEmployeeWhoRecevedPayment.Text = "Employee Who Receved Payment";
            // 
            // BAdd
            // 
            this.BAdd.Location = new System.Drawing.Point(635, 391);
            this.BAdd.Margin = new System.Windows.Forms.Padding(4);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(212, 64);
            this.BAdd.TabIndex = 22;
            this.BAdd.Text = "Add";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // LDateReserveValue
            // 
            this.LDateReserveValue.AutoSize = true;
            this.LDateReserveValue.Location = new System.Drawing.Point(251, 90);
            this.LDateReserveValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDateReserveValue.Name = "LDateReserveValue";
            this.LDateReserveValue.Size = new System.Drawing.Size(103, 17);
            this.LDateReserveValue.TabIndex = 23;
            this.LDateReserveValue.Text = "Date Reserved";
            // 
            // nUDSeat
            // 
            this.nUDSeat.Location = new System.Drawing.Point(251, 168);
            this.nUDSeat.Margin = new System.Windows.Forms.Padding(4);
            this.nUDSeat.Name = "nUDSeat";
            this.nUDSeat.Size = new System.Drawing.Size(248, 22);
            this.nUDSeat.TabIndex = 27;
            // 
            // BCustomer
            // 
            this.BCustomer.Location = new System.Drawing.Point(251, 250);
            this.BCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.BCustomer.Name = "BCustomer";
            this.BCustomer.Size = new System.Drawing.Size(192, 28);
            this.BCustomer.TabIndex = 28;
            this.BCustomer.Text = "search for a customer";
            this.BCustomer.UseVisualStyleBackColor = true;
            this.BCustomer.Click += new System.EventHandler(this.BCustomer_Click);
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = true;
            this.LStatus.Location = new System.Drawing.Point(628, 57);
            this.LStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(48, 17);
            this.LStatus.TabIndex = 29;
            this.LStatus.Text = "Status";
            // 
            // LStatusValue
            // 
            this.LStatusValue.AutoSize = true;
            this.LStatusValue.Location = new System.Drawing.Point(733, 57);
            this.LStatusValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LStatusValue.Name = "LStatusValue";
            this.LStatusValue.Size = new System.Drawing.Size(48, 17);
            this.LStatusValue.TabIndex = 30;
            this.LStatusValue.Text = "Status";
            // 
            // LMovieShowId
            // 
            this.LMovieShowId.AutoSize = true;
            this.LMovieShowId.Location = new System.Drawing.Point(632, 110);
            this.LMovieShowId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LMovieShowId.Name = "LMovieShowId";
            this.LMovieShowId.Size = new System.Drawing.Size(100, 17);
            this.LMovieShowId.TabIndex = 31;
            this.LMovieShowId.Text = "Movie Show ID";
            // 
            // TBMovieShowId
            // 
            this.TBMovieShowId.Location = new System.Drawing.Point(759, 106);
            this.TBMovieShowId.Margin = new System.Windows.Forms.Padding(4);
            this.TBMovieShowId.Name = "TBMovieShowId";
            this.TBMovieShowId.Size = new System.Drawing.Size(132, 22);
            this.TBMovieShowId.TabIndex = 32;
            // 
            // wayReserved
            // 
            this.wayReserved.Controls.Add(this.rBPhone);
            this.wayReserved.Controls.Add(this.rBPerson);
            this.wayReserved.Location = new System.Drawing.Point(222, 23);
            this.wayReserved.Margin = new System.Windows.Forms.Padding(4);
            this.wayReserved.Name = "wayReserved";
            this.wayReserved.Padding = new System.Windows.Forms.Padding(4);
            this.wayReserved.Size = new System.Drawing.Size(267, 63);
            this.wayReserved.TabIndex = 40;
            this.wayReserved.TabStop = false;
            this.wayReserved.Text = "WayReserved";
            // 
            // LDatePAymentValue
            // 
            this.LDatePAymentValue.AutoSize = true;
            this.LDatePAymentValue.Location = new System.Drawing.Point(247, 130);
            this.LDatePAymentValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDatePAymentValue.Name = "LDatePAymentValue";
            this.LDatePAymentValue.Size = new System.Drawing.Size(137, 17);
            this.LDatePAymentValue.TabIndex = 41;
            this.LDatePAymentValue.Text = "LDatePaymentVlaue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Row Id";
            // 
            // nUDRow
            // 
            this.nUDRow.Location = new System.Drawing.Point(250, 214);
            this.nUDRow.Margin = new System.Windows.Forms.Padding(4);
            this.nUDRow.Name = "nUDRow";
            this.nUDRow.Size = new System.Drawing.Size(248, 22);
            this.nUDRow.TabIndex = 43;
            // 
            // RBCancel
            // 
            this.RBCancel.AutoSize = true;
            this.RBCancel.Location = new System.Drawing.Point(15, 20);
            this.RBCancel.Margin = new System.Windows.Forms.Padding(4);
            this.RBCancel.Name = "RBCancel";
            this.RBCancel.Size = new System.Drawing.Size(72, 21);
            this.RBCancel.TabIndex = 40;
            this.RBCancel.TabStop = true;
            this.RBCancel.Text = "Cancel";
            this.RBCancel.UseVisualStyleBackColor = true;
            this.RBCancel.CheckedChanged += new System.EventHandler(this.RBCancel_CheckedChanged);
            // 
            // RB
            // 
            this.RB.AutoSize = true;
            this.RB.Location = new System.Drawing.Point(163, 17);
            this.RB.Margin = new System.Windows.Forms.Padding(4);
            this.RB.Name = "RB";
            this.RB.Size = new System.Drawing.Size(53, 21);
            this.RB.TabIndex = 41;
            this.RB.TabStop = true;
            this.RB.Text = "Pay";
            this.RB.UseVisualStyleBackColor = true;
            this.RB.CheckedChanged += new System.EventHandler(this.RB_CheckedChanged);
            // 
            // GBupdate
            // 
            this.GBupdate.Controls.Add(this.RB);
            this.GBupdate.Controls.Add(this.RBCancel);
            this.GBupdate.Location = new System.Drawing.Point(595, 317);
            this.GBupdate.Margin = new System.Windows.Forms.Padding(4);
            this.GBupdate.Name = "GBupdate";
            this.GBupdate.Padding = new System.Windows.Forms.Padding(4);
            this.GBupdate.Size = new System.Drawing.Size(337, 49);
            this.GBupdate.TabIndex = 41;
            this.GBupdate.TabStop = false;
            this.GBupdate.Text = "Updated";
            // 
            // chooseOffers
            // 
            this.chooseOffers.Location = new System.Drawing.Point(595, 177);
            this.chooseOffers.Margin = new System.Windows.Forms.Padding(4);
            this.chooseOffers.Name = "chooseOffers";
            this.chooseOffers.Padding = new System.Windows.Forms.Padding(4);
            this.chooseOffers.Size = new System.Drawing.Size(337, 132);
            this.chooseOffers.TabIndex = 42;
            this.chooseOffers.TabStop = false;
            this.chooseOffers.Text = "Offers";
            // 
            // findOffersButtom
            // 
            this.findOffersButtom.Location = new System.Drawing.Point(666, 147);
            this.findOffersButtom.Name = "findOffersButtom";
            this.findOffersButtom.Size = new System.Drawing.Size(145, 23);
            this.findOffersButtom.TabIndex = 44;
            this.findOffersButtom.Text = "find offers";
            this.findOffersButtom.UseVisualStyleBackColor = true;
            this.findOffersButtom.Click += new System.EventHandler(this.findOffersButtom_Click);
            // 
            // UCaddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.findOffersButtom);
            this.Controls.Add(this.chooseOffers);
            this.Controls.Add(this.nUDRow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GBupdate);
            this.Controls.Add(this.LDatePAymentValue);
            this.Controls.Add(this.wayReserved);
            this.Controls.Add(this.TBMovieShowId);
            this.Controls.Add(this.LMovieShowId);
            this.Controls.Add(this.LStatusValue);
            this.Controls.Add(this.LStatus);
            this.Controls.Add(this.BCustomer);
            this.Controls.Add(this.nUDSeat);
            this.Controls.Add(this.LDateReserveValue);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.LEmployeeWhoRecevedPaymentValue);
            this.Controls.Add(this.LEmployeeWhoRecevedPayment);
            this.Controls.Add(this.LREservedEmployeeVslue);
            this.Controls.Add(this.LReservedEmployee);
            this.Controls.Add(this.LCustomerId);
            this.Controls.Add(this.cBHall);
            this.Controls.Add(LHallId);
            this.Controls.Add(this.LSeatId);
            this.Controls.Add(this.LDatePayed);
            this.Controls.Add(this.LDateReserved);
            this.Controls.Add(this.LWayReserved);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCaddTicket";
            this.Size = new System.Drawing.Size(1005, 516);
            ((System.ComponentModel.ISupportInitialize)(this.nUDSeat)).EndInit();
            this.wayReserved.ResumeLayout(false);
            this.wayReserved.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDRow)).EndInit();
            this.GBupdate.ResumeLayout(false);
            this.GBupdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            ////////////////////////////
            this.cBHall.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        #endregion

        private System.Windows.Forms.Label LWayReserved;
        private System.Windows.Forms.Label LDateReserved;
        private System.Windows.Forms.Label LDatePayed;
        private System.Windows.Forms.RadioButton rBPhone;
        private System.Windows.Forms.RadioButton rBPerson;
        private System.Windows.Forms.Label LSeatId;
        private System.Windows.Forms.ComboBox cBHall;
        private System.Windows.Forms.Label LCustomerId;
        private System.Windows.Forms.Label LReservedEmployee;
        private System.Windows.Forms.Label LREservedEmployeeVslue;
        private System.Windows.Forms.Label LEmployeeWhoRecevedPaymentValue;
        private System.Windows.Forms.Label LEmployeeWhoRecevedPayment;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Label LDateReserveValue;
        private System.Windows.Forms.NumericUpDown nUDSeat;
        private System.Windows.Forms.Button BCustomer;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Label LStatusValue;
        private System.Windows.Forms.Label LMovieShowId;
        private System.Windows.Forms.TextBox TBMovieShowId;
        private System.Windows.Forms.GroupBox wayReserved;
        private System.Windows.Forms.Label LDatePAymentValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUDRow;
        private System.Windows.Forms.RadioButton RBCancel;
        private System.Windows.Forms.RadioButton RB;
        private System.Windows.Forms.GroupBox GBupdate;
        private System.Windows.Forms.GroupBox chooseOffers;
        private System.Windows.Forms.Button findOffersButtom;
    }
}
