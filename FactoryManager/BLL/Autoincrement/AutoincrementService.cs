using System;
using System.Data.OleDb;
using FactoryManager.AppData;
using FactoryManager.ViewModel.GridForm;

namespace FactoryManager.BLL
{
    public class AutoincrementService
    {
        public static AutoincrementModel GetAutoincrementNumber(string firstColumName, string secondColumName, string tableName)
        {
            AutoincrementModel autoincrementModel = new AutoincrementModel();
            var connection = ConnectionService.CreateDatabaseConnection();
            var commandString = @"SELECT  " + firstColumName + "," + secondColumName + " FROM " + tableName + " WHERE " + firstColumName + " = ( SELECT MAX(" + firstColumName + ") FROM " + tableName + ") AND ( SELECT MAX(" + secondColumName + ") FROM " + tableName + ");";

            OleDbCommand cmd = new OleDbCommand(commandString, connection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                autoincrementModel.Id = Convert.ToInt32(reader[0]) + 1;
                autoincrementModel.Number = Convert.ToInt32(reader[1]) + 1;
            }
            reader.Close();
            connection.Close(); 
            return autoincrementModel;
        }
    }
}
