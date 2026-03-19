using System.Data.SQLite;
using System.IO;

namespace SmartWaste.UI
{
    public static class DatabaseHelper
    {
        private static readonly string dbFile = "SmartWaste.db";
        private static readonly string connectionString = $"Data Source={dbFile};Version=3;";

        public static string ConnectionString
        {
            get { return connectionString; }
        }

        public static void InitializeDatabase()
        {
            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string tableQuery =
                    @"CREATE TABLE WasteEntries (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        HouseholdName TEXT,
                        WasteType TEXT,
                        WasteAmount REAL,
                        Date TEXT
                    );";

                    using (SQLiteCommand command = new SQLiteCommand(tableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}