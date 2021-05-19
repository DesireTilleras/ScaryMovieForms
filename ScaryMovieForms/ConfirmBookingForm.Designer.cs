
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
            this.lblConfirmBookingTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmBookingTitle.Location = new System.Drawing.Point(215, 43);
            this.lblConfirmBookingTitle.Name = "lblConfirmBookingTitle";
            this.lblConfirmBookingTitle.Size = new System.Drawing.Size(273, 46);
            this.lblConfirmBookingTitle.TabIndex = 0;
            this.lblConfirmBookingTitle.Text = "Confirm booking";
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Location = new System.Drawing.Point(47, 136);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(83, 20);
            this.lblMovieTitle.TabIndex = 1;
            this.lblMovieTitle.Text = "Movie title:";
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Location = new System.Drawing.Point(157, 129);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(213, 27);
            this.txtMovieTitle.TabIndex = 2;
            // 
            // lblShowTime
            // 
            this.lblShowTime.AutoSize = true;
            this.lblShowTime.Location = new System.Drawing.Point(47, 183);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(82, 20);
            this.lblShowTime.TabIndex = 3;
            this.lblShowTime.Text = "Show time:";
            // 
            // txtShowTime
            // 
            this.txtShowTime.Location = new System.Drawing.Point(157, 183);
            this.txtShowTime.Name = "txtShowTime";
            this.txtShowTime.Size = new System.Drawing.Size(213, 27);
            this.txtShowTime.TabIndex = 4;
            // 
            // lblListOfTickets
            // 
            this.lblListOfTickets.AutoSize = true;
            this.lblListOfTickets.Location = new System.Drawing.Point(47, 232);
            this.lblListOfTickets.Name = "lblListOfTickets";
            this.lblListOfTickets.Size = new System.Drawing.Size(98, 20);
            this.lblListOfTickets.TabIndex = 5;
            this.lblListOfTickets.Text = "List of tickets:";
            // 
            // lstListOfTickets
            // 
            this.lstListOfTickets.FormattingEnabled = true;
            this.lstListOfTickets.ItemHeight = 20;
            this.lstListOfTickets.Location = new System.Drawing.Point(157, 232);
            this.lstListOfTickets.Name = "lstListOfTickets";
            this.lstListOfTickets.Size = new System.Drawing.Size(150, 104);
            this.lstListOfTickets.TabIndex = 6;
            // 
            // lblCustomerFirstName
            // 
            this.lblCustomerFirstName.AutoSize = true;
            this.lblCustomerFirstName.Location = new System.Drawing.Point(422, 129);
            this.lblCustomerFirstName.Name = "lblCustomerFirstName";
            this.lblCustomerFirstName.Size = new System.Drawing.Size(80, 20);
            this.lblCustomerFirstName.TabIndex = 7;
            this.lblCustomerFirstName.Text = "First name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(422, 190);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(79, 20);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(536, 129);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(178, 27);
            this.txtFirstName.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(536, 190);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(178, 27);
            this.txtLastName.TabIndex = 10;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(620, 425);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(94, 29);
            this.btnBook.TabIndex = 11;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnGoBackMaenu
            // 
            this.btnGoBackMaenu.Location = new System.Drawing.Point(12, 425);
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
            this.ClientSize = new System.Drawing.Size(729, 466);
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