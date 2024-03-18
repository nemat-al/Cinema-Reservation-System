namespace oracleTest
{
    partial class UCMovieStatis
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RBMostShown = new System.Windows.Forms.RadioButton();
            this.RBMostSelling = new System.Windows.Forms.RadioButton();
            this.BfindStat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(102, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(664, 368);
            this.dataGridView1.TabIndex = 0;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(214, 73);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 22);
            this.startDatePicker.TabIndex = 1;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(520, 73);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 22);
            this.endDatePicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "startDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "endDate";
            // 
            // RBMostShown
            // 
            this.RBMostShown.AutoSize = true;
            this.RBMostShown.Location = new System.Drawing.Point(127, 128);
            this.RBMostShown.Name = "RBMostShown";
            this.RBMostShown.Size = new System.Drawing.Size(153, 21);
            this.RBMostShown.TabIndex = 5;
            this.RBMostShown.TabStop = true;
            this.RBMostShown.Text = "Most Movies Shown";
            this.RBMostShown.UseVisualStyleBackColor = true;
            // 
            // RBMostSelling
            // 
            this.RBMostSelling.AutoSize = true;
            this.RBMostSelling.Location = new System.Drawing.Point(304, 128);
            this.RBMostSelling.Name = "RBMostSelling";
            this.RBMostSelling.Size = new System.Drawing.Size(146, 21);
            this.RBMostSelling.TabIndex = 6;
            this.RBMostSelling.TabStop = true;
            this.RBMostSelling.Text = "MostSellingTickets";
            this.RBMostSelling.UseVisualStyleBackColor = true;
            // 
            // BfindStat
            // 
            this.BfindStat.Location = new System.Drawing.Point(476, 126);
            this.BfindStat.Name = "BfindStat";
            this.BfindStat.Size = new System.Drawing.Size(144, 23);
            this.BfindStat.TabIndex = 7;
            this.BfindStat.Text = "find statics";
            this.BfindStat.UseVisualStyleBackColor = true;
            this.BfindStat.Click += new System.EventHandler(this.BfindStat_Click);
            // 
            // UCMovieStatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BfindStat);
            this.Controls.Add(this.RBMostSelling);
            this.Controls.Add(this.RBMostShown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UCMovieStatis";
            this.Size = new System.Drawing.Size(885, 591);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RBMostShown;
        private System.Windows.Forms.RadioButton RBMostSelling;
        private System.Windows.Forms.Button BfindStat;
    }
}
