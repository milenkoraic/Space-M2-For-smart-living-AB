using FactoryManager.AppData;
using FactoryManager.ViewModel.GridForm;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace FactoryManager.BLL
{
    public static class ProjectService
    {
        public static void InsertProject(ProjectModel projectModel)
        {
            var connection = ConnectionService.CreateDatabaseConnection();
            OleDbCommand cmd = new OleDbCommand
            {
                CommandType = CommandType.Text,
                CommandText = "INSERT INTO Projekt ([Projektnummer],[Projektnamn],[Projektstatus],[Beskrivning],[Kundnamn],[Kommun]) values (?,?,?,?,?,?)"
            };
            cmd.Parameters.AddWithValue("@Projektnummer", projectModel.ProjectNumber);
            cmd.Parameters.AddWithValue("@Projektnamn", projectModel.ProjectName);
            cmd.Parameters.AddWithValue("@Projektstatus", projectModel.ProjectStatus);
            cmd.Parameters.AddWithValue("@Beskrivning", projectModel.ProjectDescription);
            cmd.Parameters.AddWithValue("@Kundnamn", projectModel.Customer);
            cmd.Parameters.AddWithValue("@Kommun", projectModel.Municipality);
            cmd.Connection = connection;

            cmd.ExecuteNonQuery();
            MessageBox.Show("Nytt projekt har lagts. Klicka på OK för att uppdatera datakällan!", "DATABASINFO");
            connection.Close();
        }

        public static void UpdateProject(ProjectModel projectModel, int projectNumber)
        {
            var connection = ConnectionService.CreateDatabaseConnection();
            OleDbCommand cmd = new OleDbCommand
            {
                CommandType = CommandType.Text,
                CommandText = "UPDATE Projekt SET [Projektnummer]=@Projektnummer,[Projektnamn]=@Projektnamn,[Projektstatus]=@Projektstatus,[Beskrivning]=@Beskrivning,[Kundnamn]=@Kundnamn,[Kommun]=@Kommun WHERE Projektnummer = @ID;"
            };
            cmd.Parameters.AddWithValue("@Projektnummer", projectModel.ProjectNumber);
            cmd.Parameters.AddWithValue("@Projektnamn", projectModel.ProjectName);
            cmd.Parameters.AddWithValue("@Projektstatus", projectModel.ProjectStatus);
            cmd.Parameters.AddWithValue("@Beskrivning", projectModel.ProjectDescription);
            cmd.Parameters.AddWithValue("@Kundnamn", projectModel.Customer);
            cmd.Parameters.AddWithValue("@Kommun", projectModel.Municipality);
            cmd.Parameters.AddWithValue("@ID", projectNumber);
            cmd.Connection = connection;

            cmd.ExecuteNonQuery();
            MessageBox.Show("Projektdata har uppdaterats framgångsrikt!", "DATABASINFO");
            connection.Close();
        }

        public static void DeleteProjectById(int id)
        {
            var connection = ConnectionService.CreateDatabaseConnection();
            OleDbCommand cmd = new OleDbCommand
            {
                CommandType = CommandType.Text,
                CommandText = "DELETE FROM Projekt WHERE ID = @ID;"
            };
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Connection = connection;

            cmd.ExecuteNonQuery();
            MessageBox.Show("Projektet har tagits bort från databasen.", "DATABASINFO");
            connection.Close();
        }
    }
}
