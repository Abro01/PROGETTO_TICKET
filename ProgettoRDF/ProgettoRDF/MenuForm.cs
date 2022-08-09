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
            LoginUtenti logout = new LoginUtenti();
            logout.Show();
            this.Hide();
            con.cn.Close();
        }

      

    }
}
