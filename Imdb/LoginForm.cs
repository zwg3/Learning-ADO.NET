using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Imdb
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string usr = userBox.Text;
            string pswd = pswdBox.Text;
            string conString = "Host=localhost;Port=5432;DataBase=imdb;Username=" + usr + ";Password=" + pswd;
            NpgsqlConnection con = new NpgsqlConnection(conString);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }

            Hide();

            Home f = new Home();
            f.conString = conString;
            f.ShowDialog();  
            
            Close();

        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            if (DialogResult == DialogResult.Cancel)
            {
                Close();
            }
        }
    }
}
