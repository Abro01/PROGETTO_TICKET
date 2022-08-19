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
        DataTable dt = new DataTable();
        DataTable costo = new DataTable();

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
    }
}
