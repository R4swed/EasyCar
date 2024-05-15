using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace EasyCar
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        DB db; // Объект для работы с базой данных

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
        private void ContactsLabel_Click(object sender, EventArgs e)
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
        private void AboutLabel_Click(object sender, EventArgs e)
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

        // Переход на окно каталога
        private void CatalogLabel_Click(object sender, EventArgs e)
        {
            Form fCatalog = new Catalog();
            fCatalog.Show();
            fCatalog.FormClosed += new FormClosedEventHandler(form_FormClosed3);
            this.Hide();
        }

        // Закрытие формы
        void form_FormClosed3(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        // Переход на окно регистрации
        private void RegLabel_Click(object sender, EventArgs e)
        {
            Form fReg= new Reg();
            fReg.Show();
            fReg.FormClosed += new FormClosedEventHandler(form_FormClosed4);
            this.Hide();
        }

        // Закрытие формы
        void form_FormClosed4(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Проверка на заполнение полей почты и пароля
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            String EmailUser = EmailBox.Text;
            String PasswordUser = PasswordBox.Text;
        
                if (EmailUser != string.Empty
                && PasswordUser != string.Empty)
            {
                checkAccount(EmailUser, PasswordUser);
            }
            else
            {
                MessageBox.Show("Введите данные", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Авториация пользователя
        private void checkAccount(string email, string password)
        {
            // Подключение к БД
            db = new DB();
            db.getConnection();

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(db.connection))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();

                    // Команда для БД
                    string query = @"SELECT role FROM users WHERE email=
                        '" + email + "' " +
                        "AND password='" + password + "'";

                    int count = 0;
                    cmd.CommandText = query;
                    cmd.Connection = con;

                    object result = cmd.ExecuteScalar();

                    SQLiteDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        count++;
                    }

                    if (count == 1)
                    {
                        // Если роль пользователя администратор то перейти на панель администратора
                        string Userrole = result.ToString();
                        if (Userrole == "admin")
                        {
                            MessageBox.Show("Вы вошли", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AdminUsers genAdmin = new AdminUsers();
                            genAdmin.Show();
                            genAdmin.FormClosed += new FormClosedEventHandler(form_FormClosed);
                            this.Hide();

                            void form_FormClosed(object sender, FormClosedEventArgs e)
                            {
                                this.Close();
                            }
                        }

                        // Иначе перейти на клиентскую часть
                        else
                        {
                            MessageBox.Show("Вы вошли", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            General gen = new General();
                            gen.Show();
                            gen.FormClosed += new FormClosedEventHandler(form_FormClosed2);
                            this.Hide();

                            void form_FormClosed2(object sender, FormClosedEventArgs e)
                            {
                                this.Close();
                            }
                        }
                    }
                    else
                        MessageBox.Show("Неверная почта или пароль", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Авторизация");
            }
        }
        #endregion
    }
}
