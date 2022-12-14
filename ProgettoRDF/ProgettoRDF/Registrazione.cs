using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProgettoRDF
{
    public partial class Registrazione : Form
    {
        myDBconnection con = new myDBconnection();
        MySqlDataAdapter da;
        DataTable dt = new DataTable();

        public Registrazione()
        {
            InitializeComponent();
            con.Connect();
            this.Text = string.Empty;                                           //QUESTI COMANDI PERMETTONO DI TRASCINARE LA SCHERMATA PRINCIPALE ATTRAVERSO IL PANNELLO IN CUI E' PRESENTE IL TITOLO DI OGNI PAGINA
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]                 //UTILIZZATI PER NASCONDERE LA BARRA IN ALTO
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void RegistrazioneUtenti_Load(object sender, EventArgs e)
        {
            con.cn.Open();
            this.cbOrg.DropDownStyle = ComboBoxStyle.DropDownList; //Non permette di scrivere nella combobox facendola diventare di fatto una ddlist
            int i = 0;
            string queryOrganizzazioni = "SELECT nome " +
                                         "FROM organizzazione";

            da = new MySqlDataAdapter(queryOrganizzazioni, con.cn);
            da.Fill(dt);
            DataRow[] righe = dt.Select();

            for (i = 0; i < dt.Rows.Count; i++)
            {
                cbOrg.Items.Add(righe[i]["nome"]);
            }
        }

        private void btnRegistrazione_Click(object sender, EventArgs e)
        {
            string emailIN = textEmail.Text;
            string passwordIN = textPassword.Text;
            string nomeIn = textNome.Text;
            string cognomeIn = textCognome.Text;
            string userIn = textUser.Text;
            int i = 0;

            if (rbOrganizzatore.Checked==true)          //REGISTRAZIONE ORGANIZZATORE
            {
                //Controllo che  tutti i campi siano compilati
                if ((String.IsNullOrEmpty(textEmail.Text)) || (String.IsNullOrEmpty(textPassword.Text)) || (String.IsNullOrEmpty(textNome.Text)) || (String.IsNullOrEmpty(textCognome.Text)))
                {
                    MessageBox.Show("E' necessario compilare tutti i campi");
                }else
                {
                    try
                    {
                        DataTable DataTableID = new DataTable();
                        string queryID = "SELECT o.ID " +
                                         "FROM organizzazione o " +
                                         "WHERE o.Nome = '" + this.cbOrg.GetItemText(this.cbOrg.SelectedItem) + "'";            //ESTRAE L'ID DELL'ORGANIZZAZIONE
                        da = new MySqlDataAdapter(queryID, con.cn);
                        da.Fill(DataTableID);
                        DataRow[] righe = DataTableID.Select();
                        string idSelect = righe[0]["ID"].ToString();
                        int ID = Int32.Parse(idSelect);

                        string query = $"INSERT INTO `ceo_organizzazioni` (`ID`, `Nome`, `Cognome`, `Email`, `Password`, `CODOrganizzazione`) VALUES ('', '" + textNome.Text + "', '" + textCognome.Text + "', '" + textEmail.Text + "', MD5('" + textPassword.Text + "'), '" + ID + "');";     //INSERIAMO NEL DATABASE I DATI INSERITI NELLE TEXTBOX E SELEZIONATI NELLA COMBOBOX
                        MySqlCommand command = new MySqlCommand(query, con.cn);
                        command.ExecuteNonQuery();
                        Login loginReg = new Login();                       //SI VIENE PORTATI AL PORTALE DEL LOGIN
                        loginReg.Show();
                        this.Hide();

                    }catch
                    {

                    }finally
                    {
                        con.cn.Close();
                    }
                }
            }else if(rbOrganizzatore.Checked==false)                    //REGISTRAZIONE UTENTE NORMALE
            {
                //Controllo che  tutti i campi siano compilati
                if ((String.IsNullOrEmpty(textEmail.Text)) || (String.IsNullOrEmpty(textPassword.Text)) || (String.IsNullOrEmpty(textNome.Text)) || (String.IsNullOrEmpty(textCognome.Text)) || (String.IsNullOrEmpty(textUser.Text)))
                {
                    MessageBox.Show("E' necessario compilare tutti i campi");
                }else
                {
                    try
                    {
                        string query = $"INSERT INTO `utenti` (`ID`, `Nome`, `Cognome`, `Username`, `Email`, `Password`) VALUES ('', '" + textNome.Text + "', '" + textCognome.Text + "', '" + textUser.Text + "', '" + textEmail.Text + "', MD5('" + textPassword.Text + "'));";           //INSERIMENTO DATI
                        MySqlCommand command = new MySqlCommand(query, con.cn);
                        command.ExecuteNonQuery();
                        Login loginReg = new Login();
                        loginReg.Show();
                        this.Hide();
                    }catch
                    {

                    }
                    finally
                    {
                        con.cn.Close();
                    }
                }
            }
        }

        //Cancella i caratteri nelle textbox per permettere di effettuare una nuova registrazione
        private void btnClear_Click(object sender, EventArgs e)
        {
            textEmail.Clear();
            textPassword.Clear();

            textEmail.Focus();
        }
        //Permette di effettuare la registrazione premendo il tasto invio
        private void textPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                btnRegistrazione.PerformClick();
        }

        private void rbUtente_CheckedChanged(object sender, EventArgs e)            //SELEZIONA LA REGISTRAZIONE PER GLI UTENTI
        {
            cbOrg.Hide();
            lCodOrg.Hide();
            lbUser.Show();
            textUser.Show();

        }

        private void rbOrganizzatore_CheckedChanged(object sender, EventArgs e)     //SELEZIONA LA REGISTRAZIONE PER GLI ORGANIZZATORI
        {
            lbUser.Hide();
            textUser.Hide();
            cbOrg.Show();
            lCodOrg.Show();
        }

        //CHIUDE IL PROGRAMMA
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)                  //GRAZIE A QUESTO BOTTONE E' POSSIBILE MASSIMIZZARE L'ESTENSIONE DELLA PAGINA TANTO QUANTO LA GRANDEZZA DELLO SCHERMO
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)                  //QUESTO BOTTONE PERMETTE DI RIDURRE IL PROGRAMMA A TENDINA
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTitolo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
