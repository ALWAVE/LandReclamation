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

namespace LandReclamation.Forms.AdminForms
{
    public partial class FeedbackForm : Form
    {
        public FeedbackForm()
        {
            InitializeComponent();
            LoadData();
            RefreshDataGrid(dataGridView1);
        }
        DBconnection dBConnection = new DBconnection();
        private void LoadData()
        {

            dataGridView1.Columns.Add("id_UserRating", "Id оценки"); //0//
            dataGridView1.Columns.Add("mark_Users", "Оценка"); //1//
            dataGridView1.Columns.Add("comment_Users", "Комментарий пользователя");//2//
            dataGridView1.Columns.Add("addressedTo", "Кому адресованно");//3//
            dataGridView1.Columns.Add("id_User", "Id пользователя");//4//
     
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetInt32(0),
                record.GetInt32(1),
                record.GetString(2),
                record.GetString(3),
                record.GetInt32(4)
            );

        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = "SELECT * FROM UserRating";
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
    }
}
