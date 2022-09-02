using MySql.Data.MySqlClient;
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

namespace ProgettoRDF
{
    public partial class Login : Form
    {
        myDBconnection con = new myDBconnection();
        DataTable dt = new DataTable();
        DataTable id = new DataTable();
        DataTable dataTable = new DataTable();

        public static string emailIN, passwordIN;

        public Login()
        {
            InitializeComponent();
            con.Connect();
            this.Text = string.Empty;                                                   //QUESTI COMANDI PERMETTONO DI TRASCINARE LA SCHERMATA PRINCIPALE ATTRAVERSO IL PANNELLO IN CUI E' PRESENTE IL TITOLO DI OGNI PAGINA
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]                        //UTILIZZATI PER NASCONDERE LA BARRA IN ALTO
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Cancella i caratteri nelle textbox per permettere di effettuare un nuovo accesso
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
            {
                btnLogin.PerformClick();
            }     
        }

        private void lnkRegistrazione_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)       //QUESTO LINK PERMETTE ALL'UTENTE DI ESSERE REINDIRIZZATO NELLA PAGINA DI REGISTRAZIONE
        {
            Registrazione reg = new Registrazione();
            reg.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)             //BOTTONE CHE CHIUDE IL PROGRAMMA
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)          //GRAZIE A QUESTO BOTTONE E' POSSIBILE MASSIMIZZARE L'ESTENSIONE DELLA PAGINA TANTO QUANTO LA GRANDEZZA DELLO SCHERMO
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

        private void btnMinimize_Click(object sender, EventArgs e)          //QUESTO BOTTONE PERMETTE DI RIDURRE IL PROGRAMMA A TENDINA
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTitolo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Permette il login con l'invio 

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();

                if (cbCEOlogin.Checked)             //LOGIN CEO
                {
                    string queryCEO = "SELECT * FROM ceo_organizzazioni WHERE Email = '" + textEmail.Text + "' AND Password = MD5('" + textPassword.Text + "')";    //VERIFICA CHE I DATI INSERITI SIANO PRESENTI NEL DATABASE
                    MySqlDataAdapter da = new MySqlDataAdapter(queryCEO, con.cn);

                    da.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        emailIN = textEmail.Text;
                        passwordIN = textPassword.Text;
                        string qId = "SELECT ID from ceo_organizzazioni WHERE Email = '" + textEmail.Text + "'";//QUERY PER TROVARE L'ID DELL'UTENTE
                        MySqlDataAdapter da1 = new MySqlDataAdapter(qId, con.cn);                  //CON LE VARIABILI DI SQL UTILI PER CIO'
                        da1.Fill(id);
                        LoginInfo.UserID = Int32.Parse(id.Rows[0]["ID"].ToString());            //SE I DATI INSERITI SONO CORRETTI ALLORA L'UTENTE VIENE LOGGATO E REINDIRIZZATO NELLA HOME DEL PROGRAMMA
                        FormInterfacciaCEO home = new FormInterfacciaCEO();
                        home.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Dati inseriti errati", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);       //SE I DATI INSERITI SONO ERRATI ESCE QUESTO MESSAGGIO DI ERRORE E I DATI VENGONO CANCELLATI 
                        textEmail.Clear();
                        textPassword.Clear();
                        textEmail.Focus();
                    }
                }
                else                                         //LOGIN UTENTI NORMALI
                {
                    string queryUtenti = "SELECT * FROM utenti WHERE Email = '" + textEmail.Text + "' AND Password = MD5('" + textPassword.Text + "')";
                    MySqlDataAdapter sda = new MySqlDataAdapter(queryUtenti, con.cn);

                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        emailIN = textEmail.Text;
                        passwordIN = textPassword.Text;
                        string qId = "SELECT ID from utenti WHERE Email = '" + textEmail.Text + "'";//QUERY PER TROVARE L'ID DELL'UTENTE
                        MySqlDataAdapter da = new MySqlDataAdapter(qId, con.cn);                  //CON LE VARIABILI DI SQL UTILI PER CIO'
                        da.Fill(id);
                        LoginInfo.UserID = Int32.Parse(id.Rows[0]["ID"].ToString());
                        FormInterfacciaUtente home = new FormInterfacciaUtente();
                        home.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Dati inseriti errati", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textEmail.Clear();
                        textPassword.Clear();
                        textEmail.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.cn.Close();
        }

    }
}
