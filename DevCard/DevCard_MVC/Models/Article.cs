namespace DevCard_MVC.Models
{
    public class Article
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Article(string description, long id, string title,string image)
        {
            Description = description;
            Id = id;
            Title = title;
            Image = image;
        }
    }
}
