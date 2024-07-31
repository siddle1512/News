using News.Domain.Entities;
using News.Domain.Repositories;
using News.Infracstructure.Data;

namespace News.Infracstructure.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(NewsDbContext newsDbContext) : base(newsDbContext)
        {
        }
    }
}
