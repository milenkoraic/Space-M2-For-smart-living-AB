using FactoryManager.AppData;
using FactoryManager.View.AppDialog;
using FactoryManager.ViewModel.GridForm;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace FactoryManager.BLL
{
    public static class ProjectService
    {
        public static DataTable Fill(DevExpress.XtraGrid.GridControl gridControl)
        {
            string query = "SELECT * FROM Projekt";
            var connection = ConnectionService.CreateDatabaseConnection();
            OleDbCommand command = new OleDbCommand(query, connection);

            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            gridControl.BindingContext = new BindingContext();
            gridControl.DataSource = dataTable;
            connection.Close();
            return dataTable;
        }

        public static void InsertProject(ProjectModel project)
        {
            var connection = ConnectionService.CreateDatabaseConnection();
            OleDbCommand cmd = new OleDbCommand
            {
                CommandType = CommandType.Text,
                CommandText = "INSERT INTO Projekt ([Projektnummer],[Projektnamn],[Projektstatus],[Beskrivning],[Kundnamn],[Kommun]) values (?,?,?,?,?,?)"
            };
            cmd.Parameters.AddWithValue("@Projektnummer", project.Number);
            cmd.Parameters.AddWithValue("@Projektnamn", project.Name);
            cmd.Parameters.AddWithValue("@Projektstatus", project.Status);
            cmd.Parameters.AddWithValue("@Beskrivning", project.Description);
            cmd.Parameters.AddWithValue("@Kundnamn", project.Customer);
            cmd.Parameters.AddWithValue("@Kommun", project.Municipality);
            cmd.Connection = connection;

            cmd.ExecuteNonQuery();
            NotificationDialog.ShowBox("Nytt projekt har lagts. Klicka på OK för att uppdatera datakällan!", "DATABASINFO");
            connection.Close();
        }

        public static void UpdateProject(ProjectModel project, int projectNumber)
        {
            var connection = ConnectionService.CreateDatabaseConnection();
            OleDbCommand cmd = new OleDbCommand
            {
                CommandType = CommandType.Text,
                CommandText = "UPDATE Projekt SET [Projektnummer]=@Projektnummer,[Projektnamn]=@Projektnamn,[Projektstatus]=@Projektstatus,[Beskrivning]=@Beskrivning,[Kundnamn]=@Kundnamn,[Kommun]=@Kommun WHERE Projektnummer = @ID;"
            };
            cmd.Parameters.AddWithValue("@Projektnummer", project.Number);
            cmd.Parameters.AddWithValue("@Projektnamn", project.Name);
            cmd.Parameters.AddWithValue("@Projektstatus", project.Status);
            cmd.Parameters.AddWithValue("@Beskrivning", project.Description);
            cmd.Parameters.AddWithValue("@Kundnamn", project.Customer);
            cmd.Parameters.AddWithValue("@Kommun", project.Municipality);
            cmd.Parameters.AddWithValue("@ID", projectNumber);
            cmd.Connection = connection;

            cmd.ExecuteNonQuery();
            NotificationDialog.ShowBox("Projektdata har uppdaterats framgångsrikt!", "DATABASINFO");
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
            NotificationDialog.ShowBox("Projektet har tagits bort från databasen.", "DATABASINFO");
            connection.Close();
        }
    }
}
