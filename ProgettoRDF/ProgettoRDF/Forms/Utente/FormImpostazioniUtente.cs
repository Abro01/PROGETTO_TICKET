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
    public partial class FormImpostazioniUtente : Form
    {
        myDBconnection con = new myDBconnection();
        DataTable dt = new DataTable();
        public FormImpostazioniUtente()
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

            lblTitoloImpo.ForeColor = ThemeColor.SecondaryColor;
            lblNome.ForeColor = ThemeColor.SecondaryColor;
            lblCognome.ForeColor = ThemeColor.SecondaryColor;
            lblUsername.ForeColor = ThemeColor.SecondaryColor;
            lblEmail.ForeColor = ThemeColor.SecondaryColor;
            txtNome.ForeColor = ThemeColor.PrimaryColor;
            txtCognome.ForeColor = ThemeColor.PrimaryColor;
            txtUsername.ForeColor = ThemeColor.PrimaryColor;
            txtEmail.ForeColor = ThemeColor.PrimaryColor;
            btnModifica.Colore_bordo = ThemeColor.SecondaryColor;
            btnModifica.TextColor = ThemeColor.SecondaryColor;
        }

        private void FormImpostazioniUtente_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();

                string query = "UPDATE utenti " + 
                               "SET Nome = '" + txtNome.Text + "', Cognome = '" + txtCognome.Text + "', Username = '" + txtUsername.Text + "', Email = '" + txtEmail.Text + "' " +
                               "WHERE ID = '" + LoginInfo.UserID + "'";

                MySqlDataAdapter sda = new MySqlDataAdapter(query, con.cn);
                sda.Fill(dt);

                MessageBox.Show("I tuoi dati sono stati modificati correttamente.");

                txtNome.Clear();
                txtCognome.Clear();
                txtEmail.Clear();
                txtUsername.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.cn.Close();
            }

            con.cn.Close();
        }
    }
}
