using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVTORIS
{
    public partial class MENU : MaterialForm
    {
        public MENU()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue400, Primary.Blue400, Accent.LightBlue200, TextShade.WHITE);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form SOTRUD = new SOTRUD();
            SOTRUD.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form KLIENT = new KLIENT();
            KLIENT.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form DETALI = new DETALI();
            DETALI.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form JOB = new JOB();
            JOB.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form DOGOVOR = new DOGOVOR();
            DOGOVOR.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form AKT = new AKT();
            AKT.Show();
            this.Hide();
        }

        

        private void MENU_Load(object sender, EventArgs e)
        {

        }
    }
}
