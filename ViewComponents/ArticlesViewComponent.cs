using asp.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp.ViewComponents;

public class ArticlesViewComponent : ViewComponent
{
    
    public IViewComponentResult Invoke()
    {
        var articles = new List<Article>
        {
            new Article("Technology", "The Newest Technology On This Year 2019", 
                "Even the all-powerful Pointing has no control about the blind texts it is an almost",
                "Dave Lewis", "image_1.jpg", "person_1.jpg", 3, 100, 2),
            
            new Article("Travel", "What to pack when visiting Sea",
                "Even the all-powerful Pointing has no control about the blind texts it is an almost",
                "Dave Lewis","image_2.jpg","person_2.jpg", 3, 100, 5),
            
            new Article("Fashion", "Awesome Fashion Trend in For Summer",
                "Even the all-powerful Pointing has no control about the blind texts it is an almost",
                "Dave Lewis","image_3.jpg","person_3.jpg", 3, 100, 5),
            
            new Article("Travel", "10 Most Awesome Place",
                "Even the all-powerful Pointing has no control about the blind texts it is an almost",
                "Dave Lewis","image_4.jpg","person_4.jpg", 3, 100, 5),
            
            new Article("Travel", "10 Most Awesome Beach in Asia",
                "Even the all-powerful Pointing has no control about the blind texts it is an almost",
                "Dave Lewis","image_5.jpg","person_2.jpg", 3, 100, 5),
            
            new Article("Travel", "Top Amazing Places to Go in Summer",
                "Even the all-powerful Pointing has no control about the blind texts it is an almost",
                "Dave Lewis","image_6.jpg","person_1.jpg", 3, 100, 5),

            new Article("Fashion", "7 Beginner Photographer’s Mistakes",
                "Even the all-powerful Pointing has no control about the blind texts it is an almost",
                "Dave Lewis","image_7.jpg","person_4.jpg", 3, 100, 5),
            
            new Article("Photography, Travel", "Excited to Visit in Palawan Philippines",
                "Even the all-powerful Pointing has no control about the blind texts it is an almost",
                "Dave Lewis","image_8.jpg","person_2.jpg", 3, 100, 5),
            
            new Article("Technology", "How to Make a Paper Boat in Scratch",
                "Even the all-powerful Pointing has no control about the blind texts it is an almost",
                "Dave Lewis","image_9.jpg","person_3.jpg", 3, 100, 5),
            
            new Article("Fashion", "10 Best Way to Styling Your Lifestyle",
                "Even the all-powerful Pointing has no control about the blind texts it is an almost",
                "Dave Lewis","image_10.jpg","person_4.jpg", 3, 100, 5),
            
            new Article("Fashion", "10 Tips to Become a Fashion Pro",
                "Even the all-powerful Pointing has no control about the blind texts it is an almost",
                "Dave Lewis","image_11.jpg","person_1.jpg", 3, 100, 5),
            
            new Article("Photography", "Visit the Most Amazing Place in North America",
                "Even the all-powerful Pointing has no control about the blind texts it is an almost",
                "Dave Lewis","image_12.jpg","person_2.jpg", 3, 100, 5),
        };
        // ReSharper disable once Mvc.ViewComponentViewNotResolved
        return View("_Articles", articles);
    }
}