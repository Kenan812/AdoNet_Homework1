using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Ex1
{
    class DBTableTool
    {
        private string _connectionString;

        public DBTableTool(string connectionString)
        {
            _connectionString = connectionString;
        }


        // Creates table using 'tableQuery'
        public void CreateTable(string tableQuery)
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            using (connection)
            {
                connection.Open();

                if (!CheckTableExistance(tableQuery))
                {
                    SqlCommand command = new SqlCommand(tableQuery, connection);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Command executed successfully");
                }

                else
                {
                    Console.WriteLine("Table alredy exists in this database");
                }
            }
        }

              
        public void InsertValue(string name, string type, string color, int colorificValue)
        {
            string query = $"INSERT INTO FruitsAndVegetablesInfo([Name], [Type], [Color], [CalorificValue]) VALUES('{name}', '{type}', '{color}', {colorificValue})";

            SqlConnection connection = new SqlConnection(_connectionString);

            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();

                Console.WriteLine("Insetion successfull");
            }
        }


        // Returns 'true' if query creates existing table
        // Returns 'false' otherwise
        private bool CheckTableExistance(string query)
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            string tableName = GetTableNameFromQuery(query);

            connection.Open();

            List<string> tableNames = new List<string>();
            DataTable dataTable = connection.GetSchema("Tables");

            foreach (DataRow row in dataTable.Rows)
            {
                string dbTableName = row[2].ToString();

                if (dbTableName == tableName) return true;  // Table already exists in DB

            }

            return false;
        }


        // Gets create table query
        // Returns table Name
        private string GetTableNameFromQuery(string query)
        {
            string tableName = String.Empty;

            for (int i = 13; i < query.Length; i++)
            {
                if (query[i] == ' ' || query[i] == '\n' || query[i] == '(')
                {
                    break;
                }

                tableName += query[i];
            }

            return tableName;
        }
    }
}
