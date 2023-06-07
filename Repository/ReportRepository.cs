using Contracts;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ReportRepository : RepositoryBase<Report>, IReportRepository
    {
        public ReportRepository(RepositoryContext repositoryContext) : base(repositoryContext) {}
        public void CreateReport(Report report) =>
            Create(report);
        public void DeleteReport(Report report) =>
            Delete(report);
        public IEnumerable<Report> GetAllReports()=>
            FindAll().OrderBy(r => r.Date);
        public Report GetReportById(int id)=>
            FindByCondition(r => r.Id.Equals(id)).FirstOrDefault();
        public void UpdateReport(Report report)=>
            Update(report);
    }
}
