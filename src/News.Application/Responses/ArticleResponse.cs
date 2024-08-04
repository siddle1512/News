using System;

namespace News.Application.Responses
{
    public class ArticleResponse
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PubliccationDate { get; set; }
        public string ImageUrl { get; set; }
        public int Priority { get; set; }
        public string UserId { get; set; }
        public string CategoryId { get; set; }
    }
}
