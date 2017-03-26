using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();
            return View(comicBooks);
        }

        public ActionResult Detail(int? id) {
            if (id == null)
            {
                return HttpNotFound();
            }

            // Object initializer syntax
            var comicBook = _comicBookRepository.GetComicBook(id.Value);


            return View(comicBook);


            //if (DateTime.Today.DayOfWeek == DayOfWeek.Saturday) {
            //    return Redirect("/");
            //    //return new RedirectResult("/");
            //}
            //return Content("Hello from CB Controller!");
            ////return new ContentResult() {
            ////    Content = "Hello from CB Controller!"
            ////};
        }
    }
}