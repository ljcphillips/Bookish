using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Dapper;
using System.Collections.Specialized;


namespace Bookish.ConsoleApp
{
    class Book
    {
        public int BookID { get; set; }
        public char ISBN { get; set; }
        public char BookTitle { get; set; }
        public char BookAuthor { get; set; }
    }
    class Item
    {
        public int ItemID { get; set; }
        public int UserID { get; set; }
        public DateTime ReturnDate { get; set; }
        public int BookID { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string SqlString = "SELECT TOP 100 [ItemID],[UserID],[ReturnDate],[BookID] FROM [Items]";
            var ourItems = (List<Item>)db.Query<Item>(SqlString);
            foreach (var Item in ourItems)
            {
                Console.WriteLine(new string('*', 20));
                Console.WriteLine("\nItem ID: " + Item.ItemID.ToString());
                Console.WriteLine("\nUser ID: " + Item.UserID.ToString());
                Console.WriteLine("\nReturn Date: " + Item.ReturnDate.ToString());
                Console.WriteLine("\nBook ID: " + Item.BookID.ToString());
                Console.WriteLine(new string('*', 20));
            }

            Console.ReadLine();
        }
    }
}
