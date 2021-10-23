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
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=(localdb)\\ProjectsV13; Initial Catalog=Fruits_And_Vegetables; Integrated Security = true;";

            string createFruitsAndVegetablesInfoTableQuery = @"CREATE TABLE FruitsAndVegetablesInfo (
                                                                   Id INT IDENTITY(1,1) PRIMARY KEY,
                                                                   Name NVARCHAR(100) NOT NULL,
                                                                   Type NVARCHAR(100) NOT NULL,
                                                                   Color NVARCHAR(100) NOT NULL,
                                                                   CalorificValue INT NOT NULL)";


            FruitsAndVegetablesDBTool fruitsAndVegetablesDBTool = new FruitsAndVegetablesDBTool(connectionString);

            fruitsAndVegetablesDBTool.CreateNewTable(createFruitsAndVegetablesInfoTableQuery);



            //fruitsAndVegetablesDBTool.InsertNewValue("Apple", "Fruit", "Red", 130);
            fruitsAndVegetablesDBTool.InsertNewValue("Avocado", "Fruit", "Green", 50);
            fruitsAndVegetablesDBTool.InsertNewValue("Banana", "Fruit", "Yellow", 110);
            fruitsAndVegetablesDBTool.InsertNewValue("Grapefruit", "Fruit", "Orange", 60);
            fruitsAndVegetablesDBTool.InsertNewValue("Grape", "Fruit", "Violet", 90);
            fruitsAndVegetablesDBTool.InsertNewValue("Kiwi", "Fruit", "Nrown", 90);
            fruitsAndVegetablesDBTool.InsertNewValue("Lemon", "Fruit", "Yellow", 15);
            fruitsAndVegetablesDBTool.InsertNewValue("Lime", "Fruit", "Green", 100);
            fruitsAndVegetablesDBTool.InsertNewValue("Peach", "Fruit", "Orange", 60);
            fruitsAndVegetablesDBTool.InsertNewValue("Watermelon", "Fruit", "Green", 80);

            fruitsAndVegetablesDBTool.InsertNewValue("Bell Paper", "Vegetable", "Red", 25);
            fruitsAndVegetablesDBTool.InsertNewValue("Broccoli", "Vegetable", "Green", 45);
            fruitsAndVegetablesDBTool.InsertNewValue("Carrot", "Vegetable", "Orange", 30);
            fruitsAndVegetablesDBTool.InsertNewValue("Celery", "Vegetable", "Green", 15);
            fruitsAndVegetablesDBTool.InsertNewValue("Cucumber", "Vegetable", "Green", 10);
            fruitsAndVegetablesDBTool.InsertNewValue("Onion", "Vegetable", "Violet", 45);
            fruitsAndVegetablesDBTool.InsertNewValue("Potato", "Vegetable", "Brown", 110);
            fruitsAndVegetablesDBTool.InsertNewValue("Green Bees", "Vegetable", "Green", 20);
            fruitsAndVegetablesDBTool.InsertNewValue("Leaf Lettuce", "Vegetable", "Green", 15);
            fruitsAndVegetablesDBTool.InsertNewValue("Redishes", "Vegetable", "Red", 10);
        }
    }
}
