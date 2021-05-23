using FactoryManager.AppData;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace FactoryManager.BLL.Quantity
{
    public class QuantityService
    {
        public static DataTable Fill(DevExpress.XtraGrid.GridControl gridControl)
        {
            string query = "SELECT * FROM Mängder";
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
    }
}
