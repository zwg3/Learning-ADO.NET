using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Imdb
{
    public partial class Actors : Form
    {
        public string conString { get; set; }
        
        public Actors()
        {                        
            InitializeComponent();
        }
        private DataTable dtActors = new DataTable();
        private DataTable dtActorsMovies = new DataTable();

        public NpgsqlConnection GetConn()
        {
            NpgsqlConnection con = new NpgsqlConnection(conString);
            return con;
        }
        

        private void actBtnUpdate_Click(object sender, EventArgs e)
        {
            new NpgsqlCommandBuilder(daActors);
            try
            {
                daActors.Update(dtActors);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void actBtnRefresh_Click(object sender, EventArgs e)
        {
            dtActors.Columns.Clear();
            dtActors.Rows.Clear();
            NpgsqlConnection con = GetConn();
            NpgsqlCommand select = new NpgsqlCommand("SELECT id, name, surname FROM actors;", con);
            daActors.SelectCommand = select;
            try
            {
                daActors.Fill(dtActors);
                dgvActors.DataSource = dtActors;
                int nRowIndex = dgvActors.Rows.Count - 1;
                dgvActors.Rows[nRowIndex].Selected = true;
                dgvActors.FirstDisplayedScrollingRowIndex = nRowIndex;
            }
            catch( Exception ex ) 
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

        private void actBtnStarred_Click(object sender, EventArgs e)
        {
            dtActorsMovies.Columns.Clear();
            dtActorsMovies.Rows.Clear();
            NpgsqlConnection con = GetConn();
            NpgsqlCommand select = new NpgsqlCommand(@"SELECT actors.name, actors.surname, movies.title, movieroles.role 
                                                        FROM actors
                                                        INNER JOIN movieroles ON movieroles.actorid = actors.id
                                                        INNER JOIN movies ON movieroles.movieid = movies.id
                                                        WHERE actors.surname = @SURNAME;", con);
            select.Parameters.Add("@SURNAME", NpgsqlTypes.NpgsqlDbType.Name);
            select.Parameters["@SURNAME"].Value = Convert.ToString(searchBox.Text);
            daActors.SelectCommand = select;
            try
            {
                daActors.Fill(dtActorsMovies);
                dgvActorsMovies.DataSource = dtActorsMovies;
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

        private void actBtnGetById_Click(object sender, EventArgs e)
        {
            dtActors.Columns.Clear();
            dtActors.Rows.Clear();
            NpgsqlConnection con = GetConn();
            NpgsqlCommand select = new NpgsqlCommand("SELECT * FROM actors WHERE surname =@SURNAME;", con);
            select.Parameters.Add("@SURNAME", NpgsqlTypes.NpgsqlDbType.Name);
            select.Parameters["@SURNAME"].Value = Convert.ToString(sortBox.Text);
            daActors.SelectCommand = select;
            try
            {
                daActors.Fill(dtActors);
                dgvActors.DataSource = dtActors;
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
