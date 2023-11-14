using ExamenOpdracht_Library.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ExamenOpdracht_Library.Repositories
{
    public class BookRepository : BaseRepository<Book>
    {
        public BookRepository(string connectionString) : base(connectionString) { }

        
        protected override string Table => "Books";
    }
}
