using DesignProject.Classi;
using System.Drawing;
using System.Windows.Forms;

namespace DesignProject.Forms
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, System.EventArgs e)
        {
            LoadTheme();
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
    }
}
