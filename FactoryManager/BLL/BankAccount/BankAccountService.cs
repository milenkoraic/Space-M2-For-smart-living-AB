using FactoryManager.AppData;
using System.Collections.Generic;
using System.Data.OleDb;

namespace FactoryManager.BLL
{
    public static class BankAccountService
    {
        public static List<BankAccountModel> GetAllAccounts()
        {
            var connection = ConnectionService.CreateDatabaseConnection();

            OleDbCommand cmd = new OleDbCommand(
               @"SELECT Konton.[Konto_Id], Konton.[Konto], Konton.[Beskrivning] FROM Konton ORDER BY Konton.[Konto_Id] ASC;", connection);

            OleDbDataReader reader = cmd.ExecuteReader();

            var accounts = new List<BankAccountModel>();

            while (reader.Read())
            {
                var account = new BankAccountModel
                {
                    AccountId = reader[0].ToString(),
                    AccountNumber = reader[1].ToString(),
                    AccountPurpose = reader[2].ToString()
                };
                accounts.Add(account);
            }
            reader.Close();
            connection.Close();
            return accounts;
        }
    }
}
