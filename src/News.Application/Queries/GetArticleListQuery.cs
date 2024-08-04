using MediatR;
using News.Application.Responses;
using System.Collections.Generic;

namespace News.Application.Queries
{
    public class GetArticleListQuery : IRequest<List<ArticleResponse>>
    {
    }
}
