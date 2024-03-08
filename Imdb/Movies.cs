using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Imdb
{
    public partial class Movies : Form
    {
        public string conString { get; set; }
        public Movies()
        {
            InitializeComponent();
        }
        private DataTable dtMovies = new DataTable();
        private DataTable dtMoviesDirectors = new DataTable();
        private DataTable dtMoviesActors = new DataTable();
        private DataTable dtPlot = new DataTable();


        public NpgsqlConnection GetConn()
        {
            NpgsqlConnection con = new NpgsqlConnection(conString);
            return con;
        }

        private void movBtnUpdate_Click(object sender, EventArgs e)
        {
            new NpgsqlCommandBuilder(daMovies);
            try
            {
                daMovies.Update(dtMovies);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void movBtnRefresh_Click(object sender, EventArgs e)
        {
            dtMovies.Columns.Clear();
            dtMovies.Rows.Clear();
            NpgsqlConnection con = GetConn();
            NpgsqlCommand select = new NpgsqlCommand(@"SELECT movies.id, movies.title, movies.years 
                                                        FROM directors
                                                        INNER JOIN moviedirectors ON directors.id = moviedirectors.directorid 
                                                        INNER JOIN movies ON movies.id = moviedirectors.movieid;", con);
            daMovies.SelectCommand = select;
            try
            {
                daMovies.Fill(dtMovies);
                dgvMovies.DataSource = dtMovies;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }

        private void movSearchByName_Click(object sender, EventArgs e)
        {
            dtMovies.Columns.Clear();
            dtMovies.Rows.Clear();
            NpgsqlConnection con = GetConn();
            NpgsqlCommand select = new NpgsqlCommand(@"SELECT movies.id, movies.title, movies.years 
                                                        FROM directors
                                                        INNER JOIN moviedirectors ON directors.id = moviedirectors.directorid
                                                        INNER JOIN movies ON movies.id = moviedirectors.movieid
                                                        WHERE title = @TITLE;", con);
            select.Parameters.Add("@TITLE", NpgsqlTypes.NpgsqlDbType.Name);
            select.Parameters["@TITLE"].Value = Convert.ToString(movSearchBox.Text);
            daMovies.SelectCommand = select;
            try
            {
                daMovies.Fill(dtMovies);
                dgvMovies.DataSource = dtMovies;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }

        private void movSearchDir_Click(object sender, EventArgs e)
        {
            dtMoviesDirectors.Columns.Clear();
            dtMoviesDirectors.Rows.Clear();
            NpgsqlConnection con = GetConn();
            NpgsqlCommand select = new NpgsqlCommand(@"SELECT directors.name, directors.surname
                                                        FROM directors
                                                        INNER JOIN moviedirectors ON directors.id = moviedirectors.directorid 
                                                        INNER JOIN movies ON movies.id = moviedirectors.movieid
                                                        WHERE movies.title = @TITLE;", con);
            select.Parameters.Add("@TITLE", NpgsqlTypes.NpgsqlDbType.Text);
            select.Parameters["@TITLE"].Value = Convert.ToString(movSearchDIrect.Text);
            daMovies.SelectCommand = select;
            try
            {
                daMovies.Fill(dtMoviesDirectors);
                dgvMoviesDirector.DataSource = dtMoviesDirectors;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }

        private void movSearchAct_Click(object sender, EventArgs e)
        {
            dtMoviesActors.Columns.Clear();
            dtMoviesActors.Rows.Clear();
            NpgsqlConnection con = GetConn();
            NpgsqlCommand select = new NpgsqlCommand(@"SELECT actors.name, actors.surname, role, movies.title
                                                        FROM actors
                                                        INNER JOIN movieroles ON movieroles.actorid = actors.id
                                                        INNER JOIN movies ON movieroles.movieid = movies.id
                                                        WHERE movies.title = @TITLE;", con);
            select.Parameters.Add("@TITLE", NpgsqlTypes.NpgsqlDbType.Text);
            select.Parameters["@TITLE"].Value = Convert.ToString(movSearchActBox.Text);
            daMovies.SelectCommand = select;
            try
            {
                daMovies.Fill(dtMoviesActors);
                dgvMoviesActors.DataSource = dtMoviesActors;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }

        private void movBtnPlot_Click(object sender, EventArgs e)
        {
            dtPlot.Columns.Clear();
            dtPlot.Rows.Clear();
            NpgsqlConnection con = GetConn();
            NpgsqlCommand select = new NpgsqlCommand(@"SELECT title, plot
                                                        FROM movieplots
                                                        INNER JOIN movies ON movies.id = movieplots.movieid
                                                        INNER JOIN moviedirectors ON moviedirectors.movieid  = movies.id
                                                        WHERE movies.title = @TITLE;", con);
            select.Parameters.Add("@TITLE", NpgsqlTypes.NpgsqlDbType.Text);
            select.Parameters["@TITLE"].Value = Convert.ToString(plotBox.Text);
            daMovies.SelectCommand = select;
            try
            {
                daMovies.Fill(dtPlot);
                string res = string.Join(Environment.NewLine, dtPlot.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));
                if (res == "")
                {
                    richPlotBox.Text = "No plot synopsis available.";
                }
                else
                {
                    richPlotBox.Text = res;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }
    }
}
