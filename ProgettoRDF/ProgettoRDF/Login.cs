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
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
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

        private void textPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnLogin.PerformClick();
            }     
        }

        private void lnkRegistrazione_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrazione reg = new Registrazione();
            reg.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
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

        private void btnMinimize_Click(object sender, EventArgs e)
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

                if (cbCEOlogin.Checked)
                {
                    string queryCEO = "SELECT * FROM ceo_organizzazioni WHERE Email = '" + textEmail.Text + "' AND Password = MD5('" + textPassword.Text + "')";
                    MySqlDataAdapter da = new MySqlDataAdapter(queryCEO, con.cn);

                    da.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        emailIN = textEmail.Text;
                        passwordIN = textPassword.Text;
                        string qId = "SELECT ID from ceo_organizzazioni WHERE Email = '" + textEmail.Text + "'";//QUERY PER TROVARE L'ID DELL'UTENTE
                        MySqlDataAdapter da1 = new MySqlDataAdapter(qId, con.cn);                  //CON LE VARIABILI DI SQL UTILI PER CIO'
                        da1.Fill(id);
                        LoginInfo.UserID = Int32.Parse(id.Rows[0]["ID"].ToString());
                        MenuCEO home = new MenuCEO();
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
                else
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
