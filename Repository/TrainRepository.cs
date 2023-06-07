using Contracts;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TrainRepository : RepositoryBase<Train>, ITrainRepository
    {
        public TrainRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateTrain(Train train)
        {
            Create(train);
        }

        public void DeleteTrain(Train train)
        {
            Delete(train);
        }

        public IEnumerable<Train> GetAllTrain()
        {
            return FindAll().OrderBy(x=>x.Id).ToList();
        }
       
        public Train? GetTrainById(int trainID)
        {
            return FindByCondition(c => c.Id.Equals(trainID)).SingleOrDefault();
        }

        public void UpdateTrain(Train train)
        {
            Update(train);
        }

      
    }
}
