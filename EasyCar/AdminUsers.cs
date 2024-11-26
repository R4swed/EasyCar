using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace EasyCar
{
    public partial class AdminUsers : Form
    {
        public AdminUsers()
        {
            InitializeComponent();
        }

        DB db; // Объект для работы с базой данных

        #region Проверка заполнены ли поля для удаления пользователя
        private void DeleteUserBtn_Click(object sender, EventArgs e)
        {
            string DeleteEmail = EmailDeleteBox.Text;
            string DeletePhone = PhoneDeleteBox.Text;

            if(DeleteEmail != string.Empty
                && DeletePhone != string.Empty)
            {
                DeleteAccount(DeleteEmail, DeletePhone);
            }
            else
                MessageBox.Show("Введите данные", "Удаление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
            #endregion

        #region Удаление пользователя из БД
            void DeleteAccount(string Email, string Phone)
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
                        string query = @"DELETE FROM users WHERE email =
                                        '" + Email + "'";
                        command.CommandText = query;
                        command.Connection = connection;

                        SQLiteDataReader reader = command.ExecuteReader();
                        while(reader.Read())
                        {
                            count--;
                        }
                        if(count == 0)
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
        }
        #endregion

        #region Вывод всех пользователей в datagridview
        private void ShowUsersBtn_Click(object sender, EventArgs e)
        {
            // Подключение к БД
            db = new DB();
            db.getConnection();

            SQLiteConnection connection = new SQLiteConnection(db.connection);
            
            // Команда для БД
            string query = @"SELECT email, phone, password, role FROM users";

            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);

            DataTable datatable = new DataTable();

            adapter.Fill(datatable);

            UsersData.DataSource = datatable;

            // Настройка "внешнего вида" datagridview
            UsersData.Columns["email"].HeaderText = "Эл.Почта";
            UsersData.Columns["phone"].HeaderText = "Номер телефона";
            UsersData.Columns["password"].HeaderText = "Пароль";
            UsersData.Columns["role"].HeaderText = "Роль";
            UsersData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UsersData.AllowUserToAddRows = false;
            UsersData.RowHeadersVisible = false;
            UsersData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UsersData.MultiSelect = false;
        }
        #endregion

        #region Проверка заполнены ли поля для добавления пользователя в БД
        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            string emailUser = EmailAddBox.Text;
            string phoneUser = PhoneAddBox.Text;
            string passwordUser = PasswordAddBox.Text;
            string roleUser = RoleBox.Text;

            if(emailUser != string.Empty
                && phoneUser != string.Empty
                && passwordUser != string.Empty
                && roleUser != string.Empty)
            {
                if (roleUser == "admin")
                {
                    AddAccount(emailUser, phoneUser, passwordUser, roleUser);
                }
                else if (roleUser == "editor")
                {
                    AddAccount(emailUser, phoneUser, passwordUser, roleUser);
                }
                else if (roleUser == "client")
                {
                    AddAccount(emailUser, phoneUser, passwordUser, roleUser);
                }
                else
                    MessageBox.Show("Можно добавить пользователя только с ролью 'admin' или 'client'", "Добавление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Введите данные", "Добваление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
            #endregion

        #region Проверка есть ли пользователь с данными которые ввели в текстбоксы
            void AddAccount(string email, string phone, string password, string role)
            {
                db = new DB();
                db.getConnection();

                using (SQLiteConnection connection = new SQLiteConnection(db.connection))
                {
                    SQLiteCommand command = connection.CreateCommand();
                    connection.Open();

                    int count = 0;
                    string query = @"SELECT * FROM users WHERE email ='" + email + "'";
                    command.CommandText = query;
                    command.Connection = connection;

                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        count++;
                    }

                    if (count == 1)
                    {
                        MessageBox.Show("Пользователь уже зарегестрирован", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    else if (count == 0)
                    InsertData(password, phone, role, email);
                }
            }
            #endregion

        #region Добавление пользователя в БД
            void InsertData(string password, string phone, string role, string email) 
            {
                // Подключение к БД
                db = new DB();
                db.getConnection();

                using (SQLiteConnection connection = new SQLiteConnection(db.connection))
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand();
                    // Команда для БД
                    string query = @"INSERT INTO users(email, password, phone, role) 
                                    VALUES(@email, @password, @phone, @Role)";
                    command.CommandText = query;
                    command.Connection = connection;
                    command.Parameters.Add(new SQLiteParameter("@email", email));
                    command.Parameters.Add(new SQLiteParameter("@password", password));
                    command.Parameters.Add(new SQLiteParameter("@phone", phone));
                    command.Parameters.Add(new SQLiteParameter("@Role", role));
                    command.ExecuteNonQuery();

                    MessageBox.Show("Пользователь добавлен", "Добавление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
        #endregion

        #region Переходы на другие окна приложения

        // Переход на окно данных о автомобилях 
        private void ChangeCatalogLabel_Click(object sender, EventArgs e)
        {
            Form fAdminCatalog = new AdminCatalog();
            fAdminCatalog.Show();
            fAdminCatalog.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }

        // Закрытие формы
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

        // Закрытие формы
        void form_FormClosed1(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
