namespace EasyCar
{
    partial class mdk
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
            this.AutoTestAddClient = new System.Windows.Forms.Button();
            this.AutoTestShowClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AutoTestDeleteUser = new System.Windows.Forms.Button();
            this.CarView = new System.Windows.Forms.DataGridView();
            this.AutoTestShowCar = new System.Windows.Forms.Button();
            this.AutoTestDeleteCar = new System.Windows.Forms.Button();
            this.Backup = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ErrorsBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.CarView)).BeginInit();
            this.SuspendLayout();
            // 
            // AutoTestAddClient
            // 
            this.AutoTestAddClient.Location = new System.Drawing.Point(11, 26);
            this.AutoTestAddClient.Name = "AutoTestAddClient";
            this.AutoTestAddClient.Size = new System.Drawing.Size(148, 50);
            this.AutoTestAddClient.TabIndex = 0;
            this.AutoTestAddClient.Text = "Автотест\r\nДобавление клиента\r\n";
            this.AutoTestAddClient.UseVisualStyleBackColor = true;
            this.AutoTestAddClient.Click += new System.EventHandler(this.AutoTestAddClient_Click);
            // 
            // AutoTestShowClient
            // 
            this.AutoTestShowClient.Location = new System.Drawing.Point(12, 83);
            this.AutoTestShowClient.Name = "AutoTestShowClient";
            this.AutoTestShowClient.Size = new System.Drawing.Size(147, 50);
            this.AutoTestShowClient.TabIndex = 1;
            this.AutoTestShowClient.Text = "Автотест\r\nВывод клиента\r\n";
            this.AutoTestShowClient.UseVisualStyleBackColor = true;
            this.AutoTestShowClient.Click += new System.EventHandler(this.AutoTestShowClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // AutoTestDeleteUser
            // 
            this.AutoTestDeleteUser.Location = new System.Drawing.Point(12, 139);
            this.AutoTestDeleteUser.Name = "AutoTestDeleteUser";
            this.AutoTestDeleteUser.Size = new System.Drawing.Size(147, 50);
            this.AutoTestDeleteUser.TabIndex = 3;
            this.AutoTestDeleteUser.Text = "Автотест\r\nУдаление клиента\r\n";
            this.AutoTestDeleteUser.UseVisualStyleBackColor = true;
            this.AutoTestDeleteUser.Click += new System.EventHandler(this.AutoTestDeleteUser_Click);
            // 
            // CarView
            // 
            this.CarView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarView.Location = new System.Drawing.Point(12, 222);
            this.CarView.Name = "CarView";
            this.CarView.Size = new System.Drawing.Size(318, 159);
            this.CarView.TabIndex = 4;
            // 
            // AutoTestShowCar
            // 
            this.AutoTestShowCar.Location = new System.Drawing.Point(165, 26);
            this.AutoTestShowCar.Name = "AutoTestShowCar";
            this.AutoTestShowCar.Size = new System.Drawing.Size(148, 50);
            this.AutoTestShowCar.TabIndex = 5;
            this.AutoTestShowCar.Text = "Автотест\r\nВывод автомобиля\r\n";
            this.AutoTestShowCar.UseVisualStyleBackColor = true;
            this.AutoTestShowCar.Click += new System.EventHandler(this.AutoTestShowCar_Click);
            // 
            // AutoTestDeleteCar
            // 
            this.AutoTestDeleteCar.Location = new System.Drawing.Point(165, 83);
            this.AutoTestDeleteCar.Name = "AutoTestDeleteCar";
            this.AutoTestDeleteCar.Size = new System.Drawing.Size(147, 50);
            this.AutoTestDeleteCar.TabIndex = 6;
            this.AutoTestDeleteCar.Text = "Автотест\r\nУдаление автомобиля";
            this.AutoTestDeleteCar.UseVisualStyleBackColor = true;
            this.AutoTestDeleteCar.Click += new System.EventHandler(this.AutoTestDeleteCar_Click);
            // 
            // Backup
            // 
            this.Backup.Location = new System.Drawing.Point(166, 139);
            this.Backup.Name = "Backup";
            this.Backup.Size = new System.Drawing.Size(147, 50);
            this.Backup.TabIndex = 7;
            this.Backup.Text = "Резевное копирование БД";
            this.Backup.UseVisualStyleBackColor = true;
            this.Backup.Click += new System.EventHandler(this.Backup_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(319, 26);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(147, 50);
            this.UpdateBtn.TabIndex = 8;
            this.UpdateBtn.Text = "Обновление";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ErrorsBtn
            // 
            this.ErrorsBtn.Location = new System.Drawing.Point(319, 83);
            this.ErrorsBtn.Name = "ErrorsBtn";
            this.ErrorsBtn.Size = new System.Drawing.Size(147, 50);
            this.ErrorsBtn.TabIndex = 9;
            this.ErrorsBtn.Text = "Сбор ошибок";
            this.ErrorsBtn.UseVisualStyleBackColor = true;
            this.ErrorsBtn.Click += new System.EventHandler(this.ErrorsBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mdk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 522);
            this.Controls.Add(this.ErrorsBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.Backup);
            this.Controls.Add(this.AutoTestDeleteCar);
            this.Controls.Add(this.AutoTestShowCar);
            this.Controls.Add(this.CarView);
            this.Controls.Add(this.AutoTestDeleteUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AutoTestShowClient);
            this.Controls.Add(this.AutoTestAddClient);
            this.Name = "mdk";
            this.Text = "mdk";
            ((System.ComponentModel.ISupportInitialize)(this.CarView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AutoTestAddClient;
        private System.Windows.Forms.Button AutoTestShowClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AutoTestDeleteUser;
        private System.Windows.Forms.DataGridView CarView;
        private System.Windows.Forms.Button AutoTestShowCar;
        private System.Windows.Forms.Button AutoTestDeleteCar;
        private System.Windows.Forms.Button Backup;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button ErrorsBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}