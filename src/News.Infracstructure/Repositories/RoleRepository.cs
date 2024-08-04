using News.Domain.Entities;
using News.Domain.Repositories;
using News.Infracstructure.Data;

namespace News.Infracstructure.Repositories
{
    public class RoleRepository : RepositoryBase<Role>, IRoleRepository
    {
        public RoleRepository(NewsDbContext newsDbContext) : base(newsDbContext)
        {
        }
    }
}
