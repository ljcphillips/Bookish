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


    public class Program
    {
        static void Main()
        {
        }
        public static string ItemReturn() 
        {
            IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string SqlString = "SELECT TOP 100 [ItemID],[UserID],[ReturnDate],[BookID] FROM [Items]";
            var ourItems = (List<Item>)db.Query<Item>(SqlString);
            foreach (var Item in ourItems)
            {
                Console.WriteLine(Item.ItemID.ToString());
                Console.ReadLine();
                return Item.ItemID.ToString();
            }
            return "No Items";
        }
    }
}
