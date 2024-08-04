using AutoMapper;
using News.Application.Responses;
using News.Domain.Entities;

namespace News.Application.Mappers
{
    public class ArticleMappingProfile : Profile
    {
        public ArticleMappingProfile()
        {
            CreateMap<Article, ArticleResponse>().ReverseMap();
        }
    }
}
