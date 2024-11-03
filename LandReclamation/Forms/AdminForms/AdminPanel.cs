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
    public partial class AdminPanel : Form
    {
        DBconnection dBConnection = new DBconnection();

        private void LoadData()
        {
            dataGridView1.Columns.Add("id_users", "Id пользователя");
            dataGridView1.Columns.Add("userlogin", "Имя пользователя");
            dataGridView1.Columns.Add("user_role", "Роль пользователя");
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2)/*, record.GetBoolean(3)*/);

        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = "SELECT id_users, userlogin, user_role FROM Users"; // Выбираем только нужные столбцы

            SqlCommand command = new SqlCommand(queryString, dBConnection.getConnection());

            dBConnection.openConnection();

            try // Используем try-catch для обработки ошибок
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ReadSingleRow(dgw, reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении данных из базы данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dBConnection.closeConnection();
            }

        }
        public AdminPanel()
        {
            InitializeComponent();
            LoadData();
            RefreshDataGrid(dataGridView1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UpStatus_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            // Получение ID пользователя из выбранной строки
            int userId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["id_users"].Value);

            // Запрос новой роли (например, через диалоговое окно)
            string newRole = "Работник"; // Замените на способ получения новой роли от пользователя
            DialogResult result = MessageBox.Show($"Вы уверены, что хотите изменить роль пользователя с ID {userId} на '{newRole}'?",
                                                  "Подтверждение",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string queryString = "UPDATE Users SET user_role = @newRole WHERE id_users = @userId";
                SqlCommand command = new SqlCommand(queryString, dBConnection.getConnection());

                // Используем параметры для безопасного выполнения запроса
                command.Parameters.AddWithValue("@newRole", newRole);
                command.Parameters.AddWithValue("@userId", userId);

                try
                {
                    dBConnection.openConnection(); // Открываем соединение перед выполнением запроса
                    command.ExecuteNonQuery();
                    MessageBox.Show("Роль пользователя успешно изменена!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGrid(dataGridView1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при обновлении роли пользователя: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dBConnection.closeConnection(); // Закрываем соединение в блоке finally
                }
            }
        }
    }
}