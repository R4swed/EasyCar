using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Drawing;

namespace EasyCar
{
    public partial class AdminCatalog : Form
    {
        public AdminCatalog()
        {
            InitializeComponent();
        }

        DB db; // Объект для работы с базой данных

        #region Переходы на другие окна приложения
        // Переходы на окно данных пользователей
        private void ChangeUsersLabel_Click(object sender, EventArgs e)
        {
            Form fAdminUsers = new AdminUsers();
            fAdminUsers.Show();
            fAdminUsers.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }

        // Закрытие текущей формы
        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        // Переход на главное окно
        private void GeneralLabel_Click(object sender, EventArgs e)
        {
            Form fGeneral = new General();
            fGeneral.Show();
            fGeneral.FormClosed += new FormClosedEventHandler(form_FormClosed1);
            this.Hide();
        }

        // Закрытие текущей формы
        void form_FormClosed1(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Проверка заполнены ли поля для удаления машины из БД
        private void DeleteCarBtn_Click(object sender, EventArgs e)
        {
            string DeleteName = DeleteNameBox.Text;
            string DeletePrice = DeletePriceBox.Text;
            string DeleteYear = DeleteYearBox.Text;
            string DeleteVehicle = DeleteVehicleBox.Text;


            if (DeleteName != string.Empty
                && DeletePrice != string.Empty
                && DeleteYear != string.Empty
                && DeleteVehicle != string.Empty)
            {
                DeleteCar(DeleteName, DeletePrice, DeleteYear, DeleteVehicle);
            }
            else
                MessageBox.Show("Введите данные", "Удаление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
            #endregion

        #region Удаление машины из БД
            void DeleteCar(string Name, string Price, string Year, string Vehicle)
            {
                // Подключение к БД
                db = new DB();
                db.getConnection();

                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(db.connection))
                    {
                        SQLiteCommand command = connection.CreateCommand();
                        connection.Open();

                        int count = 0;
                        
                        // Команда для БД
                        string query = @"DELETE FROM cars WHERE name =
                            '" + Name + "' " +
                            "AND price='" + Price + "' " +
                            "AND Year = '" + Year + "' " +
                            "AND vehicle = '" + Vehicle + "'";
                        command.CommandText = query;
                        command.Connection = connection;

                        SQLiteDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            count--;
                        }
                        if (count == 0)
                        {
                            MessageBox.Show("Автомобиль удалён", "Удаление автомобиля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Не удалось удалить автомобиль", "Удаление автомобиля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Произошла неизвестная ошибка");
                }
            }
        }
        #endregion

        #region Проверка заполнены ли поля для добавления машины в БД
        private void AddCarBtn_Click(object sender, EventArgs e)
        {
            string AddName = AddNameBox.Text;
            string AddPrice = AddPriceBox.Text;
            string AddYear = AddYearBox.Text;
            string AddVehicle = AddVehicleBox.Text;

            if (!string.IsNullOrWhiteSpace(AddName) &&
                !string.IsNullOrWhiteSpace(AddPrice) &&
                !string.IsNullOrWhiteSpace(AddYear) &&
                !string.IsNullOrWhiteSpace(AddVehicle))
            {
                string imagePath = SelectImage(); // Выбор изображения
                AddCar(AddName, AddPrice, AddYear, AddVehicle, imagePath);
            }
            else
            {
                MessageBox.Show("Введите данные", "Добавление автомобиля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            #endregion

            #region Проверка есть ли машина с такими данными которые ввели в текстбоксы в БД
            void AddCar(string Name, string Price, string Year, string Vehicle, string imagePath)
            {
                // Проверка на существование автомобиля в базе
                db = new DB();
                db.getConnection();

                using (SQLiteConnection connection = new SQLiteConnection(db.connection))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand())
                    {
                        string query = @"SELECT COUNT(*) FROM cars WHERE name = @Name AND price = @Price AND year = @Year AND vehicle = @Vehicle";
                        command.CommandText = query;
                        command.Connection = connection;

                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Price", Price);
                        command.Parameters.AddWithValue("@Year", Year);
                        command.Parameters.AddWithValue("@Vehicle", Vehicle);

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Автомобиль с такими данными уже существует", "Добавление автомобиля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                // Вставка данных в базу
                InsertData(Name, Price, Year, Vehicle, imagePath);
            }
            #endregion

            #region Добавление машины в БД
            void InsertData(string Name, string Price, string Year, string Vehicle, string imagePath)
            {
                try
                {
                    // Преобразование и изменение размера изображения в массив байтов
                    byte[] imageBytes = null;
                    if (!string.IsNullOrWhiteSpace(imagePath))
                    {
                        imageBytes = ResizeImage(imagePath, 225, 130); // Изменение размера
                    }

                    using (SQLiteConnection connection = new SQLiteConnection(db.connection))
                    {
                        connection.Open();
                        using (SQLiteCommand command = new SQLiteCommand())
                        {
                            string query = @"INSERT INTO cars (name, price, year, vehicle, image) 
                                 VALUES (@Name, @Price, @Year, @Vehicle, @Image)";
                            command.CommandText = query;
                            command.Connection = connection;

                            command.Parameters.AddWithValue("@Name", Name);
                            command.Parameters.AddWithValue("@Price", Price);
                            command.Parameters.AddWithValue("@Year", Year);
                            command.Parameters.AddWithValue("@Vehicle", Vehicle);
                            command.Parameters.AddWithValue("@Image", (object)imageBytes ?? DBNull.Value);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Автомобиль добавлен с изображением", "Добавление автомобиля", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private byte[] ResizeImage(string imagePath, int width, int height)
        {
            using (Image originalImage = Image.FromFile(imagePath))
            {
                using (Bitmap resizedBitmap = new Bitmap(width, height))
                {
                    using (Graphics graphics = Graphics.FromImage(resizedBitmap))
                    {
                        graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                        graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                        // Рисуем изображение с новым размером
                        graphics.DrawImage(originalImage, 0, 0, width, height);
                    }

                    // Конвертируем изображение в массив байтов
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        resizedBitmap.Save(memoryStream, originalImage.RawFormat);
                        return memoryStream.ToArray();
                    }
                }
            }
        }

        private string SelectImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
                openFileDialog.Title = "Выберите изображение автомобиля";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName; // Возвращаем путь к выбранному изображению
                }
            }
            return null; // Если пользователь отменил выбор
        }
        #endregion

        #region Вывод списка всех машин в datagridview
        private void ShowCarsBtn_Click(object sender, EventArgs e)
        {

            // Подключение к БД
            db = new DB();
            db.getConnection();

            SQLiteConnection connection = new SQLiteConnection(db.connection);

            // Команда для БД
            string query = @"SELECT name, price, year, vehicle, image FROM cars";

            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);

            DataTable datatable = new DataTable();

            adapter.Fill(datatable);

            CarsCatalog.DataSource = datatable;

            // Настройка "внешнего вида" datagridview
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
        }
        #endregion
    }
}
