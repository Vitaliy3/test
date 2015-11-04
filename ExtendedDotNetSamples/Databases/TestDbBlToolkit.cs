using BLToolkit.Data;
using BLToolkit.Data.Linq;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases
{
    [TableName("Book")]
    public class BlBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        [Association(ThisKey = "AuthorID", OtherKey = "Id")]
        public BlAuthor Author { get; set; }
    }

    [TableName("Author")]
    public class BlAuthor
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class TestDbBlToolkitContext : DbManager
    {
        public TestDbBlToolkitContext() : base("TestDB")
        { }

        public Table<BlBook> Books { get { return GetTable<BlBook>(); } }
        public Table<BlAuthor> Authors { get { return GetTable<BlAuthor>(); } }
    }
}
