using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SQLite;

namespace ProjectVP_DiabetesLog
{
    public static class DatabaseAccess
    {
        public static int InsertDateTime(DateTime date, DateTime time) {
            int rowId = 0;

            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string querry = "INSERT INTO Measurement (Date, Time) VALUES (@Date, @Time)";
                using (SQLiteCommand command = new SQLiteCommand(querry, connection))
                {
                    querry = "SELECT last_insert_rowid()";
                    using (SQLiteCommand readCommand = new SQLiteCommand(querry, connection))
                    {
                        command.Parameters.Add("@Date", System.Data.DbType.String).Value = date.ToString("yyyy-MM-dd");
                        command.Parameters.Add("@Time", System.Data.DbType.String).Value = time.ToString("HH:mm");
                        
                        connection.Open();
                        command.ExecuteNonQuery();

                        using (SQLiteDataReader reader = readCommand.ExecuteReader())
                        {
                            reader.Read();
                            rowId = reader.GetInt32(0);
                            reader.Close();
                        }

                        connection.Close();
                    }
                }

            }
            return rowId;
        }

        public static List<InsulinType> LoadInsulinTypes() {
            List<InsulinType> insulinTypes = new List<InsulinType>();
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                using (SQLiteCommand command = new SQLiteCommand("SELECT Name, Brand FROM Insulin", connection))
                {
                    connection.Open();
                    using (SQLiteDataReader reader= command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            insulinTypes.Add(new InsulinType(reader.GetString(0), reader.GetString(1)));
                        }
                        reader.Close();
                    }
                    connection.Close();
                }
            }

            return insulinTypes;
        }

        public static List<Food> LoadFoodTypes()
        {
            List<Food> foods = new List<Food>();
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                using (SQLiteCommand command = new SQLiteCommand("SELECT Name, Brand, Carbs FROM Food", connection))
                {
                    connection.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(0);
                            string brand = reader.GetString(1);
                            double carbs = reader.GetDouble(2);
                            foods.Add(new Food(name, brand, carbs));
                        }
                        reader.Close();
                    }
                    connection.Close();
                }
            }
            return foods;
        }

        public static void InsertFoodType(Food foodToAdd)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                using (SQLiteCommand command = new SQLiteCommand("INSERT INTO Food (Name, Brand, Carbs) VALUES (@Name, @Brand, @Carbs)", connection))
                {
                    command.Parameters.Add("@Name", System.Data.DbType.String).Value = foodToAdd.name;
                    command.Parameters.Add("@Brand", System.Data.DbType.String).Value = foodToAdd.brand;
                    command.Parameters.Add("@Carbs", System.Data.DbType.Double).Value = foodToAdd.carbs;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public static void InsertInsulinType(InsulinType tmp)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                using (SQLiteCommand command = new SQLiteCommand("INSERT INTO Insulin (Name, Brand) VALUES (@Name, @Brand)", connection))
                {
                    command.Parameters.Add("@Name", System.Data.DbType.String).Value = tmp.name;
                    command.Parameters.Add("@Brand", System.Data.DbType.String).Value = tmp.brand;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        private static string LoadConnectionString(string name = "Default") {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static void InsertMeasurement(int rowId, double value)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                using (SQLiteCommand command = new SQLiteCommand("UPDATE Measurement SET MeasuredValue = @Value WHERE MeasurementId = @RowId", connection))
                {
                    command.Parameters.Add("@Value", System.Data.DbType.Double).Value = value;
                    command.Parameters.Add("@RowId", System.Data.DbType.Int32).Value = rowId;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public static void insertMeal(int rowId, Meal meal)
        {
            int foodId;
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                using (SQLiteCommand command = new SQLiteCommand("SELECT FoodId FROM Food WHERE Name = @Name AND Brand = @Brand", connection))
                {
                    command.Parameters.Add("@Name", System.Data.DbType.String).Value = meal.food.name;
                    command.Parameters.Add("@Brand", System.Data.DbType.String).Value = meal.food.brand;
                    connection.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        foodId = reader.GetInt32(0);
                        reader.Close();
                    }
                    connection.Close();
                }
                using (SQLiteCommand command = new SQLiteCommand("INSERT INTO MeasurementFood (MeasurementId, FoodId, AmountInGrams) VALUES (@MeasurementId, @FoodId, @AmountInGrams)",connection))
                {
                    command.Parameters.Add("@MeasurementId", System.Data.DbType.Int32).Value = rowId;
                    command.Parameters.Add("@FoodId", System.Data.DbType.Int32).Value = foodId;
                    command.Parameters.Add("@AmountInGrams", System.Data.DbType.Double).Value = meal.amount;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public static void InsertInsulinMeasurement(int rowId, int value, InsulinType insulin)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                int insulinId = -1;
                int addedInsulinId = -1;
                using (SQLiteCommand command = new SQLiteCommand("SELECT InsulinId FROM Insulin WHERE Name = @Name AND Brand = @Brand", connection))
                {
                    command.Parameters.Add("@Name", System.Data.DbType.String).Value = insulin.name;
                    command.Parameters.Add("Brand", System.Data.DbType.String).Value = insulin.brand;
                    connection.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        insulinId = reader.GetInt32(0);
                        reader.Close();
                    }
                    connection.Close();
                }
                
                using (SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO AddedInsulin (InsulinId, InsulinAmount) VALUES (@InsulinId, @InsulinAmount)", connection))
                {
                    insertCommand.Parameters.Add("@InsulinId", System.Data.DbType.Int32).Value = insulinId;
                    insertCommand.Parameters.Add("@InsulinAmount", System.Data.DbType.Int32).Value = value;
                    connection.Open();
                    insertCommand.ExecuteNonQuery();
                    using (SQLiteCommand returnIdCommand = new SQLiteCommand("SELECT last_insert_rowid()", connection))
                    {
                        using (SQLiteDataReader reader = returnIdCommand.ExecuteReader())
                        {
                            reader.Read();
                            addedInsulinId = reader.GetInt32(0);
                            reader.Close();
                        }
                    }
                    connection.Close();
                }
   
                
                using (SQLiteCommand command = new SQLiteCommand("UPDATE Measurement SET AddedInsulinId = @AddedInsulinId WHERE MeasurementId = @RowId", connection))
                {
                    command.Parameters.Add("@AddedInsulinId", System.Data.DbType.Int32).Value = addedInsulinId;
                    command.Parameters.Add("@RowId", System.Data.DbType.Int32).Value = rowId;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    }
}
