using System;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Exceptions;

namespace EasyCar
{
    public partial class Contacs : Form
    {
        public Contacs()
        {
            InitializeComponent();
        }

        #region Переходы на другие окна приложения

        // Переход на главное окно
        private void GeneralLabel_Click(object sender, EventArgs e)
        {
            Form fGeneral = new General();
            fGeneral.Show();
            fGeneral.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }

        // Закрытие окна
        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        // Переход на окно информации о компании
        private void AboutLabel_Click(object sender, EventArgs e)
        {
            Form fAbout= new About();
            fAbout.Show();
            fAbout.FormClosed += new FormClosedEventHandler(form_FormClosed1);
            this.Hide();
        }

        // Закрытие окна
        void form_FormClosed1(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        // Переход на окно каталога
        private void CatalogLabel_Click(object sender, EventArgs e)
        {
            Form fCatalog = new Catalog();
            fCatalog.Show();
            fCatalog.FormClosed += new FormClosedEventHandler(form_FormClosed2);
            this.Hide();
        }

        // Закрытие окна
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

        // Закрытие окна
        void form_FormClosed3(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Отправка сообщения в телеграмм-бота
        private async void SendButton_Click(object sender, EventArgs e)
        {
 
            try
            {
                string email = EmailBox.Text;
                string subject = SubjectBox.Text;
                string messageText = QuestionBox.Text;
                string message = $"От: {email}\nТема: {subject}\n\n{messageText}";

                if(email != string.Empty
                && subject != string.Empty
                && messageText != string.Empty)
                {
                    TelegramBotClient bot = new TelegramBotClient("6034616630:AAHW58pdn8wnHsYUwPoHup0cgfnc88Z7Vq8");
                    await bot.SendTextMessageAsync(chatId: "1003484593", text: message);
                    MessageBox.Show("Сообщение отправлено", "Контакты", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Введите данные", "Контакты", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(ApiRequestException ex)
            {
                MessageBox.Show("Сообщение не отправлено", "Контакты", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Открытие ссылок 
        // Переход на телеграмм аккаунт в браузере
        private void TgLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/R4swed");
        }

        // Переход на ВК аккаунт в браузере
        private void VkLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/r4swed");
        }
        #endregion
    }
}
