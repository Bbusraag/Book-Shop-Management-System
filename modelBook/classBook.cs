using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace BookShopManagement1.modelBook
{
    public class Book
    {


        string bookName;
        int bookID;
        int price;
        int stock;
        string author;
        int page;
        string booktype;


        public string BookName { get => bookName; set => bookName = value; }
        public int BookID { get => bookID; set => bookID = value; }
        public int Price { get => price; set => price = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Author { get => author; set => author = value; }
        public int NumberofPage { get => page; set => page = value; }
        public string Booktype { get => booktype; set => booktype = value; }
        public bool LogIn(string BookName, string Author)
        {
            string query = string.Format("SELECT *FROM Book WHERE BOOK NAME='{0} AND AUTHOR ='{1}'", BookName, Author);
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
        public DataTable GetBook()
        {
            string query = "SELECT*FROM Book";
            return DataAccess.ExecuteQuery(query);

        }
        public DataTable GetBookByID(int ID)
        {
            string query = "SELECT *FROM Book where bookID=" + ID;
            return DataAccess.ExecuteQuery(query);

        }
        public DataTable GetBookByname(string name)
        {
            string query = string.Format("SELECT*FROM BOOK WHERE BookName LIKE '{0}%'", name);
            return DataAccess.ExecuteQuery(query);
        }
        public int Delete(int ID)
        {
            string query = string.Format("DELETE FROM BOOK WHERE bookID= " + ID);

            return DataAccess.ExecuteNonQuery(query);

        }
        public int Update(string bookName, int bookID, int price, int stock, string author, int page, string booktype)
        {

            string query = string.Format("UPDATE BOOK SET NAME='{0}'," + "bookID='{1}'," + "price='{2}'," + "stock='{3}'," + "author='{4}'," + "page='{5}'," + "booktype='{6}'" + "WHERE BookID={7}", bookName, bookID, price, stock, author, page, booktype);

            return DataAccess.ExecuteNonQuery(query);

        }
        public int AddBook(string bookName, int bookID, int price, int stock, string author, int page, string booktype)
        {
            string query = string.Format("INSERT INTO BOOK(name,ID,price,stock,author,page,booktype)" +
            "VALUES({1}','{2}','{3}','{4}','{5}','{6}','{7}')", BookID, bookName, price, stock, author, page, booktype);

            return DataAccess.ExecuteNonQuery(query);


        }
    }
}



   

   
        

           



            

      
