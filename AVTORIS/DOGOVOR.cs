using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;


namespace AVTORIS
{
    public partial class DOGOVOR : Form
    {
        public DOGOVOR()
        {
            InitializeComponent();
            LoadData();
        }
        string connectString = @"Data Source=DESKTOP-50S9T00;Initial Catalog=Ladea;Integrated Security=True";
        private void LoadData()
        {
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            string qure = "SELECT DOGOVOR.id_DV, DOGOVOR.DATE_DV, KLIENT.FIO FROM DOGOVOR inner Join KLIENT on DOGOVOR.id_KL = KLIENT.id_KL";
            SqlCommand command = new SqlCommand(qure, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();

            }
            reader.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void DOGOVOR_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ladeaDataSet.KLIENT". При необходимости она может быть перемещена или удалена.
            this.kLIENTTableAdapter.Fill(this.ladeaDataSet.KLIENT);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                try
                {
                    SqlConnection myConnection = new SqlConnection(connectString);//Создадим экземпляр класса для подключения к БД 

                    myConnection.Open();

                    if (myConnection.State == ConnectionState.Open)
                    {
                        SqlCommand ins = new SqlCommand($"INSERT INTO [DOGOVOR] (DATE_DV, id_KL) " +
                            $"VALUES('{dateTimePicker1.Value}'," +
                            $"(SELECT id_KL FROM KLIENT WHERE FIO = '{comboBox1.Text}'))", myConnection);

                        ins.ExecuteNonQuery();
                        MessageBox.Show("Записан!");
                        dataGridView1.Rows.Clear();
                        LoadData();
                        myConnection.Close();
                        textBox1.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
            }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            if (myConnection.State == ConnectionState.Open)
            {
                SqlCommand ins = new SqlCommand($"update DOGOVOR set  [DATE_DV]='{dateTimePicker1.Text.ToString()}'," +
                    $"  [id_KL] =(SELECT KLIENT.id_KL FROM KLIENT WHERE KLIENT.FIO= '{comboBox1.Text.ToString()}') " +
                    $" WHERE id_DV='{textBox1.Text.ToString()}'", myConnection);
                ins.ExecuteNonQuery();
                MessageBox.Show("Изменен!");
                dataGridView1.Rows.Clear();
                LoadData();
                myConnection.Close();
                textBox1.Clear();
            }

               

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            myConnection.Close();
        }
    }
}
