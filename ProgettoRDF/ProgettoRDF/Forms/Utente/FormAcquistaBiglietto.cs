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

namespace ProgettoRDF.Forms.Utente
{
    public partial class FormAcquistaBiglietto : Form
    {
        myDBconnection con = new myDBconnection();
        DataTable dt = new DataTable();
        public FormAcquistaBiglietto()
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

            lblNomeEvento.ForeColor = ThemeColor.SecondaryColor;
            lblGenere.ForeColor = ThemeColor.SecondaryColor;
            lblLuogo.ForeColor = ThemeColor.SecondaryColor;
            lblDescrizione.ForeColor = ThemeColor.SecondaryColor;
            lblPosti.ForeColor = ThemeColor.SecondaryColor;
            lblOrganizzazione.ForeColor = ThemeColor.SecondaryColor;
            lblScelta.ForeColor = ThemeColor.SecondaryColor;
            lblGenere2.ForeColor = ThemeColor.PrimaryColor;
            lblLuogo2.ForeColor = ThemeColor.PrimaryColor;
            lblDescrizione2.ForeColor = ThemeColor.PrimaryColor;
            lblPosti2.ForeColor = ThemeColor.PrimaryColor;
            lblOrganizzazione2.ForeColor = ThemeColor.PrimaryColor;
            btnAcquista.ForeColor = ThemeColor.PrimaryColor;
            btnAcquista.TextColor = ThemeColor.PrimaryColor;
        }

        private void FormAcquistaBiglietto_Load(object sender, EventArgs e)
        {
            LoadTheme();

            con.cn.Open();
            try
            {
                string query = "SELECT e.* " +
                               "FROM ceo_organizzazioni c, organizzazione o, eventi e " +
                               "WHERE c.CODOrganizzazione=o.ID AND o.ID=e.CODOrganizzazione " +
                               "";

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

            lblGenere2.Text = dt.Rows[0]["Genere"].ToString();
            lblLuogo2.Text = dt.Rows[0]["Luogo"].ToString();
            lblDescrizione2.Text = dt.Rows[0]["Descrizione"].ToString();
            lblPosti2.Text = dt.Rows[0]["NPosti"].ToString();
            lblOrganizzazione2.Text = dt.Rows[0]["Organizzazione"].ToString();
        }
    }
}
