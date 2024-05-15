using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Threading;

namespace EasyCar
{
    public partial class mdk : Form
    {
        public mdk()
        {
            InitializeComponent();
        }

        DB db;

        private void AutoTestAddClient_Click(object sender, EventArgs e)
        {
            db = new DB();
            db.getConnection();

            string emailuser = "aboba";
            string phoneuser = "124215";
            string passworduser = "532355353";
            string roleuser = "admin";

            using (SQLiteConnection connection = new SQLiteConnection(db.connection))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();
                
                string query = @"INSERT INTO users(email, password, phone, role) 
                                    VALUES(@email, @password, @phone, @Role)";
                command.CommandText = query;
                command.Connection = connection;
                command.Parameters.Add(new SQLiteParameter("@email", emailuser));
                command.Parameters.Add(new SQLiteParameter("@password", passworduser));
                command.Parameters.Add(new SQLiteParameter("@phone", phoneuser));
                command.Parameters.Add(new SQLiteParameter("@Role", roleuser));
                command.ExecuteNonQuery();

                MessageBox.Show("Пользователь добавлен", "Добавление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void AutoTestShowClient_Click(object sender, EventArgs e)
        {
            db = new DB();
            db.getConnection();

            string emailuser = "admin";
            string passworduser = "admin";

            using (SQLiteConnection connection = new SQLiteConnection(db.connection))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();

                string query = @"SELECT * FROM users WHERE email = @email and password = @password";
                command.CommandText = query;
                command.Connection = connection;
                command.Parameters.Add(new SQLiteParameter("@email", emailuser));
                command.Parameters.Add(new SQLiteParameter("@password", passworduser));
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    label1.Text = string.Format("id:{0}, email:{1}, phone:{2}, password:{3}, role:{4}", reader["id"], reader["email"], reader["phone"], reader["password"], reader["role"]);
                }
            }
        }

        private void AutoTestDeleteUser_Click(object sender, EventArgs e)
        { 
            // Подключение к БД
            db = new DB();
            db.getConnection();

            string emailuser = "aboba";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(db.connection))
                {
                    SQLiteCommand command = connection.CreateCommand();
                    connection.Open();

                    int count = 0;
                    // Команда для БД
                    string query = @"DELETE FROM users WHERE email =
                                        '" + emailuser + "'";
                    command.CommandText = query;
                    command.Connection = connection;

                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        count--;
                    }
                    if (count == 0)
                    {
                        MessageBox.Show("Пользовтаель удалён", "Удаление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Не удалось удалить пользователя", "Удаление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Произошла неизветсная ошибка");
            }
        }

        private void AutoTestShowCar_Click(object sender, EventArgs e)
        {
            // Подключение к БД
            db = new DB();
            db.getConnection();

            SQLiteConnection connection = new SQLiteConnection(db.connection);

            // Команда для БД
            string query = @"SELECT name, price, year, vehicle, image FROM cars WHERE name = 'Nissan Skyline R34' ";

            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);

            DataTable datatable = new DataTable();

            adapter.Fill(datatable);

            CarView.DataSource = datatable;


            // Настройка "внешнего вида" datagridview
            CarView.Columns["name"].HeaderText = "Название";
            CarView.Columns["price"].HeaderText = "Цена";
            CarView.Columns["year"].HeaderText = "Год выпуска";
            CarView.Columns["vehicle"].HeaderText = "Пробег";
            CarView.Columns["image"].HeaderText = "Фото";
            CarView.Columns["image"].Width = 225;

            CarView.AllowUserToAddRows = false;
            CarView.RowHeadersVisible = false;
            CarView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CarView.MultiSelect = false;
            CarView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            CarView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            CarView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void AutoTestDeleteCar_Click(object sender, EventArgs e)
        {
            // Подключение к БД
            db = new DB();
            db.getConnection();

            string Name = "abobacar";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(db.connection))
                {
                    SQLiteCommand command = connection.CreateCommand();
                    connection.Open();

                    int count = 0;

                    // Команда для БД
                    string query = @"DELETE FROM cars WHERE name =
                            '" + Name + "' ";
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

        private void Backup_Click(object sender, EventArgs e)
        {
            db = new DB();
            db.getConnection();

            using (SQLiteConnection connection = new SQLiteConnection(db.connection))
            {
                connection.Open();

                string backupPath = @"D:\ycheba\SaveDataBase\backup.db";
                string commandText = $"VACUUM main INTO '{backupPath}'";

                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Бэкап сделан", "Резервное копирование", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
