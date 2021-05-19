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
    public partial class SOTRUD : Form
    {
        public SOTRUD()
        {
            InitializeComponent();
            LoadData();
        }
        string connectString = @"Data Source=DESKTOP-50S9T00;Initial Catalog=Ladea;Integrated Security=True";
        private void LoadData()
        {
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            string qure = "SELECT SOTR.id_S, SOTR.FIO, SOTR.DOLG, SOTR.LOGI, SOTR.PAR FROM SOTR";
            SqlCommand command = new SqlCommand(qure, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }
            reader.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                if (myConnection.State == ConnectionState.Open)
                {
                    SqlCommand SOTR = new SqlCommand($"INSERT INTO [dbo].[SOTR] values (@FIO, @DOLG, @LOGI, @PAR)", myConnection);

                    SOTR.Parameters.AddWithValue("@FIO", textBox2.Text);
                    SOTR.Parameters.AddWithValue("@DOLG", textBox3.Text);
                    SOTR.Parameters.AddWithValue("@LOGI", textBox4.Text);
                    SOTR.Parameters.AddWithValue("@PAR", textBox5.Text);

                    SOTR.ExecuteNonQuery();
                    MessageBox.Show("Сотрудник Добавлен!");
                    dataGridView1.Rows.Clear();
                    LoadData();
                    myConnection.Close();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Проверте заполнение!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();

            string upd = $"UPDATE[dbo].[SOTR] set [FIO] = '{textBox2.Text.ToString()}'," + $"[DOLG] = '{textBox3.Text.ToString()}'," + $"[LOGI] = '{textBox4.Text.ToString()}'," + $"[PAR] ='{textBox5.Text.ToString()}' WHERE Id_S= " + textBox1.Text;

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
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            string ins = "DELETE FROM SOTR WHERE Id_S=" + textBox1.Text;

            SqlCommand com = new SqlCommand(ins, myConnection);
            SqlDataReader reader = com.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
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
            textBox4.Clear();
            textBox5.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form MENU = new MENU();
            MENU.Show();
            this.Hide();
        }

        private void SOTRUD_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Microsoft.Office.Interop.Excel.Application xlApp;
            Excel.Application xlApp = new Excel.Application();
            Microsoft.Office.Interop.Excel.Worksheet xlSheet;
            Microsoft.Office.Interop.Excel.Range xlSheetRange;
            Microsoft.Office.Interop.Excel.Range xlSheetRan;
            Microsoft.Office.Interop.Excel.Range worksheet_tb;
            Excel.Workbook workbook = xlApp.Workbooks.Open(@"C:\Users\ken\Desktop\авториз2\Список сотрудников.xlsx");//добавляем работы
            try
            {
                //делаем временно неактивным документ
                xlApp.Interactive = false;
                xlApp.EnableEvents = false;

                //выбираем лист на котором будем работать (Лист 1)
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);
                xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
                //Название листа
                xlSheet.Name = "Список сотрудников";

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
                worksheet.Cells[2, 2] = "Список сотрудников";

                //делаем полужирный текст и перенос слов
                xlSheetRan = xlSheet.get_Range("B2:C2:D2:E2:F2", Type.Missing);
                xlSheetRan.WrapText = true;
                xlSheetRan.Font.Bold = true;
                xlSheetRan.Cells.Font.Name = "Tahoma";

                //выделяем строку шапки таблицы
                xlSheetRange = xlSheet.get_Range("A4:F4", Type.Missing);
                //делаем полужирный текст и перенос слов
                xlSheetRange.WrapText = true;
                xlSheetRange.Font.Bold = true;
                xlSheetRange.Cells.Font.Name = "Times New Roman";

                // Вписываем заголовки столбцов
                worksheet.Cells[4, 1] = "Номер сотрудника";
                worksheet.Cells[4, 2] = "Фамилия Имя Отчество";
                worksheet.Cells[4, 3] = "Должность";
                worksheet.Cells[4, 4] = "Логин";
                worksheet.Cells[4, 5] = "Пароль";

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
                worksheet_tb = worksheet.get_Range("A4", "E" + i);
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
                string query = @"SELECT SOTR.id_S, SOTR.FIO, SOTR.DOLG,SOTR.LOGI,SOTR.PAR FROM SOTR";
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
