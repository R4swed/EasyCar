using System;
using System.Windows.Forms;

namespace EasyCar
{
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }

        #region Переходы на другие окна приложения

        // Переход на окно контактов
        private void Контакты_Click(object sender, EventArgs e)
        {
            Form fContacs = new Contacs();
            fContacs.Show();
            fContacs.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }

        // Закрытие текущей формы
        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        
        // Переход на окно информации о компании
        private void AboutLabel_Click_1(object sender, EventArgs e)
        {
            Form fAbout = new About();
            fAbout.Show();
            fAbout.FormClosed += new FormClosedEventHandler(form_FormClosed1);
            this.Hide();
        }

        // Закрытие текущей формы
        void form_FormClosed1(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        // Переход на окно авторизации
        private void Loginimg_Click(object sender, EventArgs e)
        {
            Form fAuth = new Auth();
            fAuth.Show();
            fAuth.FormClosed += new FormClosedEventHandler(form_FormClosed2);
            this.Hide();
        }

        // Закрытие текущей формы
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

        // Закрытие текущей формы
        void form_FormClosed3(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
 