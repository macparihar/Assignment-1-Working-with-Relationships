
using Core;
using Core.Entity;


using (var context = new DataContext())
{
    context.Database.EnsureCreated();

    var users = new List<User>
    {
                new User{ UserName = "Milan Parihar", Email = "milan@gmail.com", PhoneNumber = "626-648-5678" },
                new User { UserName = "Mohit Parihar", Email = "mohit@gmail.com", PhoneNumber = "618-759-1597" },
                new User { UserName = "Mukul Thakur", Email= "mukul@gmail.com", PhoneNumber = "654-954-3654" }
    };

    context.Users.AddRange(users);
    context.SaveChanges();

    Console.WriteLine("3 Users have saved successfully.");

    var user = context.Users.FirstOrDefault(u => u.UserName == "Milan Parihar");

    var blogType = new BlogType { Status = "Active", Name = "Technology", Description = "Tech related blogs" };
    context.Add(blogType);
    context.SaveChanges();

    var blog = new Blog
    {
        Url = "http://GeeksForGeeks.com",
        IsPublic = true,
        BlogTypeId = blogType.BlogTypeId,
        UserId = user.UserId
    };
    context.Add(blog);
    context.SaveChanges();

    var postType = new PostType { Status = "Active", Name = "Article", Description = "Informative articles" };
    context.Add(postType);
    context.SaveChanges();

    var post = new Post
    {
        Title = "First Post",
        Content = "This is the first post.",
        UserId = users[0].UserId,
        BlogId = blog.BlogId,
        PostTypeId = postType.PostTypeId,
       
    };
    context.Posts.Add(post);
    context.SaveChanges();

    Console.WriteLine("1 Blog and 1 Post has been saved.");

    



}
