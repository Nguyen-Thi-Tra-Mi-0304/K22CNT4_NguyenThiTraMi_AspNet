using Nttm_Lab05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nttm_Lab05.Controllers
{
    public class NttmSongController : Controller
    {
        private static List<NttmSong> nttmSongs = new List<NttmSong>()
        {
            new NttmSong{Id=210900041, NttmTitle="Nguyễn Thị Trà Mi", NttmAuthor="K22CNT4", NttmArtist="NTU", NttmYearRelease=2022},
            new NttmSong{Id=1, NttmTitle="Trà Mi", NttmAuthor="K22CNT4", NttmArtist="NTU", NttmYearRelease=2020},
        };
        // GET: NttmSong
        /// <summary>
        /// Hiển thị danh sách bài hát 
        /// Author: Nguyễn Thị Trà Mi
        /// </summary>
        /// <returns></returns>
        public ActionResult NttmIndex()
        {
            return View(nttmSongs);
        }
        // GET: NttmCreate 
        /// <summary>
        ///Form thêm mới bài hát 
        /// Author: Nguyễn Thị Trà Mi
        /// </summary>
        /// <returns></returns>
        public ActionResult NttmCreate()
        {
            var nttmSong = new NttmSong();
            return View(nttmSong);
        }
    }
}