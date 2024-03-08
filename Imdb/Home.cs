using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imdb
{
    public partial class Home : Form
    {
        public string conString { get; set; }
        public Home()
        {
            InitializeComponent();
        }

        private void btnActors_Click(object sender, EventArgs e)
        {
            Actors actors = new Actors();
            actors.conString = conString;
            actors.ShowDialog();
        }

        private void btnDirectors_Click(object sender, EventArgs e)
        {
            Directors directors = new Directors();
            directors.conString = conString;
            directors.ShowDialog();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            Movies movies = new Movies();
            movies.conString = conString;
            movies.ShowDialog();
        }
    }
}
