namespace oracleTest
{
    partial class UCEmployeeStatis
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
            this.label1 = new System.Windows.Forms.Label();
            this.TB_EmployeeId = new System.Windows.Forms.TextBox();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filterButtom = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RBreservedBy = new System.Windows.Forms.RadioButton();
            this.RBpayedBy = new System.Windows.Forms.RadioButton();
            this.RBOverPhone = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee id";
            // 
            // TB_EmployeeId
            // 
            this.TB_EmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_EmployeeId.Location = new System.Drawing.Point(166, 71);
            this.TB_EmployeeId.Name = "TB_EmployeeId";
            this.TB_EmployeeId.Size = new System.Drawing.Size(100, 22);
            this.TB_EmployeeId.TabIndex = 1;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.Location = new System.Drawing.Point(379, 74);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 22);
            this.startDatePicker.TabIndex = 2;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatePicker.Location = new System.Drawing.Point(675, 74);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 22);
            this.endDatePicker.TabIndex = 3;
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.Location = new System.Drawing.Point(283, 74);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(66, 17);
            this.startDate.TabIndex = 4;
            this.startDate.Text = "startDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(597, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "endDate";
            // 
            // filterButtom
            // 
            this.filterButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButtom.Location = new System.Drawing.Point(771, 114);
            this.filterButtom.Name = "filterButtom";
            this.filterButtom.Size = new System.Drawing.Size(104, 43);
            this.filterButtom.TabIndex = 6;
            this.filterButtom.Text = "filter";
            this.filterButtom.UseVisualStyleBackColor = true;
            this.filterButtom.Click += new System.EventHandler(this.filterButtom_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(705, 301);
            this.dataGridView1.TabIndex = 7;
            // 
            // RBreservedBy
            // 
            this.RBreservedBy.AutoSize = true;
            this.RBreservedBy.Location = new System.Drawing.Point(271, 131);
            this.RBreservedBy.Name = "RBreservedBy";
            this.RBreservedBy.Size = new System.Drawing.Size(128, 21);
            this.RBreservedBy.TabIndex = 8;
            this.RBreservedBy.TabStop = true;
            this.RBreservedBy.Text = "Reserved Ones";
            this.RBreservedBy.UseVisualStyleBackColor = true;
            // 
            // RBpayedBy
            // 
            this.RBpayedBy.AutoSize = true;
            this.RBpayedBy.Location = new System.Drawing.Point(422, 131);
            this.RBpayedBy.Name = "RBpayedBy";
            this.RBpayedBy.Size = new System.Drawing.Size(107, 21);
            this.RBpayedBy.TabIndex = 9;
            this.RBpayedBy.TabStop = true;
            this.RBpayedBy.Text = "Payed Ones";
            this.RBpayedBy.UseVisualStyleBackColor = true;
            // 
            // RBOverPhone
            // 
            this.RBOverPhone.AutoSize = true;
            this.RBOverPhone.Location = new System.Drawing.Point(564, 131);
            this.RBOverPhone.Name = "RBOverPhone";
            this.RBOverPhone.Size = new System.Drawing.Size(170, 21);
            this.RBOverPhone.TabIndex = 10;
            this.RBOverPhone.TabStop = true;
            this.RBOverPhone.Text = "Reserved Over Phone";
            this.RBOverPhone.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "You can choose one type of managed tickets:";
            // 
            // UCEmployeeStatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RBOverPhone);
            this.Controls.Add(this.RBpayedBy);
            this.Controls.Add(this.RBreservedBy);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.filterButtom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.TB_EmployeeId);
            this.Controls.Add(this.label1);
            this.Name = "UCEmployeeStatis";
            this.Size = new System.Drawing.Size(919, 492);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_EmployeeId;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label startDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button filterButtom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton RBreservedBy;
        private System.Windows.Forms.RadioButton RBpayedBy;
        private System.Windows.Forms.RadioButton RBOverPhone;
        private System.Windows.Forms.Label label2;
    }
}
