namespace Blog_App.Controllers.Domain
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PageTitle { get; set; }

        public ICollection<BlogPost> BlogPosts { get; set; }
    }
}
