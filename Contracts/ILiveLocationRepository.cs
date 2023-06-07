using Entites;
using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ILiveLocationRepository
    {

        IEnumerable<LiveLocation> GetAllLocations();
        IEnumerable<LiveLocation> GetLocationsForTrain(int TrainId);
        LiveLocation GetLocationById(int Id);
        LiveLocation GetLocationForUser(int userId, int trainId);
        void CreateLocation(LiveLocation liveLocation);
        void DeleteLocation(LiveLocation liveLocation);
        void UpdateLocation(LiveLocation liveLocation);
    }
}
