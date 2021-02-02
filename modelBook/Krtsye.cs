using System;
using System.Data;
using System.Windows.Forms;

namespace BookShopManagement1.modelBook
{
    class Krtsye {

        int productID;
        int stok;
        string type;
        string color;

        public int ProductID { get => productID; set => productID = value; }
        public int Stok { get => stok; set => stok = value; }
        public string Type { get => type; set => type = value; }
        public string Color { get => color; set => color = value; }
        public DataTable GetProduct()
        {

            string query = "SELECT * FROM Kirtasiye ";
            var dt = DataAccess.ExecuteQuery(query);
            return dt;

        }
        public DataTable GetProductById(int id)
        {
            string query = "SELECT * FROM Kirtasiye WHERE UrunID=" + id;
            var dt = DataAccess.ExecuteQuery(query);
            return dt;
        }
        public DataTable GetProductByType(string tur)
        {

            string query = string.Format("SELECT * FROM Kirtasiye WHERE UrunTuru = '{0}'", tur);
            var dt = DataAccess.ExecuteQuery(query);
            return dt;
        }
       
        public int Delete(int Id)
        {
            string query = string.Format("DELETE FROM Kirtasiye  WHERE UrunID= " + Id);

            return DataAccess.ExecuteNonQuery(query);

        }
        public int UpdateKrtsy(int Id, string tur, int stock, string color)
        {
            string query = string.Format("UPDATE Kirtasiye  SET UrunTuru='{0}'," + "Renk='{1}'," + "Stok={2},"  + "WHERE UrunID={3}", tur ,color ,stock , Id);

            return DataAccess.ExecuteNonQuery(query);

        }
        public int AddProduct(int Id, string tur, int stock, string color)
        {
            string query = string.Format("INSERT INTO Kirtasiye(UrunTuru,Renk,Stok)" +
                "VALUES('{1}','{2}',{3})", Id,tur,color,stock);

            return DataAccess.ExecuteNonQuery(query);


        }

        internal object UpdateKrtsy(TextBox tbId, string text1, NumericUpDown nudstok, string text2)
        {
            throw new NotImplementedException();
        }
    }
}