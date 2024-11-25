namespace EasyCar
{
    partial class AdminCatalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCatalog));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChangeUsersLabel = new System.Windows.Forms.Label();
            this.ChangeCatalogLabel = new System.Windows.Forms.Label();
            this.GeneralLabel = new System.Windows.Forms.Label();
            this.CarsCatalog = new System.Windows.Forms.DataGridView();
            this.ShowCarsBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DeletePriceBox = new System.Windows.Forms.TextBox();
            this.AddNameBox = new System.Windows.Forms.TextBox();
            this.DeleteNameBox = new System.Windows.Forms.TextBox();
            this.AddCarBtn = new System.Windows.Forms.Button();
            this.DeleteCarBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AddVehicleBox = new System.Windows.Forms.TextBox();
            this.AddYearBox = new System.Windows.Forms.TextBox();
            this.AddPriceBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DeleteYearBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DeleteVehicleBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsCatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, -5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ChangeUsersLabel
            // 
            this.ChangeUsersLabel.AutoSize = true;
            this.ChangeUsersLabel.Font = new System.Drawing.Font("Arial Narrow", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeUsersLabel.Location = new System.Drawing.Point(110, 25);
            this.ChangeUsersLabel.Name = "ChangeUsersLabel";
            this.ChangeUsersLabel.Size = new System.Drawing.Size(291, 30);
            this.ChangeUsersLabel.TabIndex = 13;
            this.ChangeUsersLabel.Text = "Управление Пользователями";
            this.ChangeUsersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChangeUsersLabel.Click += new System.EventHandler(this.ChangeUsersLabel_Click);
            // 
            // ChangeCatalogLabel
            // 
            this.ChangeCatalogLabel.AutoSize = true;
            this.ChangeCatalogLabel.Font = new System.Drawing.Font("Arial Narrow", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeCatalogLabel.Location = new System.Drawing.Point(400, 25);
            this.ChangeCatalogLabel.Name = "ChangeCatalogLabel";
            this.ChangeCatalogLabel.Size = new System.Drawing.Size(230, 30);
            this.ChangeCatalogLabel.TabIndex = 15;
            this.ChangeCatalogLabel.Text = "Управление Каталогом";
            this.ChangeCatalogLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GeneralLabel
            // 
            this.GeneralLabel.AutoSize = true;
            this.GeneralLabel.Font = new System.Drawing.Font("Arial Narrow", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GeneralLabel.Location = new System.Drawing.Point(640, 25);
            this.GeneralLabel.Name = "GeneralLabel";
            this.GeneralLabel.Size = new System.Drawing.Size(121, 30);
            this.GeneralLabel.TabIndex = 16;
            this.GeneralLabel.Text = "На главную";
            this.GeneralLabel.Click += new System.EventHandler(this.GeneralLabel_Click);
            // 
            // CarsCatalog
            // 
            this.CarsCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarsCatalog.Location = new System.Drawing.Point(374, 124);
            this.CarsCatalog.Name = "CarsCatalog";
            this.CarsCatalog.Size = new System.Drawing.Size(408, 222);
            this.CarsCatalog.TabIndex = 17;
            // 
            // ShowCarsBtn
            // 
            this.ShowCarsBtn.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowCarsBtn.Location = new System.Drawing.Point(374, 352);
            this.ShowCarsBtn.Name = "ShowCarsBtn";
            this.ShowCarsBtn.Size = new System.Drawing.Size(408, 35);
            this.ShowCarsBtn.TabIndex = 29;
            this.ShowCarsBtn.Text = "Показать автомобили";
            this.ShowCarsBtn.UseVisualStyleBackColor = true;
            this.ShowCarsBtn.Click += new System.EventHandler(this.ShowCarsBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Удалить автомобиль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(186, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Добавить автомобиль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(186, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Год выпуска";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(186, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 23);
            this.label6.TabIndex = 35;
            this.label6.Text = "Название";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 36;
            this.label7.Text = "Название";
            // 
            // DeletePriceBox
            // 
            this.DeletePriceBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeletePriceBox.Location = new System.Drawing.Point(17, 255);
            this.DeletePriceBox.Name = "DeletePriceBox";
            this.DeletePriceBox.Size = new System.Drawing.Size(158, 29);
            this.DeletePriceBox.TabIndex = 38;
            // 
            // AddNameBox
            // 
            this.AddNameBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNameBox.Location = new System.Drawing.Point(190, 192);
            this.AddNameBox.Name = "AddNameBox";
            this.AddNameBox.Size = new System.Drawing.Size(178, 29);
            this.AddNameBox.TabIndex = 39;
            // 
            // DeleteNameBox
            // 
            this.DeleteNameBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteNameBox.Location = new System.Drawing.Point(17, 192);
            this.DeleteNameBox.Name = "DeleteNameBox";
            this.DeleteNameBox.Size = new System.Drawing.Size(158, 29);
            this.DeleteNameBox.TabIndex = 40;
            // 
            // AddCarBtn
            // 
            this.AddCarBtn.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCarBtn.Location = new System.Drawing.Point(190, 413);
            this.AddCarBtn.Name = "AddCarBtn";
            this.AddCarBtn.Size = new System.Drawing.Size(178, 35);
            this.AddCarBtn.TabIndex = 41;
            this.AddCarBtn.Text = "Добавить автомобиль";
            this.AddCarBtn.UseVisualStyleBackColor = true;
            this.AddCarBtn.Click += new System.EventHandler(this.AddCarBtn_Click);
            // 
            // DeleteCarBtn
            // 
            this.DeleteCarBtn.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteCarBtn.Location = new System.Drawing.Point(17, 413);
            this.DeleteCarBtn.Name = "DeleteCarBtn";
            this.DeleteCarBtn.Size = new System.Drawing.Size(158, 35);
            this.DeleteCarBtn.TabIndex = 42;
            this.DeleteCarBtn.Text = "Удалить автомобиль";
            this.DeleteCarBtn.UseVisualStyleBackColor = true;
            this.DeleteCarBtn.Click += new System.EventHandler(this.DeleteCarBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(186, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 23);
            this.label8.TabIndex = 43;
            this.label8.Text = "Цена";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(186, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 23);
            this.label9.TabIndex = 44;
            this.label9.Text = "Пробег";
            // 
            // AddVehicleBox
            // 
            this.AddVehicleBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddVehicleBox.Location = new System.Drawing.Point(190, 377);
            this.AddVehicleBox.Name = "AddVehicleBox";
            this.AddVehicleBox.Size = new System.Drawing.Size(178, 29);
            this.AddVehicleBox.TabIndex = 45;
            // 
            // AddYearBox
            // 
            this.AddYearBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddYearBox.Location = new System.Drawing.Point(190, 316);
            this.AddYearBox.Name = "AddYearBox";
            this.AddYearBox.Size = new System.Drawing.Size(178, 29);
            this.AddYearBox.TabIndex = 46;
            // 
            // AddPriceBox
            // 
            this.AddPriceBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPriceBox.Location = new System.Drawing.Point(190, 255);
            this.AddPriceBox.Name = "AddPriceBox";
            this.AddPriceBox.Size = new System.Drawing.Size(178, 29);
            this.AddPriceBox.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 48;
            this.label5.Text = "Год выпуска";
            // 
            // DeleteYearBox
            // 
            this.DeleteYearBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteYearBox.Location = new System.Drawing.Point(17, 316);
            this.DeleteYearBox.Name = "DeleteYearBox";
            this.DeleteYearBox.Size = new System.Drawing.Size(158, 29);
            this.DeleteYearBox.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 23);
            this.label10.TabIndex = 50;
            this.label10.Text = "Пробег";
            // 
            // DeleteVehicleBox
            // 
            this.DeleteVehicleBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteVehicleBox.Location = new System.Drawing.Point(17, 377);
            this.DeleteVehicleBox.Name = "DeleteVehicleBox";
            this.DeleteVehicleBox.Size = new System.Drawing.Size(158, 29);
            this.DeleteVehicleBox.TabIndex = 51;
            // 
            // AdminCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.DeleteVehicleBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DeleteYearBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddPriceBox);
            this.Controls.Add(this.AddYearBox);
            this.Controls.Add(this.AddVehicleBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DeleteCarBtn);
            this.Controls.Add(this.AddCarBtn);
            this.Controls.Add(this.DeleteNameBox);
            this.Controls.Add(this.AddNameBox);
            this.Controls.Add(this.DeletePriceBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShowCarsBtn);
            this.Controls.Add(this.CarsCatalog);
            this.Controls.Add(this.GeneralLabel);
            this.Controls.Add(this.ChangeCatalogLabel);
            this.Controls.Add(this.ChangeUsersLabel);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "AdminCatalog";
            this.Text = "Панель администратора";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsCatalog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ChangeUsersLabel;
        private System.Windows.Forms.Label ChangeCatalogLabel;
        private System.Windows.Forms.Label GeneralLabel;
        private System.Windows.Forms.DataGridView CarsCatalog;
        private System.Windows.Forms.Button ShowCarsBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DeletePriceBox;
        private System.Windows.Forms.TextBox AddNameBox;
        private System.Windows.Forms.TextBox DeleteNameBox;
        private System.Windows.Forms.Button AddCarBtn;
        private System.Windows.Forms.Button DeleteCarBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AddVehicleBox;
        private System.Windows.Forms.TextBox AddYearBox;
        private System.Windows.Forms.TextBox AddPriceBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DeleteYearBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DeleteVehicleBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}