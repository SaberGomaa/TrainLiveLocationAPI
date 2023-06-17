using Contracts;
using Entites.Models;

namespace Repository
{
    public class TrainInStationTimeRepository : RepositoryBase<TrainInStationTime>, ITrainInStationTimeRepository
    {
        public TrainInStationTimeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateTrainInStationTime(TrainInStationTime trainInStationTime) { }
        public void DeleteTrainInStationTime(TrainInStationTime trainInStationTime)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TrainInStationTime> GetAllTrainInStationTime() =>
               FindAll()
               .OrderBy(c => c.TrainTime)
               .ToList();

        public void UpdateTrainInStationTime(TrainInStationTime trainInStationTime)
        {
            throw new NotImplementedException();
        }
    }
}
