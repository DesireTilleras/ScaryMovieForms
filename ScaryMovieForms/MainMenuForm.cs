using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd;
using Functions;
using Microsoft.EntityFrameworkCore;

namespace ScaryMovieForms
{
    public partial class MainMenuForm : Form
    {
        public static int MovieChoice = 0;
        public MainMenuForm()
        {
            using (var movieContext = new MovieAppContext())
            {
                movieContext.Database.Migrate();
            }

            InitializeComponent();
        }

        private void rdoRamp_CheckedChanged(object sender, EventArgs e)
        {
            btnMovie1.Visible = false;
            btnMovie2.Visible = false;
            btnMovie3.Visible = false;
            btnMovie4.Visible = false;
            btnMovie5.Visible = false;
            btnMovie6.Visible = false;
            btnMovie7.Visible = false;
            btnMovie8.Visible = false;
            lblMovieName1.Visible = false;
            lblMovieName2.Visible = false;
            lblMovieName3.Visible = false;
            lblMovieName4.Visible = false;
            lblMovieName5.Visible = false;
            lblMovieName6.Visible = false;
            lblMovieName7.Visible = false;
            lblMovieName8.Visible = false;

        }

        private void btnClearInfo_Click(object sender, EventArgs e)
        {
            rdoRamp.Checked = false;
            btnMovie1.Visible = true;
            btnMovie2.Visible = true;
            btnMovie3.Visible = true;
            btnMovie4.Visible = true;
            btnMovie5.Visible = true;
            btnMovie6.Visible = true;
            btnMovie7.Visible = true;
            btnMovie8.Visible = true;
            lblMovieName1.Visible = true;
            lblMovieName2.Visible = true;
            lblMovieName3.Visible = true;
            lblMovieName4.Visible = true;
            lblMovieName5.Visible = true;
            lblMovieName6.Visible = true;
            lblMovieName7.Visible = true;
            lblMovieName8.Visible = true;
        }

        private void btnMovie4_Click(object sender, EventArgs e)
        {
            MovieChoice = 4;
            var description = HelperClass.functions.GetMovieDescr(MovieChoice);
            var title = HelperClass.functions.GetMovieTitle(MovieChoice);
            var movieForm = new MovieForm();
            movieForm.lblDescription.Text = description;
            movieForm.lblMovieTitle.Text = title;
            this.Hide();
            movieForm.Show();
         }

        public void btnMovie1_Click(object sender, EventArgs e)
        {
            MovieChoice = 1;
            var description = HelperClass.functions.GetMovieDescr(MovieChoice);
            var title = HelperClass.functions.GetMovieTitle(MovieChoice);
            var movieForm = new MovieForm();
            movieForm.lblDescription.Text = description;
            movieForm.lblMovieTitle.Text = title;
            this.Hide();
            movieForm.Show();
            
        }

        private void btnMovie2_Click(object sender, EventArgs e)
        {
            MovieChoice = 2;
            var description = HelperClass.functions.GetMovieDescr(MovieChoice);
            var title = HelperClass.functions.GetMovieTitle(MovieChoice);
            var movieForm = new MovieForm();
            movieForm.lblDescription.Text = description;
            movieForm.lblMovieTitle.Text = title;
            this.Hide();
            movieForm.Show();
            
        }

        private void btnMovie3_Click(object sender, EventArgs e)
        {
            MovieChoice = 3;
            var description = HelperClass.functions.GetMovieDescr(MovieChoice);
            var title = HelperClass.functions.GetMovieTitle(MovieChoice);
            var movieForm = new MovieForm();
            movieForm.lblDescription.Text = description;
            movieForm.lblMovieTitle.Text = title;
            this.Hide();
            movieForm.Show();
            
        }

        private void btnMovie5_Click(object sender, EventArgs e)
        {
            MovieChoice = 5;
            var description = HelperClass.functions.GetMovieDescr(MovieChoice);
            var title = HelperClass.functions.GetMovieTitle(MovieChoice);
            var movieForm = new MovieForm();
            movieForm.lblDescription.Text = description;
            movieForm.lblMovieTitle.Text = title;
            this.Hide();
            movieForm.Show();
            
        }

        private void btnMovie6_Click(object sender, EventArgs e)
        {
            MovieChoice = 6;
            var description = HelperClass.functions.GetMovieDescr(MovieChoice);
            var title = HelperClass.functions.GetMovieTitle(MovieChoice);
            var movieForm = new MovieForm();
            movieForm.lblDescription.Text = description;
            movieForm.lblMovieTitle.Text = title;
            this.Hide();
            movieForm.Show();
            
        }

        private void btnMovie7_Click(object sender, EventArgs e)
        {
            MovieChoice = 7;
            var description = HelperClass.functions.GetMovieDescr(MovieChoice);
            var title = HelperClass.functions.GetMovieTitle(MovieChoice);
            var movieForm = new MovieForm();
            movieForm.lblDescription.Text = description;
            movieForm.lblMovieTitle.Text = title;
            this.Hide();
            movieForm.Show();
            
        }

        private void btnMovie8_Click(object sender, EventArgs e)
        {
            MovieChoice = 8;
            var description = HelperClass.functions.GetMovieDescr(MovieChoice);
            var title = HelperClass.functions.GetMovieTitle(MovieChoice);
            var movieForm = new MovieForm();
            movieForm.lblDescription.Text = description;
            movieForm.lblMovieTitle.Text = title;
            this.Hide();
            movieForm.Show();
            
        }

        private void btnMovie9_Click(object sender, EventArgs e)
        {
            MovieChoice = 9;
            var description = HelperClass.functions.GetMovieDescr(MovieChoice);
            var title = HelperClass.functions.GetMovieTitle(MovieChoice);
            var movieForm = new MovieForm();
            movieForm.lblDescription.Text = description;
            movieForm.lblMovieTitle.Text = title;
            this.Hide();
            movieForm.Show();
            
        }

        private void btnMovie10_Click(object sender, EventArgs e)
        {
            MovieChoice = 10;
            var description = HelperClass.functions.GetMovieDescr(MovieChoice);
            var title = HelperClass.functions.GetMovieTitle(MovieChoice);
            var movieForm = new MovieForm();
            movieForm.lblDescription.Text = description;
            movieForm.lblMovieTitle.Text = title;

            this.Hide();
            movieForm.Show();
           
        }

        private void btnCloseProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowMyBookings_Click(object sender, EventArgs e)
        {
            var telePhoneForm = new ShowBookingsEnterNumberForm();
            this.Hide();

            telePhoneForm.Show();


        }
    }
}
