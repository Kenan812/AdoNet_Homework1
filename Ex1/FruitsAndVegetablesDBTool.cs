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
    class FruitsAndVegetablesDBTool
    {
        private string _connectionString;

        public FruitsAndVegetablesDBTool(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void CreateNewTable(string tableQuery)
        {
            DBTableTool dBTableTool = new DBTableTool(_connectionString);
            dBTableTool.CreateTable(tableQuery);
        }

        public void InsertNewValue(string name, string type, string color, int colorificValue)
        {
            DBTableTool dBTableTool = new DBTableTool(_connectionString);
            dBTableTool.InsertValue(name, type, color, colorificValue);
        }

    }
}
