using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProgettoRDF
{
    public partial class Profilo : Form
    {
        myDBconnection con = new myDBconnection();
        DataTable dt = new DataTable();

        public Profilo()
        {
            InitializeComponent();
            con.Connect();
        }

        private void Profilo_Load(object sender, EventArgs e)
        {
            con.cn.Open();
            try
            {
                string query = "SELECT * FROM utenti WHERE email = '" + LoginInfo.UserID + "'";
               
                MySqlDataAdapter sda = new MySqlDataAdapter(query, con.cn);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.cn.Close();
            }

            lUsername.Text = dt.Rows[0]["Username"].ToString();
            lEmail.Text = dt.Rows[0]["Email"].ToString();
            lNome.Text = dt.Rows[0]["Nome"].ToString();
            lCognome.Text = dt.Rows[0]["Cognome"].ToString();
        }

        private void btnProfilo_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login logout = new Login();
            logout.Show();
            this.Hide();
            con.cn.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MenuForm home = new MenuForm();
            home.ShowDialog();
            this.Hide();
            con.cn.Close();
        }
    }
}
