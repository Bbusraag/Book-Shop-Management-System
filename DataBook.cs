using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BookShopManagement1
{
    public partial class DataBook : Form
    {
        public DataBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from BOOK ";
            SQLiteConnection con = new SQLiteConnection(@"data source=C:\Users\büşra1997\Desktop\BookShopİcons\smsuser.db");
            con.Open();
            Console.WriteLine(con);

           


            SQLiteCommand cmd = new SQLiteCommand(query, con);
          
            DataTable dt = new DataTable();
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
            {
               
                adapter.Fill(dt);
            }
            dataGridView1.DataSource = dt;

        }
    }
}
