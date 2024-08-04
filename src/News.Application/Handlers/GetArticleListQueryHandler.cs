using AutoMapper;
using MediatR;
using News.Application.Queries;
using News.Application.Responses;
using News.Domain.Repositories;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace News.Application.Handlers
{
    public class GetArticleListQueryHandler : IRequestHandler<GetArticleListQuery, List<ArticleResponse>>
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IMapper _mapper;
        public GetArticleListQueryHandler(IArticleRepository articleRepository, IMapper mapper)
        {
            _articleRepository = articleRepository;
            _mapper = mapper;
        }
        public async Task<List<ArticleResponse>> Handle(GetArticleListQuery request, CancellationToken cancellationToken)
        {
            var articleList = await _articleRepository.GetAllAsync();
            return _mapper.Map<List<ArticleResponse>>(articleList);
        }
    }
}
