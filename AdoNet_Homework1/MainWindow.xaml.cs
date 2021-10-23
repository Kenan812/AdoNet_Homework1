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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AdoNet_Homework1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _isConnected = false;
        private string _connectionString = "Data Source=(localdb)\\ProjectsV13; Initial Catalog=Fruits_And_Vegetables; Integrated Security = true;";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void makeConnectionButton_Click(object sender, RoutedEventArgs e)
        {
            _isConnected = true;
            MessageBox.Show("You are now connected to DB 'Fruits_And_Vegetables'", "Connection Successful", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void disconnectionButton_Click(object sender, RoutedEventArgs e)
        {
            _isConnected = false;
            MessageBox.Show("You are now disconnected from DB 'Fruits_And_Vegetables'", "Disconnection Successful", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void ex3SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (!_isConnected) 
            {
                MessageBox.Show("You are disconnected from DB 'Fruits_And_Vegetables'", "Not connected to DB", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            Ex3Window ex3Window = new Ex3Window(_connectionString);
            ex3Window.ShowDialog();
        }

        private void ex4SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (!_isConnected)
            {
                MessageBox.Show("You are disconnected from DB 'Fruits_And_Vegetables'", "Not connected to DB", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            Ex4Window ex4Window = new Ex4Window(_connectionString);
            ex4Window.ShowDialog();
        }
    }
}
