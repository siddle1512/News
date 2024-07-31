using News.Domain.Entities;
using News.Domain.Repositories;
using News.Infracstructure.Data;

namespace News.Infracstructure.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(NewsDbContext newsDbContext) : base(newsDbContext)
        {
        }
    }
}
