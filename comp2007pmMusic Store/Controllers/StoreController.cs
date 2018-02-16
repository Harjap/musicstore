using comp2007pmMusic_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comp2007pmMusic_Store.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            //create mock list
            var genres = new List<Genre>();
            for(int i=1; i<11; i++)
            {

                genres.Add(new Genre { Name = "Genre" + i.ToString() });
            }
            //ViewBag.Genres = genres;

            return View(genres);
        }

        //Get :Store/DEtails?genre=value

        public ActionResult Details(string genre)
        {

            //if genre is empty
            if (genre == null)
            {
               // return View("Error");
               return RedirectToAction("Index");
            }
            //mock list of albums
            var albums = new List<Album>();
            for(int i=1; i < 4; i++)
            {
                albums.Add(new Album { Title = "Album" + i.ToString(), AlbumArtUrl = "/Content/Images/placeholder.gif" , Price=8.99});
            }

            ViewBag.Genre = genre;
            return View(albums);
        }
    }
}