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
    public partial class Form1 : Form
    {
        DBconnection dBConnection = new DBconnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order order = new Order(username.Text, userid.Text, usersurname.Text);
            order.Show();

        }
        public Form1(string username1) : this()
        {
        
            string querystring = $"select id_users, userlogin ,user_role, username, surname from Users where userlogin = '{username1}'";


            using (SqlConnection connection = dBConnection.getConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(querystring, connection);

                userlogin.Text = username1;


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string userID = reader["id_users"].ToString();
                        string loginUsers = reader["userlogin"].ToString();
                        string userRole = reader["user_role"].ToString();
                        string nameUsers = reader["username"].ToString();
                        string surnameUsers = reader["surname"].ToString();

                        userid.Text = userID;
                        userrole.Text = userRole;
                        userlogin.Text = loginUsers;

                        username.Text = nameUsers;
                        usersurname.Text = surnameUsers;
                        if (userRole == "Пользователь")
                        {

                            button1.Visible = true;
                            button3.Visible = true;
                            button2.Visible = false;
                            button4.Visible = false;
                            MessageBox.Show("Вы зашли как Пользователь", "Успеx", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (userRole == "Работник")
                        {
                            button1.Visible = false;
                            button3.Visible = false;
                            button2.Visible = true;
                            button4.Visible = false;
                            MessageBox.Show("Вы зашли как Работник", "Успеx", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (userRole == "admin")
                        {
                            MessageBox.Show("Вы зашли как администратор", "Успеx", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    }
                    dBConnection.closeConnection();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker();
            worker.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewOrder viewOrder = new ViewOrder(userid.Text, username.Text, usersurname.Text);
            viewOrder.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LeaveAReviewForm leaveAReviewForm = new LeaveAReviewForm();
            leaveAReviewForm.Show();
        }
    }
}
