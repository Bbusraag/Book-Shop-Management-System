using BookShopManagement1.modelBook;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace BookShopManagement1.modelBook
{
    class Anketclass
    {
        int id;
        string birincisoru;
        string ikincisoru;
        string ucuncusoru;
        string dorduncusoru;
        string besincisoru;
        string altincisoru;
        string yedincisoru;

        public int Id { get => id; set => id = value; }
        public string Birincisoru { get => birincisoru; set => birincisoru = value; }
        public string Ikincisoru { get => ikincisoru; set => ikincisoru = value; }
        public string Ucuncusoru { get => ucuncusoru; set => ucuncusoru = value; }
        public string Dorduncusoru { get => dorduncusoru; set => dorduncusoru = value; }
        public string Besincisoru { get => besincisoru; set => besincisoru = value; }
        public string Altincisoru { get => altincisoru; set => altincisoru = value; }
        public string Yedincisoru { get => yedincisoru; set => yedincisoru = value; }


        public DataTable GetAllQuestions()
        {
            string query = "SELECT * FROM Anket";
            return DataAccess.ExecuteQuery(query);

        }

        public DataTable GetQuestionByID(int id)
        {
            string query = "SELECT *FROM Anket WHERE SoruID=" + id;
            return DataAccess.ExecuteQuery(query);
        }
        public int AddQuestion(int id, string birincisoru,string ikincisoru, string ucuncusoru,  string dorduncusoru,  string besincisoru,  string altincisoru,  string yedincisoru )
        {
          string query = string.Format("INSERT INTO Anket(Sorubir,Soruiki,Soruuc,Sorudort,Sorubes,Sorualti,Soruyedi)" +
                "VALUES('{1}','{2}','{3}','{4}','{5}','{6}','{7}')",id,birincisoru, ikincisoru, ucuncusoru, dorduncusoru, besincisoru, altincisoru, yedincisoru);

            return DataAccess.ExecuteNonQuery(query);
            

            }
        public int Update(
         int Id,
         string birincisoru, string ikincisoru,
        string ucuncusoru,
        string dorduncusoru,
        string besincisoru,
        string altincisoru,
        string yedincisoru
                    )
        {
            string query = string.Format("UPDATE Anket SET Sorubir= '{0}'," +
                "Soruiki = '{1}'," +
                "Soruuc = '{2}'," +
                "Sorudort = '{3}'," +
                "Sorubes = '{4}'," +
                "Sorualti = '{5}'," +
                "Soruyedi = '{6}'," +
                "WHERE SoruID = {7} ",
                birincisoru, ikincisoru, ucuncusoru, dorduncusoru, besincisoru, altincisoru, yedincisoru, Id);
            return DataAccess.ExecuteNonQuery(query);
        }
        public int Delete(int id)
        {
            string query = "DELETE FROM Anket WHERE SoruID= " + id;
            return DataAccess.ExecuteNonQuery(query);
        }
    }
}