using MVC_Project_Pronia.Models;


namespace MVC_Project_Pronia.ViewModels
{
    public class HomeVM
    {
      public  List<Slide> Slides { get; set; }
      public  List<Blog> Blogs { get; set; }
      public List<Product> Products { get; set; }
    }
}
