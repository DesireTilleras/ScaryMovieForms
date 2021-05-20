
namespace ScaryMovieForms
{
    partial class ConfirmBookingForm
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
            this.lblConfirmBookingTitle = new System.Windows.Forms.Label();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.txtShowTime = new System.Windows.Forms.TextBox();
            this.lblListOfTickets = new System.Windows.Forms.Label();
            this.lstListOfTickets = new System.Windows.Forms.ListBox();
            this.lblCustomerFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnGoBackMaenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConfirmBookingTitle
            // 
            this.lblConfirmBookingTitle.AutoSize = true;
            this.lblConfirmBookingTitle.BackColor = System.Drawing.Color.White;
            this.lblConfirmBookingTitle.Font = new System.Drawing.Font("Chiller", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmBookingTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblConfirmBookingTitle.Location = new System.Drawing.Point(315, 138);
            this.lblConfirmBookingTitle.Name = "lblConfirmBookingTitle";
            this.lblConfirmBookingTitle.Size = new System.Drawing.Size(239, 50);
            this.lblConfirmBookingTitle.TabIndex = 0;
            this.lblConfirmBookingTitle.Text = "Confirm booking";
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.BackColor = System.Drawing.Color.White;
            this.lblMovieTitle.Location = new System.Drawing.Point(53, 233);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(83, 20);
            this.lblMovieTitle.TabIndex = 1;
            this.lblMovieTitle.Text = "Movie title:";
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Enabled = false;
            this.txtMovieTitle.Location = new System.Drawing.Point(157, 230);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(213, 27);
            this.txtMovieTitle.TabIndex = 2;
            // 
            // lblShowTime
            // 
            this.lblShowTime.AutoSize = true;
            this.lblShowTime.BackColor = System.Drawing.Color.White;
            this.lblShowTime.Location = new System.Drawing.Point(53, 276);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(82, 20);
            this.lblShowTime.TabIndex = 3;
            this.lblShowTime.Text = "Show time:";
            // 
            // txtShowTime
            // 
            this.txtShowTime.Enabled = false;
            this.txtShowTime.Location = new System.Drawing.Point(157, 273);
            this.txtShowTime.Name = "txtShowTime";
            this.txtShowTime.Size = new System.Drawing.Size(213, 27);
            this.txtShowTime.TabIndex = 4;
            // 
            // lblListOfTickets
            // 
            this.lblListOfTickets.AutoSize = true;
            this.lblListOfTickets.BackColor = System.Drawing.Color.White;
            this.lblListOfTickets.Location = new System.Drawing.Point(53, 315);
            this.lblListOfTickets.Name = "lblListOfTickets";
            this.lblListOfTickets.Size = new System.Drawing.Size(96, 20);
            this.lblListOfTickets.TabIndex = 5;
            this.lblListOfTickets.Text = "Seat number:";
            // 
            // lstListOfTickets
            // 
            this.lstListOfTickets.FormattingEnabled = true;
            this.lstListOfTickets.ItemHeight = 20;
            this.lstListOfTickets.Location = new System.Drawing.Point(157, 315);
            this.lstListOfTickets.Name = "lstListOfTickets";
            this.lstListOfTickets.Size = new System.Drawing.Size(150, 104);
            this.lstListOfTickets.TabIndex = 6;
            // 
            // lblCustomerFirstName
            // 
            this.lblCustomerFirstName.AutoSize = true;
            this.lblCustomerFirstName.BackColor = System.Drawing.Color.White;
            this.lblCustomerFirstName.Location = new System.Drawing.Point(408, 236);
            this.lblCustomerFirstName.Name = "lblCustomerFirstName";
            this.lblCustomerFirstName.Size = new System.Drawing.Size(80, 20);
            this.lblCustomerFirstName.TabIndex = 7;
            this.lblCustomerFirstName.Text = "First name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(409, 276);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(79, 20);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(516, 233);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(178, 27);
            this.txtFirstName.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(516, 273);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(178, 27);
            this.txtLastName.TabIndex = 10;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(719, 546);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(155, 29);
            this.btnBook.TabIndex = 11;
            this.btnBook.Text = "Confirm booking";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnGoBackMaenu
            // 
            this.btnGoBackMaenu.Location = new System.Drawing.Point(12, 546);
            this.btnGoBackMaenu.Name = "btnGoBackMaenu";
            this.btnGoBackMaenu.Size = new System.Drawing.Size(198, 29);
            this.btnGoBackMaenu.TabIndex = 12;
            this.btnGoBackMaenu.Text = "Go back to main menu";
            this.btnGoBackMaenu.UseVisualStyleBackColor = true;
            this.btnGoBackMaenu.Click += new System.EventHandler(this.btnGoBackMaenu_Click);
            // 
            // ConfirmBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ScaryMovieForms.Properties.Resources.blod1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 587);
            this.ControlBox = false;
            this.Controls.Add(this.btnGoBackMaenu);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblCustomerFirstName);
            this.Controls.Add(this.lstListOfTickets);
            this.Controls.Add(this.lblListOfTickets);
            this.Controls.Add(this.txtShowTime);
            this.Controls.Add(this.lblShowTime);
            this.Controls.Add(this.txtMovieTitle);
            this.Controls.Add(this.lblMovieTitle);
            this.Controls.Add(this.lblConfirmBookingTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmBookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmBookingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfirmBookingTitle;
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.TextBox txtMovieTitle;
        private System.Windows.Forms.Label lblShowTime;
        private System.Windows.Forms.TextBox txtShowTime;
        private System.Windows.Forms.Label lblListOfTickets;
        private System.Windows.Forms.ListBox lstListOfTickets;
        private System.Windows.Forms.Label lblCustomerFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnGoBackMaenu;
    }
}