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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace LandReclamation
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        DBconnection dBConnection = new DBconnection();
        private Boolean checkuser()
        {
            var loginUser = textBoxYourLogin.Text;
            var passUser = textBoxYourPassword.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_users from Users where userlogin = @loginUser";
            SqlCommand command = new SqlCommand(querystring, dBConnection.getConnection());
            command.Parameters.AddWithValue("@loginUser", loginUser);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует!");
                return true;
            }
            else
            {

                return false;
            }
        }
        private Boolean checkLoginLength(string login)
        {
            if (login.Length < 5)
            {
                MessageBox.Show("Логин должен состоять как минимум из 5 символов!");
                return false;
            }
            return true;
        }
        private Boolean cheackName(string name)
        {
            if (name.Length < 2)
            {
                MessageBox.Show("Имя должен состоять как минимум из 2 символов! и Введите ваше настоящие имя Пожалуйста");
                return false;
            }
            if (name == "aaaaa")
            {
                MessageBox.Show("Введите пожалуйста ваше настоящие имя");
                return false;
            }
            else if (name == "12345")
            {
                MessageBox.Show("Введите пожалуйста ваше настоящие имя");
                return false;
            }
            else if (name == "qwerty")
            {
                MessageBox.Show("Введите пожалуйста ваше настоящие имя");
                return false;
            }
            else if (name == "qwerty")
            {
                MessageBox.Show("Введите пожалуйста ваше настоящие имя");
                return false;
            }
            else if (name == "11111")
            {
                MessageBox.Show("Введите пожалуйста ваше настоящие имя");
                return false;
            }
            else if (name == "123")
            {
                MessageBox.Show("Введите пожалуйста ваше настоящие имя");
                return false;
            }
            else if (name == "qwe")
            {
                MessageBox.Show("Введите пожалуйста ваше настоящие имя");
                return false;
            }
            else if (name == "qqq")
            {
                MessageBox.Show("Введите пожалуйста ваше настоящие имя");
                return false;
            }
            return true;
        }
        private Boolean checkPasswordLength(string password)
        {
            if (password.Length < 5)
            {
                MessageBox.Show("Пароль должен состоять как минимум из 5 символов!");
                return false;
            }
            return true;
        }
        

        private void btnRegistation_Click(object sender, EventArgs e)
        {
            var login = textBoxYourLogin.Text;
            var password = textBoxYourPassword.Text;
            var name = textBoxYourName.Text;
            var surName = textBoxYourSurname.Text;
            string user_role = "Пользователь";
            string querystring = $"insert into Users(userlogin, user_role, user_password, username, surname) values('{login}','{user_role}','{password}', '{name}','{surName}')";
            if (!checkLoginLength(login))
            {
                return; // Если длина логина недостаточна, прекращаем выполнение метода
            }
            if (!checkPasswordLength(password))
            {
                return;
            }
            if (!cheackName(name))
            {
                return ;
            }
            SqlCommand command = new SqlCommand(querystring, dBConnection.getConnection());

            dBConnection.openConnection();
            if (checkuser())

            {
                return;
            }

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успешное создание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Authorization authorization = new Authorization();
                this.Hide();

                authorization.ShowDialog();

            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }

            dBConnection.closeConnection();
        }

        private void backIcon_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.ShowDialog();
            this.Hide();
        }
    }
}
