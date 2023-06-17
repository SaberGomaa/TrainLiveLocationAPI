using Entites;
using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRailwayRepository
    {
        IEnumerable<Railway> GetAllRailway();
        Railway GetRailwayById(int Id);
        void CreateRailway(Railway railway);
        void DeleteRailway(Railway railway);
        void UpdateRailway(Railway railway);
    }
}
