using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace FinalProject
{
    public static class DatabaseHelper
    {
        private static readonly string DbPath =
        Path.Combine(
        Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location),
        "users.db");

        private static string ConnectionString =>
            $"Data Source={DbPath};Version=3;";

        public static void InitializeDatabase()
        {
            // Create QuickNest folder in AppData if it doesn't exist
            string folder = Path.GetDirectoryName(DbPath);
            if (!string.IsNullOrEmpty(folder) && !Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                string usersTable = @"
            CREATE TABLE IF NOT EXISTS Users (
                Id       INTEGER PRIMARY KEY AUTOINCREMENT,
                FullName TEXT NOT NULL,
                Email    TEXT NOT NULL UNIQUE,
                Password TEXT NOT NULL,
                UserRole TEXT NOT NULL
            );";

                string propertiesTable = @"
            CREATE TABLE IF NOT EXISTS Properties (
                Id           INTEGER PRIMARY KEY AUTOINCREMENT,
                OwnerEmail   TEXT NOT NULL,
                Title        TEXT NOT NULL,
                Details      TEXT,
                Price        REAL NOT NULL,
                Location     TEXT,
                PropertyType TEXT NOT NULL,
                Category     TEXT NOT NULL DEFAULT 'House',
                IsPublic     INTEGER NOT NULL DEFAULT 0,
                DatePosted   TEXT NOT NULL,
                ImageData    BLOB
            );";

                new SQLiteCommand(usersTable, conn).ExecuteNonQuery();
                new SQLiteCommand(propertiesTable, conn).ExecuteNonQuery();

                string transactionsTable = @"
                CREATE TABLE IF NOT EXISTS Transactions (
                Id               INTEGER PRIMARY KEY AUTOINCREMENT,
                BuyerEmail       TEXT NOT NULL,
                OwnerEmail       TEXT NOT NULL,
                PropertyId       INTEGER NOT NULL,
                PropertyTitle    TEXT NOT NULL,
                PropertyLocation TEXT NOT NULL,
                Price            REAL NOT NULL,
                PropertyType     TEXT NOT NULL,
                DatePurchased    TEXT NOT NULL
                );";
                new SQLiteCommand(transactionsTable, conn).ExecuteNonQuery();

                try
                {
                    new SQLiteCommand(
                        "ALTER TABLE Properties ADD COLUMN Category TEXT NOT NULL DEFAULT 'House';",
                        conn).ExecuteNonQuery();
                }
                catch { /* already exists */ }
            }
        }

       

        public static bool RegisterUser(string fullName, string email,
                                        string password, string role)
        {
            try
            {
                using (var conn = new SQLiteConnection(ConnectionString))
                {
                    conn.Open();
                    string sql = @"INSERT INTO Users (FullName, Email, Password, UserRole)
                                   VALUES (@FullName, @Email, @Password, @UserRole);";
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@UserRole", role);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch { return false; }
        }

        public static LoginPage.UserInfo GetUserByEmail(string email)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Users WHERE Email = @Email COLLATE NOCASE;";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                            return new LoginPage.UserInfo
                            {
                                FullName = r["FullName"].ToString(),
                                Email = r["Email"].ToString(),
                                Password = r["Password"].ToString(),
                                UserRole = r["UserRole"].ToString()
                            };
                    }
                }
            }
            return null;
        }

        public static void AddProperty(string ownerEmail, string title, string details,
            double price, string location, string propertyType,
            string category, byte[] imageData)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"
                    INSERT INTO Properties
                        (OwnerEmail, Title, Details, Price, Location,
                         PropertyType, Category, IsPublic, DatePosted, ImageData)
                    VALUES
                        (@OwnerEmail, @Title, @Details, @Price, @Location,
                         @PropertyType, @Category, 0, @DatePosted, @ImageData);";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@OwnerEmail", ownerEmail?.Trim().ToLower() ?? "");
                    cmd.Parameters.AddWithValue("@Title", title ?? "");
                    cmd.Parameters.AddWithValue("@Details", details ?? "");
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Location", location ?? "");
                    cmd.Parameters.AddWithValue("@PropertyType", propertyType ?? "");
                    cmd.Parameters.AddWithValue("@Category", category ?? "House");
                    cmd.Parameters.AddWithValue("@DatePosted", DateTime.Now.ToString("o"));
                    cmd.Parameters.AddWithValue("@ImageData",
                        imageData != null ? (object)imageData : DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateProperty(int id, string title, string details,
            double price, string location, string propertyType, bool isPublic)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"
                    UPDATE Properties SET
                        Title        = @Title,
                        Details      = @Details,
                        Price        = @Price,
                        Location     = @Location,
                        PropertyType = @PropertyType,
                        IsPublic     = @IsPublic
                    WHERE Id = @Id;";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", title ?? "");
                    cmd.Parameters.AddWithValue("@Details", details ?? "");
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Location", location ?? "");
                    cmd.Parameters.AddWithValue("@PropertyType", propertyType ?? "");
                    cmd.Parameters.AddWithValue("@IsPublic", isPublic ? 1 : 0);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void SetPropertyPublic(int id, bool isPublic)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(
                    "UPDATE Properties SET IsPublic = @p WHERE Id = @id;", conn))
                {
                    cmd.Parameters.AddWithValue("@p", isPublic ? 1 : 0);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteProperty(int id)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(
                    "DELETE FROM Properties WHERE Id = @id;", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

       
        public static List<PropertyRecord> GetAllProperties(string ownerEmail)
        {
            var list = new List<PropertyRecord>();
            if (string.IsNullOrEmpty(ownerEmail)) return list;

            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"SELECT * FROM Properties
                               WHERE OwnerEmail = @Owner COLLATE NOCASE
                               ORDER BY DatePosted DESC;";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Owner", ownerEmail?.Trim().ToLower() ?? "");
                    using (var r = cmd.ExecuteReader())
                        while (r.Read()) list.Add(ReadProperty(r));
                }
            }
            return list;
        }

       
        public static List<PropertyRecord> GetPublicProperties(string type)
        {
            var list = new List<PropertyRecord>();
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"SELECT * FROM Properties
                               WHERE IsPublic = 1 AND PropertyType = @Type
                               ORDER BY DatePosted DESC;";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Type", type);
                    using (var r = cmd.ExecuteReader())
                        while (r.Read()) list.Add(ReadProperty(r));
                }
            }
            return list;
        }

      
        public static List<PropertyRecord> GetAllPropertiesAdmin()
        {
            var list = new List<PropertyRecord>();
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(
                    "SELECT * FROM Properties ORDER BY DatePosted DESC;", conn))
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) list.Add(ReadProperty(r));
            }
            return list;
        }

        private static PropertyRecord ReadProperty(SQLiteDataReader r)
        {
            return new PropertyRecord
            {
                Id = Convert.ToInt32(r["Id"]),
                OwnerEmail = r["OwnerEmail"].ToString(),
                Title = r["Title"].ToString(),
                Details = r["Details"].ToString(),
                Price = Convert.ToDouble(r["Price"]),
                Location = r["Location"].ToString(),
                PropertyType = r["PropertyType"].ToString(),
                Category = r["Category"].ToString(),
                IsPublic = Convert.ToInt32(r["IsPublic"]) == 1,
                DatePosted = DateTime.Parse(r["DatePosted"].ToString()),
                ImageData = r["ImageData"] == DBNull.Value
                                   ? null : (byte[])r["ImageData"]
            };
        }

        public class PropertyRecord
        {
            public int Id { get; set; }
            public string OwnerEmail { get; set; }
            public string Title { get; set; }
            public string Details { get; set; }
            public double Price { get; set; }
            public string Location { get; set; }
            public string PropertyType { get; set; }
            public string Category { get; set; }
            public bool IsPublic { get; set; }
            public DateTime DatePosted { get; set; }
            public byte[] ImageData { get; set; }
        }

        public static string DebugAllProperties()
        {
            string result = "";
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("SELECT Id, OwnerEmail, Title, IsPublic FROM Properties;", conn))
                using (var r = cmd.ExecuteReader())
                    while (r.Read())
                        result += $"ID:{r["Id"]} | Owner:[{r["OwnerEmail"]}] | Title:{r["Title"]} | Public:{r["IsPublic"]}\n";
            }
            return string.IsNullOrEmpty(result) ? "NO ROWS IN DATABASE" : result;
        }
        public static void AddTransaction(string buyerEmail, string ownerEmail,
    int propertyId, string title, string location,
    double price, string propertyType)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO Transactions
            (BuyerEmail, OwnerEmail, PropertyId, PropertyTitle,
             PropertyLocation, Price, PropertyType, DatePurchased)
            VALUES
            (@BuyerEmail, @OwnerEmail, @PropertyId, @PropertyTitle,
             @PropertyLocation, @Price, @PropertyType, @DatePurchased);";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@BuyerEmail", buyerEmail);
                    cmd.Parameters.AddWithValue("@OwnerEmail", ownerEmail);
                    cmd.Parameters.AddWithValue("@PropertyId", propertyId);
                    cmd.Parameters.AddWithValue("@PropertyTitle", title);
                    cmd.Parameters.AddWithValue("@PropertyLocation", location);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@PropertyType", propertyType);
                    cmd.Parameters.AddWithValue("@DatePurchased",
                        DateTime.Now.ToString("o"));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public class TransactionRecord
        {
            public int Id { get; set; }
            public string BuyerEmail { get; set; }
            public string OwnerEmail { get; set; }
            public int PropertyId { get; set; }
            public string PropertyTitle { get; set; }
            public string PropertyLocation { get; set; }
            public double Price { get; set; }
            public string PropertyType { get; set; }
            public DateTime DatePurchased { get; set; }
        }

        public static List<TransactionRecord> GetTransactionsByBuyer(string buyerEmail)
        {
            var list = new List<TransactionRecord>();
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"SELECT * FROM Transactions
                       WHERE BuyerEmail = @Email COLLATE NOCASE
                       ORDER BY DatePurchased DESC;";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Email",
                        buyerEmail?.Trim().ToLower() ?? "");
                    using (var r = cmd.ExecuteReader())
                        while (r.Read())
                            list.Add(new TransactionRecord
                            {
                                Id = Convert.ToInt32(r["Id"]),
                                BuyerEmail = r["BuyerEmail"].ToString(),
                                OwnerEmail = r["OwnerEmail"].ToString(),
                                PropertyId = Convert.ToInt32(r["PropertyId"]),
                                PropertyTitle = r["PropertyTitle"].ToString(),
                                PropertyLocation = r["PropertyLocation"].ToString(),
                                Price = Convert.ToDouble(r["Price"]),
                                PropertyType = r["PropertyType"].ToString(),
                                DatePurchased = DateTime.Parse(r["DatePurchased"].ToString())
                            });
                }
            }
            return list;
        }
    }


}