using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases
{
    class Program
    {
        const string connStringName = "TestDB";
        const string connString = "Data Source=TestDB.sdf; Persist Security Info=False;";

        static void Main(string[] args)
        {
            DemoConnectedModel();
            Console.WriteLine();

            DemoDisconnectedModel();
            Console.WriteLine();

            DemoEntityFrameworkCodeFirst();
            Console.WriteLine();

            DemoBlToolkit();
            Console.WriteLine();

            Console.ReadLine();
        }

        private static void DemoConnectedModel()
        {
            Console.WriteLine("Connected Model.");

            using (var conn = new SqlCeConnection(connString))
            {
                conn.Open();
                using (var comm = conn.CreateCommand())
                {
                    comm.CommandText = "SELECT * FROM [Book]";
                    using (var reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            object[] values = new object[3];
                            reader.GetValues(values);
                            Console.WriteLine(string.Join(", ", values));
                        }
                    }
                    conn.Close();
                }
            }
        }

        private static void DemoDisconnectedModel()
        {
            Console.WriteLine("Disconnected Model.");

            var ds = new DataSet();
            using (var conn = new SqlCeConnection(connString))
            {
                conn.Open();
                using (var comm = conn.CreateCommand())
                {
                    comm.CommandText = "SELECT * FROM [Book]";
                    using (var reader = comm.ExecuteReader())
                    {
                        ds.Load(reader, LoadOption.Upsert, "Book");
                    }
                    conn.Close();
                }
            }

            foreach (DataRow row in ds.Tables["Book"].Rows)
            {
                Console.WriteLine(string.Join(", ", row.ItemArray));
            }
        }

        private static void DemoEntityFrameworkCodeFirst()
        {
            Console.WriteLine("Entity Framework.");

            using (var db = new TestDbEfCodeFirstContext())
            {
                var booksQuery =
                    from book in db.Books.Include("Author")
                    where book.Title.Contains("б") && book.Author.Name.Contains("о")
                    select book;

                foreach (var book in booksQuery)
                {
                    Console.WriteLine(string.Join(", ", book.Id, book.Title, book.AuthorID, book.Author.Name));
                }
            }
        }

        private static void DemoBlToolkit()
        {
            Console.WriteLine("BLToolkit.");

            using (var db = new TestDbBlToolkitContext())
            {
                var booksQuery =
                    from book in db.Books
                    where book.Title.Contains("б") && book.Author.Name.Contains("о")
                    select new
                     {
                         Id = book.Id,
                         Title = book.Title,
                         AuthorID = book.AuthorID,
                         Author = book.Author,
                     };

                foreach (var book in booksQuery)
                {
                    Console.WriteLine(string.Join(", ", book.Id, book.Title, book.AuthorID, book.Author.Name));
                }
            }
        }

    }
}
