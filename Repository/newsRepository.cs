using Contracts;
using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class newsRepository : RepositoryBase<News>, InewsRepository
    {


        public newsRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public News? GetNewsById(int NewId)
        {
            return FindByCondition(x => x.Id.Equals(NewId)).SingleOrDefault();
        }
        public void CreateNews(News news)
        {
            Create(news);
        }

        public void DeleteNews(News news)
        {
            Delete(news);
        }

        public IEnumerable<News> GetAllNews()
        {
            return FindAll().ToList();
        }

        public void UpdateNews(News news)
        {
            Update(news);
        }
    }
}