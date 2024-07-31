using News.Domain.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace News.Domain.Entities
{
    public class User : EntityBase
    {
        [MaxLength(256)]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string PasswordHash { get; set; }
        [DataType(DataType.EmailAddress)]
        [ConcurrencyCheck]
        public string Email { get; set; }
        public string RoleId { get; set; }

        public Role Role { get; set; }
        public ICollection<Article> Articles { get; }
    }
}
