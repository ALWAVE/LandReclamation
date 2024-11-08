using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandReclamation
{
    public partial class LeaveAReviewForm : Form
    {
        private string ids;
        public LeaveAReviewForm(string id) : this() 
        { 
            ids= id;    
        }
        public LeaveAReviewForm()
        {
            InitializeComponent();
        }
        DBconnection dBconnection = new DBconnection();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();        
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string quary = $"insert into UserRating(mark_Users, comment_Users, addressedTo, id_User)" +
                $"values ('{comboBox1.Text}', '{richTextBox1.Text}', '{textBox1.Text}','{ids}')";
           
            SqlCommand sqlCommand = new SqlCommand(quary, dBconnection.getConnection());
            dBconnection.openConnection();

            // Выполнение запроса
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Спасибо за отзыв");
            }
            else
            {
                MessageBox.Show("Произошла ошибка при отправки отзыва.");
            }

            dBconnection.closeConnection();
        }
    }
}
