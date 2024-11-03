using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandReclamation
{
    class DBconnection
    {

        //Класс подключения Базы данных к проекту DESKTOP-LKJLFLS\SQLEXPRESS это наименование локального компьютера на котором созданна база данных dbLand
        //The class of Database connection to the DESKTOP-LKJLFLS\SQLEXPRESS is the name of the local computer on which the dbLand database was created

        SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-LKJLFLS\SQLEXPRESS; Initial Catalog = dbLand; Integrated Security = True");

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
