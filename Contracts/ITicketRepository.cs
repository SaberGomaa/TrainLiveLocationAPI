using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ITicketRepository
    {
        Ticket GetTicketById(int Id);
        void CreateTicket(Ticket ticket);
        void UpdateTicket(Ticket ticket);
        Ticket? CheckTecketExiesting(int TicketId);
        void DeleteTikcket(Ticket ticket);
        IEnumerable<Ticket> GetAllTikets();
    }
}
