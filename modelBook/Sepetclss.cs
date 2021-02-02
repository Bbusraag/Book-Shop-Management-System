using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement1.modelBook
{
    class Sepetclss
    {
        int urunid;
        int fiyat;
        int adet;
        int banka;
        int kredi;

        public int Urunid { get => urunid; set => urunid = value; }
        public int Fiyat { get => fiyat; set => fiyat = value; }
        public int Adet { get => adet; set => adet = value; }
        public int Banka { get => banka; set => banka = value; }
        public int Kredi { get => kredi; set => kredi = value; }


        public DataTable GetInfo()
        {
            string query = "SELECT * FROM Sepet ";
            var dt = DataAccess.ExecuteQuery(query);
            return dt;
        }
        public DataTable GetProductByBank(int type)
        {
            string query = "SELECT * FROM Sepet WHERE Banka=" + banka;
            var dt = DataAccess.ExecuteQuery(query);
            return dt;
        }
        public int Delete(int Id)
        {
            string query = string.Format("DELETE FROM Sepet  WHERE UrunID= " + Id);

            return DataAccess.ExecuteNonQuery(query);

        }
        public int AddProduct(int Id, int adet,int fiyat,string banka,int kredicard)
        {
            string query = string.Format("INSERT INTO Sepet(UrunID,Banka,KrediKartı,Urunfiyatı,UrunAdeti)" +
                "VALUES({1},'{2}',{3},{4})", Id, banka,kredicard,fiyat,adet);

            return DataAccess.ExecuteNonQuery(query);
        }
        public int Update(int Id, int adet, int fiyat, string banka, int kredicard)
        {
            string query = string.Format("UPDATE Sepet  SET Banka='{0}'," + "KrediKartı={1}," + "Urunfiyatı={2}," + "UrunAdeti={3},"  + "WHERE UrunID={4}",banka,kredicard,fiyat,adet, Id);

            return DataAccess.ExecuteNonQuery(query);

        }

    }
}
