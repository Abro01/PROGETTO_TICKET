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
    public partial class MenuCEO : Form
    {
        myDBconnection con = new myDBconnection();
        MySqlCommand command;
        MySqlDataAdapter da;
        DataTable dt = new DataTable();

        public MenuCEO()
        {
            InitializeComponent();
            con.Connect();
        }

        private void bHome_Click(object sender, EventArgs e)
        {
           
        }

        private void bProfilo_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login logout = new Login();
            logout.Show();
            this.Close();
            con.cn.Close();
        }

        private void MenuCEO_Load(object sender, EventArgs e)
        {
            con.cn.Open();

            string query = "SELECT e.* " +
                           "FROM eventi e, organizzazione o, ceo_organizzazioni c " +
                           "WHERE c.CODOrganizzazione=o.ID AND o.ID=e.CODOrganizzazione " +
                           "AND e.CODOrganizzazione= '" +LoginInfo.UserID + "'";

            command = new MySqlCommand(query, con.cn);
            da = new MySqlDataAdapter(command);
            da.Fill(dt);

            dtEventi.DataSource = dt;

        }
    }
}
