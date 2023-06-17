using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ITrainInStationTimeRepository
    {
        IEnumerable<TrainInStationTime> GetAllTrainInStationTime() ;
        void CreateTrainInStationTime(TrainInStationTime trainInStationTime);
        void DeleteTrainInStationTime(TrainInStationTime trainInStationTime);
        void UpdateTrainInStationTime(TrainInStationTime trainInStationTime);
    }
}
