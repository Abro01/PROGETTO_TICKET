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
    public partial class FormInfoEventi : Form
    {
        myDBconnection con = new myDBconnection();
        MySqlCommand command;
        MySqlDataAdapter da;
        DataTable dt = new DataTable();
        public FormInfoEventi()
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
        }

        private void FormInfoEventi_Load(object sender, EventArgs e)
        {
            LoadTheme();

            con.cn.Open();
            try
            {
                   string query="SELECT u.Nome, u.Cognome, u.Username, u.Email " +
                                "FROM utenti u, biglietti b, utenti_biglietti ub " +    //CERCO LE INFORMAZIONI DEGLI UTENTI CHE CHE HANNO ACQUISTATO DEI  BIGLIETTI PER UN CERTO EVENTO SELEZIONATO
                                "WHERE b.ID=ub.CODBiglietto AND ub.CODUtente=u.ID " +   //TRAMITE L'ID DELL'EVENTO
                                "AND b.CODEvento = '" + LoginInfo.IdEvento + "'";

                command = new MySqlCommand(query, con.cn);
                da = new MySqlDataAdapter(command);
                da.Fill(dt);

                dtUtenti.DataSource = dt;
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
