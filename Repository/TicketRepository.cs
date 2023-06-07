using Contracts;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TicketRepository : RepositoryBase<Ticket>, ITicketRepository
    {
        public TicketRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {}


        public Ticket GetTicketById(int Id)
        {
            return FindByCondition(c => c.Id.Equals(Id)).SingleOrDefault();
        }
        public void CreateTicket(Ticket ticket)
        {
            Create(ticket);
        }

        public void UpdateTicket(Ticket ticket)
        {
            Update(ticket);
        }

        public Ticket CheckTecketExiesting(int TicketId)
        {
            return FindByCondition(x => x.Id.Equals(TicketId)).SingleOrDefault();
        }

        public void DeleteTikcket(Ticket ticket)=>
            Delete(ticket);

        public IEnumerable<Ticket> GetAllTikets() =>
            FindAll();
    }
}
