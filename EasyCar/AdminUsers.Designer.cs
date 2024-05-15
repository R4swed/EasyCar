namespace EasyCar
{
    partial class AdminUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUsers));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChangeUsersLabel = new System.Windows.Forms.Label();
            this.ChangeCatalogLabel = new System.Windows.Forms.Label();
            this.UsersData = new System.Windows.Forms.DataGridView();
            this.DeleteUserBtn = new System.Windows.Forms.Button();
            this.PhoneDeleteBox = new System.Windows.Forms.TextBox();
            this.EmailDeleteBox = new System.Windows.Forms.TextBox();
            this.EmailAddBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PhoneAddBox = new System.Windows.Forms.TextBox();
            this.ShowUsersBtn = new System.Windows.Forms.Button();
            this.RoleBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PasswordAddBox = new System.Windows.Forms.TextBox();
            this.GeneralLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersData)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, -5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ChangeUsersLabel
            // 
            this.ChangeUsersLabel.AutoSize = true;
            this.ChangeUsersLabel.Font = new System.Drawing.Font("Arial Narrow", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeUsersLabel.Location = new System.Drawing.Point(110, 25);
            this.ChangeUsersLabel.Name = "ChangeUsersLabel";
            this.ChangeUsersLabel.Size = new System.Drawing.Size(291, 30);
            this.ChangeUsersLabel.TabIndex = 12;
            this.ChangeUsersLabel.Text = "Управление Пользователями";
            this.ChangeUsersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeCatalogLabel
            // 
            this.ChangeCatalogLabel.AutoSize = true;
            this.ChangeCatalogLabel.Font = new System.Drawing.Font("Arial Narrow", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeCatalogLabel.Location = new System.Drawing.Point(400, 25);
            this.ChangeCatalogLabel.Name = "ChangeCatalogLabel";
            this.ChangeCatalogLabel.Size = new System.Drawing.Size(230, 30);
            this.ChangeCatalogLabel.TabIndex = 14;
            this.ChangeCatalogLabel.Text = "Управление Каталогом";
            this.ChangeCatalogLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChangeCatalogLabel.Click += new System.EventHandler(this.ChangeCatalogLabel_Click);
            // 
            // UsersData
            // 
            this.UsersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersData.Location = new System.Drawing.Point(477, 124);
            this.UsersData.Name = "UsersData";
            this.UsersData.Size = new System.Drawing.Size(288, 161);
            this.UsersData.TabIndex = 15;
            // 
            // DeleteUserBtn
            // 
            this.DeleteUserBtn.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteUserBtn.Location = new System.Drawing.Point(30, 295);
            this.DeleteUserBtn.Name = "DeleteUserBtn";
            this.DeleteUserBtn.Size = new System.Drawing.Size(192, 35);
            this.DeleteUserBtn.TabIndex = 16;
            this.DeleteUserBtn.Text = "Удалить";
            this.DeleteUserBtn.UseVisualStyleBackColor = true;
            this.DeleteUserBtn.Click += new System.EventHandler(this.DeleteUserBtn_Click);
            // 
            // PhoneDeleteBox
            // 
            this.PhoneDeleteBox.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneDeleteBox.Location = new System.Drawing.Point(30, 259);
            this.PhoneDeleteBox.Name = "PhoneDeleteBox";
            this.PhoneDeleteBox.Size = new System.Drawing.Size(192, 30);
            this.PhoneDeleteBox.TabIndex = 17;
            // 
            // EmailDeleteBox
            // 
            this.EmailDeleteBox.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailDeleteBox.Location = new System.Drawing.Point(30, 194);
            this.EmailDeleteBox.Name = "EmailDeleteBox";
            this.EmailDeleteBox.Size = new System.Drawing.Size(192, 30);
            this.EmailDeleteBox.TabIndex = 18;
            // 
            // EmailAddBox
            // 
            this.EmailAddBox.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailAddBox.Location = new System.Drawing.Point(250, 194);
            this.EmailAddBox.Name = "EmailAddBox";
            this.EmailAddBox.Size = new System.Drawing.Size(192, 30);
            this.EmailAddBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Почта";
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUserBtn.Location = new System.Drawing.Point(250, 413);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(192, 35);
            this.AddUserBtn.TabIndex = 22;
            this.AddUserBtn.Text = "Добавить";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(245, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Добавить пользователя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(25, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Удалить пользователя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(245, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(245, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Почта";
            // 
            // PhoneAddBox
            // 
            this.PhoneAddBox.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneAddBox.Location = new System.Drawing.Point(250, 255);
            this.PhoneAddBox.Name = "PhoneAddBox";
            this.PhoneAddBox.Size = new System.Drawing.Size(192, 30);
            this.PhoneAddBox.TabIndex = 27;
            // 
            // ShowUsersBtn
            // 
            this.ShowUsersBtn.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowUsersBtn.Location = new System.Drawing.Point(477, 295);
            this.ShowUsersBtn.Name = "ShowUsersBtn";
            this.ShowUsersBtn.Size = new System.Drawing.Size(288, 35);
            this.ShowUsersBtn.TabIndex = 28;
            this.ShowUsersBtn.Text = "Показать пользователей";
            this.ShowUsersBtn.UseVisualStyleBackColor = true;
            this.ShowUsersBtn.Click += new System.EventHandler(this.ShowUsersBtn_Click);
            // 
            // RoleBox
            // 
            this.RoleBox.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleBox.Location = new System.Drawing.Point(250, 377);
            this.RoleBox.Name = "RoleBox";
            this.RoleBox.Size = new System.Drawing.Size(192, 30);
            this.RoleBox.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(245, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Роль";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(245, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Пароль";
            // 
            // PasswordAddBox
            // 
            this.PasswordAddBox.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordAddBox.Location = new System.Drawing.Point(250, 316);
            this.PasswordAddBox.Name = "PasswordAddBox";
            this.PasswordAddBox.Size = new System.Drawing.Size(192, 30);
            this.PasswordAddBox.TabIndex = 33;
            // 
            // GeneralLabel
            // 
            this.GeneralLabel.AutoSize = true;
            this.GeneralLabel.Font = new System.Drawing.Font("Arial Narrow", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GeneralLabel.Location = new System.Drawing.Point(640, 25);
            this.GeneralLabel.Name = "GeneralLabel";
            this.GeneralLabel.Size = new System.Drawing.Size(121, 30);
            this.GeneralLabel.TabIndex = 34;
            this.GeneralLabel.Text = "На главную";
            this.GeneralLabel.Click += new System.EventHandler(this.GeneralLabel_Click);
            // 
            // AdminUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.GeneralLabel);
            this.Controls.Add(this.PasswordAddBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RoleBox);
            this.Controls.Add(this.ShowUsersBtn);
            this.Controls.Add(this.PhoneAddBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddUserBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailAddBox);
            this.Controls.Add(this.EmailDeleteBox);
            this.Controls.Add(this.PhoneDeleteBox);
            this.Controls.Add(this.DeleteUserBtn);
            this.Controls.Add(this.UsersData);
            this.Controls.Add(this.ChangeCatalogLabel);
            this.Controls.Add(this.ChangeUsersLabel);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "AdminUsers";
            this.Text = "Панель Администратора";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ChangeUsersLabel;
        private System.Windows.Forms.Label ChangeCatalogLabel;
        private System.Windows.Forms.DataGridView UsersData;
        private System.Windows.Forms.Button DeleteUserBtn;
        private System.Windows.Forms.TextBox PhoneDeleteBox;
        private System.Windows.Forms.TextBox EmailDeleteBox;
        private System.Windows.Forms.TextBox EmailAddBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PhoneAddBox;
        private System.Windows.Forms.Button ShowUsersBtn;
        private System.Windows.Forms.TextBox RoleBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PasswordAddBox;
        private System.Windows.Forms.Label GeneralLabel;
    }
}