using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOpdracht_Library.Classes
{
    
    public class Book
    {
        public long Id { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal BuyingPrice { get; set; }
        public decimal RentingPrice { get; set; }

    }
}

