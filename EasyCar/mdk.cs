using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace EasyCar
{
    public partial class mdk : Form
    {
        public mdk()
        {
            InitializeComponent();
        }

        DB db;

        private void Backup_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    BackupDatabase(saveFileDialog1.FileName);
                    MessageBox.Show("Резервное копирование выполнено успешно.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Резервное копирование не удалось: {ex.Message}");
            }

        }
        private void BackupDatabase(string backupPath)
        {
            string sourceDatabasePath = "DB\\DB.db";
            File.Copy(sourceDatabasePath, backupPath, true);
        }

        private void AutoTestBtn_Click(object sender, EventArgs e)
        {
            db = new DB();
            db.getConnection();

            using (SQLiteConnection connection = new SQLiteConnection(db.connection))
            {
                connection.Open();
                DataTable tables = connection.GetSchema("Tables");
                Random random = new Random();

                // Выбираем случайные две таблицы из базы данных
                var randomTables = tables.AsEnumerable()
                                       .Select(r => r["TABLE_NAME"].ToString())
                                       .OrderBy(x => random.Next())
                                       .Take(2)
                                       .ToList();

                List<string> columns = new List<string>();

                foreach (var tableName in randomTables)
                {
                    DataTable tableColumns = connection.GetSchema("Columns", new string[] { null, null, tableName, null });

                    // Фильтруем метаданные и выбираем только реальные столбцы таблицы
                    var columnNames = tableColumns.AsEnumerable()
                                                 .Where(r => !r["COLUMN_NAME"].ToString().Equals("name", StringComparison.OrdinalIgnoreCase) &&
                                                             !r["COLUMN_NAME"].ToString().Equals("seq", StringComparison.OrdinalIgnoreCase) &&
                                                             !r["COLUMN_NAME"].ToString().Equals("id", StringComparison.OrdinalIgnoreCase)) // исключаем столбец id
                                                 .Select(r => r["COLUMN_NAME"].ToString())
                                                 .ToList();

                    // Выбираем ровно 5 случайных столбцов для каждой таблицы
                    var randomColumns = columnNames.OrderBy(x => random.Next()).Take(5);

                    columns.AddRange(randomColumns);
                }

                // Создаем запрос для выборки случайных столбцов из случайных таблиц
                string query = $"SELECT {string.Join(", ", columns)} FROM {string.Join(", ", randomTables)} LIMIT 10";

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    CarView.DataSource = dataTable;
                }
            }
        }
    }
}

