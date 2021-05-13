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

namespace AVTORIS
{
    public partial class DETALI : Form
    {
        public DETALI()
        {
            InitializeComponent();
            LoadData();
            DataTable dt;
            SqlDataAdapter adpt;

        }
        string connectString = @"Data Source=DESKTOP-50S9T00;Initial Catalog=Ladea;Integrated Security=True";
        private void LoadData()
        {
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();


            string qure = "SELECT DETALI.id_DT, DETALI.NAME, DETALI.PRICE FROM DETALI";
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

        private void DETALI_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)//добав детали
        {
            try
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                if (myConnection.State == ConnectionState.Open)
                {
                    SqlCommand DETALI = new SqlCommand($"INSERT INTO [dbo].[DETALI] values (@NAME, @PRICE)", myConnection);

                    DETALI.Parameters.AddWithValue("@NAME", textBox2.Text);
                    DETALI.Parameters.AddWithValue("@PRICE", textBox3.Text);


                    DETALI.ExecuteNonQuery();
                    MessageBox.Show("Деталь Добавлена!");
                    dataGridView1.Rows.Clear();
                    LoadData();
                    myConnection.Close();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Проверте заполнение!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();

            string upd = $"UPDATE[dbo].[DETALI] set [NAME] = '{textBox2.Text.ToString()}'," + $"[PRICE] = '{textBox3.Text.ToString()}' WHERE Id_DT = " + textBox1.Text;

            SqlCommand a = new SqlCommand(upd, myConnection);
            a.ExecuteNonQuery();
            MessageBox.Show("Изменения внесены!");
            myConnection.Close();
            myConnection.Dispose();
            this.dataGridView1.Rows.Clear();//удаление всей строчек
            LoadData();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            string ins = "DELETE FROM DETALI WHERE Id_DT=" + textBox1.Text;

            SqlCommand com = new SqlCommand(ins, myConnection);
            SqlDataReader reader = com.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();

            }
            reader.Close();
            dataGridView1.Rows.Clear();
            LoadData();

            MessageBox.Show("Данные Удалены!");

            reader.Close();
            myConnection.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form MENU = new MENU();
            MENU.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)// поиск дет
        {
            //{
            //    dataGridView1.Rows.Clear();
            //    SqlConnection myConnection1 = new SqlConnection(connectString);
            //    myConnection1.Open();

            //    SqlCommand command1 = new SqlCommand($"SELECT DETALI.NAME  FROM  DETALI  WHERE DETALI.NAME = @nam", myConnection1);
            //    command1.Parameters.AddWithValue("@nam", textBox4.Text.ToString());

            //    dataGridView1.Rows.Clear();
            //    SqlDataReader reader1 = command1.ExecuteReader();
            //    List<string[]> data = new List<string[]>();
            //    while (reader1.Read())
            //    {
            //        data.Add(new string[3]);
            //        data[data.Count - 1][0] = reader1[0].ToString();
            //        data[data.Count - 1][1] = reader1[1].ToString();
            //        data[data.Count - 1][2] = reader1[2].ToString();

            //    }
            //    reader1.Close();
            //    myConnection1.Close();
            //    foreach (string[] s in data)
            //        dataGridView1.Rows.Add(s);
            //{
            //    dataGridView1.Rows.Clear();
            //    SqlConnection myConnection1 = new SqlConnection(connectString);
            //    myConnection1.Open();
            //    //string query1 = "SELECT DETALI. FROM DETALI where DETALI.NAME='" + textBox2.Text.ToString() + "'  DETALI.PRICE='" + textBox3.Text.ToString() + "' order by DETALI.id_DETALI";
            //    //string query1 = "SELECT DETALI.  DETALI.NAME='" + textBox2.Text.Trim() + "' or DETALI.PRICE='" + textBox3.Text.Trim() + "' order by DETALI.id_DETALI";
            //    //SqlCommand command1 = new SqlCommand(query1, myConnection1);
            //    SqlDataReader reader1 = command1.ExecuteReader();
            //    List<string[]> data1 = new List<string[]>();
            //    while (reader1.Read())
            //    {
            //        data1.Add(new string[3]);
            //        data1[data1.Count - 1][0] = reader1[0].ToString();
            //        data1[data1.Count - 1][1] = reader1[1].ToString();
            //        data1[data1.Count - 1][2] = reader1[2].ToString();

            //    }
            //    reader1.Close();
            //    myConnection1.Close();
            //    foreach (string[] s in data1)
            //        dataGridView1.Rows.Add(s);


            //DataTable rezult = new DataTable();
            //dataGridView1.DataSource = rezult;
            //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("NAME like '%" + textBox4.Text + "%'");

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;

                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox4.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Purple;
                            break;
                        }
            }
        }


    }

        
 }


