namespace oracleTest.forms
{
    partial class ucAddOffer
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
            this.POfferOverCat = new System.Windows.Forms.Panel();
            this.CBCategory = new System.Windows.Forms.ComboBox();
            this.LCategory = new System.Windows.Forms.Label();
            this.DTMPStartDate = new System.Windows.Forms.DateTimePicker();
            this.LstartDate = new System.Windows.Forms.Label();
            this.LEndDate = new System.Windows.Forms.Label();
            this.DTMPEndDate = new System.Windows.Forms.DateTimePicker();
            this.BAdd = new System.Windows.Forms.Button();
            this.NUDpercentage = new System.Windows.Forms.NumericUpDown();
            this.LPercentage = new System.Windows.Forms.Label();
            this.LOfWell = new System.Windows.Forms.Label();
            this.POfferOverCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDpercentage)).BeginInit();
            this.SuspendLayout();
            // 
            // POfferOverCat
            // 
            this.POfferOverCat.Controls.Add(this.DTMPEndDate);
            this.POfferOverCat.Controls.Add(this.LEndDate);
            this.POfferOverCat.Controls.Add(this.LstartDate);
            this.POfferOverCat.Controls.Add(this.DTMPStartDate);
            this.POfferOverCat.Controls.Add(this.LCategory);
            this.POfferOverCat.Controls.Add(this.CBCategory);
            this.POfferOverCat.Location = new System.Drawing.Point(17, 103);
            this.POfferOverCat.Name = "POfferOverCat";
            this.POfferOverCat.Size = new System.Drawing.Size(567, 188);
            this.POfferOverCat.TabIndex = 2;
            // 
            // CBCategory
            // 
            this.CBCategory.FormattingEnabled = true;
            this.CBCategory.Location = new System.Drawing.Point(196, 12);
            this.CBCategory.Name = "CBCategory";
            this.CBCategory.Size = new System.Drawing.Size(315, 21);
            this.CBCategory.TabIndex = 0;
            // 
            // LCategory
            // 
            this.LCategory.AutoSize = true;
            this.LCategory.Location = new System.Drawing.Point(19, 21);
            this.LCategory.Name = "LCategory";
            this.LCategory.Size = new System.Drawing.Size(49, 13);
            this.LCategory.TabIndex = 1;
            this.LCategory.Text = "Category";
            // 
            // DTMPStartDate
            // 
            this.DTMPStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTMPStartDate.Location = new System.Drawing.Point(139, 78);
            this.DTMPStartDate.Name = "DTMPStartDate";
            this.DTMPStartDate.Size = new System.Drawing.Size(382, 23);
            this.DTMPStartDate.TabIndex = 5;
            // 
            // LstartDate
            // 
            this.LstartDate.AutoSize = true;
            this.LstartDate.Location = new System.Drawing.Point(22, 85);
            this.LstartDate.Name = "LstartDate";
            this.LstartDate.Size = new System.Drawing.Size(55, 13);
            this.LstartDate.TabIndex = 6;
            this.LstartDate.Text = "Start Date";
            // 
            // LEndDate
            // 
            this.LEndDate.AutoSize = true;
            this.LEndDate.Location = new System.Drawing.Point(22, 150);
            this.LEndDate.Name = "LEndDate";
            this.LEndDate.Size = new System.Drawing.Size(52, 13);
            this.LEndDate.TabIndex = 7;
            this.LEndDate.Text = "End Date";
            // 
            // DTMPEndDate
            // 
            this.DTMPEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTMPEndDate.Location = new System.Drawing.Point(139, 143);
            this.DTMPEndDate.Name = "DTMPEndDate";
            this.DTMPEndDate.Size = new System.Drawing.Size(382, 23);
            this.DTMPEndDate.TabIndex = 8;
            // 
            // BAdd
            // 
            this.BAdd.Location = new System.Drawing.Point(220, 297);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(150, 39);
            this.BAdd.TabIndex = 4;
            this.BAdd.Text = "Add";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // NUDpercentage
            // 
            this.NUDpercentage.Location = new System.Drawing.Point(145, 60);
            this.NUDpercentage.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.NUDpercentage.Name = "NUDpercentage";
            this.NUDpercentage.Size = new System.Drawing.Size(212, 20);
            this.NUDpercentage.TabIndex = 5;
            // 
            // LPercentage
            // 
            this.LPercentage.AutoSize = true;
            this.LPercentage.Location = new System.Drawing.Point(39, 62);
            this.LPercentage.Name = "LPercentage";
            this.LPercentage.Size = new System.Drawing.Size(88, 13);
            this.LPercentage.TabIndex = 6;
            this.LPercentage.Text = "Offer Percentage";
            // 
            // LOfWell
            // 
            this.LOfWell.AutoSize = true;
            this.LOfWell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOfWell.Location = new System.Drawing.Point(14, 26);
            this.LOfWell.Name = "LOfWell";
            this.LOfWell.Size = new System.Drawing.Size(305, 17);
            this.LOfWell.TabIndex = 7;
            this.LOfWell.Text = "Let\'s add an Offer  of type Offer Over Category";
            // 
            // ucAddOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LOfWell);
            this.Controls.Add(this.LPercentage);
            this.Controls.Add(this.NUDpercentage);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.POfferOverCat);
            this.Name = "ucAddOffer";
            this.Size = new System.Drawing.Size(623, 367);
            this.POfferOverCat.ResumeLayout(false);
            this.POfferOverCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDpercentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel POfferOverCat;
        private System.Windows.Forms.Label LCategory;
        private System.Windows.Forms.ComboBox CBCategory;
        private System.Windows.Forms.DateTimePicker DTMPEndDate;
        private System.Windows.Forms.Label LEndDate;
        private System.Windows.Forms.Label LstartDate;
        private System.Windows.Forms.DateTimePicker DTMPStartDate;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.NumericUpDown NUDpercentage;
        private System.Windows.Forms.Label LPercentage;
        private System.Windows.Forms.Label LOfWell;
    }
}