using News.Domain.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace News.Domain.Entities
{
    public class Category : EntityBase
    {
        [MaxLength(256)]
        public string CategoryName { get; set; }

        public ICollection<Article> Articles { get; }
    }
}
