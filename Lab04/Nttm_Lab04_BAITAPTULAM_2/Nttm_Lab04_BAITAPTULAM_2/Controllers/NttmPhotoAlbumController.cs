using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nttm_Lab04_BAITAPTULAM_2.Controllers
{
    public class NttmPhotoAlbumController : Controller
    {
        // Action để hiển thị các ảnh trong thư mục
        // GET: NttmPhotoAlbum
        public ActionResult NttmIndex()
        {
            string[] imageFiles = Directory.GetFiles(Server.MapPath("~/Content/Images"));
            List<string> imageUrls = new List<string>();

            foreach (string imageFile in imageFiles)
            {
                string fileName = Path.GetFileName(imageFile);
                string imageUrl = Url.Content("~/Content/Images/" + fileName);
                imageUrls.Add(imageUrl);
            }
            return View(imageUrls);
        }
        // Action để upload ảnh vào thư mục
        [HttpPost]
        public ActionResult NttmUpload(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                string fileName = Path.GetFileName(file.FileName);
                string filePath = Path.Combine(Server.MapPath("~/Content/Images"), fileName);
                file.SaveAs(filePath);
            }

            return RedirectToAction("NttmIndex");
        }
        // Action để xóa ảnh
        public ActionResult NttmDelete(string fileName)
        {
            string filePath = Path.Combine(Server.MapPath("~/Content/Images"), fileName);

            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }

            return RedirectToAction("NttmIndex");
        }
    }
}