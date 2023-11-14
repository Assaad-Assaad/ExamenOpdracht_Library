using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOpdracht_Library.Classes
{
    
    public class Event
    {
        public long Id { get; set; }
        public string EventName { get; set; }

        public DateTime DateAndTime { get; set; }

        public string EventDisplay
        {
            get { return $"{EventName} - {DateAndTime.ToString("yyyy-MM-dd HH:mm")}"; }
        }
    }
}
