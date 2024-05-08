using Lab02_BAITAPTULAM.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Lab02_BAITAPTULAM.Controllers
{
    public class SongController : Controller
    {
        // Danh sách các bài hát
        private static List<Song> songs = new List<Song>
        {
            new Song { ID = 001, Title = "Anh Ở Đâu - Trang Pháp", FilePath = "/path/to/song1.mp3" },
            new Song { ID = 002, Title = "Anh Biết - Hồ Quang Hiếu", FilePath = "/path/to/song2.mp3" },
            new Song { ID = 003, Title = "Phía sau một cô gái - Sobin Hoàng Sơn", FilePath = "/path/to/song3.mp3" },
            new Song { ID = 004, Title = "Có chắc yêu là đây - Sơn Tùng M-TP", FilePath = "/path/to/song4.mp3" },
            new Song { ID = 005, Title = "Bùa Yêu - Bích Phương", FilePath = "/path/to/song5.mp3" },
            new Song { ID = 006, Title = "Chúng ta của hiện tại -  Sơn Tùng M-TP", FilePath = "/path/to/song6.mp3" },
            new Song { ID = 007, Title = "See Tình - Hoàng Thùy Linh", FilePath = "/path/to/song7.mp3" },
            new Song { ID = 008, Title = "Nấu ăn cho em - Đen Vâu", FilePath = "/path/to/song8.mp3" },
            new Song { ID = 009, Title = "Cà phê - Min", FilePath = "/path/to/song9.mp3" },
             new Song { ID = 010, Title = "Em xinh - Mono", FilePath = "/path/to/song10.mp3" },
        };
        // GET: Song
        public ActionResult Index()
        {
            return View(songs);
        }
        public ActionResult Download(int id)
        {
            // Tìm bài hát có Id tương ứng trong danh sách
            var song = songs.FirstOrDefault(s => s.ID == id);
            if (song == null)
            {
                return HttpNotFound("Không tìm thấy bài hát.");
            }

            var filePath = Server.MapPath(song.FilePath);
            if (!System.IO.File.Exists(filePath))
            {
                // Xử lý trường hợp không tìm thấy file âm nhạc
                return HttpNotFound("Không tim thay file am nhac.");
            }

            // Trả về file để tải về
            return File(filePath, "application/octet-stream", Path.GetFileName(filePath));
        }
        // GET: Action chi tiết bài hát 
        public ActionResult DetailsSong(string songName, int? songId)
        {
            ViewBag.ID = songId;
            ViewBag.Title = songName;
            return View();
        }
    }
}