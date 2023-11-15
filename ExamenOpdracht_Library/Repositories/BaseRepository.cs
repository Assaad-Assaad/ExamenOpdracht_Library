using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;

namespace ExamenOpdracht_Library.Repositories
{
    public abstract class BaseRepository<TEntity> : IDisposable
    {
        protected abstract string Table { get; }


        protected string connectionString;
        protected readonly SqlConnection connection;

        public BaseRepository(string connectionString)
        {
            this.connectionString = connectionString;
            
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
        public void Dispose() => connection.Dispose();



        public IEnumerable<TEntity> GetAll()
        {
            
            
                return connection.Query<TEntity>($"SELECT * FROM {Table}");
            
            
        }
        
    }
}
