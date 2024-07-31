using System.ComponentModel.DataAnnotations;

namespace News.Domain.Common
{
    public abstract class EntityBase
    {
        [Key]
        public string Id { get; protected set; }
    }
}
