using System.Data.SQLite;
using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ADO_attached_mode
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=Warehouse.db;Version=3;";
        SQLiteConnection connection = null;

        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        private void ToolStripMenuItemOpenDB_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists("Warehouse.db"))
            {
                MessageBox.Show("Файл бази даних не знайдено.", "Помилка");
                return;
            }

            connection = new SQLiteConnection(connectionString);

            try
            {
                connection.Open();
                MessageBox.Show("Базу даних підключено", "Успішно");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToolStripMenuItemCloseBD_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.State != ConnectionState.Closed)
            {
                try
                {
                    connection.Close();
                    // Очистити вміст dataGridView1
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    dataGridView1.Refresh();
                    MessageBox.Show("Базу даних закрито", "Успіх");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("З'єднання з базою даних вже закрито або не ініціалізовано.", "Помилка");
            }
        }

        private void ToolStripMenuItemNomenclature_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            string query = @"SELECT Goods.id,
                                    Goods.name,
                                    Goods.category_id,
                                    Categories.name
                            FROM Goods
                            INNER JOIN Categories ON Goods.category_id = Categories.id";
            try { 
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                    dataGridView1.Columns[0].HeaderText = "id товару";

                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                    dataGridView1.Columns[1].HeaderText = "Назва товару";

                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                    dataGridView1.Columns[2].HeaderText = "id категорії";

                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                    dataGridView1.Columns[3].HeaderText = "Назва категорії";
                    while (reader.Read())
                    {

                        DataGridViewRow row = new DataGridViewRow();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells[i].Value = reader[i];
                        }

                        dataGridView1.Rows.Add(row);
                    }
                }

            }

            }
            catch(Exception ex) { MessageBox.Show(ex.Message);

            }

           
                
        }

        private void ToolStripMenuItemCategories_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            string query = @"SELECT Categories.id,
                                    Categories.name
                            FROM Categories";
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[0].HeaderText = "id категорії";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[1].HeaderText = "Назва категорії";

                        while (reader.Read())
                        {

                            DataGridViewRow row = new DataGridViewRow();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row.Cells.Add(new DataGridViewTextBoxCell());
                                row.Cells[i].Value = reader[i];
                            }

                            dataGridView1.Rows.Add(row);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void ToolStripMenuItemProviders_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            string query = @"SELECT id, Name, Telephone, Adress

                            FROM Providers";
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[0].HeaderText = "id постачальника";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[1].HeaderText = "Назва постачальника";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[2].HeaderText = "Контактний телефон";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[3].HeaderText = "Адреса";

                        while (reader.Read())
                        {

                            DataGridViewRow row = new DataGridViewRow();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row.Cells.Add(new DataGridViewTextBoxCell());
                                row.Cells[i].Value = reader[i];
                            }

                            dataGridView1.Rows.Add(row);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToolStripMenuItemAll_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            string query = @"SELECT 
                            Receiving.good_id, 
                            Goods.name AS good_name, 
                            Categories.id AS category_id,
                            Categories.name AS category_name,
                            Receiving.provider_id, 
                            Providers.name AS provider_name, 
                            Receiving.unit_cost, 
                            Receiving.number, 
	                        Receiving.unit_cost * Receiving.number AS total_cost,
                            Receiving.delivery_date
                        FROM Receiving
                        INNER JOIN Goods ON Goods.id = Receiving.good_id
                        INNER JOIN Categories ON Categories.id = Goods.category_id
                        INNER JOIN Providers ON Providers.id = Receiving.provider_id;
                        ";
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[0].HeaderText = "id товару";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[1].HeaderText = "Назва товару";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[2].HeaderText = "id категорії";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[3].HeaderText = "Назва категорії";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[4].HeaderText = "id постачальника";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[5].HeaderText = "Назва постачальника";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[6].HeaderText = "Ціна (собівартість)";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[7].HeaderText = "Кількість/Вага";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[8].HeaderText = "Загальна вартість";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[9].HeaderText = "Дата поставки";

                        while (reader.Read())
                        {

                            DataGridViewRow row = new DataGridViewRow();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row.Cells.Add(new DataGridViewTextBoxCell());
                                row.Cells[i].Value = reader[i];
                            }

                            dataGridView1.Rows.Add(row);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            panel1.Visible = true;
            query = @"SELECT                           
                            Categories.name
                        FROM Categories";
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        comboBox_categories.Items.Clear();
                        comboBox_categories.Items.Add("Всі");
                        comboBox_categories.SelectedIndex = 0;


                        while (reader.Read())
                        {
                            string categoryName = reader["name"].ToString();
                            comboBox_categories.Items.Add(categoryName);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            query = @"SELECT                           
                            Providers.name
                        FROM Providers";
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        comboBox_providers.Items.Clear();
                        comboBox_providers.Items.Add("Всі");
                        comboBox_providers.SelectedIndex = 0;
                        


                        while (reader.Read())
                        {
                            string categoryName = reader["name"].ToString();
                            comboBox_providers.Items.Add(categoryName);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }











        }
        private void changedFilters()
        {




            string selectedCategory;
            string selectedProvider;
            if (comboBox_categories.SelectedItem != null && comboBox_categories.SelectedItem.ToString() != "Всі") selectedCategory = comboBox_categories.SelectedItem.ToString();
            else selectedCategory= "";
            if (comboBox_providers.SelectedItem != null && comboBox_providers.SelectedItem.ToString() != "Всі") selectedProvider = comboBox_providers.SelectedItem.ToString();
            else selectedProvider = "";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string categoryCellValue = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : "";
                string providerCellValue = row.Cells[5].Value != null ? row.Cells[5].Value.ToString() : "";

                if (!string.IsNullOrEmpty(selectedCategory) && categoryCellValue != selectedCategory)
                {
                    row.Visible = false;
                }
                else if (!string.IsNullOrEmpty(selectedProvider) && providerCellValue != selectedProvider)
                {
                    row.Visible = false;
                }
                else
                {
                    row.Visible = true;
                }
            }
        }

        private void comboBox_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            changedFilters();
        }

        private void comboBox_providers_SelectedIndexChanged(object sender, EventArgs e)
        {
            changedFilters();
        }

        private void ToolStripMenuItemMaxNum_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            panel1.Visible= false;


            string query = @"SELECT 
                                Receiving.good_id, 
                                Goods.name, 
                                Categories.id ,
                                Categories.name , 
                                Receiving.unit_cost, 
                                Receiving.number, 
                                Receiving.unit_cost * Receiving.number,
                                Receiving.delivery_date
                            FROM Receiving
                            INNER JOIN Goods ON Goods.id = Receiving.good_id
                            INNER JOIN Categories ON Categories.id = Goods.category_id
                            WHERE Receiving.good_id IN (
                                SELECT good_id
                                FROM Receiving
                                GROUP BY good_id
                                HAVING SUM(number) = (
                                    SELECT MAX(total_sum)
                                    FROM (
                                        SELECT SUM(number) AS total_sum
                                        FROM Receiving
                                        GROUP BY good_id
                                    )
                                )
                            );


                        ";
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[0].HeaderText = "id товару";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[1].HeaderText = "Назва товару";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[2].HeaderText = "id категорії";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[3].HeaderText = "Назва категорії";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[4].HeaderText = "Ціна (собівартість)";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[5].HeaderText = "Кількість/Вага";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[6].HeaderText = "Загальна вартість";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[7].HeaderText = "Дата поставки";

                        while (reader.Read())
                        {

                            DataGridViewRow row = new DataGridViewRow();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row.Cells.Add(new DataGridViewTextBoxCell());
                                row.Cells[i].Value = reader[i];
                            }

                            dataGridView1.Rows.Add(row);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ToolStripMenuItemMinNum_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            panel1.Visible = false;


            string query = @"SELECT 
                                Receiving.good_id, 
                                Goods.name, 
                                Categories.id ,
                                Categories.name , 
                                Receiving.unit_cost, 
                                Receiving.number, 
                                Receiving.unit_cost * Receiving.number,
                                Receiving.delivery_date
                            FROM Receiving
                            INNER JOIN Goods ON Goods.id = Receiving.good_id
                            INNER JOIN Categories ON Categories.id = Goods.category_id
                            WHERE Receiving.good_id IN (
                                SELECT good_id
                                FROM Receiving
                                GROUP BY good_id
                                HAVING SUM(number) = (
                                    SELECT MIN(total_sum)
                                    FROM (
                                        SELECT SUM(number) AS total_sum
                                        FROM Receiving
                                        GROUP BY good_id
                                    )
                                )
                            );


                        ";
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[0].HeaderText = "id товару";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[1].HeaderText = "Назва товару";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[2].HeaderText = "id категорії";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[3].HeaderText = "Назва категорії";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[4].HeaderText = "Ціна (собівартість)";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[5].HeaderText = "Кількість/Вага";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[6].HeaderText = "Загальна вартість";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[7].HeaderText = "Дата поставки";

                        while (reader.Read())
                        {

                            DataGridViewRow row = new DataGridViewRow();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row.Cells.Add(new DataGridViewTextBoxCell());
                                row.Cells[i].Value = reader[i];
                            }

                            dataGridView1.Rows.Add(row);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToolStripMenuItemMinCost_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            panel1.Visible = false;


            string query = @"SELECT 
                                Receiving.good_id, 
                                Goods.name, 
                                Categories.id ,
                                Categories.name , 
                                Receiving.unit_cost, 
                                Receiving.number, 
                                Receiving.unit_cost * Receiving.number,
                                Receiving.delivery_date
                            FROM Receiving
                            INNER JOIN Goods ON Goods.id = Receiving.good_id
                            INNER JOIN Categories ON Categories.id = Goods.category_id
                            INNER JOIN Providers ON Providers.id = Receiving.provider_id
                            WHERE Receiving.good_id IN (
                                SELECT good_id
                                FROM Receiving
                                GROUP BY good_id
                                HAVING SUM(Receiving.unit_cost * Receiving.number) = (
                                    SELECT MIN(total_sum)
                                    FROM (
                                        SELECT SUM(Receiving.unit_cost * Receiving.number) AS total_sum
                                        FROM Receiving
                                        GROUP BY good_id
                                    )
                                )

                        )";
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[0].HeaderText = "id товару";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[1].HeaderText = "Назва товару";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[2].HeaderText = "id категорії";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[3].HeaderText = "Назва категорії";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[4].HeaderText = "Ціна (собівартість)";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[5].HeaderText = "Кількість/Вага";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[6].HeaderText = "Загальна вартість";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[7].HeaderText = "Дата поставки";

                        while (reader.Read())
                        {

                            DataGridViewRow row = new DataGridViewRow();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row.Cells.Add(new DataGridViewTextBoxCell());
                                row.Cells[i].Value = reader[i];
                            }

                            dataGridView1.Rows.Add(row);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToolStripMenuItemMaxCost_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            panel1.Visible = false;


            string query = @"SELECT 
                                Receiving.good_id, 
                                Goods.name, 
                                Categories.id ,
                                Categories.name , 
                                Receiving.unit_cost, 
                                Receiving.number, 
                                Receiving.unit_cost * Receiving.number,
                                Receiving.delivery_date
                            FROM Receiving
                            INNER JOIN Goods ON Goods.id = Receiving.good_id
                            INNER JOIN Categories ON Categories.id = Goods.category_id
                            INNER JOIN Providers ON Providers.id = Receiving.provider_id
                            WHERE Receiving.good_id IN (
                                SELECT good_id
                                FROM Receiving
                                GROUP BY good_id
                                HAVING SUM(Receiving.unit_cost * Receiving.number) = (
                                    SELECT MAX(total_sum)
                                    FROM (
                                        SELECT SUM(Receiving.unit_cost * Receiving.number) AS total_sum
                                        FROM Receiving
                                        GROUP BY good_id
                                    )
                                )

                        )";
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[0].HeaderText = "id товару";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[1].HeaderText = "Назва товару";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[2].HeaderText = "id категорії";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[3].HeaderText = "Назва категорії";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[4].HeaderText = "Ціна (собівартість)";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[5].HeaderText = "Кількість/Вага";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[6].HeaderText = "Загальна вартість";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[7].HeaderText = "Дата поставки";


                        while (reader.Read())
                        {

                            DataGridViewRow row = new DataGridViewRow();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row.Cells.Add(new DataGridViewTextBoxCell());
                                row.Cells[i].Value = reader[i];
                            }

                            dataGridView1.Rows.Add(row);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToolStripMenuItemOldest_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            panel1.Visible = false;


            string query = @"SELECT 
                                Receiving.good_id, 
                                Goods.name AS good_name, 
                                Categories.id AS category_id,
                                Categories.name AS category_name,
                                Receiving.provider_id, 
                                Providers.name AS provider_name, 
                                Receiving.unit_cost, 
                                Receiving.number, 
                                Receiving.unit_cost * Receiving.number AS total_cost,
                                Receiving.delivery_date
                            FROM Receiving
                            INNER JOIN Goods ON Goods.id = Receiving.good_id
                            INNER JOIN Categories ON Categories.id = Goods.category_id
                            INNER JOIN Providers ON Providers.id = Receiving.provider_id
                            WHERE Receiving.delivery_date = (
                                SELECT MIN(Receiving.delivery_date)
                                FROM Receiving
                            )";
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[0].HeaderText = "id товару";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[1].HeaderText = "Назва товару";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[2].HeaderText = "id категорії";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[3].HeaderText = "Назва категорії";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[4].HeaderText = "id постачальника";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[5].HeaderText = "Назва постачальника";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[6].HeaderText = "Ціна (собівартість)";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[7].HeaderText = "Кількість/Вага";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[8].HeaderText = "Загальна вартість";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[9].HeaderText = "Дата поставки";


                        while (reader.Read())
                        {

                            DataGridViewRow row = new DataGridViewRow();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row.Cells.Add(new DataGridViewTextBoxCell());
                                row.Cells[i].Value = reader[i];
                            }

                            dataGridView1.Rows.Add(row);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToolStripMenuItemNumByProviders_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            panel1.Visible = false;


            string query = @"SELECT
                            Providers.id,
                            Providers.name AS provider_name,
                            SUM(Receiving.number) AS total_quantity
                        FROM
                            Receiving
                        INNER JOIN
                            Providers ON Providers.id = Receiving.provider_id
                        GROUP BY
                            Providers.name;
                        ";
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[0].HeaderText = "id постачальника";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[1].HeaderText = "Назва постачальника";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[2].HeaderText = "Кількість товарів";

                        


                        while (reader.Read())
                        {

                            DataGridViewRow row = new DataGridViewRow();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row.Cells.Add(new DataGridViewTextBoxCell());
                                row.Cells[i].Value = reader[i];
                            }

                            dataGridView1.Rows.Add(row);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToolStripMenuItemCostByProviders_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            panel1.Visible = false;


            string query = @"SELECT
                            Providers.id,
                            Providers.name AS provider_name,
                            SUM(Receiving.number*Receiving.unit_cost) AS total_sum
                        FROM
                            Receiving
                        INNER JOIN
                            Providers ON Providers.id = Receiving.provider_id
                        GROUP BY
                            Providers.name;
                        ";
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[0].HeaderText = "id постачальника";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[1].HeaderText = "Назва постачальника";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[2].HeaderText = "Загальна вартість товарів";




                        while (reader.Read())
                        {

                            DataGridViewRow row = new DataGridViewRow();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row.Cells.Add(new DataGridViewTextBoxCell());
                                row.Cells[i].Value = reader[i];
                            }

                            dataGridView1.Rows.Add(row);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToolStripMenuItemCostByCategories_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            panel1.Visible = false;


            string query = @"SELECT
                            Categories.id,
                            Categories.name AS Categories_name,
                            SUM(Receiving.number*Receiving.unit_cost) AS total_sum
                        FROM
                            Receiving
                        INNER JOIN
                            Goods ON Goods.id=Receiving.good_id
                        INNER JOIN
                            Categories ON Categories.id = Goods.category_id
                        GROUP BY
                            Categories.name;
                        ";
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[0].HeaderText = "id категорії";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[1].HeaderText = "Назва категорії";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[2].HeaderText = "Загальна вартість товарів";




                        while (reader.Read())
                        {

                            DataGridViewRow row = new DataGridViewRow();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row.Cells.Add(new DataGridViewTextBoxCell());
                                row.Cells[i].Value = reader[i];
                            }

                            dataGridView1.Rows.Add(row);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToolStripMenuItemNumByCategories_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            panel1.Visible = false;


            string query = @"SELECT
                            Categories.id,
                            Categories.name AS Categories_name,
                            SUM(Receiving.number) AS total_quantity
                        FROM
                            Receiving
                        INNER JOIN
                            Goods ON Goods.id=Receiving.good_id
                        INNER JOIN
                            Categories ON Categories.id = Goods.category_id
                        GROUP BY
                            Categories.name;
                        ";
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[0].HeaderText = "id постачальника";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[1].HeaderText = "Назва постачальника";

                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                        dataGridView1.Columns[2].HeaderText = "Кількість товарів";




                        while (reader.Read())
                        {

                            DataGridViewRow row = new DataGridViewRow();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row.Cells.Add(new DataGridViewTextBoxCell());
                                row.Cells[i].Value = reader[i];
                            }

                            dataGridView1.Rows.Add(row);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
