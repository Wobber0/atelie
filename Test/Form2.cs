﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test
{
    public partial class UserWin : Form
    {

        public UserWin()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(UserWin_FormClosing);
        }
        void UserWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorWin autor = new AuthorWin();
            autor.Show();
            this.Hide();
        }

        private void InfoMenuItem_Click(object sender, EventArgs e)
        {
            Privet.Visible = false;
            pictureBox1.Visible = false;
            TaskGridView.Visible = false;
            panel1.Visible = true;
            SaveBut.Visible = false;
            info.Text = "Методы работы с тканями:\nНарезка: Важно правильно нарезать ткань, используя острые ножницы или специальный роликовый резак. Следует учитывать направление ворса (если есть) и выкройки.\nСтачивание: Соединение деталей осуществляется с помощью швейной машины или вручную. Важно использовать подходящую нить и настраивать натяжение для качественного шва.\r\nКройка: Использование разметки для последующего точного соединения деталей. Можно воспользоваться меловыми карандашами или специализированными маркерами.\nОбработка краев: Чтобы избежать осыпания тканей, края следует обрабатывать оверлоком, зигзагом или использовать специальные бейки.\nУстановка застежек: Установка молний, кнопок или пуговиц должна выполняться аккуратно, чтобы обеспечить долговечность и функциональность.\nУтюжка: После стирки или шитья важно правильно утюжить изделия, чтобы они обретали аккуратный вид. Разные ткани требуют разной температуры и режима.\nСоветы:\nПеред началом работы с новым материалом проведите тест на небольшом кусочке, чтобы выяснить, как ткань ведет себя при шитье и стирке.\nИспользуйте специальные иглы для различных тканей: для плотных материалов – иглы с острым концом, для тонких – иглы с закругленным концом.\nВсегда следите за состоянием швейной машины: чистите и смазывайте её, чтобы предотвратить поломки." +
                "\r\n\r\nТехника безопасности на рабочем месте:\n1. Общие рекомендации\nВладение инструментами: Прежде чем приступить к работе, обязательно ознакомьтесь с инструкциями по использованию всех инструментов и оборудования. Убедитесь, что вы знаете, как ими пользоваться правильно и безопасно.\nРабочая зона: Убедитесь, что рабочее место очищено от лишних предметов. Уберите все, что может привести к спотыканию или мешать вашей работе.\nОсвещение: Рабочая зона должна быть хорошо освещена. Это поможет избежать ошибок при работе с мелкими деталями и инструментами.\n2. Использование швейных машин\nПроверка оборудования: Перед началом работы проверьте швейную машину. Убедитесь, что все детали закреплены, а нить правильно заправлена.\nОсторожность с иглами: Иголки швейной машины очень острые. Избегайте дотрагиваться до них руками, особенно во время работы. При замене иглы используйте специальные инструменты.\nЗаведение ткани: Убедитесь, что ваша рука и другие части тела находятся достаточно далеко от движущихся частей машины. Всегда направляйте ткань к игле с помощью обеих рук, не зажимая материал слишком сильно.\n3. Работа с ножницами и резаками\nОстрые инструменты: Ножницы и резаки должны быть острыми. Тупые инструменты требуют больше усилий и увеличивают риск порезов. Храните их в безопасном месте, когда не используете.\nПравильный способ резки: При использовании ножниц держите их вертикально и избегайте резки вблизи тела. При работе с роликовым резаком используйте специальную матовую подложку для защиты поверхности.\r\n4. Работа с тканями и материалами\r\nПылевые аллергии: Если вы работаете с материалами, которые могут производить пыль (например, шерсть, хлопок), носите маску. Это защитит вас от аллергий и респираторных проблем.\r\nСтатическое электричество: Некоторые синтетические ткани могут накапливать статическое электричество. Используйте антистатические средства или шприц с водой для распыления после работы с такими материалами.\n5. ЭлектрооборудованиеnБезопасность проводов: Убедитесь, что шнуры и провода швейной машины не запутаны и не тронуты водой. Избегайте работы с оборудованием вблизи воды или в условиях высокой влажности.\nОтключение при обслуживании: При замене деталей, очищении машины или выполнении каких-либо работ по обслуживанию отключайте оборудование от сети.\n6. Здоровье и безопасность\nРегулярные перерывы: Чтобы избежать усталости и перенапряжения, делайте регулярные перерывы. Это поможет снизить риск возникновения травм, связанных с нагрузкой на спину, шею и руки.\nОборудование для эргономики: Подумайте о том, как организовать свое рабочее место. Используйте удобный стул и стол, чтобы минимизировать мышечное напряжение.";
            info.MaximumSize = new System.Drawing.Size(550, info.MaximumSize.Height);
        }

        private void MyTasksMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            TaskGridView.Visible = true;
            SaveBut.Visible = true;
            TaskGridView.ColumnCount = 4;
            TaskGridView.Columns[0].Name = "Задача";
            TaskGridView.Columns[1].Name = "Пожелания клиента";
            TaskGridView.Columns[2].Name = "Сроки выполнения";
            TaskGridView.Columns[3].Name = "Статус задачи";
            TaskGridView.Columns[0].ReadOnly = true;
            TaskGridView.Columns[1].ReadOnly = true;
            TaskGridView.Columns[2].ReadOnly = true;

            Random random = new Random();
            string[] tasks = { "Укоротить платье", "Изготовить новую юбку", "Заменить молнию на куртке" };
            string[] klientCom = { "Сделать длину до колена, без дополнительного подбора ткани", "Юбка должна быть в стиле «А-силуэт», из легкой ткани, с карманами", "Молния должна быть такого же цвета, с водоотталкивающей пропиткой" };
            string[] srok = { "3 дня", "1 неделя", "2 дня" };
            string[] status = { "Выполнено", "В процессе", "Запланировано на завтра" };
            TaskGridView.Rows.Clear();
            for (int i = 0; i < tasks.Length; i++)
            {
                TaskGridView.Rows.Add(tasks[i], klientCom[i], srok[i], status[i]);
            }
            TaskGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void SaveBut_Click(object sender, EventArgs e)
        {
            
    }
    }
}
