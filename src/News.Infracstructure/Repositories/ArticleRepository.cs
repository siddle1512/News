using News.Domain.Entities;
using News.Domain.Repositories;
using News.Infracstructure.Data;

namespace News.Infracstructure.Repositories
{
    public class ArticleRepository : RepositoryBase<Article>, IArticleRepository
    {
        public ArticleRepository(NewsDbContext newsDbContext) : base(newsDbContext)
        {
        }
    }
}
