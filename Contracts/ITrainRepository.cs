using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ITrainRepository
    {
        IEnumerable<Train> GetAllTrain();
        Train? GetTrainById(int trainID);

        void CreateTrain(Train train);
        void DeleteTrain(Train train);
        void UpdateTrain(Train train);
    }
}
