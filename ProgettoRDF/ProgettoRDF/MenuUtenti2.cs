using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoRDF
{
    public partial class MenuUtenti2 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activateForm;

        myDBconnection con = new myDBconnection();

        public MenuUtenti2()
        {
            InitializeComponent();
            random = new Random();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);

            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }

            tempIndex = index;
            string color = ThemeColor.ColorList[index];

            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnlTitolo.BackColor = color;
                    pnlLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in pnlMenu.Controls)
            {
                previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                previousBtn.ForeColor = Color.White;
                previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activateForm != null)
            {
                activateForm.Close();
            }

            ActivateButton(btnSender);
            activateForm = childForm;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnCarrello_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnProfilo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnImpostazioni_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Login logout = new Login();
            logout.Show();
            this.Hide();

            con.cn.Close();
        }

        private void MenuUtenti2_Load(object sender, EventArgs e)
        {
            con.cn.Open();
        }
    }
}
