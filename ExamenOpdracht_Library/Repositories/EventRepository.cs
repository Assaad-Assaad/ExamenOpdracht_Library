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
    public class EventRepository : BaseRepository<Event>
    {
        public EventRepository(string connectionString) : base(connectionString) { }

        protected override string Table => "Events";

       

        public bool SignForEvent(long memberId, long eventId)
        {
            
                var existingRegistration = connection.QuerySingleOrDefault<long>(
                    "SELECT Id FROM Members_Events WHERE Event_Id = @EventId AND Member_Id = @MemberId",
                    new { EventId = eventId, MemberId = memberId });

                if (existingRegistration != 0)
                {

                    return false;
                }
                else
                {
                    int rowsAffected = connection.Execute(
                        "INSERT INTO Members_Events (Event_Id, Member_Id) VALUES (@EventId, @MemberId)",
                        new { EventId = eventId, MemberId = memberId });

                    return rowsAffected > 0;
                }
            
        }
    }
}


