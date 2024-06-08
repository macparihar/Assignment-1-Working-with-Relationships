using System.ComponentModel.DataAnnotations;

namespace Core.Entity
{
    
        public class User
        {
        [Key]
            public int UserId { get; set; }
            public string UserName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public ICollection<Blog> Blogs { get; set; }
            public ICollection<Post> Posts { get; set; }
        }
    
}
