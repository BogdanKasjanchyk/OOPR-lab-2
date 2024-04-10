using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasianchuk_task_2
{
    internal class Concert
    {
            public string ConcertName { get; set; }
            public string Location { get; set; }
            public string Date { get; set; }
            public int TicketPrice { get; set; }
            public bool IsSoldOut { get; set; }

            public Concert(string concertName, string location, string date, int ticketPrice, bool isSoldOut)
            {
                ConcertName = concertName;
                Location = location;   
                Date = date;   
                TicketPrice = ticketPrice;
            }
    }

}
