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
    //Форма отображения списка товаров
    public partial class ListProducts : Form
    {
        //Глобальные величины
        string pathExe = Application.StartupPath;   //Путь к exe без имени файла
        int sort, filter;       //Для выбранных сортировки и поиска
        int countAll, countFilter;  //Количество всех записей и после фильтрации
        string search;      //Строка поиска

        public ListProducts()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод для отображения текущих данных из БД
        /// Направление сортировки, значение фильтра, строка поиска
        /// </summary>
        private void ShowListPerfumeries(int sort, int filter, string search)
        {
            dataGridViewProduct.Rows.Clear();       //Очистить таблицу
            user08Entities db = new user08Entities();   //Создать БД
            List<Perfumery> products = db.Perfumeries.ToList(); //Получить все записи
            countAll = products.Count;      //Их количество
            //Список отсортирован по нужному направлению
            if (sort == 0)
            {
                products = products.OrderBy(x => x.Cost).ToList();  //По возрастания поля Cost
            }
            else
            {
                products = products.OrderByDescending(x => x.Cost).ToList();//По убыванию поля Cost
            }
            //Выбрать отфильтрованные данные по скидке (диапазон значений)
            switch (filter)
            {
                case 1:
                    products = products.Where(x => x.Discount >= 0 && x.Discount <= 1).ToList();
                    break;
                case 2:
                    products = products.Where(x => x.Discount >= 2 && x.Discount <= 3).ToList();
                    break;
                case 3:
                    products = products.Where(x => x.Discount > 3).ToList();
                    break;
            }
            //Поиск по названию (дополнительно)
            products = products.Where(x => x.Description.Contains(search)).ToList();
            countFilter = products.Count;       //Количество отфильтрованных записей
            //Отображение данных
            int i = -1;         //Номер строки таблицы
            foreach (var product in products)           //По всем отобранным записям
            {
                dataGridViewProduct.Rows.Add();         //Для записи добавить отдельную строку
                i++;                    //Номер следующей
                this.dataGridViewProduct.Rows[i].Cells[0].Value = product.Id;   //Невидимый Id
                //Работа с фото
                if (String.IsNullOrEmpty(product.Photo))        //проверка пустоты поля с фото
                {
                    ColumnPhoto.Image = Properties.Resources.Empty; //Картинку из ресурсов
                }
                else                        //Поле с картинкой не пустое
                {
                    string s = pathExe + @"\Photos\" + product.Photo;   //Полный путь к картинке
                    if (!File.Exists(s))            //Проверка существования файла с фото
                    {
                        ColumnPhoto.Image = Properties.Resources.Empty; //Не нашли файл - загрузка из ресурса
                    }
                    else
                    {
                        this.dataGridViewProduct.Rows[i].Cells[1].Value = new Bitmap(s);       //Загрузка файла
                    }
                }
                //Работа с описанием товара - строка из нескольких строк
                string dics = "";
                dics += "Описание: " + product.Description + Environment.NewLine;
                dics += "Категория: " + product.Categoty.Title + Environment.NewLine;
                dics += "Цена без скидки: " + product.Cost + Environment.NewLine;
                //Расчет стоимости товара со скидкой
                if (product.Discount > 0)
                {
                    dics += "Скидка: " + product.Discount + "%" + Environment.NewLine;
                    dics += "Цена со скидкой: " + (int)product.Cost * product.Discount / 100.0;
                }
                this.dataGridViewProduct.Rows[i].Cells[2].Value = dics; //Отобразить поле описания
                //Подготовить таблицу для отображения
                this.dataGridViewProduct.Rows[i].MinimumHeight = 120;
                this.dataGridViewProduct.Rows[i].Height = 120;
                //Для переноса слов в ячейках таблицы надо AutoSizeRowsMode установить в AllCells, потом зайти в RowsDefaultCellStyle и установить WrapMode в положение True
                //Задание цвета для строк при заданных условиях
                if (product.Discount > 3)
                {
                    this.dataGridViewProduct.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(0x7F, 0xFF, 0x00);
                }
                else
                {
                    this.dataGridViewProduct.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(0xFF, 0xFF, 0xFF);
                }
            }
            labelCount.Text = countFilter + @"/" + countAll;    //вывод строки сколичеством
        }

        /// <summary>
        /// При активизации формы - начальные настройки для вывода списка товаров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListProducts_Activated(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0xFF, 0xFF, 0xFF);      //Цвет формы
            tableLayoutPanelTop.BackColor = Color.FromArgb(188, 227, 131);  //Цвет верхней панели

            labelFulName.Text = Helper.ClassHelper.FullName;        //Вывод полного имени
            dataGridViewProduct.AllowUserToAddRows = false;      //Нельзя пользователю менять число строк
            ColumnPhoto.MinimumWidth = 100;
            ColumnDisc.MinimumWidth = 400;
            //Видимость кнопки "Редактировать" в таблице для каждого режима 
            if (Helper.ClassHelper.CurrentRole == Helper.SystemRoles.Гость_неавторизированный || Helper.ClassHelper.CurrentRole == Helper.SystemRoles.Гость_авторизированный)
            {
                ColumnButton.Visible = false;
            }
            else
            {
                ColumnButton.Visible = true;
            }
            //Начальные установки для фильтрации, поиска и сортировки
            sort = 0;
            filter = 0;
            search = "";
            comboBoxSort.SelectedIndex = 0;
            comboBoxFilter.SelectedIndex = 0;
            textBoxSearch.Text = "";
            ShowListPerfumeries(sort, filter, search);
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
        /// Выбор направления сортировки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            sort = comboBoxSort.SelectedIndex;      //Направление
            ShowListPerfumeries(sort, filter, search);  //Отобразить
        }

        /// <summary>
        /// Поиск по Описанию товара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            search = textBoxSearch.Text;        //Строка поиска
            ShowListPerfumeries(sort, filter, search);  //Отображение
        }
        
        /// <summary>
        /// Выбор направления сортировки диапазона по скидке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter = comboBoxFilter.SelectedIndex;      //Номер фильтра из списка
            ShowListPerfumeries(sort, filter, search);  //Отображение
        }

        /// <summary>
        /// Щелчок по любой части ячейки - для кнопок редактирования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idProduct;          //Id выбранного продукта
            if (e.ColumnIndex == 3) //Щелчок в 4-ом столбце
            {
                idProduct = (int)dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value;   //Id товара
                //Перейти на форму для отдельного товара и передать номер товара
                this.Hide();
                new WorkProduct(idProduct).ShowDialog();
                this.Show();
            }
        }

        /// <summary>
        /// Добавить новый товар
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Перейти на форму для отдельного товара и передать 0 - отсутствие товара в случае добавления
            this.Hide();
            new WorkProduct(0).ShowDialog();
            this.Show();
        }
    }
}
