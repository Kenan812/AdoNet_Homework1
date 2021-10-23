using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace AdoNet_Homework1
{
    /// <summary>
    /// Interaction logic for Ex3Window.xaml
    /// </summary>
    public partial class Ex3Window : Window
    {
        private string _connectionString;

        public Ex3Window(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
        }

        private void ex3_1Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            string query = "SELECT Id,Name,Type,Color,CalorificValue FROM FruitsAndVegetablesInfo";

            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable("FruitsAndVegetablesInfo");
                dataAdapter.Fill(dataTable);
                tableDataGrid.ItemsSource = dataTable.DefaultView;
                dataAdapter.Update(dataTable);
                connection.Close();
            }
        }

        private void ex3_2Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            string query = @"SELECT Id, [Name] AS 'All Fruits and Vegetables Names'
                             FROM FruitsAndVegetablesInfo";

            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable("FruitsAndVegetablesInfo");
                dataAdapter.Fill(dataTable);
                tableDataGrid.ItemsSource = dataTable.DefaultView;
                dataAdapter.Update(dataTable);
                connection.Close();
            }
        }

        private void ex3_3Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            string query = @"SELECT [Color] AS 'All Fruits and Vegetables Colors'
                             FROM FruitsAndVegetablesInfo";

            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable("FruitsAndVegetablesInfo");
                dataAdapter.Fill(dataTable);
                tableDataGrid.ItemsSource = dataTable.DefaultView;
                dataAdapter.Update(dataTable);
                connection.Close();
            }
        }

        private void ex3_4Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            string query = @"SELECT MAX(CalorificValue) AS 'Max Calorific Value'
                             FROM FruitsAndVegetablesInfo";

            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable("FruitsAndVegetablesInfo");
                dataAdapter.Fill(dataTable);
                tableDataGrid.ItemsSource = dataTable.DefaultView;
                dataAdapter.Update(dataTable);
                connection.Close();
            }
        }

        private void ex3_5Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            string query = @"SELECT MIN(CalorificValue) AS 'Min Calorific Value'
                             FROM FruitsAndVegetablesInfo";

            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable("FruitsAndVegetablesInfo");
                dataAdapter.Fill(dataTable);
                tableDataGrid.ItemsSource = dataTable.DefaultView;
                dataAdapter.Update(dataTable);
                connection.Close();
            }
        }

        private void ex3_6Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            string query = @"SELECT AVG(CalorificValue) AS 'Average Calorific Value'
                             FROM FruitsAndVegetablesInfo";

            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable("FruitsAndVegetablesInfo");
                dataAdapter.Fill(dataTable);
                tableDataGrid.ItemsSource = dataTable.DefaultView;
                dataAdapter.Update(dataTable);
                connection.Close();
            }
        }
    }
}
