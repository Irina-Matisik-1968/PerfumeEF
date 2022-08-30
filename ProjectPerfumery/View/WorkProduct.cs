using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjectPerfumery
{
    //Форма для работы с отдельным товаром
    public partial class WorkProduct : Form
    {
        //Глабальные объекты: БД и таблица товароров
        user08Entities db;
        Perfumery perfumery;
        string pathExe = Application.StartupPath;   //Путь до exe для фото
        string fileName;        //Только имя фото
        int idProduct;      //Id переданного продукта или 0
        public WorkProduct()
        {
            InitializeComponent();
        }
        //Конструктор с переданным Id товара или 0
        public WorkProduct(int idProduct)
        {
            InitializeComponent();
            this.idProduct = idProduct;     //Заполнить глобальный объект
        }

        //Вывод информацию о продукте
        private void ShowProduct()
        {
            //Настройка ComoBox для категорий товаров
            List<Categoty> categoties = db.Categoties.ToList();     //Список категорий товаров
            comboBoxCat.DataSource = categoties;
            comboBoxCat.DisplayMember = "Title";
            comboBoxCat.ValueMember = "Id";
            if (idProduct == 0)     //При добавлении
                {
                textBoxiD.Text = textBoxDisc.Text = "";
                textBoxCost.Text = textBoxDiscont.Text = textBoxCount.Text = "0";
                textBoxiD.Visible = false;
                labelId.Visible = false;
                buttonDelete.Visible = false;
                perfumery = new Perfumery();        //Создать пустой объект, т.к. добавление
            }
            else          //При редактировании
            {
                buttonDelete.Visible = true;
                //Найти объект- товар по его Id
                perfumery = db.Perfumeries.ToList().First(x => x.Id == idProduct);
                //Заполнение полей о найденном товаре из БД
                textBoxiD.Text = perfumery.Id.ToString();
                textBoxiD.Enabled = false;
                textBoxDisc.Text = perfumery.Description;
                comboBoxCat.SelectedValue = perfumery.Categoty.Id;
                textBoxCost.Text = perfumery.Cost.ToString();
                textBoxDiscont.Text = perfumery.Discount.ToString();
                textBoxCount.Text = perfumery.Count.ToString();
                fileName = perfumery.Photo;
                //Работа с фото
                if (String.IsNullOrEmpty(perfumery.Photo))
                {
                    pictureBoxPhoto.Image = Properties.Resources.Empty;
                }
                else
                {
                    string s = pathExe + @"\Photos\" + perfumery.Photo;
                    if (!File.Exists(s))
                    {
                        pictureBoxPhoto.Image = Properties.Resources.Empty;
                    }
                    else
                    {
                        pictureBoxPhoto.Load(s);
                    }
                }
            }
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
        /// Выбор фото
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectPhoto_Click(object sender, EventArgs e)
        {
            if(openFileDialogPhoto.ShowDialog()==DialogResult.OK)
            {
                fileName = openFileDialogPhoto.SafeFileName;
                pictureBoxPhoto.Load(openFileDialogPhoto.FileName);
            }
        }

        /// <summary>
        /// При открытии формы настройки компонентов и БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorkProduct_Shown(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0xFF, 0xFF, 0xFF);
            tableLayoutPanelMain.BackColor = Color.FromArgb(0xFF, 0xFF, 0xFF);
            tableLayoutPanelTop.BackColor = Color.FromArgb(188, 227, 131);
            tableLayoutPanelBottom.BackColor = Color.FromArgb(188, 227, 131);
            openFileDialogPhoto.InitialDirectory = pathExe + @"\Photos";
            openFileDialogPhoto.Filter = "JPG|*.jpg";
            db = new user08Entities();
            ShowProduct();      //Отобразить
        }

        /// <summary>
        /// Фиксировать изменения в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFixedDB_Click(object sender, EventArgs e)
        {
            //Заполнить поля объекта значениями
            perfumery.CategoryId = (int)comboBoxCat.SelectedValue;
            perfumery.Cost = Convert.ToInt32(textBoxCost.Text);
            perfumery.Count = Convert.ToInt32(textBoxCount.Text);
            perfumery.Description = textBoxDisc.Text;
            perfumery.Discount = Convert.ToInt32(textBoxDiscont.Text);
            perfumery.Photo = fileName;
            if (idProduct == 0)     //Добавление. Для редактирования достаточно заполнить поля
            {
                db.Perfumeries.Add(perfumery);
            }
            try            //Контроль успешности записи в БД
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Возникли проблемы при обновлении БД");
                this.Close();
                return;
            }
            MessageBox.Show("Изменения внесены в БД");
            this.Close();
        }

        /// <summary>
        /// Удать товар
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            db.Perfumeries.Remove(perfumery);   //Удалить
            try               //Контроль над удалением
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Нельзя удалить данный товар");
                this.Close();
                return;
            }
            MessageBox.Show("Товар удален из БД");
            this.Close();
        }
    }
}
