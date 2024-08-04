using System;
using System.ComponentModel.DataAnnotations;
using News.Domain.Common;

namespace News.Domain.Entities
{
    public class Article : EntityBase
    {
        [Required]
        [MaxLength(256)]
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PubliccationDate { get; set; }
        public string ImageUrl { get; set; }
        public int Priority { get; set; }
        public string UserId { get; set; }
        public string CategoryId { get; set; }

        public User User { get; set; }
        public Category Category { get; set; }
    }
}
