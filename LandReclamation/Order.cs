using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LandReclamation
{
    public partial class Order : Form
    {
        private int TotalPrice = 0;
        DBconnection dBConnection = new DBconnection();
        public Order()
        {
            InitializeComponent();
        }
        private string user_name;
        private string user_id;
        private string user_surname;
        public Order(string username, string userid, string surname) : this()
        {
            user_name = username;
            user_surname = surname;
            user_id = userid;
        }
        private void Additional_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Улучшенный полив поля - Используем самый лучший аппарат, который удобряет почву\n" +
                "2. Прополка поля - Если ваше поле не вспахано, мы поможем его вспахать \n", "Информация о дополниях", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void PrideHectar()
        {

            int[] prices = {250000,500000,750000,1000000,1250000,1500000,1750000,2000000,2500000,2750000 };
            int selectedIndexFieldSize = FieldSize.SelectedIndex;
            if (selectedIndexFieldSize >= 0 && selectedIndexFieldSize < prices.Length)
            {
                TotalPrice = prices[selectedIndexFieldSize];
            }
        }
        public void PriceCity()
        {
            string selectedCity = City.SelectedItem.ToString();
            if (selectedCity == "Энгельс")
            {
                TotalPrice -= (int)(TotalPrice * 0.05);
            }
            else if (selectedCity == "Саратов")
            {

            }
            else if (selectedCity == "Самара")
            {
                TotalPrice += (int)(TotalPrice * 0.05);
            }
            else if (selectedCity == "Балашово")
            {
                TotalPrice += (int)(TotalPrice * 0.10);
            }
            else if (selectedCity == "Балашов")
            {
                TotalPrice += (int)(TotalPrice * 0.11);
            }
            else if (selectedCity == "Вольск")
            {
                TotalPrice += (int)(TotalPrice * 0.15);
            }
            else if (selectedCity == "Пугачёв")
            {
                TotalPrice += (int)(TotalPrice * 0.15);
            }
            else if (selectedCity == "Маркс")
            {
                TotalPrice += (int)(TotalPrice * 0.19);
            }
            else if (selectedCity == "Москва")
            {
                TotalPrice += (int)(TotalPrice * 0.25);
            }
        }
        private void CheackedAddition()
        {
            string selectedOneAddition = OneAddition.SelectedItem.ToString();
            if(selectedOneAddition == "Нету")
            {
               
            }
            else
            {
                TotalPrice += (int)(TotalPrice * 1.4);
            }
            string selectedTwoAddition = TwoAddition.SelectedItem.ToString();
            if (selectedTwoAddition == "Нету")
            {

            }
            else
            {
                TotalPrice += (int)(TotalPrice * 0.50);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();    
        }
        
        private void BtnViewTotalPrice_Click(object sender, EventArgs e)
        {
            PrideHectar();
            PriceCity();
            CheackedAddition();

            TotalPriceName.Visible = true;
            Label_TotalPrice.Visible = true;
            BtnAccept.Visible = true;
            BtnRefuse.Visible = true;
            
            Label_TotalPrice.Text = TotalPrice.ToString() + " Рублей";
        }

        private void BtnRefuse_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Быстро купил чорт, для тебя {TotalPrice} рублей это дорого? ты че нищий? Нафиг ты сюда тогда зашел полупокер вонючий! Продай свои поля нищиброд... ", "Опа...опа... не в ту игру играешь детка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {

            var name_orga = NameOrganization.Text;
            var adress = LocationField.Text;
            var yourCity = City.SelectedItem.ToString();
            var additionalImpovedField = OneAddition.SelectedItem.ToString();
            var additionalWeddingField = TwoAddition.SelectedItem.ToString();
            var sizeField = FieldSize.SelectedItem.ToString();
            var price = Convert.ToInt64(TotalPrice);
            var idBelongs = Convert.ToInt64(user_id);
            var dateCreate = DateTime.Now;
            var landStatus = "В процессе";

            // Формируем запрос с использованием параметров
            string querystring = @"
            INSERT INTO LandReclamation 
            (organization_name, adress, city, additionalImprovedField, additionalWeedingField, size, price,id_belongs, create_data, land_status) 
            VALUES (@name_orga, @adress, @yourCity, @additionalImpovedField, @additionalWeddingField, @sizeField, @price,@idBelongs, @dateCreate, @landStatus)"
            ;

            using (SqlCommand command = new SqlCommand(querystring, dBConnection.getConnection()))
            {
                command.Parameters.AddWithValue("@name_orga", name_orga);
                command.Parameters.AddWithValue("@adress", adress);
                command.Parameters.AddWithValue("@yourCity", yourCity);
                command.Parameters.AddWithValue("@additionalImpovedField", additionalImpovedField);
                command.Parameters.AddWithValue("@additionalWeddingField", additionalWeddingField);
                command.Parameters.AddWithValue("@sizeField", sizeField);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@idBelongs", idBelongs);
                command.Parameters.AddWithValue("@dateCreate", dateCreate);
                command.Parameters.AddWithValue("@landStatus", landStatus);

                dBConnection.openConnection();

                // Выполнение запроса
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Данные успешно добавлены в базу данных!");
                }
                else
                {
                    MessageBox.Show("Произошла ошибка при добавлении данных.");
                }

                dBConnection.closeConnection();
            }

            MessageBox.Show("Данные успешно добавлены в базу данных!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyWorker.Visible = true;
        }
    }
}
