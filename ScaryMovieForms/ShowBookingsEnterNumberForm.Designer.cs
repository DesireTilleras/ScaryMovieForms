
namespace ScaryMovieForms
{
    partial class ShowBookingsEnterNumberForm
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
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumberBookings = new System.Windows.Forms.TextBox();
            this.btnShowBookings = new System.Windows.Forms.Button();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(27, 149);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(184, 20);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "Enter your phone number: ";
            // 
            // txtPhoneNumberBookings
            // 
            this.txtPhoneNumberBookings.Location = new System.Drawing.Point(241, 149);
            this.txtPhoneNumberBookings.Name = "txtPhoneNumberBookings";
            this.txtPhoneNumberBookings.Size = new System.Drawing.Size(205, 27);
            this.txtPhoneNumberBookings.TabIndex = 1;
            this.txtPhoneNumberBookings.TextChanged += new System.EventHandler(this.txtPhoneNumberBookings_TextChanged);
            // 
            // btnShowBookings
            // 
            this.btnShowBookings.Location = new System.Drawing.Point(342, 332);
            this.btnShowBookings.Name = "btnShowBookings";
            this.btnShowBookings.Size = new System.Drawing.Size(183, 29);
            this.btnShowBookings.TabIndex = 2;
            this.btnShowBookings.Text = "Show my bookings";
            this.btnShowBookings.UseVisualStyleBackColor = true;
            this.btnShowBookings.Click += new System.EventHandler(this.btnShowBookings_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Location = new System.Drawing.Point(3, 332);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(183, 29);
            this.btnBackToMenu.TabIndex = 3;
            this.btnBackToMenu.Text = "Go back to main menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // ShowBookingsEnterNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 373);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.btnShowBookings);
            this.Controls.Add(this.txtPhoneNumberBookings);
            this.Controls.Add(this.lblPhoneNumber);
            this.Name = "ShowBookingsEnterNumberForm";
            this.Text = "ShowBookingsEnterNumberForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumberBookings;
        private System.Windows.Forms.Button btnShowBookings;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}