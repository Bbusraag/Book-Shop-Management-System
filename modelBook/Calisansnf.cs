using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement1.modelBook
{
    class Calisansnf:Person
    {
        
            //Data member
            int KullanıcıID;
            //string isim;
            //string soyisim;
            //string email;
            //string password;
            string task;

            public int KullanıcıID1 { get => KullanıcıID; set => KullanıcıID = value; }
            //public string Isim { get => isim; set => isim = value; }
            //public string Soyisim { get => soyisim; set => soyisim = value; }
            //public string Email { get => email; set => email = value; }
            //public string Password { get => password; set => password = value; }
            public string Task { get => task; set => task = value; }




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
            public bool LogIn(string email, string password)
            {
                //connection
                //commend
                //adapter
                //datatable


                string query = string.Format("SELECT * FROM Calisanlar WHERE Email='{0}' AND Password='{1}'", email, password);

                var dt = DataAccess.ExecuteQuery(query);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public DataTable GetEmployee()
            {

                string query = "SELECT * FROM Calisanlar ";
                var dt = DataAccess.ExecuteQuery(query);
                return dt;

            }
            public DataTable GetEmployeeById(int id)
            {
                string query = "SELECT * FROM Calisanlar WHERE CalisanID=" + id;
                var dt = DataAccess.ExecuteQuery(query);
                return dt;
            }
            public DataTable GetEmployeeByName(string name)
            {

                string query = string.Format("SELECT * FROM Calisanlar WHERE İsim = '{0}'", name);
                var dt = DataAccess.ExecuteQuery(query);
                return dt;
            }
            public DataTable GetEmployeeByEmail(string email)
            {
                string query = string.Format("SELECT * FROM Calisanlar WHERE Email = '{0}'", email);
                var dt = DataAccess.ExecuteQuery(query);
                return dt;
            }
            public int Delete(int Id)
            {
                string query = string.Format("DELETE FROM Kullanıcı WHERE KullaniciID= " + Id);

                return DataAccess.ExecuteNonQuery(query);

            }
            public int Update(int Id, string fname, string lname, string email, string task,string password)
            {
                string query = string.Format("UPDATE Calisanlar SET Isim='{0}'," + "Soyisim='{1}'," + "Email='{2}'," + "Password='{3}'" + "Gorev='{4}'"+"WHERE CalisanID={5}", fname, lname, email, password,Task, Id);

                return DataAccess.ExecuteNonQuery(query);

            }
            public int AddUser(int Id, string fname, string lname, string email, string task, string password)
            {
                string query = string.Format("INSERT INTO Kullanıcı(Isim,Soyisim,Email,Gorev,Password)" +
                    "VALUES('{1}','{2}','{3}','{4}','{5}')", Id, fname, lname, email,task, password);

                return DataAccess.ExecuteNonQuery(query);


            }





        }
        //class Calisanlar:Person
        //{
        //    int CalisanID;
        //    public int CalisanID1 { get => CalisanID; set => CalisanID = value; }
        //}



    }


