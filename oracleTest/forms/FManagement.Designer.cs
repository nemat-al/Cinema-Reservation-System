namespace oracleTest.forms
{
    partial class FManagement
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
            this.BShowEmployees = new System.Windows.Forms.Button();
            this.BAddMovie = new System.Windows.Forms.Button();
            this.BViewAndEditShows = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BMovies = new System.Windows.Forms.Button();
            this.BMovieStatistics = new System.Windows.Forms.Button();
            this.bAddOfferOverCategory = new System.Windows.Forms.Button();
            this.BAddOfferOverShow = new System.Windows.Forms.Button();
            this.ucMovieStatis1 = new oracleTest.UCMovieStatis();
            this.uCtableFromManagment = new oracleTest.forms.UCtable();
            this.ucAddMovieFromManagment = new oracleTest.forms.UCAddMovie();
            this.ucAddOfferfromManagmentButton = new oracleTest.forms.ucAddOffer();
            this.uCtablefromManagement = new oracleTest.forms.UCtable();
            this.SuspendLayout();
            // 
            // BShowEmployees
            // 
            this.BShowEmployees.Location = new System.Drawing.Point(16, 79);
            this.BShowEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BShowEmployees.Name = "BShowEmployees";
            this.BShowEmployees.Size = new System.Drawing.Size(144, 47);
            this.BShowEmployees.TabIndex = 0;
            this.BShowEmployees.Text = "Show Employees";
            this.BShowEmployees.UseVisualStyleBackColor = true;
            this.BShowEmployees.Click += new System.EventHandler(this.BShowEmployees_Click);
            // 
            // BAddMovie
            // 
            this.BAddMovie.Location = new System.Drawing.Point(16, 133);
            this.BAddMovie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BAddMovie.Name = "BAddMovie";
            this.BAddMovie.Size = new System.Drawing.Size(144, 47);
            this.BAddMovie.TabIndex = 1;
            this.BAddMovie.Text = "Add Movie";
            this.BAddMovie.UseVisualStyleBackColor = true;
            this.BAddMovie.Click += new System.EventHandler(this.BAddMovie_Click);
            // 
            // BViewAndEditShows
            // 
            this.BViewAndEditShows.Location = new System.Drawing.Point(16, 187);
            this.BViewAndEditShows.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BViewAndEditShows.Name = "BViewAndEditShows";
            this.BViewAndEditShows.Size = new System.Drawing.Size(144, 47);
            this.BViewAndEditShows.TabIndex = 2;
            this.BViewAndEditShows.Text = "View and edit Shows";
            this.BViewAndEditShows.UseVisualStyleBackColor = true;
            this.BViewAndEditShows.Click += new System.EventHandler(this.BViewAndEditShows_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(15, 459);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Receptionist";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BMovies
            // 
            this.BMovies.Location = new System.Drawing.Point(15, 241);
            this.BMovies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BMovies.Name = "BMovies";
            this.BMovies.Size = new System.Drawing.Size(144, 53);
            this.BMovies.TabIndex = 7;
            this.BMovies.Text = "Show Movies And Add New Shows";
            this.BMovies.UseVisualStyleBackColor = true;
            this.BMovies.Click += new System.EventHandler(this.BMovies_Click);
            // 
            // BMovieStatistics
            // 
            this.BMovieStatistics.Location = new System.Drawing.Point(16, 302);
            this.BMovieStatistics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BMovieStatistics.Name = "BMovieStatistics";
            this.BMovieStatistics.Size = new System.Drawing.Size(144, 47);
            this.BMovieStatistics.TabIndex = 8;
            this.BMovieStatistics.Text = "Show Movies statistics";
            this.BMovieStatistics.UseVisualStyleBackColor = true;
            this.BMovieStatistics.Click += new System.EventHandler(this.BMovieStatistics_Click);
            // 
            // bAddOfferOverCategory
            // 
            this.bAddOfferOverCategory.Location = new System.Drawing.Point(17, 354);
            this.bAddOfferOverCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAddOfferOverCategory.Name = "bAddOfferOverCategory";
            this.bAddOfferOverCategory.Size = new System.Drawing.Size(141, 42);
            this.bAddOfferOverCategory.TabIndex = 8;
            this.bAddOfferOverCategory.Text = "Add Offer Over Category";
            this.bAddOfferOverCategory.UseVisualStyleBackColor = true;
            this.bAddOfferOverCategory.Click += new System.EventHandler(this.bAddOfferOverCategory_Click);
            // 
            // BAddOfferOverShow
            // 
            this.BAddOfferOverShow.Location = new System.Drawing.Point(15, 402);
            this.BAddOfferOverShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BAddOfferOverShow.Name = "BAddOfferOverShow";
            this.BAddOfferOverShow.Size = new System.Drawing.Size(143, 49);
            this.BAddOfferOverShow.TabIndex = 6;
            this.BAddOfferOverShow.Text = "Add Offer Over Show";
            this.BAddOfferOverShow.UseVisualStyleBackColor = true;
            this.BAddOfferOverShow.Click += new System.EventHandler(this.BAddOfferOverShow_Click);
            // 
            // ucMovieStatis1
            // 
            this.ucMovieStatis1.Location = new System.Drawing.Point(232, 14);
            this.ucMovieStatis1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucMovieStatis1.Name = "ucMovieStatis1";
            this.ucMovieStatis1.Size = new System.Drawing.Size(896, 591);
            this.ucMovieStatis1.TabIndex = 9;
            this.ucMovieStatis1.Load += new System.EventHandler(this.ucMovieStatis1_Load);
            // 
            // uCtableFromManagment
            // 
            this.uCtableFromManagment.Enabled = false;
            this.uCtableFromManagment.Location = new System.Drawing.Point(183, 7);
            this.uCtableFromManagment.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uCtableFromManagment.Name = "uCtableFromManagment";
            this.uCtableFromManagment.Size = new System.Drawing.Size(1121, 550);
            this.uCtableFromManagment.TabIndex = 4;
            this.uCtableFromManagment.User = null;
            this.uCtableFromManagment.Visible = false;
            // 
            // ucAddMovieFromManagment
            // 
            this.ucAddMovieFromManagment.Enabled = false;
            this.ucAddMovieFromManagment.Location = new System.Drawing.Point(211, 98);
            this.ucAddMovieFromManagment.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucAddMovieFromManagment.Name = "ucAddMovieFromManagment";
            this.ucAddMovieFromManagment.Size = new System.Drawing.Size(835, 473);
            this.ucAddMovieFromManagment.TabIndex = 3;
            this.ucAddMovieFromManagment.Visible = false;
            // 
            // ucAddOfferfromManagmentButton
            // 
            this.ucAddOfferfromManagmentButton.Enabled = false;
            this.ucAddOfferfromManagmentButton.Location = new System.Drawing.Point(197, 79);
            this.ucAddOfferfromManagmentButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucAddOfferfromManagmentButton.Name = "ucAddOfferfromManagmentButton";
            this.ucAddOfferfromManagmentButton.Size = new System.Drawing.Size(931, 479);
            this.ucAddOfferfromManagmentButton.TabIndex = 9;
            this.ucAddOfferfromManagmentButton.Visible = false;
            // 
            // uCtablefromManagement
            // 
            this.uCtablefromManagement.Enabled = false;
            this.uCtablefromManagement.Location = new System.Drawing.Point(139, 23);
            this.uCtablefromManagement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uCtablefromManagement.Name = "uCtablefromManagement";
            this.uCtablefromManagement.Size = new System.Drawing.Size(612, 373);
            this.uCtablefromManagement.TabIndex = 4;
            this.uCtablefromManagement.User = null;
            this.uCtablefromManagement.Visible = false;
            // 
            // FManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 672);
            this.Controls.Add(this.ucMovieStatis1);
            this.Controls.Add(this.BMovieStatistics);
            this.Controls.Add(this.BMovies);
            this.Controls.Add(this.BAddOfferOverShow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uCtableFromManagment);
            this.Controls.Add(this.ucAddMovieFromManagment);
            this.Controls.Add(this.BViewAndEditShows);
            this.Controls.Add(this.BAddMovie);
            this.Controls.Add(this.BShowEmployees);
            this.Controls.Add(this.ucAddOfferfromManagmentButton);
            this.Controls.Add(this.bAddOfferOverCategory);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FManagement";
            this.Text = "Fanagement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FManagement_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BShowEmployees;
        private System.Windows.Forms.Button BAddMovie;
        private System.Windows.Forms.Button BViewAndEditShows;
        private UCAddMovie ucAddMovieFromManagment;
        private UCtable uCtablefromManagement;
        private UCtable uCtableFromManagment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BMovies;
        private System.Windows.Forms.Button BMovieStatistics;
        private UCMovieStatis ucMovieStatis1;
        private ucAddOffer ucAddOfferfromManagmentButton;
        private System.Windows.Forms.Button bAddOfferOverCategory;
        private System.Windows.Forms.Button BAddOfferOverShow;
        //  private oracleTest.employeeStatis employeeStatis1;
    }
}