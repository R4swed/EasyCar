using System;
using System.Windows.Forms;

namespace EasyCar
{
    public partial class About : Form
    {
        public About()
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

        // Закрытие текущей формы
        void form_FormClosed(object sender, FormClosedEventArgs e)
        { 
            this.Close(); 
        }

        // Переход на окно контактов
        private void ContactLabel_Click(object sender, EventArgs e)
        {
            Form fContact = new Contacs();
            fContact.Show();
            fContact.FormClosed += new FormClosedEventHandler(form_FormClosed2);
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

        // Переход на окно авторизации
        private void Loginimg_Click(object sender, EventArgs e)
        {
            Form fAuth = new Auth();
            fAuth.Show();
            fAuth.FormClosed += new FormClosedEventHandler(form_FormClosed4);
            this.Hide();
        }

        // Закрытие текущей формы
        void form_FormClosed4(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
        