using Lab02_BAITAPTULAM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Lab02_BAITAPTULAM.Controllers
{
    public class SongController : Controller
    {
        // GET: Song
        public ActionResult Index()
        {
            var songs = new List<Song>
        {
            new Song { Title = "Thị Mầu", Artist = "Hòa Minzy x Masew", DownloadLink = "link1.mp3" },
            new Song { Title = "Để Mị Nói Cho Mà Nghe", Artist = "Hoàng Thùy Linh", DownloadLink = "link2.mp3" },
            new Song { Title = "Phía sau một cô gái", Artist = "Sobin Hoàng Sơn", DownloadLink = "link3.mp3" },
            new Song { Title = "Chúng ta của hiện tại", Artist = "Sơn Tùng M-TP", DownloadLink = "link4.mp3" },
            new Song { Title = "Nấu ăn cho em", Artist = "Đen Vâu", DownloadLink = "link5.mp3" },
            new Song { Title = "Mây x Gió", Artist = "Jank x Sỹ Tây x Freak D", DownloadLink = "link6.mp3" },
            new Song { Title = "Em có nhớ anh không", Artist = "Hiya", DownloadLink = "link7.mp3" },
            new Song { Title = "Như Anh Đã Thấy Em", Artist = "PhucXp ft. Freak D", DownloadLink = "link8.mp3" },
            new Song { Title = "Kẻ theo đuổi ánh sáng", Artist = "Huy Vạc x Tiến Nguyễn", DownloadLink = "link9.mp3" },
            new Song { Title = "Hẹn em ở lần yêu thứ 2", Artist = "Nguyenn x @Dangtuanvu.Original ", DownloadLink = "link10.mp3" }
        };

            return View(songs);
        }
        public ActionResult Details(string downloadLink, string title, string artist)
        {
            var song = new Song { Title = title, Artist = artist, DownloadLink = downloadLink };

            return View(song);
        }

    }
}