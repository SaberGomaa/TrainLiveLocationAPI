using Contracts;
using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RailwayRepository : RepositoryBase<Railway>, IRailwayRepository
    {
        public RailwayRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateRailway(Railway railway)
        {
            throw new NotImplementedException();
        }

        public void DeleteRailway(Railway railway)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Railway> GetAllRailway()=>
            FindAll()
            .OrderBy(c=>c.Id)
            .ToList();

        public Railway GetRailwayById(int Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateRailway(Railway railway)
        {
            throw new NotImplementedException();
        }
    }
}
