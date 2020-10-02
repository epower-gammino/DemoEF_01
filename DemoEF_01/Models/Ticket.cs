using System;
using System.Collections.Generic;

namespace DemoEF_01.Models
{
    public partial class Ticket
    {
        public Ticket()
        {
            Note = new HashSet<Note>();
        }

        public int TicketId { get; set; }
        public DateTime DataApertura { get; set; }
        public int FkUtentiId { get; set; }
        public string Status { get; set; }
        public string Richiesta { get; set; }

        public virtual Utente FkUtenti { get; set; }
        public virtual ICollection<Note> Note { get; set; }
    }
}
