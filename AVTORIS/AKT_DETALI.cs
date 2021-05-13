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
    public partial class AKT_DETALI : Form
    {
        public AKT_DETALI()
        {
            InitializeComponent();
        }

        private void AKT_DETALI_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ladeaDataSet4.DETALI". При необходимости она может быть перемещена или удалена.
            this.dETALITableAdapter.Fill(this.ladeaDataSet4.DETALI);

        }
    }
}
