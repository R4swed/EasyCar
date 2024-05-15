using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace EasyCar
{
    public partial class Reg : Form
    {
        public Reg()
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

        // Закртие окна
        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        // Переход на окно контактов
        private void ContacsLabel_Click(object sender, EventArgs e)
        {
            Form fContacts = new Contacs();
            fContacts.Show();
            fContacts.FormClosed += new FormClosedEventHandler(form_FormClosed1);
            this.Hide();
        }

        // Закртие окна
        void form_FormClosed1(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        // Переход на окно информации о компании
        private void AboutLabel_Click(object sender, EventArgs e)
        {
            Form fAbout = new About();
            fAbout.Show();
            fAbout.FormClosed += new FormClosedEventHandler(form_FormClosed2);
            this.Hide();
        }

        // Закртие окна
        void form_FormClosed2(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        // Переход на окно каталога
        private void CatalogLabel_Click(object sender, EventArgs e)
        {
            Form fCatalog = new Catalog();
            fCatalog.Show();
            fCatalog.FormClosed += new FormClosedEventHandler(form_FormClosed3);
            this.Hide();
        }

        // Закртие окна
        void form_FormClosed3(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        // Переход на окно авторизации
        private void LoginLabel_Click(object sender, EventArgs e)
        {
            Form fAuth = new Auth();
            fAuth.Show();
            fAuth.FormClosed += new FormClosedEventHandler(form_FormClosed4);
            this.Hide();
        }

        // Закртие окна
        void form_FormClosed4(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Проверка на заполнения полей почты пароля и телефона
        private void RegButton_Click(object sender, EventArgs e)
        {
            String EmailUser = EmailBox.Text;
            String PasswordUser = PasswordBox.Text;
            String PhoneUser = PhoneBox.Text;

            if (EmailUser != string.Empty
            && PasswordUser != string.Empty
            && PhoneUser != string.Empty)
            {
                checkAccount(EmailUser, PasswordUser, PhoneUser);
            }
            else
                MessageBox.Show("Введите данные", "Регестрация", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Проверка зарегестрирован ли пользователь
        private void checkAccount(string email, string password, string phone)
        {
            db = new DB();
            db.getConnection();

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(db.connection))
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    con.Open();

                    int count = 0;
                    string query = @"SELECT * FROM users 
                           WHERE email ='" + email + "'";
                    string query2 = @"SELECT * FROM users 
                            WHERE phone ='" + phone + "'";
                    cmd.CommandText = query;
                    cmd.CommandText = query2;
                    cmd.Connection = con;

                    SQLiteDataReader reader = cmd.ExecuteReader();
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
                        insertData(email, password, phone);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Регестрация", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Добавления пользователя в БД
        private void insertData(string email, string password, string phone)
        {
            db = new DB();
            db.getConnection();

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(db.connection))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    string query = @"INSERT INTO users(email, password, phone) 
                                    VALUES(@email, @password, @phone)";
                    cmd.CommandText = query;
                    cmd.Connection = con;
                    cmd.Parameters.Add(new SQLiteParameter("@email", email));
                    cmd.Parameters.Add(new SQLiteParameter("@password", password));
                    cmd.Parameters.Add(new SQLiteParameter("@phone", phone));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Вы зарегестрировались", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Регестрация", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}

