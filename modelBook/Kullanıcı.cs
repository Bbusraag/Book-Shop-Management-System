using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace BookShopManagement1.modelBook
{
    //class Person
    //{
    //    string isim;
    //    string soyisim;
    //    string email;
    //    string password;

    //    public string Isim { get => isim; set => isim = value; }
    //    public string Soyisim { get => soyisim; set => soyisim = value; }
    //    public string Email { get => email; set => email = value; }
    //    public string Password { get => password; set => password = value; }
    //}
        class Kullanıcı:Person
    {
        //Data member
        int KullanıcıID;
        //string isim;
        //string soyisim;
        //string email;
        //string password;


        public int KullanıcıID1 { get => KullanıcıID; set => KullanıcıID = value; }
        //public string Isim { get => isim; set => isim = value; }
        //public string Soyisim { get => soyisim; set => soyisim = value; }
        //public string Email { get => email; set => email = value; }
        //public string Password { get => password; set => password = value; }

        //public bool LogIn(string email, string password)
        //{
        //    if(email=="admin"&& password == "1234")
        //    {
        //        return true;
        //    }
        //    else
        //    {

        //    }

        //}
        //public override void Login(string email, string password)
        //{

        //}
        public bool LogIn(string email,string password)
        {
            //connection
            //commend
            //adapter
            //datatable
            
            
            string query=string.Format("SELECT * FROM Kullanıcı WHERE Email='{0}' AND Password='{1}'",email,password);
            
            var dt= DataAccess.ExecuteQuery(query);
            if (dt.Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable GetUser()
        {
            
            string query = "SELECT * FROM Kullanıcı ";
            var dt = DataAccess.ExecuteQuery(query);
            return dt;

        }
        public DataTable GetUserById(int id)
        {
            string query ="SELECT * FROM Kullanıcı WHERE KullaniciID="+id;
            var dt = DataAccess.ExecuteQuery(query);
            return dt;
        }
        public DataTable GetUserByName(string name)
        {
           
            string query = string.Format("SELECT * FROM Kullanıcı WHERE İsim = '{0}'",name);
            var dt = DataAccess.ExecuteQuery(query);
            return dt;
        }
        public DataTable GetUserByEmail(string email)
        {
            string query = string.Format("SELECT * FROM Kullanıcı WHERE Email = '{0}'",email);
            var dt = DataAccess.ExecuteQuery(query);
            return dt;
        }
        public int Delete(int Id)
        {
            string query = string.Format("DELETE FROM Kullanıcı WHERE KullaniciID= "+Id);

            return DataAccess.ExecuteNonQuery(query);

        }
        public int Update( string fname, string lname, string email, string password, int Id)
        {
            string query = string.Format("UPDATE Kullanıcı SET İsim='{0}',"+"Soyisim='{1}',"+"Email='{2}',"+"Password='{3}'" +"WHERE KullaniciID={4}",fname, lname, email, password,Id);

            return DataAccess.ExecuteNonQuery(query);

        }
        public int AddUser(int Id,string fname,string lname,string email,string password)
        {
            string query = string.Format("INSERT INTO Kullanıcı(İsim,Soyisim,Email,Password)"+
                "VALUES('{1}','{2}','{3}','{4}')", Id, fname, lname, email, password);

            return DataAccess.ExecuteNonQuery(query);


        }





    }
    //class Calisanlar:Person
    //{
    //    int CalisanID;
    //    public int CalisanID1 { get => CalisanID; set => CalisanID = value; }
    //}
   

   
}
