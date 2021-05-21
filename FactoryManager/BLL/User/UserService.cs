using FactoryManager.AppData;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace FactoryManager.BLL
{
    public static class UserService
    {

        public static bool ValidateUser(string password)
        {

            var connection = ConnectionService.CreateDatabaseConnection();

            bool isPasswordValid;

            OleDbCommand cmd = new OleDbCommand(
               @"SELECT  
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
            connection.Close();
            return isPasswordValid;
        }    

        public static UserModel GetLogedInUser(string password)
        {
            var connection = ConnectionService.CreateDatabaseConnection();
            var user = new UserModel();

            OleDbCommand cmd = new OleDbCommand(
                @"SELECT 
                        Användare.ID, 
                        Användare.Usernummer, 
                        Användare.Rollsnummer, 
                        Användare.Förnamn, 
                        Användare.Efternamn,
                        Användare.Lösenord,
                        Användare.BildLänk, 
                        AnvändareRoller.ID,
                        AnvändareRoller.Rollsnummer,
                        AnvändareRoller.RollNamn
                        FROM 
                        AnvändareRoller 
                        INNER JOIN Användare 
                        ON AnvändareRoller.Rollsnummer = Användare.Rollsnummer
                        WHERE Användare.Lösenord =" + "'" + password + "';", connection);

            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                user.Id = Convert.ToInt32(reader[0]);
                user.Number = Convert.ToInt32(reader[1]);
                user.RoleNumber = Convert.ToInt32(reader[2]);
                user.FirstName= reader[3].ToString();
                user.LastName = reader[4].ToString();
                user.Password = reader[5].ToString();
                user.ImagePath = reader[6].ToString();
                user.RoleId = Convert.ToInt32(reader[7]);
                user.RoleNumber = Convert.ToInt32(reader[8]);
                user.RoleName = reader[9].ToString();
            }
            reader.Close();
            connection.Close();
            return user;
        }
        public static void InsertNewUser(UserModel userModel)
        {
            var connection = ConnectionService.CreateDatabaseConnection();

            OleDbCommand cmd = new OleDbCommand
            {
                CommandType = CommandType.Text,
                CommandText = "INSERT INTO Projekt ([Projektnummer],[Projektnamn],[Projektstatus],[Beskrivning],[Kundnamn],[Kommun]) values (?,?,?,?,?,?)"
            };
            //cmd.Parameters.AddWithValue("@Projektnummer", userModel.ProjectNumber);
            //cmd.Parameters.AddWithValue("@Projektnamn", userModel.ProjectName);
            //cmd.Parameters.AddWithValue("@Projektstatus", userModel.ProjectStatus);
            //cmd.Parameters.AddWithValue("@Beskrivning", userModel.ProjectDescription);
            //cmd.Parameters.AddWithValue("@Kundnamn", userModel.Customer);
            //cmd.Parameters.AddWithValue("@Kommun", userModel.Municipality);
            cmd.Connection = connection;

            cmd.ExecuteNonQuery();

            MessageBox.Show("Nytt projekt har lagts. Klicka på OK för att uppdatera datakällan!", "DATABASINFO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            connection.Close();
        }
    }
}
