using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookShopManagement1.modelBook
{
    class DataAccess
    {

        private static string dbpath = @"data source=C:\Users\büşra1997\Desktop\BookShopİcons\smsuser.db";
        

        public static DataTable ExecuteQuery(string query)
        { //connection
            //commend
            //adapter
            //datatable
           //JUST FOR SELECTİON
            SQLiteConnection con = new SQLiteConnection(dbpath);
            con.Open();
            
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            int v = adapter.Fill(dt);
            return dt;
        }
        //İNSERT,DELETE,UPDATE için farklı kod oluşturmalıyız.
        public static int ExecuteNonQuery(string query)
        { 
            //adapter is only used to read data
            SQLiteConnection con = new SQLiteConnection(dbpath);
            con.Open();

            SQLiteCommand cmd = new SQLiteCommand(query, con);
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            return cmd.ExecuteNonQuery();
            //if you delete 5 rows it will return five same as insert and update sayıya dönüyor yani
        }
    }
}
