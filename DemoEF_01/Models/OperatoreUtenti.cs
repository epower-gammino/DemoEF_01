using System;
using System.Collections.Generic;

namespace DemoEF_01.Models
{
    public partial class OperatoreUtenti
    {
        public int OperatoriUtentiId { get; set; }
        public int FkUtentiId { get; set; }
        public int FkOperId { get; set; }

        public virtual Operatore FkOper { get; set; }
        public virtual Utente FkUtenti { get; set; }
    }
}
