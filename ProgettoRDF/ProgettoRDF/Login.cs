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
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Vuoi uscire?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();

                if(cbCEOlogin.Checked)
                {
                    string queryCEO = "SELECT * FROM ceo_organizzazioni WHERE Email = '" + textEmail.Text + "' AND Password = MD5('" + textPassword.Text + "')";
                    MySqlDataAdapter da = new MySqlDataAdapter(queryCEO, con.cn);

                    da.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        emailIN = textEmail.Text;
                        passwordIN = textPassword.Text;
                        string qId = "SELECT ID from utenti WHERE Email =" + textEmail.Text + "'";//QUERY PER TROVARE L'ID DELL'UTENTE
                        MySqlDataAdapter da1 = new MySqlDataAdapter(qId, con.cn);                  //CON LE VARIABILI DI SQL UTILI PER CIO'
                        da1.Fill(id);
                        LoginInfo.UserID = Int32.Parse(id.Rows[0]["ID"].ToString());
                        MenuCEO home = new MenuCEO();
                        home.ShowDialog();
                        this.Hide();
                    }
                }

                string queryUtenti = "SELECT * FROM utenti WHERE Email = '" + textEmail.Text + "' AND Password = MD5('" + textPassword.Text + "')";
                MySqlDataAdapter sda = new MySqlDataAdapter(queryUtenti, con.cn);

                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    emailIN = textEmail.Text;
                    passwordIN = textPassword.Text;
                    string qId = "SELECT ID from utenti WHERE Email =" + textEmail.Text + "'";//QUERY PER TROVARE L'ID DELL'UTENTE
                    MySqlDataAdapter da = new MySqlDataAdapter(qId, con.cn);                  //CON LE VARIABILI DI SQL UTILI PER CIO'
                    da.Fill(id);
                    LoginInfo.UserID = Int32.Parse(id.Rows[0]["ID"].ToString());
                    MenuUtenti home = new MenuUtenti();
                    home.ShowDialog();
                    this.Hide();
                }else
                {
                    MessageBox.Show("Dati inseriti errati", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textEmail.Clear();
                    textPassword.Clear();

                    textEmail.Focus();
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.cn.Close();
        }
        //Cancella i caratteri nelle textbox per permettere di effettuare un nuovo accesso
        private void btnClear_Click(object sender, EventArgs e)
        {
            textEmail.Clear();
            textPassword.Clear();

            textEmail.Focus();
        }
        //Permette il login con l'invio 
        private void textPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                btnLogin.PerformClick();
        }

        private void lnkRegistrazione_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrazione reg = new Registrazione();
            reg.Show();
            this.Hide();
        }

    }
}
