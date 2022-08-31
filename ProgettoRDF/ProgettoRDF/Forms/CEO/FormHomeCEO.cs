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
    public partial class FormHomeCEO : Form
    {
        public FormHomeCEO()
        {
            InitializeComponent();
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

            lblTitoloDesktop.ForeColor = ThemeColor.SecondaryColor;
            lblDescrizioneDesktop.ForeColor = ThemeColor.PrimaryColor;
        }

        private void FormHomeCEO_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
