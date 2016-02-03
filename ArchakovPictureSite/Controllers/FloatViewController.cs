using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArchakovPictureSite.Models;
using System.IO;

namespace ArchakovPictureSite.Controllers
{
    public class FloatViewController : Controller
    {
        //
        // GET: /FloatView/

        const int PicturesFromPhotoesVolume = 4;
        [HttpPost]
        public ActionResult OpenPicturesFromPhotoesView(string pageName)
        {
            FileInfo[] files = new FileManager().GetFiles("//Content//Examples1//Pictures");
            FileInfo[] currentFiles = files.Take(PicturesFromPhotoesVolume).ToArray();
            TempData["count"] = PicturesFromPhotoesVolume;
            ViewBag.isExhausted = false;
            return PartialView(pageName, currentFiles);
        }
        [HttpPost]
        public ActionResult AppendPicturesFromPhotoesView(string pageName)
        {
            FileInfo[] files = new FileManager().GetFiles("//Content//Examples1//Pictures");
            int index = int.Parse(TempData.Peek("count").ToString());
            TempData["count"] = index + PicturesFromPhotoesVolume;

            if (index >= files.Length - PicturesFromPhotoesVolume) { ViewBag.isExhausted = true; }
            else ViewBag.isExhausted = false;

            int currentVolume = PicturesFromPhotoesVolume;
            if (currentVolume > files.Length + 1 - index) currentVolume = files.Length - index;

            FileInfo[] currentFiles = files.Skip(index).Take(currentVolume).ToArray();
            return PartialView(pageName, currentFiles);
        }
        [HttpPost]
        public ActionResult ContactTheArtistView(string pageName)
        {
            return PartialView();
        }
    }
}
