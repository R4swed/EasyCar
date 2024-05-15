using System;

using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EasyCar
{
    public partial class Cars : Form
    {
        public Cars(string name, string year, string price, string vehicle, byte[] imageData)
        {
            InitializeComponent();

            NameLabel.Text = name;
            DescriptionLabel.Text = year;
            PriceLabel.Text = price;
            VehicleLabel.Text = vehicle;

            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(ms);
                    PhotoBox.Image = image;
                }
            }
        }

        // Переход на форму отправки заявки
        private void PurchaseBtn_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.ShowDialog();
        }
    }
}
