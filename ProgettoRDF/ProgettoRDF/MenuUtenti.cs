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
    public partial class MenuUtenti : Form
    {

        myDBconnection con = new myDBconnection();
        MySqlCommand command;
        MySqlDataAdapter da;
        DataTable dt = new DataTable();
        string id;

        public MenuUtenti()
        {
            InitializeComponent();
            con.Connect();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            con.cn.Open();

            string query = "SELECT e.* " +
                           "FROM eventi e, organizzazione o, ceo_organizzazioni c " +
                           "WHERE c.CODOrganizzazione=o.ID AND o.ID=e.CODOrganizzazione ";
            
            MessageBox.Show(query);
            command = new MySqlCommand(query, con.cn);
            da = new MySqlDataAdapter(command);
            da.Fill(dt);

            dtRisultati.DataSource = dt;
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

        public void ricercaEventi(string nomeEvento)
        {
            dt.Rows.Clear();

            string query = "SELECT e.* " +
                           "FROM eventi e, organizzazione o, ceo_organizzazioni c " +
                           "WHERE c.CODOrganizzazione=o.ID AND o.ID=e.CODOrganizzazione " +
                           "AND e.Nome = '" + nomeEvento + "'";
            MessageBox.Show(query);
            command = new MySqlCommand(query, con.cn);
            da = new MySqlDataAdapter(command);
            da.Fill(dt);

            dtRisultati.DataSource = dt;
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            ricercaEventi(txtNomeEvento.Text);
        }
    }
}
