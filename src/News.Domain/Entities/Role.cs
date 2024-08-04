using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using News.Domain.Common;

namespace News.Domain.Entities
{
    public class Role : EntityBase
    {
        [MaxLength(50)]
        public string RoleName { get; set; }

        public ICollection<User> Users { get; }
    }
}
