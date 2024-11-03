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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
        DBconnection dbConnection = new DBconnection();

        private void btnAuth_Click(object sender, EventArgs e)
        {
            var loginUser = textBox1.Text;
            var passUser = textBox2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_users, userlogin, user_password from Users where userlogin = '{loginUser}' and user_password = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dbConnection.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);



            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1 menu = new Form1(textBox1.Text);

                this.Hide();

                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Увы.. Братец или Сестренка такого аккаунта не существует!", "Акаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
