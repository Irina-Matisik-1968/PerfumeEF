using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPerfumery
{
    public partial class Authorization : Form
    {
        user08Entities db;   //БД - глобально

        public Authorization()
        {
            InitializeComponent();
        }

        //Начальные установки и связь с БД
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0xFF, 0xFF, 0xFF);
            tableLayoutPanelMain.BackColor = Color.FromArgb(0xFF, 0xFF, 0xFF);
            tableLayoutPanelTop.BackColor = Color.FromArgb(188, 227, 131);
            db = new user08Entities();   //БД
        }

        /// <summary>
        /// Закрыть текущую форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Зайти неавторизованным гостем
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGuest_Click(object sender, EventArgs e)
        {
            //Helper.ClassHelper.RoleId = 0;
            //Helper.ClassHelper.CurrentRole = (Helper.SystemRoles)Helper.ClassHelper.RoleId;
            ////Helper.ClassHelper.CurrentRole = Helper.SystemRoles.Гость_неавторизированный;
            //MessageBox.Show("Вы зашли с ролью: " + Helper.ClassHelper.CurrentRole);
        }

        /// <summary>
        /// Вход в систему с авторизацией (разделяемое событие)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUser_Click(object sender, EventArgs e)
        {
            Button but = sender as Button;      //Идентификация кнопки
            if (but.Text == "Зайти гостем")
            {
                Helper.ClassHelper.RoleId = 0;  //Глобальный номер роли
                Helper.ClassHelper.FullName = "Без имени";  //Глобальное имя пользователя
            }
            else
            {
                //Поиск в БД по логину и паролю
                string login = textBoxLogin.Text;
                string password = textBoxPassword.Text;
                //Проверка заполнения данных для ввода
                if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Не все данные введены", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Поиск записи с введенными данными
                var user = db.Users.Where(x => x.Login == login && x.Password == password).ToList();
                if (user.Count == 0)        //Нет таких
                {
                    MessageBox.Show("Ваши данные не найдены", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var userOne = user.FirstOrDefault();    //Конкретная запись
                Helper.ClassHelper.RoleId = userOne.RoleId; //Сохраняем глобально роль и имя
                Helper.ClassHelper.FullName = userOne.FullName;
            }
            //Задаем текущую роль: 0 - для неавторизованного пользователя
            Helper.ClassHelper.CurrentRole = (Helper.SystemRoles)Helper.ClassHelper.RoleId;
            MessageBox.Show("Вы зашли с ролью: " + Helper.ClassHelper.CurrentRole);
            //Показать форму со списком товаров
            this.Hide();
            new ListProducts().ShowDialog();
            this.Show();
        }
    }
}
