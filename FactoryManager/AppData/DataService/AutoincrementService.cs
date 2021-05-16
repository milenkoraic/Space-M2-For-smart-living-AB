using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryManager.ViewModel.GridForm;

namespace FactoryManager.AppData.DataService
{
    public class AutoincrementService
    {
        public static AutoincrementViewModel GetAutoincrementProjectNumber()
        {
            AutoincrementViewModel autoincrementViewModel = new AutoincrementViewModel();

            var connection = ConnectionService.OpenDatabaseConnection();

            OleDbCommand cmd = new OleDbCommand(
               @"SELECT Projekt_Id FROM Projekt WHERE Projekt_Id = ( SELECT MAX(Projekt_Id) FROM Projekt);", connection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                autoincrementViewModel.Id = Convert.ToInt32(reader[0]) + 1;
            }
            reader.Close();
            ConnectionService.CloseDatabaseConnection();

            var connection2 = ConnectionService.OpenDatabaseConnection();
            OleDbCommand cmd2 = new OleDbCommand(
               @"SELECT MAX([Proj nr]) FROM Projekt WHERE [Proj nr] < ( SELECT MAX([Proj nr]) FROM Projekt)", connection2);
            OleDbDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                autoincrementViewModel.Number = Convert.ToInt32(reader2[0]) + 1;
            }
            reader2.Close();
            ConnectionService.CloseDatabaseConnection();

            return autoincrementViewModel;
        }
    }
}
