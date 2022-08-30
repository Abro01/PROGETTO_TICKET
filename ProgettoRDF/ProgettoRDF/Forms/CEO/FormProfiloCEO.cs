using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoRDF.Forms.CEO
{
    public partial class FormProfiloCEO : Form
    {
        myDBconnection con = new myDBconnection();
        DataTable dt = new DataTable();
        public FormProfiloCEO()
        {
            InitializeComponent();
            con.Connect();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

            lblTitoloAccount.ForeColor = ThemeColor.SecondaryColor;
            lblNome.ForeColor = ThemeColor.SecondaryColor;
            lblCognome.ForeColor = ThemeColor.SecondaryColor;
            lblEmail.ForeColor = ThemeColor.SecondaryColor;
            lblNome2.ForeColor = ThemeColor.PrimaryColor;
            lblCognome2.ForeColor = ThemeColor.PrimaryColor;
            lblEmail2.ForeColor = ThemeColor.PrimaryColor;
        }

        private void FormProfiloCEO_Load(object sender, EventArgs e)
        {
            LoadTheme();

            con.cn.Open();
            try
            {
                string query = "SELECT * FROM ceo_organizzazioni WHERE ID = '" + LoginInfo.UserID + "'";

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

            lblEmail2.Text = dt.Rows[0]["Email"].ToString();
            lblNome2.Text = dt.Rows[0]["Nome"].ToString();
            lblCognome2.Text = dt.Rows[0]["Cognome"].ToString();
        }
    }
}
