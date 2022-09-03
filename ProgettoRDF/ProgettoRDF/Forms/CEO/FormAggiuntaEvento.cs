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
    public partial class FormAggiuntaEvento : Form
    {
        myDBconnection con = new myDBconnection();
        MySqlCommand command;
        MySqlDataAdapter da, db, ds;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();

        public FormAggiuntaEvento()
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

            lblTitolo.ForeColor = ThemeColor.SecondaryColor;
            lblNome.ForeColor = ThemeColor.SecondaryColor;
            lblGenere.ForeColor = ThemeColor.SecondaryColor;
            lblLuogo.ForeColor = ThemeColor.SecondaryColor;
            lblDescrizione.ForeColor = ThemeColor.SecondaryColor;
            lblPosti.ForeColor = ThemeColor.SecondaryColor;
            lblCosto.ForeColor = ThemeColor.SecondaryColor;
            txtNome.ForeColor = ThemeColor.PrimaryColor;
            txtGenere.ForeColor = ThemeColor.PrimaryColor;
            txtLuogo.ForeColor = ThemeColor.PrimaryColor;
            txtDescrizione.ForeColor = ThemeColor.PrimaryColor;
            txtPosti.ForeColor = ThemeColor.PrimaryColor;
            txtCosto.ForeColor = ThemeColor.PrimaryColor;
            btnAggiungi.ForeColor = ThemeColor.PrimaryColor;
            btnAggiungi.Colore_bordo = ThemeColor.PrimaryColor;
            btnAggiungi.TextColor = ThemeColor.PrimaryColor;
        }

        private void FormAggiuntaEvento_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();

                DataTable DataTableID = new DataTable();
                string queryID =  "SELECT c.CODOrganizzazione " +             //PRENDO IL CODICE DELL'ORGANIZZAZIONE POSSEDUTA DAL CEO
                                  "FROM ceo_organizzazioni c " +               //CHE HA EFFETTUATO IL LOGIN PRIMA TRAMITE L'ID SALVATO
                                  "WHERE c.ID = '" + LoginInfo.UserID + "'";  //IN LOGININFO
                da = new MySqlDataAdapter(queryID, con.cn);
                da.Fill(DataTableID);
                string idS = DataTableID.Rows[0]["CODOrganizzazione"].ToString();
                int ID  = Int32.Parse(idS);
                
                MessageBox.Show(ID.ToString());
                string queryEvento = $"INSERT INTO eventi (`ID`, `Nome`, `Genere`, `Luogo`, `Descrizione`, `Nposti`, `CODOrganizzazione`) VALUES ('', '" + txtNome.Text + "', '" + txtGenere.Text + "', '" + txtLuogo.Text + "', '" + txtDescrizione.Text + "', '" + txtPosti.Text + "', '" + ID + "')";

                db = new MySqlDataAdapter(queryEvento, con.cn);
                db.Fill(dt);

                string qId = "SELECT ID " +
                             "FROM EVENTI WHERE Nome = '" + txtNome.Text + "'"; //QUERY CHE  PERMETTE DI TROVARE L'ID DELL'EVENTO APPENA INSERITO 

                MySqlDataAdapter da1 = new MySqlDataAdapter(qId, con.cn);                 
                da1.Fill(dt3);

                LoginInfo.IdEvento = Int32.Parse(dt3.Rows[0]["ID"].ToString());
                                            //CREAZIONE DEL BIGLIETTO COLLEGATO ALL'EVENTO APPENA CREATO
                string queryBiglietto = $"INSERT INTO biglietti (`ID`, `Costo`, `CODEvento`) VALUES ('', '" + txtCosto.Text + "', '" + LoginInfo.IdEvento + "')";
                                                
                ds = new MySqlDataAdapter(queryBiglietto, con.cn);
                ds.Fill(dt2);

                txtNome.Clear();
                txtGenere.Clear();
                txtLuogo.Clear();
                txtDescrizione.Clear();
                txtPosti.Clear();

                MessageBox.Show("Evento Aggiunto con successo");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.cn.Close();
            }
        }
    }
}
