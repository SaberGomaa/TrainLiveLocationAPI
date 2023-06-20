using Contracts;
using Entites.Models;

namespace Repository
{
    public class TrainInStationTimeRepository : RepositoryBase<TrainInStationTime>, ITrainInStationTimeRepository
    {
        public TrainInStationTimeRepository(RepositoryContext repositoryContext) : base(repositoryContext){}

        public void CreateTrainInStationTime(TrainInStationTime trainInStationTime) => Create(trainInStationTime);
        public void DeleteTrainInStationTime(TrainInStationTime trainInStationTime)=> Delete(trainInStationTime);
        
        public IEnumerable<TrainInStationTime> GetAllTrainInStationTime() =>
               FindAll()
               .OrderBy(c => c.TrainTime)
               .ToList();

        public void UpdateTrainInStationTime(TrainInStationTime trainInStationTime)=>Update(trainInStationTime);
    }
}
