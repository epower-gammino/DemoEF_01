using System;
using System.Collections.Generic;

namespace DemoEF_01.Models
{
    public partial class Operatore
    {
        public Operatore()
        {
            Note = new HashSet<Note>();
        }

        public int OperId { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public virtual ICollection<Note> Note { get; set; }
    }
}
