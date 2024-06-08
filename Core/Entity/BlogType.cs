

using System.ComponentModel.DataAnnotations;

namespace Core.Entity
{
    public class BlogType
    {
        [Key]
        public int BlogTypeId { get; set; }
        public string Status { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Blog> Blogs { get;   set; }
        
    }
}
