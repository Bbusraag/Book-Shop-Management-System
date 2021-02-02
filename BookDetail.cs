using BookShopManagement1.modelBook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement1
{


    public partial class BookDetail : Form
    {
        int BookID = -1;
        BookHome home = null;
        int id;


        public BookDetail(int id, BookHome b)
        {
            InitializeComponent();
            BookID = id;
            home = b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Book b = new Book();
                if (cbBook.SelectedIndex == 0)
                {
                    return;
                }

                string Booktype = "Roman";
                if (cbBook.SelectedIndex == 1)
                {
                    Booktype = "Hikaye";
                }
                if (cbBook.SelectedIndex == 2)
                {
                    Booktype = "Masal";
                }
                if (cbBook.SelectedIndex == 3)
                {
                    Booktype = "Deneme";
                }
                if (cbBook.SelectedIndex == 4)
                {
                    Booktype = "Makale";
                }
                if (cbBook.SelectedIndex == 5)
                {
                    Booktype = "Bilim Kurgu";
                }


                int result = b.Update(BookID, tbBookname.Text, tbStock.Text, tbPrice.Text, tbAuthor.Text, tbNumberOfPage.Text, cbBook.Text, Booktype);
                if (result > 0)
                {
                    lblMessage.Text = "Updated successfully.";
                    lblMessage.ForeColor = Color.Green;

                    if (home != null)
                    {
                        home.LoadGridviewData();
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
                lblMessage.ForeColor = Color.Red;
            }
        }

        private void BookDetail_Load(object sender, EventArgs e)
        {
            try
            {
                Book std = new Book();
                DataTable dt = std.GetBookByID(BookID);
                if (dt.Rows.Count > 0)
                {
                    tbBookID.Text = dt.Rows[0]["BookID"].ToString();
                    tbBookname.Text = dt.Rows[0]["Bookname"].ToString();
                    tbStock.Text = dt.Rows[0]["Stock"].ToString();
                    tbPrice.Text = dt.Rows[0]["Price"].ToString();
                    tbAuthor.Text = dt.Rows[0]["Author"].ToString();
                    cbBook.SelectedIndex = 0;

                    if (dt.Rows[0]["Booktype"].ToString().ToLower() == "female")
                    {
                        cbBook.SelectedIndex = 2;
                    }
                    else
                    {
                        cbBook.SelectedIndex = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }

        }
    }

   }

    


