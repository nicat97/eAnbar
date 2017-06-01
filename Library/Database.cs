using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace eAnbar.Library
{
    public class Database
    {

        public SQLiteConnection connect = new SQLiteConnection("Data Source=db.db");

        public Database()
        {
            connect.Open();
        }

        public SQLiteDataReader GetItems(string tableName)
        {
            string query = String.Format(@"SELECT * FROM {0} ORDER BY item_id DESC LIMIT 100", tableName);

            SQLiteCommand command = new SQLiteCommand(query, connect);
            SQLiteDataReader row = command.ExecuteReader();

            return row;

        }

        public SQLiteDataReader GetItem(string tableName, int item_id)
        {
            string query = String.Format(@"SELECT * FROM {0} WHERE item_id=@item_id;", tableName);

            SQLiteCommand command = new SQLiteCommand(query, connect);
            command.Parameters.AddWithValue("@item_id", item_id);

            SQLiteDataReader row = command.ExecuteReader();

            return row;
        }

        public bool AddItems(object[] data)
        {
            int status;
            string query = @"INSERT INTO in_stock (
                                            item_name,
                                            item_count,
                                            item_unit,
                                            item_cost,
                                            item_cost_currency,
                                            item_price,
                                            item_price_currency,
                                            item_date,
                                            item_comment
                                            )
                                    VALUES (
                                            @item_name,
                                            @item_count,
                                            @item_unit,
                                            @item_cost,
                                            @item_cost_currency,
                                            @item_price,
                                            @item_price_currency,
                                            @item_date,
                                            @item_comment
                                            );";

            try
            {
                SQLiteCommand command = new SQLiteCommand(query, connect);

                command.Parameters.AddWithValue("@item_name", data[0]);
                command.Parameters.AddWithValue("@item_count", data[1]);
                command.Parameters.AddWithValue("@item_unit", data[2]);
                command.Parameters.AddWithValue("@item_cost", data[3]);
                command.Parameters.AddWithValue("@item_cost_currency", data[4]);
                command.Parameters.AddWithValue("@item_price", data[5]);
                command.Parameters.AddWithValue("@item_price_currency", data[6]);
                command.Parameters.AddWithValue("@item_date", data[7]);
                command.Parameters.AddWithValue("@item_comment", data[8]);

                status = command.ExecuteNonQuery();
                
                if (status == 0) //affected rows
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool ModifyItem(object[] data, string table)
        {
            int status;
            string query = String.Format(@"UPDATE {0} SET 
                                item_name = @item_name,
                                item_count = @item_count,
                                item_unit = @item_unit,
                                item_cost = @item_cost,
                                item_cost_currency = @item_cost_currency,
                                item_price = @item_price,
                                item_price_currency = @item_price_currency,
                                item_date = @item_date,
                                item_comment = @item_comment
                            WHERE 
                                item_id = @item_id;", table);

            try
            {
                SQLiteCommand command = new SQLiteCommand(query, connect);

                command.Parameters.AddWithValue("@item_id", data[9]);
                command.Parameters.AddWithValue("@item_name", data[0]);
                command.Parameters.AddWithValue("@item_count", data[1]);
                command.Parameters.AddWithValue("@item_unit", data[2]);
                command.Parameters.AddWithValue("@item_cost", data[3]);
                command.Parameters.AddWithValue("@item_cost_currency", data[4]);
                command.Parameters.AddWithValue("@item_price", data[5]);
                command.Parameters.AddWithValue("@item_price_currency", data[6]);
                command.Parameters.AddWithValue("@item_date", data[7]);
                command.Parameters.AddWithValue("@item_comment", data[8]);

                status = command.ExecuteNonQuery();

                if (status == 0) //affected rows
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool DeleteItem(string tableName, int item_id)
        {
            int status;
            string query = String.Format(@"DELETE FROM {0} WHERE item_id=@item_id;", tableName);

            try
            {
                SQLiteCommand command = new SQLiteCommand(query, connect);

                command.Parameters.AddWithValue("@tableName", tableName);
                command.Parameters.AddWithValue("@item_id", item_id);

                status = command.ExecuteNonQuery();

                if (status == 0) //affected rows
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public object MoveItem(string tableName, string targetTableName, int item_id)
        {
            //*un yerinə id-dən başqa digər columnları yaz
            int status;
            string query = String.Format(@"INSERT INTO {0} select * from {1} where item_id= {2} ;", targetTableName, tableName, item_id);

            try
            {
                //INSERT INTO TARGET TABLE
                SQLiteCommand command = new SQLiteCommand(query, connect);
                status = command.ExecuteNonQuery();

                if (status == 0) //affected rows
                {
                    return false;
                }
                else
                {
                    query = String.Format(@"DELETE FROM {0} where person_name = {1};", tableName, item_id);

                    try
                    {
                        //DELETE ROW
                        command = new SQLiteCommand(query, connect);
                        status = command.ExecuteNonQuery();

                        if (status == 0) //affected rows
                        {
                            return "unexpected";
                        }
                        else
                        {
                            return true;
                        }
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("======================================================");
                Console.WriteLine(ex.ToString());
                Console.WriteLine("======================================================");
                return false;
            }
        }
    }
}
