using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Songlist.Models;

namespace Songlist.Controllers
{
    public class HomeController : Controller
    {
     private SongContext context { get; set; }

        public HomeController(SongContext ctx )
        {
            context = ctx;           
        }

        public IActionResult Index()
        {
            var songs = context.Songs.OrderBy(m => m.Name).ToList();
            return View(songs);
        }

    }
}
