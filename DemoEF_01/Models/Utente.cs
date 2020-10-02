using System;
using System.Collections.Generic;

namespace DemoEF_01.Models
{
    public partial class Utente
    {
        public Utente()
        {
            Ticket = new HashSet<Ticket>();
        }

        public int UtentiId { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public virtual ICollection<Ticket> Ticket { get; set; }
    }
}
