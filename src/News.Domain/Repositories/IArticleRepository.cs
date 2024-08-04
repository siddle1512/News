﻿using News.Domain.Entities;

namespace News.Domain.Repositories
{
    public interface IArticleRepository : IAsyncRepository<Article>
    {
    }
}
