using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Imdb
{
    public partial class Directors : Form
    {
        public string conString { get; set; }
        public Directors()
        {
            InitializeComponent();
        }
        private DataTable dtDirectors = new DataTable();
        private DataTable dtDirectorsMovies = new DataTable();

        public NpgsqlConnection GetConn()
        {
            NpgsqlConnection con = new NpgsqlConnection(conString);
            return con;
        }

        private void dirBtnRefresh_Click(object sender, EventArgs e)
        {
            dtDirectors.Columns.Clear();
            dtDirectors.Rows.Clear();
            NpgsqlConnection con = GetConn();
            NpgsqlCommand select = new NpgsqlCommand("SELECT * FROM directors;", con);
            daDirectors.SelectCommand = select;
            try
            {
                daDirectors.Fill(dtDirectors);
                dgvDirectors.DataSource = dtDirectors;
                int nRowIndex = dgvDirectors.Rows.Count - 1;
                dgvDirectors.Rows[nRowIndex].Selected = true;
                dgvDirectors.FirstDisplayedScrollingRowIndex = nRowIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new NpgsqlCommandBuilder(daDirectors);
            try
            {
                daDirectors.Update(dtDirectors);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                       
        }

        private void dirBtnDirected_Click(object sender, EventArgs e)
        {
            dtDirectorsMovies.Columns.Clear();
            dtDirectorsMovies.Rows.Clear();
            NpgsqlConnection con = GetConn();
            NpgsqlCommand select = new NpgsqlCommand(@"SELECT directors.name, directors.surname, movies.title, movies.years 
                                                        FROM directors 
                                                        INNER JOIN moviedirectors ON directors.id = moviedirectors.directorid 
                                                        INNER JOIN movies ON movies.id = moviedirectors.movieid 
                                                        WHERE directors.surname= @SURNAME;", con);
            select.Parameters.Add("@SURNAME", NpgsqlTypes.NpgsqlDbType.Name);
            select.Parameters["@SURNAME"].Value = Convert.ToString(searchBox.Text);
            daDirectors.SelectCommand = select;
            try
            {
                daDirectors.Fill(dtDirectorsMovies);
                dgvDirectorsMovies.DataSource = dtDirectorsMovies;
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

        private void dirSearch_Click_1(object sender, EventArgs e)
        {
            dtDirectors.Columns.Clear();
            dtDirectors.Rows.Clear();
            NpgsqlConnection con = GetConn();
            NpgsqlCommand select = new NpgsqlCommand("SELECT * FROM directors WHERE surname =@SURNAME;", con);
            select.Parameters.Add("@SURNAME", NpgsqlTypes.NpgsqlDbType.Name);
            select.Parameters["@SURNAME"].Value = Convert.ToString(dirSeachBox.Text);
            daDirectors.SelectCommand = select;
            try
            {
                daDirectors.Fill(dtDirectors);
                dgvDirectors.DataSource = dtDirectors;
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
