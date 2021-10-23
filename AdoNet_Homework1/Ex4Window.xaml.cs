using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace AdoNet_Homework1
{
    /// <summary>
    /// Interaction logic for Ex4Window.xaml
    /// </summary>
    public partial class Ex4Window : Window
    {
        private string _connectionString;

        public Ex4Window(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
        }

        private void ex4_1Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            string query = @"SELECT COUNT(Id) AS 'Total number of vegetables'
                             FROM FruitsAndVegetablesInfo
                             WHERE [Type] LIKE 'Vegetable'";

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

        private void ex4_2Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            string query = @"SELECT COUNT(Id) AS 'Total number of vegetables'
                             FROM FruitsAndVegetablesInfo
                             WHERE [Type] LIKE 'Fruit'";

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

        private void ex4_3Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            string query = $"SELECT COUNT(Id) AS 'Total number of fruits and vegetables of provided color' FROM FruitsAndVegetablesInfo WHERE Color LIKE '{colorTextBox.Text}'";

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

        private void ex4_4Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            string query = @"SELECT Color, COUNT(Id) AS 'Total number of fruits and vegetabes'
                             FROM FruitsAndVegetablesInfo
                             GROUP BY Color";

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

        private void ex4_5Button_Click(object sender, RoutedEventArgs e)
        {
            if (maxCalorityTextBox.Text == String.Empty) return;

            try { Int32.Parse(maxCalorityTextBox.Text); }
            catch (Exception) { return; }

            SqlConnection connection = new SqlConnection(_connectionString);
            string query = $"SELECT [Name] FROM FruitsAndVegetablesInfo WHERE CalorificValue < '{maxCalorityTextBox.Text}'";

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

        private void ex4_6Button_Click(object sender, RoutedEventArgs e)
        {
            if (minCalorityTextBox.Text == String.Empty) return;

            try { Int32.Parse(minCalorityTextBox.Text); }
            catch (Exception) { return; }

            SqlConnection connection = new SqlConnection(_connectionString);
            string query = $"SELECT [Name] FROM FruitsAndVegetablesInfo WHERE CalorificValue > '{minCalorityTextBox.Text}'";

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

        private void ex4_7Button_Click(object sender, RoutedEventArgs e)
        {
            if (lowerBoundTextBox.Text == String.Empty) return;
            if (upperBoundTextBox.Text == String.Empty) return;

            int l, u;

            try { l = Int32.Parse(lowerBoundTextBox.Text); }
            catch (Exception) { return; }

            try { u = Int32.Parse(upperBoundTextBox.Text); }
            catch (Exception) { return; }

            if (l > u)
            {
                int temp = u;
                u = l;
                l = temp;
            }


            SqlConnection connection = new SqlConnection(_connectionString);
            string query = $"SELECT [Name] FROM FruitsAndVegetablesInfo WHERE CalorificValue > {l} AND CalorificValue < {u}  ";

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

        private void ex4_8Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            string query = @"SELECT [Name]
                             FROM FruitsAndVegetablesInfo
                             WHERE Color LIKE 'Yellow' OR Color LIKE 'Red'";

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
