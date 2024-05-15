using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace EasyCar
{
    public partial class Catalog : Form
    {
        public Catalog()
        {
            InitializeComponent();
        }

        DB db;  // Объект для работы с базой данных

        #region Переходы на другие окна приложения

        // Переход на главное окно
        private void GeneralLabel_Click(object sender, EventArgs e)
        {
            Form fGeneral = new General();
            fGeneral.Show();
            fGeneral.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }

        // Закрытие формы
        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        // Переход на окно контактов
        private void Contacts_Click(object sender, EventArgs e)
        {
            Form fContacts = new Contacs();
            fContacts.Show();
            fContacts.FormClosed += new FormClosedEventHandler(form_FormClosed1);
            this.Hide();
        }

        // Закрытие формы
        void form_FormClosed1(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        // Переход на окно информации о компании
        private void About_Click(object sender, EventArgs e)
        {
            Form fAbout = new About();
            fAbout.Show();
            fAbout.FormClosed += new FormClosedEventHandler(form_FormClosed2);
            this.Hide();
        }

        // Закрытие формы
        void form_FormClosed2(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        // Переход на окно авторизации
        private void Loginimg_Click(object sender, EventArgs e)
        {
            Form fAuth = new Auth();
            fAuth.Show();
            fAuth.FormClosed += new FormClosedEventHandler(form_FormClosed3);
            this.Hide();
        }

        // Закрытие формы
        void form_FormClosed3(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Вывод данных о машинах в datagridview
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Подключение к БД
            db = new DB();
            db.getConnection();

            // Проверка выбраны ли фильтры в комбобоксах
            if (PriceBox.SelectedItem == null
                || VehicleBox.SelectedItem == null
                || YearBox.SelectedItem == null
                    )
            {
                MessageBox.Show("Выберите фильтры", "Каталог", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
            else
            {
            string Price = PriceBox.SelectedItem.ToString();
            string Vehicle = VehicleBox.SelectedItem.ToString();
            string Year = YearBox.SelectedItem.ToString();

            string[] Prices = Price.Split(new char[] { '-' });
            string[] Vehicles = Vehicle.Split(new char[] { '-' });
            string[] Years = Year.Split(new char[] { '-' });

            int MinPrice = int.Parse(Prices[0].Trim());
            int MaxPrice = int.Parse((Prices[1].Trim()));
            int MinVehicle = int.Parse(Vehicles[0].Trim());
            int MaxVehicle = int.Parse((Vehicles[1].Trim()));
            int MinYear = int.Parse(Years[0].Trim());
            int MaxYear = int.Parse((Years[1].Trim()));

            // Команда для БД
            string query = $"SELECT name, price, vehicle, year, image FROM cars " +
                    $"WHERE price >= {MinPrice} "+
                    $"AND price <= {MaxPrice} " +
                    $"AND vehicle >= {MinVehicle} " +
                    $"AND vehicle <= {MaxVehicle} " +
                    $"AND year >= {MinYear} " +
                    $"AND year <= {MaxYear}";
                     
            using (SQLiteConnection connection = new SQLiteConnection(db.connection))
            {
                 using (SQLiteCommand command = new SQLiteCommand(query, connection))
                 {

                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            CarsCatalog.DataSource = dataTable;

                            // Настройка "внешнего вида" таблицы
                            CarsCatalog.Columns["name"].HeaderText = "Название";
                            CarsCatalog.Columns["price"].HeaderText = "Цена";
                            CarsCatalog.Columns["year"].HeaderText = "Год выпуска";
                            CarsCatalog.Columns["vehicle"].HeaderText = "Пробег";
                            CarsCatalog.Columns["image"].HeaderText = "Фото автомобиля";
                            CarsCatalog.Columns["image"].Width = 225;

                            CarsCatalog.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                            CarsCatalog.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                            CarsCatalog.AllowUserToAddRows = false;
                            CarsCatalog.RowHeadersVisible = false;
                            CarsCatalog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            CarsCatalog.MultiSelect = false;


                            // Провека есть ли машины с такими данными в БД
                            if (CarsCatalog.Rows.Count > 0)
                            {

                                foreach (DataGridViewRow row in CarsCatalog.Rows)
                                {
                                    DataGridViewImageCell cell = new DataGridViewImageCell();
                                    row.Cells["image"] = cell;
                                }
                            }
                            else
                                MessageBox.Show("Автомобили не найдены", "Каталог", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                 }
            }
            }
        }
        #endregion

        #region Отправка данных из строки в datagridview в форму Cars
        private void CarsCatalog_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CarsCatalog.Rows[e.RowIndex];

                Image image = null;
                if (row.Cells["image"].Value != null)
                {
                    byte[] imageBytes = (byte[])row.Cells["image"].Value;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        image = Image.FromStream(ms);
                    }
                }

                Cars CarForm = new Cars(
                    row.Cells["name"].Value.ToString(),
                    row.Cells["year"].Value.ToString(),  
                    row.Cells["vehicle"].Value.ToString(),
                    row.Cells["price"].Value.ToString(),
                    (byte[])row.Cells["image"].Value
                    );

                CarForm.ShowDialog();
            }
        }
        #endregion
    }
}
