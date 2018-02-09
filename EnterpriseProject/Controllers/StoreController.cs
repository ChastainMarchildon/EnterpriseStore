using EnterpriseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnterpriseProject.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            //create a mock list genre object
            var genres = new List<Genre>();

            for (int i = 1; i<11; i++)
            {
                genres.Add(new Genre { Name = "Genre" + i.ToString() });
            }
            //ViewBag.Genres = genres;
            return View(genres);

        }

        //GET: Store/Details?genre=[value]
        public ActionResult Details(string genre)
        {
            //check for an empty genre
            if (genre == null)
            {
                //return View("Error");
                return RedirectToAction("Index");
            }

            var albums = new List<Albums>();

            for (int i = 1; i < 4; i++)
            {
                albums.Add(new Albums { Title = "Album " + i.ToString(),Price=8.99, AlbumArtUrl = "/Content/Images/placeholder.gif" });
            }
        

            ViewBag.Genre = genre;
            return View(albums);
        }
    }
}