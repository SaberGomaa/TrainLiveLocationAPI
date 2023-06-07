using Entites;
using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface InewsRepository
    {

        IEnumerable<News> GetAllNews();
        News? GetNewsById(int NewId);
        void CreateNews(News news);
        void DeleteNews(News news);
        void UpdateNews(News news);
    }
}
