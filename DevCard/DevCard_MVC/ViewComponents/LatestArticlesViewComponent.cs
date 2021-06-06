using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article("این اولین مقاله ای است که منشتر شد است", 1, "مقاله یکم", "blog-post-thumb-1.jpg"),
                new Article("این دومین مقاله ای است که منشتر شد است", 2, "مقاله دوم", "blog-post-thumb-2.jpg"),
                new Article("این سومین مقاله ای است که منشتر شد است", 3, "مقاله سوم", "blog-post-thumb-3.jpg"),
            };
            return View("_LatestArticles", articles);
        }
    }
}