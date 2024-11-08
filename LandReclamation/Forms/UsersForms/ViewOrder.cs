using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Interop.Word;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Application = Microsoft.Office.Interop.Word.Application;
using Document = Microsoft.Office.Interop.Word.Document;




namespace LandReclamation
{
    public partial class ViewOrder : Form
    {
        private string currentUserId;
        private string currentUserName;
        private string currentSurname;
        DBconnection dBConnection = new DBconnection();
        public ViewOrder(string idUser, string nameUser, string surnameUser) : this()
        {

            currentUserId = idUser;
            currentUserName = nameUser;
            currentSurname = surnameUser;
            label1.Text = currentUserId;
            RefreshDataGrid(dataGridView1);
        }



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
            if (int.TryParse(label1.Text, out int userId))
            {
                string queryString = "SELECT * FROM LandReclamation WHERE id_belongs = @currentUserId";
                SqlCommand command = new SqlCommand(queryString, dBConnection.getConnection());

                command.Parameters.AddWithValue("@currentUserId", label1.Text);

                dBConnection.openConnection();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ReadSingleRow(dgw, reader);
                }

                reader.Close();
                dBConnection.closeConnection();
            }

        }
        public ViewOrder()
        {
            InitializeComponent();
            LoadData();
            RefreshDataGrid(dataGridView1);
        }

       


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        private void GiveCheack_Click(object sender, EventArgs e)
        {
            
            int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            if (selectedRowIndex >= 0)
            {
                string status = dataGridView1.Rows[selectedRowIndex].Cells["land_status"].Value.ToString();


                if (status == "Выполнено")
                {
                    string inputFilePath = $@"{System.Windows.Forms.Application.StartupPath}\Receipt\Example.docx";
                    string outputFilePath = $@"{System.Windows.Forms.Application.StartupPath}\Receipt\receipt {DateTime.Now.ToString("dd-mm-yyyy hh-mm-ss")}.pdf";

                    string additionalImprovedField = dataGridView1.Rows[selectedRowIndex].Cells["additionalImprovedField"].Value.ToString();
                    string additionalWeedingField = dataGridView1.Rows[selectedRowIndex].Cells["additionalWeedingField"].Value.ToString();

                    var replacements = new System.Collections.Generic.Dictionary<string, string>
                    {
                    {"<id_land>", $"{dataGridView1.Rows[selectedRowIndex].Cells["id_land"].Value.ToString()}"},
                    {"<orga_name>", $"{dataGridView1.Rows[selectedRowIndex].Cells["organization_name"].Value.ToString()}"},
                    {"<adress>", $"{dataGridView1.Rows[selectedRowIndex].Cells["adress"].Value.ToString()}"},
                    {"<city>", $"{dataGridView1.Rows[selectedRowIndex].Cells["city"].Value.ToString()}"},
                    {"<size>", $"{dataGridView1.Rows[selectedRowIndex].Cells["size"].Value.ToString()}"},
                    {"<data_order>", $"{dataGridView1.Rows[selectedRowIndex].Cells["create_data"].Value.ToString()}"},
                    {"<id_belongs>", $"{dataGridView1.Rows[selectedRowIndex].Cells["id_belongs"].Value.ToString()}"},
                    {"<username>", $"{currentUserName}"},
                    {"<surname>", $"{currentSurname}"},
                    {"<additionalImprovedField>", additionalImprovedField},
                    {"<additionalWeedingField >", additionalWeedingField},
                    {"<price>", $"{dataGridView1.Rows[selectedRowIndex].Cells["price"].Value.ToString()}"},
                    };
                    if (ReplaceTags(inputFilePath, outputFilePath, replacements) == true)
                    {
                        MessageBox.Show("Чек сделан", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Документ еще не выполнен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите документ из списка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static bool ReplaceTags(string inputFilePath, string outputFilePath, Dictionary<string, string> replacements)
        {
            Application wordApp = new Application();

            try
            {
                Document doc = wordApp.Documents.Open(inputFilePath, ReadOnly: true);
                Range range = doc.Content;
                Document newDoc = wordApp.Documents.Add();
                range.Copy();
                newDoc.Range().Paste();

                foreach (var replacement in replacements)
                {
                    newDoc.Content.Find.Execute(FindText: replacement.Key, ReplaceWith: replacement.Value, Replace: WdReplace.wdReplaceAll);
                }
                newDoc.SaveAs2(outputFilePath, WdSaveFormat.wdFormatPDF);
                newDoc.Close(SaveChanges: false);
                Process.Start(outputFilePath);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при формировании чека: " + ex.Message, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }
            finally
            {
                wordApp.Quit();
            }

        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
