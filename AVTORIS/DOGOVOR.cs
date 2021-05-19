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

        private void button1_Click(object sender, EventArgs e)//добавть договор
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

        private void button5_Click(object sender, EventArgs e)// печть в ворд 
        {
            //Создаём объект документа
            Word.Document doc = null;
            try
            {
                // Создаём объект приложения
                Word.Application app = new Word.Application();
                // Путь до шаблона документа
                string source = @"C:\Users\ken\Desktop\авториз2\Ладья Договор.doc";
                // Открываем
                doc = app.Documents.Open(source);
                doc.Activate();

                // Добавляем информацию
                // wBookmarks содержит все закладки
                Word.Bookmarks wBookmarks = doc.Bookmarks;
                Word.Range wRange;
                int i = 0;
                var DATA_DV = dateTimePicker1.Text;
                //var b = dateTimePicker2.Text;
                var FIO = comboBox1.Text;
                // var d = textBox3.Text;
                string[] data = new string[2] { DATA_DV, FIO }; //формирование акта в документе
                foreach (Word.Bookmark mark in wBookmarks)
                {
                    wRange = mark.Range;
                    wRange.Text = data[i];
                    i++;
                }
                Console.WriteLine(i.ToString());
                // Закрываем документ
                doc.Close();
                doc = null;
            }
            catch (Exception ex)
            {
                // Если произошла ошибка, то
                // закрываем документ и выводим информацию
                doc.Close();
                doc = null;
                Console.WriteLine("Во время выполнения произошла ошибка!");
                Console.ReadLine();
            }
        }


        private void button3_Click(object sender, EventArgs e)//удал догов
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            string del = "DELETE FROM dbo.DOGOVOR WHERE id_DV =" + textBox1.Text;

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

        private void button2_Click(object sender, EventArgs e)//измен догов
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            if (myConnection.State == ConnectionState.Open)
            {
                SqlCommand ins = new SqlCommand($"update DOGOVOR set  [DATE_DV]='{dateTimePicker1.Value}'," +
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
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            myConnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form MENU = new MENU();
            MENU.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            string Pos = "SELECT DOGOVOR.id_DV, DOGOVOR.DATE_DV, KLIENT.FIO FROM DOGOVOR inner Join KLIENT" +
                " on DOGOVOR.id_KL = KLIENT.id_KL WHERE DOGOVOR.id_KL= (SELECT KLIENT.id_KL FROM KLIENT WHERE KLIENT.FIO='{textBox2.Text.ToString()})')";
            SqlCommand command = new SqlCommand(Pos, myConnection);
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)// перх на форму клиент
        {
            Form KLIENT = new KLIENT();
            KLIENT.Show();
            this.Hide();
        }
        private DataTable GetData()// метод, который будет выгружать данные из SQL в DataTable, для печати карточки читателя
        {
            SqlConnection con = new SqlConnection(connectString);
            DataTable dt = new DataTable();
            try
            {
                SqlCommand comm = new SqlCommand($"SELECT DOGOVOR.id_DV, DOGOVOR.DATE_DV, DOGOVOR.id_KL, KLIENT.FIO, KLIENT.N_PASP, KLIENT.SERIA_PASP, KLIENT.ADRES, KLIENT.TEL " +
                               $"FROM((DOGOVOR inner join KLIENT ON DOGOVOR.id_KL = KLIENT.id_KL ) " +
                               $"WHERE KLIENT.FIO = '{comboBox1.Text}'", con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dt;
        }

        private void button8_Click(object sender, EventArgs e)//перход на акт
        {
            Form AKT = new AKT();
            AKT.Show();
            this.Hide();
        }
        private DataTable GetData1()// методом, который будет выгружать данные из SQL в DataTable
        {
            SqlConnection con = new SqlConnection(connectString);
            DataTable dt = new DataTable();
            try
            {
                string query = @"SELECT DOGOVOR.id_DV, DOGOVOR.DATE.DV,  KLIENT.FIO, KLIENT.N_PASP, KLIENT.SERIA_PASP, KLIENT.ADRES, KLIENT.TEL  FROM DOGOVOR INNER JOIN KLIENT on KLIENT.id_KL = DOGOVOR.id_KL WHERE DOGOVOR-id_DV='{textBox2.Text.ToString()}'";
                SqlCommand comm = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dt;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form MENU = new MENU();
            MENU.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form SOTRUD = new SOTRUD();
            SOTRUD.Show();
            this.Hide();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
