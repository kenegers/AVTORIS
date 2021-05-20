using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AVTORIS
{
    public partial class AVTORIS : Form
    {
        public AVTORIS()
        {
            InitializeComponent();
        }

        private void AVTORIS_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-50S9T00;Initial Catalog=Ladea;Integrated Security=True");
            string query = "SELECT * FROM SOTR WHERE LOGI = '" + textBox1.Text.Trim() + "' and PAR = '" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtb1 = new DataTable();
            sda.Fill(dtb1);
            if (dtb1.Rows.Count == 1)
            {
                Form MENU = new MENU();
                MENU.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Введен неправильный логин или пароль!");
            }
        }
    }
}
