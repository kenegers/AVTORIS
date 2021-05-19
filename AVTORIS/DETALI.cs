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
using Excel = Microsoft.Office.Interop.Excel;

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


            string qure = "SELECT DETALI.id_DT, DETALI.NAME, DETALI.PRICE_D FROM DETALI";
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
                    SqlCommand DETALI = new SqlCommand($"INSERT INTO [dbo].[DETALI] values (@NAME, @PRICE_D)", myConnection);

                    DETALI.Parameters.AddWithValue("@NAME", textBox2.Text);
                    DETALI.Parameters.AddWithValue("@PRICE_D", textBox3.Text);


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

            string upd = $"UPDATE[dbo].[DETALI] set [NAME] = '{textBox2.Text.ToString()}'," + $"[PRICE_D] = '{textBox3.Text.ToString()}' WHERE Id_DT = " + textBox1.Text;

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

        private void button6_Click(object sender, EventArgs e)
        {
            //Microsoft.Office.Interop.Excel.Application xlApp;
            Excel.Application xlApp = new Excel.Application();
            Microsoft.Office.Interop.Excel.Worksheet xlSheet;
            Microsoft.Office.Interop.Excel.Range xlSheetRange;
            Microsoft.Office.Interop.Excel.Range xlSheetRan;
            Microsoft.Office.Interop.Excel.Range worksheet_tb;
            Excel.Workbook workbook = xlApp.Workbooks.Open(@"C:\Users\ken\Desktop\авториз2\Прайс деталей.xlsx");//добавляем работы
            try
            {
                //делаем временно неактивным документ
                xlApp.Interactive = false;
                xlApp.EnableEvents = false;

                //выбираем лист на котором будем работать (Лист 1)
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);
                xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
                //Название листа
                xlSheet.Name = "Прайс деталей";

                //Выгрузка данных
                DataTable dt = GetData();
                // Заполняем дату
                Excel.Range dataCells = worksheet.get_Range("A1", "B1").Cells;  // Выделяем диапазон ячеек
                dataCells.Merge(Type.Missing);                                  // Производим объединение         
                dataCells.Value2 = "Дата создания : " + DateTime.Now.ToString("dd MMMM yyyy") + " г."; // Заполняем сегодняшней датой
                dataCells.Cells.Font.Name = "Tahoma";
                xlApp.StandardFontSize = 12;

                //выделяем строку заголовка
                dataCells = worksheet.get_Range("B2", "C2").Cells;  // Выделяем диапазон ячеек
                dataCells.Merge(Type.Missing);  // Производим объединение 
                worksheet.Cells[2, 2] = "Прайс деталей";

                //делаем полужирный текст и перенос слов
                xlSheetRan = xlSheet.get_Range("B2:C2:D2", Type.Missing);
                xlSheetRan.WrapText = true;
                xlSheetRan.Font.Bold = true;
                xlSheetRan.Cells.Font.Name = "Tahoma";

                //выделяем строку шапки таблицы
                xlSheetRange = xlSheet.get_Range("A4:C4", Type.Missing);
                //делаем полужирный текст и перенос слов
                xlSheetRange.WrapText = true;
                xlSheetRange.Font.Bold = true;
                xlSheetRange.Cells.Font.Name = "Times New Roman";

                // Вписываем заголовки столбцов
                worksheet.Cells[4, 1] = "№ детали";
                worksheet.Cells[4, 2] = "Название детали";
                worksheet.Cells[4, 3] = "Цена";

                int collInd = 0;
                int rowInd = 0;
                string data = "";
                //заполняем строки
                for (rowInd = 0; rowInd < dt.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dt.Columns.Count; collInd++)
                    {
                        data = dt.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet.Cells[rowInd + 5, collInd + 1] = data;
                    }
                }
                string i = Convert.ToString(rowInd + 4);
                //MessageBox.Show(i.ToString());

                //выбираем всю область данных
                xlSheetRange = xlSheet.UsedRange;
                // Количетсво строк до подписи
                int rowsCount = dataGridView1.Rows.Count + 6;
                // Подпись
                worksheet.Cells[rowsCount, 2] = "Подпись администратора: ";
                //рисуем рамочку
                worksheet_tb = worksheet.get_Range("A4", "C" + i);
                worksheet_tb.Borders.Color = System.Drawing.Color.Black.ToArgb();
                //Шрифт для диапазона
                worksheet_tb.Cells.Font.Name = "Times New Roman";
                //выравниваем строки и колонки по их содержимому
                xlSheetRange.Columns.AutoFit();
                xlSheetRange.Rows.AutoFit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //Показываем ексель
                xlApp.Visible = true;

                xlApp.Interactive = true;
                xlApp.ScreenUpdating = true;
                xlApp.UserControl = true;

                //Отсоединяемся от Excel
                releaseObject(xlApp);
            }
        }
        //Освобождаем ресурсы и отсоединяемся от ексель:
        void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show(ex.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                GC.Collect();
            }
        }
        private DataTable GetData()// методом, который будет выгружать данные из SQL в DataTable
        {
            SqlConnection con = new SqlConnection(connectString);
            DataTable dt = new DataTable();
            try
            {
                string query = @"SELECT DETALI.id_DT, DETALI.NAME, DETALI.PRICE_D FROM DETALI";
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
    }

        
 }


