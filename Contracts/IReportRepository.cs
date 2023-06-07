using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IReportRepository
    {
        IEnumerable<Report> GetAllReports();
        Report GetReportById(int id);
        void CreateReport(Report report);
        void UpdateReport(Report report);
        void DeleteReport(Report report);
    }
}
