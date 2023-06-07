using Contracts;
using Entites;
using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class LiveLocationRepository : RepositoryBase<LiveLocation>, ILiveLocationRepository
    {
        public LiveLocationRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateLocation(LiveLocation liveLocation) =>
            Create(liveLocation);

        public void DeleteLocation(LiveLocation liveLocation) =>
            Delete(liveLocation);

        public IEnumerable<LiveLocation> GetAllLocations() =>
            FindAll()
            .OrderBy(x => x.DateOfShareLoaction)
            .ToList();

        public LiveLocation GetLocationById(int Id) =>
        FindByCondition(c => c.Id.Equals(Id)).SingleOrDefault();

        public LiveLocation GetLocationForUser(int userId, int trainId) =>
            FindByCondition(c => c.UserId.Equals(userId) && c.TrainId.Equals(trainId)).FirstOrDefault();

        public IEnumerable<LiveLocation> GetLocationsForTrain(int TrainId) =>
            FindByCondition(c => c.TrainId.Equals(TrainId)).ToList();

        public void UpdateLocation(LiveLocation liveLocation) =>
            Update(liveLocation);
    }
}
