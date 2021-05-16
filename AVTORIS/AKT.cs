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
using Excel = Microsoft.Office.Interop.Excel;

namespace AVTORIS
{
    public partial class AKT : Form
    {
        public AKT()
        {
            InitializeComponent();
            LoadData();
            LoadDataJ();
            LoadDataD();

        }
        string connectString = @"Data Source=DESKTOP-50S9T00;Initial Catalog=Ladea;Integrated Security=True";

        private void LoadDataJ()
        {
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            
            SqlCommand command = new SqlCommand($"SELECT AKT_JOB.Id_AKT_JOB, JOB.NAME, JOB.PRICE, SOTR.FIO" +
                $" FROM (AKT_JOB inner Join JOB on AKT_JOB.Id_J = JOB.Id_J ) " +
                $"inner Join SOTR on  AKT_JOB.Id_S = SOTR.id_S where [Id_AKT]='{textBox1.Text.ToString()}'", myConnection);
            

            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();

            }
            reader.Close();

            foreach (string[] s in data)
                dataGridView2.Rows.Add(s);
            dataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            

        }
        private void LoadData()
        {
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            string qure = "SELECT AKT.id_AKT, AKT.DATE_AKT, DOGOVOR.id_DV FROM AKT inner Join DOGOVOR on AKT.id_DV = DOGOVOR.id_DV";
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



        private void LoadDataD()
        {
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();
            
            SqlCommand command = new SqlCommand($"SELECT AKT_DETALI.Id_AKT_DET, DETALI.NAME,  DETALI.PRICE_D " +
                $"FROM (AKT_DETALI inner Join DETALI on AKT_DETALI.Id_DT = DETALI.Id_DT )  where [Id_AKT]='{textBox1.Text.ToString()}'", myConnection);

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
                dataGridView3.Rows.Add(s);
            dataGridView3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void AKT_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ladeaDataSet5.DETALI". При необходимости она может быть перемещена или удалена.
            this.dETALITableAdapter.Fill(this.ladeaDataSet5.DETALI);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ladeaDataSet3.SOTR". При необходимости она может быть перемещена или удалена.
            this.sOTRTableAdapter.Fill(this.ladeaDataSet3.SOTR);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ladeaDataSet2.JOB". При необходимости она может быть перемещена или удалена.
            this.jOBTableAdapter.Fill(this.ladeaDataSet2.JOB);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ladeaDataSet1.DOGOVOR". При необходимости она может быть перемещена или удалена.
            this.dOGOVORTableAdapter.Fill(this.ladeaDataSet1.DOGOVOR);

        }

        private void button1_Click(object sender, EventArgs e)//перход на дог
        {
            Form DOGOVOR = new DOGOVOR();
            DOGOVOR.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
         
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dataGridView2.Rows.Clear();///чистим второй датагрид , что бы после записывали значения дт1

            SqlCommand comm = new SqlCommand ($"SELECT AKT_JOB.Id_AKT_JOB, JOB.NAME, JOB.PRICE, SOTR.FIO FROM (AKT_JOB inner Join JOB on AKT_JOB.Id_J = JOB.Id_J ) " +
              $"inner Join SOTR on  AKT_JOB.Id_S = SOTR.id_S where [Id_AKT]='{textBox1.Text.ToString()}'", myConnection);

            SqlDataReader reader = comm.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();

            }
            reader.Close();

            foreach (string[] s in data)
                dataGridView2.Rows.Add(s);
            dataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //
            dataGridView3.Rows.Clear();///чистим третий датагрид , что бы после записывали значения дт1

            SqlCommand commi = new SqlCommand($"SELECT AKT_DETALI.Id_AKT_DET, DETALI.NAME,  DETALI.PRICE_D FROM (AKT_DETALI inner Join DETALI on AKT_DETALI.Id_DT = DETALI.Id_DT ) " +
                 $" where [Id_AKT]='{textBox1.Text.ToString()}'", myConnection);

            SqlDataReader reader1 = commi.ExecuteReader();
            List<string[]> data1 = new List<string[]>();
            while (reader1.Read())
            {
                data1.Add(new string[3]);

                data1[data1.Count - 1][0] = reader1[0].ToString();
                data1[data1.Count - 1][1] = reader1[1].ToString();
                data1[data1.Count - 1][2] = reader1[2].ToString();
            
            }
            reader1.Close();

            foreach (string[] s in data1)
                dataGridView3.Rows.Add(s);
            dataGridView3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void button4_Click(object sender, EventArgs e)//добавть акт 
        {
            try
            {
                SqlConnection myConnection = new SqlConnection(connectString);//Создадим экземпляр класса для подключения к БД 

                myConnection.Open();

                if (myConnection.State == ConnectionState.Open)
                {
                    SqlCommand ins = new SqlCommand($"INSERT INTO [AKT] (DATE_AKT, id_DV) " +
                        $"VALUES('{dateTimePicker1.Value}'," +
                        $"(SELECT id_DV FROM DOGOVOR WHERE id_DV = '{comboBox1.Text}'))", myConnection);

                    ins.ExecuteNonQuery();
                    MessageBox.Show("Записан!");
                    dataGridView1.Rows.Clear();
                    LoadData();
                    myConnection.Close();
                    textBox1.Clear();
                    dataGridView2.Rows.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void button2_Click(object sender, EventArgs e)//Изменить акт 
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            if (myConnection.State == ConnectionState.Open)
            {
                SqlCommand ins = new SqlCommand($"update AKT set  [DATE_AKT]='{dateTimePicker1.Value}'," +
                    $"  [id_DV] =(SELECT DOGOVOR.id_DV FROM DOGOVOR WHERE DOGOVOR.id_DV= '{comboBox1.Text.ToString()}') " +
                    $" WHERE id_DV='{textBox1.Text.ToString()}'", myConnection);
                ins.ExecuteNonQuery();
                MessageBox.Show("Изменен!");
                dataGridView1.Rows.Clear();
                LoadData();
                myConnection.Close();
                textBox1.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)//удалить акт
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            string del = "DELETE FROM dbo.AKT WHERE id_AKT =" + textBox1.Text;

            SqlCommand com = new SqlCommand(del, myConnection);
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

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
           // comboBox2.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
          //  comboBox3.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            //dateTimePicker1.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            //textBox2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();

            myConnection.Close();
        }

        private void button5_Click(object sender, EventArgs e)//добавить в акт работу
        {
            try
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                if (myConnection.State == ConnectionState.Open)
                {
                    SqlCommand JOB_AKT = new SqlCommand($"INSERT INTO [dbo].[AKT_JOB] values (@Id_AKT,(SELECT JOB.id_J FROM JOB" +
                        $" WHERE JOB.NAME = @Id_J),(SELECT SOTR.id_S FROM SOTR WHERE SOTR.FIO =@Id_S))", myConnection);

                    JOB_AKT.Parameters.AddWithValue("@Id_AKT", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    JOB_AKT.Parameters.AddWithValue("@Id_J", comboBox2.Text);
                    JOB_AKT.Parameters.AddWithValue("@Id_S", comboBox3.Text);



                    JOB_AKT.ExecuteNonQuery();
                    MessageBox.Show("Добавлен!");
                    dataGridView2.Rows.Clear();
                    LoadDataJ();
                    myConnection.Close();
                                       
                    
                }
            }
            catch
            {
                MessageBox.Show("Проверьте заполнение!");
            }
        }

        private void button6_Click(object sender, EventArgs e)//изменить акт работ
        {
            SqlConnection myConnection = new SqlConnection(connectString); 
            myConnection.Open();
            textBox2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            string upd = $"UPDATE[dbo].[AKT_JOB] set [Id_J] =(SELECT JOB.id_J FROM JOB WHERE JOB.NAME = '{comboBox2.Text}'), " +
                $"[id_S]=(SELECT SOTR.id_S FROM SOTR WHERE SOTR.FIO ='{comboBox3.Text.ToString()}') " +
                $"WHERE [Id_AKT] = '{textBox1.Text.ToString()}' and [Id_AKT_JOB] = '{textBox2.Text.ToString()}'"; 
               
            
            SqlCommand a = new SqlCommand(upd, myConnection);
            a.ExecuteNonQuery();
            MessageBox.Show("Изменения внесены!");
            myConnection.Close();
            myConnection.Dispose();
            this.dataGridView2.Rows.Clear();//удаление всей строчек
            LoadDataJ();
            textBox1.Clear();
            textBox2.Clear();
                        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//ПРи заполнение акта, выбрать из таблицы джоб
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            string del = "DELETE FROM dbo.AKT_JOB WHERE Id_AKT_JOB =" + textBox2.Text;

            SqlCommand com = new SqlCommand(del, myConnection);
            SqlDataReader reader = com.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[4]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();

            }
            reader.Close();
            dataGridView2.Rows.Clear();
            LoadDataJ();

            MessageBox.Show("Данные Удалены!");

            reader.Close();
            myConnection.Close();
            textBox1.Clear();
        }

        private void button8_Click(object sender, EventArgs e)//добавить в датагрид 3 
        {
            try
            {
                string connectString = @"Data Source=DESKTOP-50S9T00;Initial Catalog=Ladea;Integrated Security=True";
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                if (myConnection.State == ConnectionState.Open)
                {
                   SqlCommand DET_AKT = new SqlCommand($"INSERT INTO [dbo].[AKT_DETALI] values (@Id_AKT,(SELECT DETALI.id_DT FROM DETALI" +
                        $" WHERE DETALI.NAME = @Id_DT))", myConnection);

                    DET_AKT.Parameters.AddWithValue("@Id_AKT", textBox1.Text.ToString()); //dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    DET_AKT.Parameters.AddWithValue("@Id_DT", comboBox4.Text);



                    DET_AKT.ExecuteNonQuery();
                    MessageBox.Show("Добавлен!");
                    dataGridView3.Rows.Clear();
                    LoadDataD();
                    myConnection.Close();
              
                }
            }
            catch
            {
                MessageBox.Show("Проверьте заполнение!");
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            textBox3.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();

            //comboBox4.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            
            myConnection.Close();
        }

        private void button9_Click(object sender, EventArgs e)  //  изменение деталей в акте
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            textBox3.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();


            SqlCommand aa = new SqlCommand($"UPDATE[dbo].[AKT_DETALI] set [Id_DT] =(SELECT DETALI.Id_DT FROM DETALI " +
                $"WHERE DETALI.NAME = '{comboBox4.Text}') WHERE ([Id_AKT] = '{textBox1.Text.ToString()}') and " +
                $"([Id_AKT_DET] = '{ dataGridView3.CurrentRow.Cells[0].Value.ToString()}')", myConnection);


            aa.ExecuteNonQuery();
            MessageBox.Show("Изменения внесены!");
            myConnection.Close();
            myConnection.Dispose();
            this.dataGridView3.Rows.Clear();//удаление всей строчек
            LoadDataD();
            textBox3.Clear();
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            string del = "DELETE FROM dbo.AKT_DETALI WHERE Id_AKT_DET =" +  dataGridView3.CurrentRow.Cells[0].Value.ToString();

            SqlCommand com = new SqlCommand(del, myConnection);
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
            dataGridView3.Rows.Clear();
            LoadDataD();

            MessageBox.Show("Данные Удалены!");

            reader.Close();
            myConnection.Close();
            textBox3.Clear();
        }
    }
}
