using Contracts;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class StationRepository : RepositoryBase<Station>, IStationRepository
    {
        public StationRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateStation(Station station)
        {
            Create(station);
        }

        public void DeleteStation(Station station)
        {
            Delete(station);    
        }

        public IEnumerable<Station> GetAllStations()
        {
           return FindAll().OrderBy(x => x.Position).Distinct().ToList();
        }

        public Station? GetStationById(int ID)
        {
            return FindByCondition(x => x.Id.Equals( ID)).SingleOrDefault();
        }


        public void UpdateStation(Station station)
        {
            Update(station);
        }
    }
}
