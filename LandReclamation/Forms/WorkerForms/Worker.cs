using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandReclamation
{
    public partial class Worker : Form
    {
        public Worker()
        {
            InitializeComponent();
            LoadData();
            RefreshDataGrid(dataGridView1);
        }
        DBconnection dBConnection = new DBconnection();
        private void LoadData()
        {

            dataGridView1.Columns.Add("id_land", "Id заказа"); //0//
            dataGridView1.Columns.Add("organization_name", "Наименование Организации"); //1//
            dataGridView1.Columns.Add("adress", "Адрес");//2//
            dataGridView1.Columns.Add("city", "Город");//3//
            dataGridView1.Columns.Add("additionalImprovedField", "Улучшенное поле");//4//
            dataGridView1.Columns.Add("additionalWeedingField", "Поле с прополкой");//5//
            dataGridView1.Columns.Add("size", "Размер поля");//6//
            dataGridView1.Columns.Add("price", "Цена");//7//
            dataGridView1.Columns.Add("id_belongs", "ID Покупателя");//8//
            dataGridView1.Columns.Add("create_data", "Дата Создания");//9//
            dataGridView1.Columns.Add("land_status", "Статус");//10//
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetInt32(0),
                record.GetString(1),
                record.GetString(2),
                record.GetString(3),
                record.GetString(4),
                record.GetString(5),
                record.GetString(6),
                record.GetInt64(7) + " Рублей", // Форматируем цену как валюту
                record.GetInt32(8),
                record.GetDateTime(9), // Форматируем дату
                record.GetString(10)
            );

        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = "SELECT * FROM LandReclamation";
            SqlCommand command = new SqlCommand(queryString, dBConnection.getConnection());

            dBConnection.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }

            reader.Close();
            dBConnection.closeConnection();


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            // Получаем ID документа из выбранной строки
            int landId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["id_land"].Value);

            string queryString = "UPDATE LandReclamation SET land_status = @status WHERE id_land = @landId";
            SqlCommand command = new SqlCommand(queryString, dBConnection.getConnection());

            // Используем параметры для безопасного выполнения запроса
            command.Parameters.AddWithValue("@status", "Выполнено");
            command.Parameters.AddWithValue("@landId", landId);

            command.ExecuteNonQuery();

            MessageBox.Show("Статус заказа успешно изменен на 'Выполнено'!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshDataGrid(dataGridView1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

          
            int landId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["id_land"].Value);

            string queryString = "UPDATE LandReclamation SET land_status = @status WHERE id_land = @landId";
            SqlCommand command = new SqlCommand(queryString, dBConnection.getConnection());

            // Используем параметры для безопасного выполнения запроса
            command.Parameters.AddWithValue("@status", "Отменено");
            command.Parameters.AddWithValue("@landId", landId);

            command.ExecuteNonQuery();
            MessageBox.Show("Статус заказа успешно изменен на 'Отменено'!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshDataGrid(dataGridView1);
        }
    }
}
