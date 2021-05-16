using System.Collections.Generic;
using System.Data.OleDb;

namespace FactoryManager.AppData.Services.Account
{
    public static class AccountService
    {
        public static List<DataModel.BankAccount> GetAllAccounts()
        {
            var connection = ConnectionService.OpenDatabaseConnection();

            OleDbCommand cmd = new OleDbCommand(
               @"SELECT Konton.[Konto_Id], Konton.[Konto], Konton.[Beskrivning] FROM Konton ORDER BY Konton.[Konto_Id] ASC;", connection);

            OleDbDataReader reader = cmd.ExecuteReader();

            var accounts = new List<DataModel.BankAccount>();

            while (reader.Read())
            {
                var account = new DataModel.BankAccount
                {
                    AccountId = reader[0].ToString(),
                    AccountNumber = reader[1].ToString(),
                    AccountPurpose = reader[2].ToString()
                };
                accounts.Add(account);
            }
            reader.Close();
            ConnectionService.CloseDatabaseConnection();
            return accounts;
        }
    }
}
