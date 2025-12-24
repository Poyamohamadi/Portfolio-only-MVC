namespace asp.Models;

public class Article
{
    public String Category { get; set; }
    public String Title { get; set; }
    public String Content { get; set; }
    public String Author { get; set; }
    public String Image { get; set; }
    public String ImageAuthore { get; set; }

    public int Like { get; set; }
    public int Seen {get; set;}
    public int Comment {get; set;}
    
    public Article(String category, String title, String content, String author, 
        String image, String imageAuthore,  int like, int seen, int comment)
    {
        this.Category = category;
        this.Title = title;
        this.Content = content;
        this.Author = author;
        this.Image = image;
        this.ImageAuthore = imageAuthore;
        this.Like = like;
        this.Seen = seen;
        this.Comment = comment;
        
    }
}