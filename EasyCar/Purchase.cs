using System;
using System.Windows.Forms;
using Telegram.Bot.Exceptions;
using Telegram.Bot;

namespace EasyCar
{
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }

        #region Отправка сообщения в телеграмм-бота
        private async void SendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string email = EmailBox.Text;
                string contact = ContactBox.Text;
                string car = CarBox.Text;
                string message = $"От: {email}\nКонтакт для связи: {contact}\n\n{car}";

                if (email != string.Empty
                && contact != string.Empty
                && car != string.Empty)
                {
                    TelegramBotClient bot = new TelegramBotClient("6034616630:AAHW58pdn8wnHsYUwPoHup0cgfnc88Z7Vq8");
                    await bot.SendTextMessageAsync(chatId: "1003484593", text: message);
                    MessageBox.Show("Сообщение отправлено", "Связаться", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Введите данные", "Связаться", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ApiRequestException ex)
            {
                MessageBox.Show("Сообщение не отправлено", "Связаться", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
