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
        int prezzo;
        int costo;
        int idBiglietto;


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
            btnAcquista.Colore_bordo = ThemeColor.PrimaryColor;
            cbPremium.ForeColor = ThemeColor.PrimaryColor;
            cbNumBig.ForeColor = ThemeColor.PrimaryColor;
            lblCosto.ForeColor = ThemeColor.SecondaryColor;
            lPrezzo.ForeColor = ThemeColor.PrimaryColor;
        }

        private void FormAcquistaBiglietto_Load(object sender, EventArgs e)
        {
            LoadTheme();

            con.cn.Open();
            try
            {
                string query = "SELECT e.* " +
                               "FROM ceo_organizzazioni c, organizzazione o, eventi e " +
                               "WHERE c.CODOrganizzazione=o.ID AND o.ID=e.CODOrganizzazione  " +        //QUERY PER TROVARE LE INFORMAZIONI DELL'EVENTO SELEZIONATO
                               "AND e.ID= '" + LoginInfo.IdEvento +"'";

                MySqlDataAdapter sda = new MySqlDataAdapter(query, con.cn);
                sda.Fill(dt);


                DataTable dbPrezzo = new DataTable();
                string query2 = "SELECT b.* " +
                                "FROM biglietti b, eventi e " +
                                "WHERE b.CODEvento = e.ID " +                   //QUERY PER TROVARE IL PREZZO DI OGNI BIGLIETTO DELL'EVENTO
                                "AND e.ID= '" + LoginInfo.IdEvento + "'";

                MySqlDataAdapter da = new MySqlDataAdapter(query2, con.cn);
                da.Fill(dbPrezzo);

                string costo = dbPrezzo.Rows[0]["Costo"].ToString();        //SALVO IL COSTO DI OGNI BIGLIETTO 
                prezzo = Int32.Parse(costo);

                string biglietto = dbPrezzo.Rows[0]["ID"].ToString();       //SALVO ANCHE L'ID
                idBiglietto = Int32.Parse(biglietto);
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.cn.Close();
            }

            lblNomeEvento.Text = dt.Rows[0]["Nome"].ToString();
            lblGenere2.Text = dt.Rows[0]["Genere"].ToString();
            lblLuogo2.Text = dt.Rows[0]["Luogo"].ToString();
            lblDescrizione2.Text = dt.Rows[0]["Descrizione"].ToString();    
            lblPosti2.Text = dt.Rows[0]["NPosti"].ToString();
            lblOrganizzazione2.Text = dt.Rows[0]["Nome"].ToString();
            cbNumBig.SelectedIndex = 0;

        }

        private void cbNumBig_SelectedIndexChanged(object sender, EventArgs e)
        {
            string app = cbNumBig.Text;
            int numBig = Int32.Parse(app);          //AGGIORNO IL PREZZO IN BASE AL NUMERO DI BIGLIETTI CHE SI VOGLIONO ACQUISTARE
            costo = prezzo * numBig;
            lPrezzo.Text = costo.ToString();
        }

        private void btnAcquista_Click(object sender, EventArgs e)
        {
            string app = cbNumBig.Text;
            int numBig = Int32.Parse(app);
            con.cn.Open();


            for (int i = numBig; i > 0; i--) //CICLO UTILE NEL CASO SI ACQUISTI PIU' DI UN BIGLIETTO 
            { 

                if (cbPremium.Checked)
                {
                    costo = costo + 50;
                    try
                    {
                        string query = $"INSERT INTO utenti_biglietti  (`ID`, `Premium`, `CODUtente`, `CODBiglietto`) VALUES ('', 'SI', '" + LoginInfo.UserID + "', '" + idBiglietto + "');";
                        MySqlCommand command = new MySqlCommand(query, con.cn); //INSERIMENTO IN CASO SIA UN BIGLIETTO PREMIUM
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        string query = $"INSERT INTO utenti_biglietti  (`ID`, `Premium`, `CODUtente`, `CODBiglietto`) VALUES ('', 'NO', '" + LoginInfo.UserID + "', '" + idBiglietto + "');";
                        MySqlCommand command = new MySqlCommand(query, con.cn); //INSERIMENTO SE NON E' STATO FLAGGATO IL PREMIUM
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            string queryE =  "UPDATE eventi "+ 
                             "SET Nposti = Nposti - " + numBig +
                             " WHERE ID = '" + LoginInfo.IdEvento + "'"; //AGGIORNO IL  NUMERO DI BIGLIETTI DISPONIBILI PER L'EVENTO SCELTO

            MySqlCommand commandE = new MySqlCommand(queryE, con.cn);
            commandE.ExecuteNonQuery();
            con.cn.Close();

            MessageBox.Show("Acquisto riusciuto con successo, costo totale: €" + costo.ToString());

            this.Close();
        }
    }
}
