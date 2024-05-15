namespace EasyCar
{
    partial class Catalog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalog));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GeneralLabel = new System.Windows.Forms.Label();
            this.Contacts = new System.Windows.Forms.Label();
            this.About = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Loginimg = new System.Windows.Forms.PictureBox();
            this.PriceBox = new System.Windows.Forms.ComboBox();
            this.VehicleBox = new System.Windows.Forms.ComboBox();
            this.YearBox = new System.Windows.Forms.ComboBox();
            this.CarsCatalog = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loginimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsCatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, -5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // GeneralLabel
            // 
            this.GeneralLabel.AutoSize = true;
            this.GeneralLabel.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.GeneralLabel.Location = new System.Drawing.Point(150, 25);
            this.GeneralLabel.Name = "GeneralLabel";
            this.GeneralLabel.Size = new System.Drawing.Size(99, 31);
            this.GeneralLabel.TabIndex = 10;
            this.GeneralLabel.Text = "Главная";
            this.GeneralLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GeneralLabel.Click += new System.EventHandler(this.GeneralLabel_Click);
            // 
            // Contacts
            // 
            this.Contacts.AutoSize = true;
            this.Contacts.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.Contacts.Location = new System.Drawing.Point(300, 25);
            this.Contacts.Name = "Contacts";
            this.Contacts.Size = new System.Drawing.Size(109, 31);
            this.Contacts.TabIndex = 11;
            this.Contacts.Text = "Контакты";
            this.Contacts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Contacts.Click += new System.EventHandler(this.Contacts_Click);
            // 
            // About
            // 
            this.About.AutoSize = true;
            this.About.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.About.Location = new System.Drawing.Point(460, 25);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(72, 31);
            this.About.TabIndex = 12;
            this.About.Text = "О нас";
            this.About.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(590, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Каталог";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Loginimg
            // 
            this.Loginimg.Image = ((System.Drawing.Image)(resources.GetObject("Loginimg.Image")));
            this.Loginimg.Location = new System.Drawing.Point(745, 5);
            this.Loginimg.Margin = new System.Windows.Forms.Padding(0);
            this.Loginimg.Name = "Loginimg";
            this.Loginimg.Size = new System.Drawing.Size(35, 35);
            this.Loginimg.TabIndex = 14;
            this.Loginimg.TabStop = false;
            this.Loginimg.Click += new System.EventHandler(this.Loginimg_Click);
            // 
            // PriceBox
            // 
            this.PriceBox.BackColor = System.Drawing.Color.LightGray;
            this.PriceBox.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceBox.FormattingEnabled = true;
            this.PriceBox.Items.AddRange(new object[] {
            "500000-700000",
            "700000-900000",
            "900000-1100000",
            "1100000-1500000",
            "1500000-2000000",
            "2000000-4000000",
            "4000000-7000000"});
            this.PriceBox.Location = new System.Drawing.Point(30, 130);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(210, 39);
            this.PriceBox.TabIndex = 17;
            this.PriceBox.Text = "Цена";
            // 
            // VehicleBox
            // 
            this.VehicleBox.BackColor = System.Drawing.Color.Gainsboro;
            this.VehicleBox.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VehicleBox.FormattingEnabled = true;
            this.VehicleBox.Items.AddRange(new object[] {
            "0-20000",
            "20000-40000",
            "40000-60000",
            "60000-80000",
            "80000-100000",
            "100000-150000",
            "150000-200000"});
            this.VehicleBox.Location = new System.Drawing.Point(30, 196);
            this.VehicleBox.Name = "VehicleBox";
            this.VehicleBox.Size = new System.Drawing.Size(210, 39);
            this.VehicleBox.TabIndex = 18;
            this.VehicleBox.Text = "Пробег";
            // 
            // YearBox
            // 
            this.YearBox.BackColor = System.Drawing.Color.LightGray;
            this.YearBox.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearBox.FormattingEnabled = true;
            this.YearBox.Items.AddRange(new object[] {
            "1995-2000",
            "2000-2003",
            "2004-2007",
            "2007-2010",
            "2010-2013",
            "2013-2016",
            "2016-2019"});
            this.YearBox.Location = new System.Drawing.Point(30, 270);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(210, 39);
            this.YearBox.TabIndex = 19;
            this.YearBox.Text = "Год выпуска";
            // 
            // CarsCatalog
            // 
            this.CarsCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarsCatalog.Location = new System.Drawing.Point(260, 130);
            this.CarsCatalog.Name = "CarsCatalog";
            this.CarsCatalog.Size = new System.Drawing.Size(512, 277);
            this.CarsCatalog.TabIndex = 21;
            this.CarsCatalog.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarsCatalog_CellDoubleClick);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(30, 330);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(210, 77);
            this.buttonSearch.TabIndex = 22;
            this.buttonSearch.Text = "Показать автомобили";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.CarsCatalog);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.VehicleBox);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.Loginimg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Contacts);
            this.Controls.Add(this.GeneralLabel);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Catalog";
            this.Text = "Каталог";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loginimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsCatalog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label GeneralLabel;
        private System.Windows.Forms.Label Contacts;
        private System.Windows.Forms.Label About;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Loginimg;
        private System.Windows.Forms.ComboBox PriceBox;
        private System.Windows.Forms.ComboBox VehicleBox;
        private System.Windows.Forms.ComboBox YearBox;
        private System.Windows.Forms.DataGridView CarsCatalog;
        private System.Windows.Forms.Button buttonSearch;
    }
}