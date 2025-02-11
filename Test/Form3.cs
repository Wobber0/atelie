using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Test
{
    public partial class AdminWin : Form
    {
        public AdminWin()
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(AdminWin_FormClosing);
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void AdminWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorWin autor = new AuthorWin();
            autor.Show();
            this.Hide();
        }

        private void UsersMenuItem_Click(object sender, EventArgs e)
        {
            Privet.Visible = false;
            pictureBox1.Visible = false;
            BDGridVew.Visible = true;
            SaveBut.Visible = true;
            ReportZone.Visible = false;
            SaveBut.Text = "Сохранить изменения";

            BDGridVew.ColumnCount = 3;
            BDGridVew.Columns[0].Name = "Логин";
            BDGridVew.Columns[1].Name = "Пароль";
            BDGridVew.Columns[2].Name = "Роль";
            
            BDGridVew.Rows.Clear();
            string[] login = { "Admin", "Elena", "Oleg" };
            string[] password = { "Admin5$5", "Sokolova32#", "Volkov&27" };
            string[] role = { "admin", "user", "user" };
            BDGridVew.Rows.Clear();
            for (int i = 0; i < login.Length; i++)
            {
                BDGridVew.Rows.Add(login[i], password[i], role[i]);
            }
            BDGridVew.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        private void OrdersMenuItem_Click(object sender, EventArgs e)
        {
            Privet.Visible = false;
            pictureBox1.Visible = false;
            BDGridVew.Visible = true;
            SaveBut.Visible = true;
            ReportZone.Visible = false;
            SaveBut.Text = "Сохранить изменения";

            BDGridVew.ColumnCount = 6;
            BDGridVew.Columns[0].Name = "ID заказа";
            BDGridVew.Columns[1].Name = "ID клиента";
            BDGridVew.Columns[2].Name = "Дата заказа";
            BDGridVew.Columns[3].Name = "Услуга";
            BDGridVew.Columns[4].Name = "Статус";
            BDGridVew.Columns[5].Name = "Сумма";

            Random random = new Random();
            string[] id = { "1", "2", "3", "4" };
            string[] idcust = { "1", "2", "1", "3" };
            string[] data = { "2024-07-01", "2024-07-03", "2024-07-05", "2024-07-07" };
            string[] servise = { "Пошив платья", "Ремонт куртки", "Устранение дефектов", "Пошив костюма" };
            string[] status = { "Завершен", "В процессе", "Запланирован", "В процессе" };
            string[] price = { "5000 рублей", "1500 рублей", "1000 рублей", "8000 рублей" };
            BDGridVew.Rows.Clear();
            for (int i = 0; i < id.Length; i++)
            {
                BDGridVew.Rows.Add(id[i],idcust[i], data[i], servise[i], status[i], price[i]);
            }
            BDGridVew.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        private void CustsMenuItem_Click(object sender, EventArgs e)
        {
            Privet.Visible = false;
            pictureBox1.Visible = false;
            BDGridVew.Visible = true;
            SaveBut.Visible = true;
            ReportZone.Visible = false;
            SaveBut.Text = "Сохранить изменения";

            BDGridVew.ColumnCount = 5;
            BDGridVew.Columns[0].Name = "ID Клиента";
            BDGridVew.Columns[1].Name = "Фамилия";
            BDGridVew.Columns[2].Name = "Имя";
            BDGridVew.Columns[3].Name = "Телефон";
            BDGridVew.Columns[4].Name = "Email";

            Random random = new Random();
            string[] id = { "1", "2", "3", "4" };
            string[] lastname = { "Иванов", "Петрова", "Сидоров", "Смирнова" };
            string[] firstname = { "Алексей", "Мария", "Сергей", "Ольга" };
            string[] phonenumber = { "+7(999) 123 - 45 - 67", "+7(999) 234 - 56 - 78", "+7(999) 456 - 78 - 90", "+7(999) 456 - 78 - 90" };
            string[] mail = { "ivanov @example.com", "petrova @example.com", " sidorov @example.com", "smirnova @example.com" };
            BDGridVew.Rows.Clear();
            for (int i = 0; i < id.Length; i++)
            {
                BDGridVew.Rows.Add(id[i], lastname[i], firstname[i], phonenumber[i], mail[i]);
            }
            BDGridVew.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        private void ServicesMenuItem_Click(object sender, EventArgs e)
        {
            Privet.Visible = false;
            pictureBox1.Visible = false;
            BDGridVew.Visible = true;
            SaveBut.Visible = true;
            ReportZone.Visible = false;
            SaveBut.Text = "Сохранить изменения";

            BDGridVew.ColumnCount = 4;
            BDGridVew.Columns[0].Name = "ID услуги";
            BDGridVew.Columns[1].Name = "Название услуги";
            BDGridVew.Columns[2].Name = "Описание";
            BDGridVew.Columns[3].Name = "Цена";

            BDGridVew.Rows.Clear();

            BDGridVew.Rows.Add(1, "Пошив платья", "Индивидуальный пошив платья по размеру", "5000 RUB");
            BDGridVew.Rows.Add(2, "Ремонт куртки", "Замена молнии и подкладки", "1500 RUB");
            BDGridVew.Rows.Add(3, "Устранение дефектов", "Исправление швов и дефектов", "1000 RUB");
            BDGridVew.Rows.Add(4, "Пошив костюма", "Индивидуальный пошив мужского костюма", "8000 RUB");

            BDGridVew.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        bool flag = true;
        double power = 8;
        private void тестикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Privet.Visible = false;
            pictureBox1.Visible = false;
            BDGridVew.Visible = true;
            SaveBut.Visible = true;
            ReportZone.Visible = false;
            SaveBut.Text = "stop";
            double max = 10;
            double step = 0.1;
            BDGridVew.ColumnCount = 2;
            BDGridVew.Columns[0].Name = "максимум";
            BDGridVew.Columns[1].Name = "значение";

            while (flag)
            {
                if (power > max)
                {
                }
                else
                {
                    power += step;
                }
                    BDGridVew.Rows.Clear();

                BDGridVew.Rows.Add(max, power);

                System.Windows.Forms.Application.DoEvents(); // помогает не ложить прогу циклом 
            }
        }
        private void ReportMenuItem_Click(object sender, EventArgs e)
        {
            BDGridVew.Visible=false;
            Privet.Visible = false;
            pictureBox1.Visible = false;
            ReportZone.Visible = true;
            SaveBut.Visible = true;
            Report.Visible = true ;
            SaveBut.Text = "Сохранить в отдельный документ";
            Report.MaximumSize = new System.Drawing.Size(520, Report.MaximumSize.Height);
        }

        private void SaveBut_Click(object sender, EventArgs e)
        {
            if(SaveBut.Text == "stop")
            {
                flag = false;
            }

             if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                 return;
             // получаем выбранный файл
             string filename = saveFileDialog1.FileName;
             // сохраняем текст в файл
             System.IO.File.WriteAllText(filename, Report.Text);

            MessageBox.Show("Отчет был успешно сохранен!", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Worksheet xlsht = new Microsoft.Office.Interop.Excel.Worksheet();
            string path = @"C:\Users\Admin\Desktop\aaa.xlsx";
            xlsht = xlApp.Application.Workbooks.Open(path).Worksheets[1];
            int iLastRow = xlsht.Cells[xlsht.Rows.Count, "A"].End[Microsoft.Office.Interop.Excel.XlDirection.xlUp].Row;
            for (int i = 0; i < BDGridVew.RowCount; i++)
            {
                iLastRow += 1;
                for (int j = 0; j < BDGridVew.ColumnCount; j++)
                {
                    if (BDGridVew[j, i].ValueType == typeof(string))
                    {
                        xlsht.Cells[iLastRow, j + 1] = BDGridVew[j, i].Value;
                    }
                    else
                    {
                        xlsht.Cells[iLastRow, j + 1] = BDGridVew[j, i].Value;
                        xlsht.Cells[1, 1].CurrentRegion.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    }
                }
            }
            xlApp.DisplayAlerts = false;
            string fileTest = "C:\\Users\\Admin\\Desktop\\aaa.xlsx";
            xlsht.SaveAs(fileTest);
            xlApp.Quit();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            power = Convert.ToDouble(textBox1.Text);
        }

        /*// Создание экземпляра приложения Excel
Excel.Application excelApp = new Excel.Application();
excelApp.Visible = true;  // Установите true, если хотите видеть Excel

// Создание новой книги
Excel.Workbook workbook = excelApp.Workbooks.Add();
Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

// Получение количества строк и столбцов из DataGridView
int rowCount = BDGridVew.Rows.Count;
   int colCount = BDGridVew.Columns.Count;

   // Цикл по столбцам для добавления заголовков
   for (int i = 0; i < colCount; i++)
   {
   worksheet.Cells[1, i + 1].Value = BDGridVew.Columns[i].HeaderText; // Заголовки
   }

   // Цикл по строкам и столбцам для добавления данных
   for (int i = 0; i < rowCount; i++)
   {
       for (int j = 0; j < colCount; j++)
       {
       worksheet.Cells[i + 2, j + 1].Value = BDGridVew.Rows[i].Cells[j].Value; // Данные
       }
   }

// Сохранение файла
string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "AAAAA.xlsx");
workbook.SaveAs(filePath);
workbook.Close();
excelApp.Quit();
System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
MessageBox.Show("Данные успешно сохранены в файл Excel." +  filePath, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

*/
    }
    }