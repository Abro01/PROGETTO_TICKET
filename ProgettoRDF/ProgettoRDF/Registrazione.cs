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
    public partial class Registrazione : Form
    {
        myDBconnection con = new myDBconnection();
        MySqlDataAdapter da;
        DataTable dt = new DataTable();

        public Registrazione()
        {
            InitializeComponent();
            con.Connect();
        }

        private void btnRegistrazione_Click(object sender, EventArgs e)
        {
            //Controllo che  tutti i campi siano compilati
            if ((String.IsNullOrEmpty(textEmail.Text)) || (String.IsNullOrEmpty(textPassword.Text)) || (String.IsNullOrEmpty(textNome.Text)) || (String.IsNullOrEmpty(textCognome.Text)) || (String.IsNullOrEmpty(textUser.Text)))
            {
                MessageBox.Show("E' necessario compilare tutti i campi");
            }
            else
            {
                string emailIN = textEmail.Text;
                string passwordIN = textPassword.Text;
                string nomeIn = textNome.Text;
                string cognomeIn = textCognome.Text;
                string userIn = textUser.Text;

                try
                {
                    con.cn.Open();
                    string query = $"INSERT INTO `utenti` (`ID`, `Nome`, `Cognome`, `Username`, `Email`, `Password`) VALUES ('', '" + textNome.Text + "', '" + textCognome.Text + "', '" + textUser.Text + "', '" + textEmail.Text + "', MD5('" + textPassword.Text + "'));";
                    MySqlCommand command = new MySqlCommand(query, con.cn);
                    command.ExecuteNonQuery();
                    MessageBox.Show(query);
                    Login loginReg = new Login();
                    loginReg.Show();
                    this.Hide();
                }
                catch
                {

                }
                finally
                {

                    con.cn.Close();
                }
            }
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
    }
}
