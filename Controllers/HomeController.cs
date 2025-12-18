using Microsoft.AspNetCore.Mvc;
using MVC_Project_Pronia.Models;
using MVC_Project_Pronia.ViewModels;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata;


namespace MVC_Project_Pronia.Controllers
{
    public class HomeController : Controller

    {
        
            public IActionResult Index()
        {
            return View();
            List<Slide> slides = new List<Slide>
{
                new Slide
                {
                Title = "Bitki 1",
                Discount = 30,
                Description = "Yaz sezonuna özəl %30 endirim fürsati!!!",
                Image = "1-2-270x300.jpg",
            Order = 1
        },
    new Slide
    {
        Title = "Bitki 2",
        Discount = 20,
        Description = "Yeni sezon ürünlerde qaçırılmayacaq endirim.",
        Image = "1-1-270x300.jpg",
        Order = 2
    },
    new Slide
    {
        Title = "Bitki 3",
        Discount = 50,
        Description = "Seçilmiş bitgilərə %60'ye çatan endirimler.",
        Image = "1-1-570x633.jpg",
        Order = 3
    }
};
            List<Product> products = new List<Product>
{
    new Product
    {
        Name = "Bitki 1 ",
        Price = 67.45m,
        PrimaryImage = "1-7-270x300.jpg",
        SecondaryImage = "1-8-270x300.jpg"
    },
    new Product
    {
        Name = "Bitki-2",
        Price = 20.00m,
        PrimaryImage = "1-8-270x300.jpg",
        SecondaryImage = "1-1-270x300.jpg"
    },
    new Product
    {
        Name = "Bitki 3",
        Price = 23.45m,
        PrimaryImage = "1-1-270x300.jpg",
        SecondaryImage = "1-2-270x300.jpg"
    }
};
            List<Blog> blogs = new List<Blog>
{
            new Blog
             {
                     Id = 3,
                
                Title = "Ev Bitkiləri Baxımı",
                Description = "Ev bitkilərinizi sağlam qalamsını təmin etmək üçün əsas qaydalar.",
                ImageUrl = "1-3-270x300.jpg",
                CreatedDate = new DateTime(2025, 12, 16)
            },
            new Blog
            {
                Id = 2,
                
                Title = "Sedum haqqında Bilməli olduğunuz  faktlar",
                Description = "Sedumların necə qulluq edilməsi və çoxaldılması haqqında praktiki məsləhətlər.",
                ImageUrl = "1-3-270x300.jpg",
                CreatedDate = new DateTime(1212, 12, 12)
            },
            new Blog
            {
                Id = 1,
                
                Title = "Bağçılıqda Təbii Gübrələr",
                Description = "Bitkilər üçün ekoloji təmiz və effektiv gübrələrin istifadəsi.",
                ImageUrl = "1-1-300x220.jpg",
                CreatedDate= new DateTime(1111, 11, 11)
            } };


            HomeVM homeVM = new HomeVM
            {
                Slides = slides,
                Products = products,
                Blogs = blogs,

            };


            return View(homeVM);
        }

        
    }
}

    

