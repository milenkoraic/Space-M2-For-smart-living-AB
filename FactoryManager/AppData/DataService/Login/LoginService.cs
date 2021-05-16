using System.Data.OleDb;
using FactoryManager.ViewModel.LoginForm;

namespace FactoryManager.AppData.Services.Login
{
    public static class LoginService
    {

        public static bool ValidateUser(string password)
        {

            var connection = ConnectionService.OpenDatabaseConnection();

            bool isPasswordValid;

            OleDbCommand cmd = new OleDbCommand(
               @"SELECT 
                        Användar_Id, 
                        Roll_Id, 
                        Förnamn, 
                        Efternamn, 
                        Lösenord
                        FROM 
                        Användare
                        WHERE Lösenord = @password", connection);
            cmd.Parameters.AddWithValue("@password", password);

            OleDbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                isPasswordValid = true;
            }
            else
            {
                isPasswordValid = false;
            }
            reader.Close();
            ConnectionService.CloseDatabaseConnection();
            return isPasswordValid;
        }    

        public static UserViewModel GetLogedInUser(string password)
        {
            var connection = ConnectionService.OpenDatabaseConnection();
            var user = new UserViewModel();

            OleDbCommand cmd = new OleDbCommand(
                @"SELECT 
                        Användare.Roll_Id, 
                        Användare.Förnamn, 
                        Användare.Efternamn, 
                        Användare_Roller.Roll_Namn
                        FROM 
                        Användare_Roller 
                        INNER JOIN Användare 
                        ON Användare_Roller.Roll_Id = Användare.[Roll_Id]
                        WHERE Användare.Lösenord =" + "'" + password + "';", connection);

            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                user.RoleId = reader[0].ToString();
                user.FirstName= reader[1].ToString();
                user.LastName = reader[2].ToString();
                user.RoleName = reader[3].ToString();
            }
            reader.Close();
            ConnectionService.CloseDatabaseConnection();
            return user;
        }
    }
}
