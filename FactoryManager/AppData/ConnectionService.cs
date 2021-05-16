﻿using System.Data.OleDb;
using FactoryManager.AppService.ConfigurationReader;

namespace FactoryManager.AppData
{
    public class ConnectionService
    {
        private static IConfigurationReader _configurationReader;

        private static OleDbConnection GetDatabaseConnection()
        {
            _configurationReader = (IConfigurationReader)Program.ServiceProvider.GetService(typeof(IConfigurationReader));
            OleDbConnection oleDbConnection = new OleDbConnection
            {
                ConnectionString = _configurationReader.GetConnectionString()
            };
            return oleDbConnection;
        }

        public static OleDbConnection OpenDatabaseConnection()
        {
            var oleDbConnection = GetDatabaseConnection();
            oleDbConnection.Open();
            return oleDbConnection;
        }

        public static OleDbConnection CloseDatabaseConnection()
        {
            var oleDbConnection = GetDatabaseConnection();
            oleDbConnection.Close();
            return oleDbConnection;
        }
    }
}