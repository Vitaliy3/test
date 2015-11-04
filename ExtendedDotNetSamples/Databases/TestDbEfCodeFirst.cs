using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases
{
    [Table("Book")]
    public class EfCfBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public EfCfAuthor Author { get; set; }
    }

    [Table("Author")]
    public class EfCfAuthor
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public class TestDbEfCodeFirstContext : DbContext
    {
        public TestDbEfCodeFirstContext() : base("TestDbEfCodeFirstContext")
        { }

        public DbSet<EfCfBook> Books { get; set; }
        public DbSet<EfCfAuthor> Authors { get; set; }
    }
}
