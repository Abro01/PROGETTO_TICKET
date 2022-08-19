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
    public partial class EventiInfo : Form
    {

        myDBconnection con = new myDBconnection();
        DataTable dt = new DataTable();
        DataTable costo = new DataTable();
        int prezzo;
        public EventiInfo()
        {
            InitializeComponent();
            con.Connect();
        }

        private void EventiInfo_Load(object sender, EventArgs e)
        {
            con.cn.Open();
            this.cbNumBiglietti.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNumBiglietti.SelectedIndex = 0;
            try
            {
                string query = "SELECT * FROM eventi WHERE id = '" + LoginInfo.IdEvento + "'";
                string qBiglietto = "SELECT costo FROM biglietti WHERE id = '" + LoginInfo.IdEvento + "'";

                MySqlDataAdapter sda = new MySqlDataAdapter(query, con.cn);
                MySqlDataAdapter da = new MySqlDataAdapter(qBiglietto, con.cn);
                da.Fill(costo);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            lDescrizione.Text = dt.Rows[0]["Descrizione"].ToString();
            lTitolo.Text = dt.Rows[0]["Nome"].ToString();
            lLuogo.Text = dt.Rows[0]["Luogo"].ToString();
            prezzo = Int32.Parse(costo.Rows[0]["costo"].ToString());
            lPrezzo.Text = prezzo.ToString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login logout = new Login();
            logout.Show();
            this.Close();
            con.cn.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MenuUtenti home = new MenuUtenti();
            home.ShowDialog();
            this.Hide();
            con.cn.Close();
        }

        private void btnProfilo_Click(object sender, EventArgs e)
        {
            Profilo profilo = new Profilo();
            profilo.Show();
            this.Hide();
        }

        private void cbNumBiglietti_SelectedIndexChanged(object sender, EventArgs e)
        {
            lPrezzo.Text = (((cbNumBiglietti.SelectedIndex) + 1) * prezzo).ToString(); //Cambia il prezzo in base a quanti biglietti si desiderano
        }

        private void btnAcquista_Click(object sender, EventArgs e)
        {
            /*
            string query = $"INSERT INTO 'utenti_biglietti` (`ID`, `CODUtente`, `CODBiglietto`) VALUES ('', '" + LoginInfo.UserID + "', '" + LoginInfo.IdEvento +"');";
            MessageBox.Show(query);
            MySqlCommand command = new MySqlCommand(query, con.cn);
            command.ExecuteNonQuery();
            con.cn.Close();*/
        }
    }
}