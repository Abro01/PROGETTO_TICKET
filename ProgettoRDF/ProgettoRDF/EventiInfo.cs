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
        MySqlDataAdapter da;

        public EventiInfo()
        {
            InitializeComponent();
            con.Connect();
        }

        private void EventiInfo_Load(object sender, EventArgs e)
        {
            con.cn.Open();
            for (int y = 1; y < 5; y++)
            {
                cbNumBiglietti.Items.Add(y);
            }
            try
            {
                string query = "SELECT * FROM eventi WHERE id = '" + LoginInfo.IdEvento + "'";

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

            lDescrizione.Text = dt.Rows[0]["Descrizione"].ToString();
            lTitolo.Text = dt.Rows[0]["Nome"].ToString();
            lLuogo.Text = dt.Rows[0]["Luogo"].ToString();
        }
    }
}
