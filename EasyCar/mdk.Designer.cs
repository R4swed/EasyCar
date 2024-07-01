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
            this.label1 = new System.Windows.Forms.Label();
            this.CarView = new System.Windows.Forms.DataGridView();
            this.Backup = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.AutoTestBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CarView)).BeginInit();
            this.SuspendLayout();
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
            // CarView
            // 
            this.CarView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarView.Location = new System.Drawing.Point(12, 222);
            this.CarView.Name = "CarView";
            this.CarView.Size = new System.Drawing.Size(435, 239);
            this.CarView.TabIndex = 4;
            // 
            // Backup
            // 
            this.Backup.Location = new System.Drawing.Point(165, 12);
            this.Backup.Name = "Backup";
            this.Backup.Size = new System.Drawing.Size(147, 50);
            this.Backup.TabIndex = 7;
            this.Backup.Text = "Резевное копирование БД";
            this.Backup.UseVisualStyleBackColor = true;
            this.Backup.Click += new System.EventHandler(this.Backup_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AutoTestBtn
            // 
            this.AutoTestBtn.Location = new System.Drawing.Point(12, 12);
            this.AutoTestBtn.Name = "AutoTestBtn";
            this.AutoTestBtn.Size = new System.Drawing.Size(147, 50);
            this.AutoTestBtn.TabIndex = 8;
            this.AutoTestBtn.Text = "Автотест";
            this.AutoTestBtn.UseVisualStyleBackColor = true;
            this.AutoTestBtn.Click += new System.EventHandler(this.AutoTestBtn_Click);
            // 
            // mdk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 522);
            this.Controls.Add(this.AutoTestBtn);
            this.Controls.Add(this.Backup);
            this.Controls.Add(this.CarView);
            this.Controls.Add(this.label1);
            this.Name = "mdk";
            this.Text = "mdk";
            ((System.ComponentModel.ISupportInitialize)(this.CarView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CarView;
        private System.Windows.Forms.Button Backup;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button AutoTestBtn;
    }
}