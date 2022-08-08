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
    public partial class MenuForm : Form
    {

        myDBconnection con = new myDBconnection();
        MySqlCommand command;
        MySqlDataAdapter da;
        DataTable dt = new DataTable();
        string id;

        public MenuForm()
        {
            InitializeComponent();
            con.Connect();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            con.cn.Open();
            /* string query = "SELECT t.* " +
                            "FROM tratte t, tratte_fermate tf, treni tr, fermate f ";
             command = new MySqlCommand(query, con.cn);
             da = new MySqlDataAdapter(command);
             da.Fill(dt);

             dtRisultati.DataSource = dt;*/

            //refresh();
        }

        private void btnProfilo_Click(object sender, EventArgs e)
        {
            Profilo profilo = new Profilo();
            profilo.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login logout = new Login();
            logout.Show();
            this.Hide();
            con.cn.Close();
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            string partenza = txtPartenza.Text.ToString();
            string arrivo = txtArrivo.Text.ToString();

            ricercaTratte(partenza, arrivo);
        }

        public void ricercaTratte(string partenza, string arrivo)
        {
            dt.Rows.Clear();

            string query = "SELECT t.* " +
                           "FROM tratte t, tratte_fermate tf, treni tr, fermate f " +
                           "WHERE tr.CODTratta=t.ID AND t.ID=tf.CODTratta AND tf.CODFermata=f.ID " +
                           "AND t.Partenza = '" + partenza + "' AND t.Arrivo = '" + arrivo + "'";
            command = new MySqlCommand(query, con.cn);
            da = new MySqlDataAdapter(command);
            da.Fill(dt);

            dtRisultati.DataSource = dt;
        }

        /*public void refresh()
        {
            string sqlRefresh = "SELECT * " +
                                "FROM tratte t, tratte_fermate tf, treni tr, fermate f " +
                                "WHERE tr.CODTratta=t.ID AND t.ID=tf.CODTratta AND tf.CODFermata=f.ID";

            MySqlDataAdapter sda = new MySqlDataAdapter(sqlRefresh, con.cn);
            DataSet ds = new System.Data.DataSet();
            sda.Fill(ds);
            dtRisultati.DataSource = dt;
        }*/

    }
}
