
namespace ScaryMovieForms
{
    partial class EnterPhoneNumber
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
            this.lblTextToContinue = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTextToContinue
            // 
            this.lblTextToContinue.AutoSize = true;
            this.lblTextToContinue.BackColor = System.Drawing.Color.White;
            this.lblTextToContinue.Location = new System.Drawing.Point(12, 181);
            this.lblTextToContinue.Name = "lblTextToContinue";
            this.lblTextToContinue.Size = new System.Drawing.Size(311, 20);
            this.lblTextToContinue.TabIndex = 0;
            this.lblTextToContinue.Text = "To continue, please enter your phone number:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(340, 178);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(190, 27);
            this.txtPhoneNumber.TabIndex = 1;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(445, 348);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 29);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Location = new System.Drawing.Point(12, 352);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(171, 29);
            this.btnBackToMenu.TabIndex = 3;
            this.btnBackToMenu.Text = "Go back to main menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // EnterPhoneNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ScaryMovieForms.Properties.Resources.blod;
            this.ClientSize = new System.Drawing.Size(561, 393);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblTextToContinue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnterPhoneNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnterPhoneNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextToContinue;
        public System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}