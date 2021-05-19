
namespace ScaryMovieForms
{
    partial class MovieForm
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.rdoShow1 = new System.Windows.Forms.RadioButton();
            this.rdoShow2 = new System.Windows.Forms.RadioButton();
            this.rdoShow3 = new System.Windows.Forms.RadioButton();
            this.rdoShow4 = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cklListTickets = new System.Windows.Forms.CheckedListBox();
            this.tlpVisualizeSeats = new System.Windows.Forms.TableLayoutPanel();
            this.lblSeat20 = new System.Windows.Forms.Label();
            this.lblSeat19 = new System.Windows.Forms.Label();
            this.lblSeat18 = new System.Windows.Forms.Label();
            this.lblSeat17 = new System.Windows.Forms.Label();
            this.lblSeat16 = new System.Windows.Forms.Label();
            this.lblSeat15 = new System.Windows.Forms.Label();
            this.lblSeat14 = new System.Windows.Forms.Label();
            this.lblSeat13 = new System.Windows.Forms.Label();
            this.lblSeat12 = new System.Windows.Forms.Label();
            this.lblSeat11 = new System.Windows.Forms.Label();
            this.lblSeat10 = new System.Windows.Forms.Label();
            this.lblSeat9 = new System.Windows.Forms.Label();
            this.lblSeat8 = new System.Windows.Forms.Label();
            this.lblSeat7 = new System.Windows.Forms.Label();
            this.lblSeat6 = new System.Windows.Forms.Label();
            this.lblSeat5 = new System.Windows.Forms.Label();
            this.lblSeat4 = new System.Windows.Forms.Label();
            this.lblSeat3 = new System.Windows.Forms.Label();
            this.lblSeat2 = new System.Windows.Forms.Label();
            this.lblSeat1 = new System.Windows.Forms.Label();
            this.btnBooked = new System.Windows.Forms.Button();
            this.btnCheckSeatList = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.picMovieImage = new System.Windows.Forms.PictureBox();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblFree = new System.Windows.Forms.Label();
            this.lblBooked = new System.Windows.Forms.Label();
            this.lblAvailabletickets = new System.Windows.Forms.Label();
            this.lblSeatOrientation = new System.Windows.Forms.Label();
            this.lblScreen = new System.Windows.Forms.Label();
            this.tlpVisualizeSeats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMovieImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(12, 117);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(167, 238);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Descripton";
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.BackColor = System.Drawing.Color.White;
            this.lblMovieTitle.Location = new System.Drawing.Point(185, 117);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(160, 30);
            this.lblMovieTitle.TabIndex = 1;
            this.lblMovieTitle.Text = "Movie Title";
            // 
            // rdoShow1
            // 
            this.rdoShow1.AutoSize = true;
            this.rdoShow1.BackColor = System.Drawing.Color.White;
            this.rdoShow1.Location = new System.Drawing.Point(24, 358);
            this.rdoShow1.Name = "rdoShow1";
            this.rdoShow1.Size = new System.Drawing.Size(65, 24);
            this.rdoShow1.TabIndex = 2;
            this.rdoShow1.Text = "20.00\r\n";
            this.rdoShow1.UseVisualStyleBackColor = false;
            this.rdoShow1.CheckedChanged += new System.EventHandler(this.rdoShow1_CheckedChanged);
            // 
            // rdoShow2
            // 
            this.rdoShow2.AutoSize = true;
            this.rdoShow2.BackColor = System.Drawing.Color.White;
            this.rdoShow2.Location = new System.Drawing.Point(24, 404);
            this.rdoShow2.Name = "rdoShow2";
            this.rdoShow2.Size = new System.Drawing.Size(65, 24);
            this.rdoShow2.TabIndex = 3;
            this.rdoShow2.Text = "22.00";
            this.rdoShow2.UseVisualStyleBackColor = false;
            this.rdoShow2.CheckedChanged += new System.EventHandler(this.rdoShow2_CheckedChanged);
            // 
            // rdoShow3
            // 
            this.rdoShow3.AutoSize = true;
            this.rdoShow3.BackColor = System.Drawing.Color.White;
            this.rdoShow3.Location = new System.Drawing.Point(24, 447);
            this.rdoShow3.Name = "rdoShow3";
            this.rdoShow3.Size = new System.Drawing.Size(65, 24);
            this.rdoShow3.TabIndex = 4;
            this.rdoShow3.Text = "24.00";
            this.rdoShow3.UseVisualStyleBackColor = false;
            this.rdoShow3.CheckedChanged += new System.EventHandler(this.rdoShow3_CheckedChanged);
            // 
            // rdoShow4
            // 
            this.rdoShow4.AutoSize = true;
            this.rdoShow4.BackColor = System.Drawing.Color.White;
            this.rdoShow4.Location = new System.Drawing.Point(24, 488);
            this.rdoShow4.Name = "rdoShow4";
            this.rdoShow4.Size = new System.Drawing.Size(65, 24);
            this.rdoShow4.TabIndex = 5;
            this.rdoShow4.Text = "02.00";
            this.rdoShow4.UseVisualStyleBackColor = false;
            this.rdoShow4.CheckedChanged += new System.EventHandler(this.rdoShow4_CheckedChanged);
            // 
            // cklListTickets
            // 
            this.cklListTickets.CheckOnClick = true;
            this.cklListTickets.FormattingEnabled = true;
            this.cklListTickets.Location = new System.Drawing.Point(382, 104);
            this.cklListTickets.Name = "cklListTickets";
            this.cklListTickets.Size = new System.Drawing.Size(104, 334);
            this.cklListTickets.TabIndex = 6;
            this.cklListTickets.SelectedIndexChanged += new System.EventHandler(this.cklListTickets_SelectedIndexChanged);
            // 
            // tlpVisualizeSeats
            // 
            this.tlpVisualizeSeats.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tlpVisualizeSeats.ColumnCount = 5;
            this.tlpVisualizeSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpVisualizeSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpVisualizeSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpVisualizeSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpVisualizeSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpVisualizeSeats.Controls.Add(this.lblSeat20, 4, 3);
            this.tlpVisualizeSeats.Controls.Add(this.lblSeat19, 3, 3);
            this.tlpVisualizeSeats.Controls.Add(this.lblSeat18, 2, 3);
            this.tlpVisualizeSeats.Controls.Add(this.lblSeat17, 1, 3);
            this.tlpVisualizeSeats.Controls.Add(this.lblSeat16, 0, 3);
            this.tlpVisualizeSeats.Controls.Add(this.lblSeat15, 4, 2);
            this.tlpVisualizeSeats.Controls.Add(this.lblSeat14, 3, 2);
            this.tlpVisualizeSeats.Controls.Add(this.lblSeat13, 2, 2);
            this.tlpVisualizeSeats.Controls.Add(this.lblSeat12, 1, 2);
            this.tlpVisualizeSeats.Controls.Add(this.lblSeat11, 0, 2);
            this.tlpVisualizeSeats.Controls.Add(this.lblSeat10, 4, 1);
            this.tlpVisualizeSeats.Controls.Add(this.lblSeat9, 3, 1);
            this.tlpVisualizeSeats.Controls.Add(this.lblSeat8, 2, 1);
            this.tlpVisualizeSeats.Controls.Add(this.lblSeat7, 1, 1);
            this.tlpVisualizeSeats.Controls.Add(this.lblSeat6, 0, 1);
            this.tlpVisualizeSeats.Controls.Add(this.lblSeat5, 4, 0);
            this.tlpVisualizeSeats.Controls.Add(this.lblSeat4, 3, 0);
            this.tlpVisualizeSeats.Controls.Add(this.lblSeat3, 2, 0);
            this.tlpVisualizeSeats.Controls.Add(this.lblSeat2, 1, 0);
            this.tlpVisualizeSeats.Controls.Add(this.lblSeat1, 0, 0);
            this.tlpVisualizeSeats.Location = new System.Drawing.Point(513, 138);
            this.tlpVisualizeSeats.Name = "tlpVisualizeSeats";
            this.tlpVisualizeSeats.RowCount = 4;
            this.tlpVisualizeSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpVisualizeSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpVisualizeSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpVisualizeSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpVisualizeSeats.Size = new System.Drawing.Size(304, 254);
            this.tlpVisualizeSeats.TabIndex = 7;
            this.tlpVisualizeSeats.Visible = false;
            // 
            // lblSeat20
            // 
            this.lblSeat20.AutoSize = true;
            this.lblSeat20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeat20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeat20.Location = new System.Drawing.Point(246, 189);
            this.lblSeat20.Name = "lblSeat20";
            this.lblSeat20.Size = new System.Drawing.Size(52, 62);
            this.lblSeat20.TabIndex = 19;
            this.lblSeat20.Text = "20";
            this.lblSeat20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat19
            // 
            this.lblSeat19.AutoSize = true;
            this.lblSeat19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeat19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeat19.Location = new System.Drawing.Point(186, 189);
            this.lblSeat19.Name = "lblSeat19";
            this.lblSeat19.Size = new System.Drawing.Size(51, 62);
            this.lblSeat19.TabIndex = 18;
            this.lblSeat19.Text = "19";
            this.lblSeat19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat18
            // 
            this.lblSeat18.AutoSize = true;
            this.lblSeat18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeat18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeat18.Location = new System.Drawing.Point(126, 189);
            this.lblSeat18.Name = "lblSeat18";
            this.lblSeat18.Size = new System.Drawing.Size(51, 62);
            this.lblSeat18.TabIndex = 17;
            this.lblSeat18.Text = "18";
            this.lblSeat18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat17
            // 
            this.lblSeat17.AutoSize = true;
            this.lblSeat17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeat17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeat17.Location = new System.Drawing.Point(66, 189);
            this.lblSeat17.Name = "lblSeat17";
            this.lblSeat17.Size = new System.Drawing.Size(51, 62);
            this.lblSeat17.TabIndex = 16;
            this.lblSeat17.Text = "17";
            this.lblSeat17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat16
            // 
            this.lblSeat16.AutoSize = true;
            this.lblSeat16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeat16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeat16.Location = new System.Drawing.Point(6, 189);
            this.lblSeat16.Name = "lblSeat16";
            this.lblSeat16.Size = new System.Drawing.Size(51, 62);
            this.lblSeat16.TabIndex = 15;
            this.lblSeat16.Text = "16";
            this.lblSeat16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat15
            // 
            this.lblSeat15.AutoSize = true;
            this.lblSeat15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeat15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeat15.Location = new System.Drawing.Point(246, 127);
            this.lblSeat15.Name = "lblSeat15";
            this.lblSeat15.Size = new System.Drawing.Size(52, 59);
            this.lblSeat15.TabIndex = 14;
            this.lblSeat15.Text = "15";
            this.lblSeat15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat14
            // 
            this.lblSeat14.AutoSize = true;
            this.lblSeat14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeat14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeat14.Location = new System.Drawing.Point(186, 127);
            this.lblSeat14.Name = "lblSeat14";
            this.lblSeat14.Size = new System.Drawing.Size(51, 59);
            this.lblSeat14.TabIndex = 13;
            this.lblSeat14.Text = "14";
            this.lblSeat14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat13
            // 
            this.lblSeat13.AutoSize = true;
            this.lblSeat13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeat13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeat13.Location = new System.Drawing.Point(126, 127);
            this.lblSeat13.Name = "lblSeat13";
            this.lblSeat13.Size = new System.Drawing.Size(51, 59);
            this.lblSeat13.TabIndex = 12;
            this.lblSeat13.Text = "13";
            this.lblSeat13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat12
            // 
            this.lblSeat12.AutoSize = true;
            this.lblSeat12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeat12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeat12.Location = new System.Drawing.Point(66, 127);
            this.lblSeat12.Name = "lblSeat12";
            this.lblSeat12.Size = new System.Drawing.Size(51, 59);
            this.lblSeat12.TabIndex = 11;
            this.lblSeat12.Text = "12";
            this.lblSeat12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat11
            // 
            this.lblSeat11.AutoSize = true;
            this.lblSeat11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeat11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeat11.Location = new System.Drawing.Point(6, 127);
            this.lblSeat11.Name = "lblSeat11";
            this.lblSeat11.Size = new System.Drawing.Size(51, 59);
            this.lblSeat11.TabIndex = 10;
            this.lblSeat11.Text = "11";
            this.lblSeat11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat10
            // 
            this.lblSeat10.AutoSize = true;
            this.lblSeat10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeat10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeat10.Location = new System.Drawing.Point(246, 65);
            this.lblSeat10.Name = "lblSeat10";
            this.lblSeat10.Size = new System.Drawing.Size(52, 59);
            this.lblSeat10.TabIndex = 9;
            this.lblSeat10.Text = "10";
            this.lblSeat10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat9
            // 
            this.lblSeat9.AutoSize = true;
            this.lblSeat9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeat9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeat9.Location = new System.Drawing.Point(186, 65);
            this.lblSeat9.Name = "lblSeat9";
            this.lblSeat9.Size = new System.Drawing.Size(51, 59);
            this.lblSeat9.TabIndex = 8;
            this.lblSeat9.Text = "9";
            this.lblSeat9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat8
            // 
            this.lblSeat8.AutoSize = true;
            this.lblSeat8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeat8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeat8.Location = new System.Drawing.Point(126, 65);
            this.lblSeat8.Name = "lblSeat8";
            this.lblSeat8.Size = new System.Drawing.Size(51, 59);
            this.lblSeat8.TabIndex = 7;
            this.lblSeat8.Text = "8";
            this.lblSeat8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat7
            // 
            this.lblSeat7.AutoSize = true;
            this.lblSeat7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeat7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeat7.Location = new System.Drawing.Point(66, 65);
            this.lblSeat7.Name = "lblSeat7";
            this.lblSeat7.Size = new System.Drawing.Size(51, 59);
            this.lblSeat7.TabIndex = 6;
            this.lblSeat7.Text = "7";
            this.lblSeat7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat6
            // 
            this.lblSeat6.AutoSize = true;
            this.lblSeat6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeat6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeat6.Location = new System.Drawing.Point(6, 65);
            this.lblSeat6.Name = "lblSeat6";
            this.lblSeat6.Size = new System.Drawing.Size(51, 59);
            this.lblSeat6.TabIndex = 5;
            this.lblSeat6.Text = "6";
            this.lblSeat6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat5
            // 
            this.lblSeat5.AutoSize = true;
            this.lblSeat5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeat5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeat5.Location = new System.Drawing.Point(246, 3);
            this.lblSeat5.Name = "lblSeat5";
            this.lblSeat5.Size = new System.Drawing.Size(52, 59);
            this.lblSeat5.TabIndex = 4;
            this.lblSeat5.Text = "5";
            this.lblSeat5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat4
            // 
            this.lblSeat4.AutoSize = true;
            this.lblSeat4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeat4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeat4.Location = new System.Drawing.Point(186, 3);
            this.lblSeat4.Name = "lblSeat4";
            this.lblSeat4.Size = new System.Drawing.Size(51, 59);
            this.lblSeat4.TabIndex = 3;
            this.lblSeat4.Text = "4";
            this.lblSeat4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat3
            // 
            this.lblSeat3.AutoSize = true;
            this.lblSeat3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeat3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeat3.Location = new System.Drawing.Point(126, 3);
            this.lblSeat3.Name = "lblSeat3";
            this.lblSeat3.Size = new System.Drawing.Size(51, 59);
            this.lblSeat3.TabIndex = 2;
            this.lblSeat3.Text = "3";
            this.lblSeat3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat2
            // 
            this.lblSeat2.AutoSize = true;
            this.lblSeat2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeat2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeat2.Location = new System.Drawing.Point(66, 3);
            this.lblSeat2.Name = "lblSeat2";
            this.lblSeat2.Size = new System.Drawing.Size(51, 59);
            this.lblSeat2.TabIndex = 1;
            this.lblSeat2.Text = "2";
            this.lblSeat2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat1
            // 
            this.lblSeat1.AutoSize = true;
            this.lblSeat1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeat1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeat1.Location = new System.Drawing.Point(6, 3);
            this.lblSeat1.Name = "lblSeat1";
            this.lblSeat1.Size = new System.Drawing.Size(51, 59);
            this.lblSeat1.TabIndex = 0;
            this.lblSeat1.Text = "1";
            this.lblSeat1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBooked
            // 
            this.btnBooked.Location = new System.Drawing.Point(703, 483);
            this.btnBooked.Name = "btnBooked";
            this.btnBooked.Size = new System.Drawing.Size(94, 29);
            this.btnBooked.TabIndex = 8;
            this.btnBooked.Text = "Book";
            this.btnBooked.UseVisualStyleBackColor = true;
            this.btnBooked.Visible = false;
            this.btnBooked.Click += new System.EventHandler(this.btnBooked_Click);
            // 
            // btnCheckSeatList
            // 
            this.btnCheckSeatList.Location = new System.Drawing.Point(493, 482);
            this.btnCheckSeatList.Name = "btnCheckSeatList";
            this.btnCheckSeatList.Size = new System.Drawing.Size(158, 29);
            this.btnCheckSeatList.TabIndex = 9;
            this.btnCheckSeatList.Text = "Save seat choice";
            this.btnCheckSeatList.UseVisualStyleBackColor = true;
            this.btnCheckSeatList.Click += new System.EventHandler(this.btnCheckSeatList_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(320, 482);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 29);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Go back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picMovieImage
            // 
            this.picMovieImage.BackColor = System.Drawing.Color.White;
            this.picMovieImage.Location = new System.Drawing.Point(185, 150);
            this.picMovieImage.Name = "picMovieImage";
            this.picMovieImage.Size = new System.Drawing.Size(160, 205);
            this.picMovieImage.TabIndex = 11;
            this.picMovieImage.TabStop = false;
            // 
            // lblGreen
            // 
            this.lblGreen.BackColor = System.Drawing.Color.LightGreen;
            this.lblGreen.Location = new System.Drawing.Point(570, 395);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(40, 33);
            this.lblGreen.TabIndex = 12;
            this.lblGreen.Visible = false;
            // 
            // lblRed
            // 
            this.lblRed.BackColor = System.Drawing.Color.LightCoral;
            this.lblRed.Location = new System.Drawing.Point(570, 438);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(40, 33);
            this.lblRed.TabIndex = 13;
            this.lblRed.Visible = false;
            // 
            // lblFree
            // 
            this.lblFree.AutoSize = true;
            this.lblFree.BackColor = System.Drawing.Color.White;
            this.lblFree.Location = new System.Drawing.Point(630, 404);
            this.lblFree.Name = "lblFree";
            this.lblFree.Size = new System.Drawing.Size(108, 20);
            this.lblFree.TabIndex = 14;
            this.lblFree.Text = "Available seats";
            this.lblFree.Visible = false;
            // 
            // lblBooked
            // 
            this.lblBooked.AutoSize = true;
            this.lblBooked.BackColor = System.Drawing.Color.White;
            this.lblBooked.Location = new System.Drawing.Point(630, 447);
            this.lblBooked.Name = "lblBooked";
            this.lblBooked.Size = new System.Drawing.Size(60, 20);
            this.lblBooked.TabIndex = 15;
            this.lblBooked.Text = "Booked";
            this.lblBooked.Visible = false;
            // 
            // lblAvailabletickets
            // 
            this.lblAvailabletickets.AutoSize = true;
            this.lblAvailabletickets.BackColor = System.Drawing.Color.White;
            this.lblAvailabletickets.Location = new System.Drawing.Point(382, 81);
            this.lblAvailabletickets.Name = "lblAvailabletickets";
            this.lblAvailabletickets.Size = new System.Drawing.Size(104, 20);
            this.lblAvailabletickets.TabIndex = 16;
            this.lblAvailabletickets.Text = "Choose tickets";
            // 
            // lblSeatOrientation
            // 
            this.lblSeatOrientation.AutoSize = true;
            this.lblSeatOrientation.BackColor = System.Drawing.Color.White;
            this.lblSeatOrientation.Location = new System.Drawing.Point(513, 106);
            this.lblSeatOrientation.Name = "lblSeatOrientation";
            this.lblSeatOrientation.Size = new System.Drawing.Size(44, 20);
            this.lblSeatOrientation.TabIndex = 17;
            this.lblSeatOrientation.Text = "Seats";
            // 
            // lblScreen
            // 
            this.lblScreen.AutoSize = true;
            this.lblScreen.BackColor = System.Drawing.Color.White;
            this.lblScreen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScreen.Location = new System.Drawing.Point(630, 98);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(70, 28);
            this.lblScreen.TabIndex = 18;
            this.lblScreen.Text = "Screen";
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ScaryMovieForms.Properties.Resources.blod;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 531);
            this.Controls.Add(this.lblScreen);
            this.Controls.Add(this.lblSeatOrientation);
            this.Controls.Add(this.lblAvailabletickets);
            this.Controls.Add(this.lblBooked);
            this.Controls.Add(this.lblFree);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.picMovieImage);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCheckSeatList);
            this.Controls.Add(this.btnBooked);
            this.Controls.Add(this.tlpVisualizeSeats);
            this.Controls.Add(this.cklListTickets);
            this.Controls.Add(this.rdoShow4);
            this.Controls.Add(this.rdoShow3);
            this.Controls.Add(this.rdoShow2);
            this.Controls.Add(this.rdoShow1);
            this.Controls.Add(this.lblMovieTitle);
            this.Controls.Add(this.lblDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieForm";
            this.tlpVisualizeSeats.ResumeLayout(false);
            this.tlpVisualizeSeats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMovieImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblDescription;
        public System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.RadioButton rdoShow1;
        private System.Windows.Forms.RadioButton rdoShow2;
        private System.Windows.Forms.RadioButton rdoShow3;
        private System.Windows.Forms.RadioButton rdoShow4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.CheckedListBox cklListTickets;
        private System.Windows.Forms.TableLayoutPanel tlpVisualizeSeats;
        private System.Windows.Forms.Label lblSeat20;
        private System.Windows.Forms.Label lblSeat19;
        private System.Windows.Forms.Label lblSeat18;
        private System.Windows.Forms.Label lblSeat17;
        private System.Windows.Forms.Label lblSeat16;
        private System.Windows.Forms.Label lblSeat15;
        private System.Windows.Forms.Label lblSeat14;
        private System.Windows.Forms.Label lblSeat13;
        private System.Windows.Forms.Label lblSeat12;
        private System.Windows.Forms.Label lblSeat11;
        private System.Windows.Forms.Label lblSeat10;
        private System.Windows.Forms.Label lblSeat9;
        private System.Windows.Forms.Label lblSeat8;
        private System.Windows.Forms.Label lblSeat7;
        private System.Windows.Forms.Label lblSeat6;
        private System.Windows.Forms.Label lblSeat5;
        private System.Windows.Forms.Label lblSeat4;
        private System.Windows.Forms.Label lblSeat3;
        private System.Windows.Forms.Label lblSeat2;
        private System.Windows.Forms.Label lblSeat1;
        private System.Windows.Forms.Button btnBooked;
        private System.Windows.Forms.Button btnCheckSeatList;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picMovieImage;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblFree;
        private System.Windows.Forms.Label lblBooked;
        private System.Windows.Forms.Label lblAvailabletickets;
        private System.Windows.Forms.Label lblSeatOrientation;
        private System.Windows.Forms.Label lblScreen;
    }
}