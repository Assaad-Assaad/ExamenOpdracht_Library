using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ExamenOpdracht_Library.Classes;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ExamenOpdracht_Library.Repositories
{
    public class MemberRepository : BaseRepository<Member>
    {
        public MemberRepository(string connectionString) : base(connectionString) { }

        protected override string Table => "Members";

        public bool IsEmailAlreadyRegistered(string email)
        {

                    return connection.Query<int>(
                        "SELECT COUNT(*) FROM Members WHERE Email = @Email",
                        new { Email = email })
                    .FirstOrDefault() > 0;
            
            
        }
        

        public bool RegisterMember(Member newMember)
        {
              string insertQuery = "INSERT INTO Members (FirstName, LastName, Age, Email, Password) " +
                                 "VALUES (@FirstName, @LastName, @Age, @Email, @Password)";

              int rowsAffected = connection.Execute(insertQuery, newMember);

              return rowsAffected > 0;
        }
        public Member? VerifyMember(string email, string password)
        {
            
                var member = connection.QuerySingleOrDefault<Member>(
                    "SELECT Id, FirstName FROM Members WHERE Email = @Email AND Password = @Password",
                    new { Email = email, Password = password });

                return member;
            
            
        }
        
    }
}
