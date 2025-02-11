using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class AuthorWin : Form
    {
        public AuthorWin()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(AutorWin_FormClosing);
        }

        void AutorWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private (string Login, string Password, string role)[] Users = new (string, string, string)[]
        {
            ("Admin", "Admin5$5", "admin"),
            ("Elena", "Sokolova32#", "user"),
            ("Oleg", "Volkov&27", "user")

        };
        string login;
        string password;
        int ban = 3;
        private void autorizating_Click(object sender, EventArgs e)
        {
            login = Convert.ToString(loginBox.Text);
            password = Convert.ToString(passwordBox.Text);
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Логин и пароль не должны быть пустыми!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                goto green;
            }
            foreach (var user in Users)
            {
                if (login == user.Login && password == user.Password)
                {
                    if (user.role == "admin")
                    {
                        AdminWin adm = new AdminWin();
                        adm.Show();
                        this.Hide();
                        goto green;
                    }
                    else
                    {
                        UserWin userWin = new UserWin();
                        userWin.Show();
                        this.Hide();
                        goto green;
                    }
                }
                else if (login == user.Login && password != user.Password)
                {
                    ban--;
                    if (ban == 2)
                    {
                        MessageBox.Show("Пароль введен неверно, осталось " + ban + " попытки до блокировки!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (ban == 1)
                    {
                        MessageBox.Show("Пароль введен неверно, осталась " + ban + " попытка до блокировки!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        loginBox.Enabled = false;
                        passwordBox.Enabled = false;
                        MessageBox.Show("Вы были заблокированы за чрезмерное количество неправильных попыток входа!\nОбратитесь к администратору.", "Нарушение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    goto green;
                }
            }
            MessageBox.Show("Такого логина не существует.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        green:;
        }

        private void loginBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                passwordBox.Focus();
            }
        }
        private void passwordBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                autorizating.Focus();
            }
        }
    }
}