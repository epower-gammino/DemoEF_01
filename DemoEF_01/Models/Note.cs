using System;
using System.Collections.Generic;

namespace DemoEF_01.Models
{
    public partial class Note
    {
        public int FkTicketId { get; set; }
        public int NoteId { get; set; }
        public DateTime DataNote { get; set; }
        public int? FkOperId { get; set; }
        public string TipoNota { get; set; }
        public string StatoNota { get; set; }
        public string TestoNota { get; set; }

        public virtual Operatore FkOper { get; set; }
        public virtual Ticket FkTicket { get; set; }
    }
}
