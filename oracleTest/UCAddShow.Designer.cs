using System.Windows.Forms;

namespace oracleTest
{
    partial class UCAddShow
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
            this.LAddShowWelcome = new System.Windows.Forms.Label();
            this.LMovieName = new System.Windows.Forms.Label();
            this.LShowDate = new System.Windows.Forms.Label();
            this.DTMPShowDate = new System.Windows.Forms.DateTimePicker();
            this.LShowPoints = new System.Windows.Forms.Label();
            this.NUDShowPoints = new System.Windows.Forms.NumericUpDown();
            this.LShowPrice = new System.Windows.Forms.Label();
            this.NUDShowPrice = new System.Windows.Forms.NumericUpDown();
            this.LShowHall = new System.Windows.Forms.Label();
            this.cBHall = new System.Windows.Forms.ComboBox();
            this.BAdd = new System.Windows.Forms.Button();
            this.LMovieNameValue = new System.Windows.Forms.Label();
            this.DTMPShowTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.NUDShowPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDShowPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // LAddShowWelcome
            // 
            this.LAddShowWelcome.AutoSize = true;
            this.LAddShowWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAddShowWelcome.Location = new System.Drawing.Point(58, 39);
            this.LAddShowWelcome.Name = "LAddShowWelcome";
            this.LAddShowWelcome.Size = new System.Drawing.Size(143, 17);
            this.LAddShowWelcome.TabIndex = 0;
            this.LAddShowWelcome.Text = "Let\'s add a new show";
            // 
            // LMovieName
            // 
            this.LMovieName.AutoSize = true;
            this.LMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMovieName.Location = new System.Drawing.Point(58, 112);
            this.LMovieName.Name = "LMovieName";
            this.LMovieName.Size = new System.Drawing.Size(100, 17);
            this.LMovieName.TabIndex = 1;
            this.LMovieName.Text = "Movie\'s  Name";
            // 
            // LShowDate
            // 
            this.LShowDate.AutoSize = true;
            this.LShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LShowDate.Location = new System.Drawing.Point(58, 153);
            this.LShowDate.Name = "LShowDate";
            this.LShowDate.Size = new System.Drawing.Size(86, 17);
            this.LShowDate.TabIndex = 3;
            this.LShowDate.Text = "Show\'s Date";
            // 
            // DTMPShowDate
            // 
            this.DTMPShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTMPShowDate.Location = new System.Drawing.Point(175, 153);
            this.DTMPShowDate.Name = "DTMPShowDate";
            this.DTMPShowDate.Size = new System.Drawing.Size(242, 23);
            this.DTMPShowDate.TabIndex = 4;
            // 
            // LShowPoints
            // 
            this.LShowPoints.AutoSize = true;
            this.LShowPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LShowPoints.Location = new System.Drawing.Point(58, 194);
            this.LShowPoints.Name = "LShowPoints";
            this.LShowPoints.Size = new System.Drawing.Size(95, 17);
            this.LShowPoints.TabIndex = 5;
            this.LShowPoints.Text = "Show\'s Points";
            // 
            // NUDShowPoints
            // 
            this.NUDShowPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDShowPoints.Location = new System.Drawing.Point(175, 188);
            this.NUDShowPoints.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NUDShowPoints.Name = "NUDShowPoints";
            this.NUDShowPoints.Size = new System.Drawing.Size(242, 23);
            this.NUDShowPoints.TabIndex = 6;
            // 
            // LShowPrice
            // 
            this.LShowPrice.AutoSize = true;
            this.LShowPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LShowPrice.Location = new System.Drawing.Point(58, 228);
            this.LShowPrice.Name = "LShowPrice";
            this.LShowPrice.Size = new System.Drawing.Size(88, 17);
            this.LShowPrice.TabIndex = 7;
            this.LShowPrice.Text = "Show\'s Price";
            // 
            // NUDShowPrice
            // 
            this.NUDShowPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDShowPrice.Location = new System.Drawing.Point(175, 226);
            this.NUDShowPrice.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NUDShowPrice.Name = "NUDShowPrice";
            this.NUDShowPrice.Size = new System.Drawing.Size(242, 23);
            this.NUDShowPrice.TabIndex = 8;
            // 
            // LShowHall
            // 
            this.LShowHall.AutoSize = true;
            this.LShowHall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LShowHall.Location = new System.Drawing.Point(58, 267);
            this.LShowHall.Name = "LShowHall";
            this.LShowHall.Size = new System.Drawing.Size(80, 17);
            this.LShowHall.TabIndex = 9;
            this.LShowHall.Text = "Show\'s Hall";
            // 
            // cBHall
            // 
            this.cBHall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBHall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBHall.FormattingEnabled = true;
            this.cBHall.Location = new System.Drawing.Point(175, 264);
            this.cBHall.Name = "cBHall";
            this.cBHall.Size = new System.Drawing.Size(242, 24);
            this.cBHall.TabIndex = 10;
            // 
            // BAdd
            // 
            this.BAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAdd.Location = new System.Drawing.Point(463, 290);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(97, 46);
            this.BAdd.TabIndex = 11;
            this.BAdd.Text = "Add";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // LMovieNameValue
            // 
            this.LMovieNameValue.AutoSize = true;
            this.LMovieNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMovieNameValue.Location = new System.Drawing.Point(175, 112);
            this.LMovieNameValue.Name = "LMovieNameValue";
            this.LMovieNameValue.Size = new System.Drawing.Size(126, 17);
            this.LMovieNameValue.TabIndex = 12;
            this.LMovieNameValue.Text = "Movie Name Value";
            // 
            // DTMPShowTime
            // 
            this.DTMPShowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTMPShowTime.Location = new System.Drawing.Point(433, 149);
            this.DTMPShowTime.Name = "DTMPShowTime";
            this.DTMPShowTime.Size = new System.Drawing.Size(128, 23);
            this.DTMPShowTime.TabIndex = 13;
            // 
            // UCAddShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DTMPShowTime);
            this.Controls.Add(this.LMovieNameValue);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.cBHall);
            this.Controls.Add(this.LShowHall);
            this.Controls.Add(this.NUDShowPrice);
            this.Controls.Add(this.LShowPrice);
            this.Controls.Add(this.NUDShowPoints);
            this.Controls.Add(this.LShowPoints);
            this.Controls.Add(this.DTMPShowDate);
            this.Controls.Add(this.LShowDate);
            this.Controls.Add(this.LMovieName);
            this.Controls.Add(this.LAddShowWelcome);
            this.Name = "UCAddShow";
            this.Size = new System.Drawing.Size(592, 364);
            ((System.ComponentModel.ISupportInitialize)(this.NUDShowPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDShowPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LAddShowWelcome;
        private System.Windows.Forms.Label LMovieName;
        private System.Windows.Forms.Label LShowDate;
        private System.Windows.Forms.DateTimePicker DTMPShowDate;
        private System.Windows.Forms.Label LShowPoints;
        private System.Windows.Forms.NumericUpDown NUDShowPoints;
        private System.Windows.Forms.Label LShowPrice;
        private System.Windows.Forms.NumericUpDown NUDShowPrice;
        private System.Windows.Forms.Label LShowHall;
        private System.Windows.Forms.ComboBox cBHall;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Label LMovieNameValue;
        private System.Windows.Forms.DateTimePicker DTMPShowTime;
    }
}