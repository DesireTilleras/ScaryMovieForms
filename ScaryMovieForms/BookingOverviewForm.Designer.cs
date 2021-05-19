
namespace ScaryMovieForms
{
    partial class BookingOverviewForm
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
            this.cklBookingList = new System.Windows.Forms.CheckedListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.btnChangeBooking = new System.Windows.Forms.Button();
            this.btnGoBackMenu = new System.Windows.Forms.Button();
            this.lstShowBookingInfo = new System.Windows.Forms.ListBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cklBookingList
            // 
            this.cklBookingList.FormattingEnabled = true;
            this.cklBookingList.Location = new System.Drawing.Point(38, 194);
            this.cklBookingList.Name = "cklBookingList";
            this.cklBookingList.Size = new System.Drawing.Size(25, 180);
            this.cklBookingList.TabIndex = 0;
            this.cklBookingList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cklBookingList_ItemCheck_1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Chiller", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(252, 118);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(319, 50);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Your current bookings";
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Location = new System.Drawing.Point(624, 409);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(146, 29);
            this.btnDeleteBooking.TabIndex = 2;
            this.btnDeleteBooking.Text = "Delete booking";
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // btnChangeBooking
            // 
            this.btnChangeBooking.Location = new System.Drawing.Point(423, 409);
            this.btnChangeBooking.Name = "btnChangeBooking";
            this.btnChangeBooking.Size = new System.Drawing.Size(164, 29);
            this.btnChangeBooking.TabIndex = 3;
            this.btnChangeBooking.Text = "Change booking";
            this.btnChangeBooking.UseVisualStyleBackColor = true;
            this.btnChangeBooking.Click += new System.EventHandler(this.btnChangeBooking_Click);
            // 
            // btnGoBackMenu
            // 
            this.btnGoBackMenu.Location = new System.Drawing.Point(38, 409);
            this.btnGoBackMenu.Name = "btnGoBackMenu";
            this.btnGoBackMenu.Size = new System.Drawing.Size(182, 29);
            this.btnGoBackMenu.TabIndex = 4;
            this.btnGoBackMenu.Text = "Go back to main menu";
            this.btnGoBackMenu.UseVisualStyleBackColor = true;
            this.btnGoBackMenu.Click += new System.EventHandler(this.btnGoBackMenu_Click);
            // 
            // lstShowBookingInfo
            // 
            this.lstShowBookingInfo.Enabled = false;
            this.lstShowBookingInfo.FormattingEnabled = true;
            this.lstShowBookingInfo.ItemHeight = 20;
            this.lstShowBookingInfo.Location = new System.Drawing.Point(65, 194);
            this.lstShowBookingInfo.Name = "lstShowBookingInfo";
            this.lstShowBookingInfo.Size = new System.Drawing.Size(705, 184);
            this.lstShowBookingInfo.TabIndex = 5;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.White;
            this.lblCustomerName.Location = new System.Drawing.Point(38, 159);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(113, 20);
            this.lblCustomerName.TabIndex = 6;
            this.lblCustomerName.Text = "Customer name";
            // 
            // BookingOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ScaryMovieForms.Properties.Resources.blod;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lstShowBookingInfo);
            this.Controls.Add(this.btnGoBackMenu);
            this.Controls.Add(this.btnChangeBooking);
            this.Controls.Add(this.btnDeleteBooking);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cklBookingList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookingOverviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingOverviewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cklBookingList;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Button btnChangeBooking;
        private System.Windows.Forms.Button btnGoBackMenu;
        private System.Windows.Forms.ListBox lstShowBookingInfo;
        private System.Windows.Forms.Label lblCustomerName;
    }
}