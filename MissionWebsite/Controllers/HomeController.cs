using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Mission(int missionID = 1)
        {
            return View();
        }


        public ActionResult MissionFAQs(int missionID = 1)
        {
            if (missionID == 1)
            {
                ViewBag.name = "Cape Coast, Ghana";
                ViewBag.mpname = "President Melvin Sabey" ;
                ViewBag.address =   "Cape Coast" ;
                ViewBag.lang =   "English, Twi  " ;
                ViewBag.climate = "Tropical, hot and humid   ";
                ViewBag.religion =   "Christian " ;
                ViewBag.flag = "http://icons.veryicon.com/ico/Flag/Rounded%20World%20Flags/Ghana%20Flag.ico";
                ViewBag.photo = "http://www.ldsdb.com/dadmin/photosfldr/photoalbums/1564/Cape-Coast-Castle-Ghana-2011-11-13-999_midx.jpg";
            }

            if (missionID == 2)
            {
                ViewBag.name = "Abidjan, Ivory Coast";
                ViewBag.mpname = "  ";
                ViewBag.address = "  ";
                ViewBag.lang = "French, local dialects  ";
                ViewBag.climate = "Tropical, hot and humid  ";
                ViewBag.religion = " Christian";
                ViewBag.flag = "http://www.pngall.com/wp-content/uploads/2016/05/Ivory-Coast-Flag-PNG-Clipart.png";
                ViewBag.photo = "https://s-media-cache-ak0.pinimg.com/originals/85/4f/eb/854febf1604c5fc6e4a935543e4d5cb7.jpg";
            }

            if (missionID == 3)
            {
                ViewBag.name = "Beijing, China";
                ViewBag.mpname = "  ";
                ViewBag.address = "  ";
                ViewBag.lang = "Mandarin, Chinese  ";
                ViewBag.climate = "Four seasons";
                ViewBag.religion = "Not religious";
                ViewBag.flag = "http://bestanimations.com/Flags/Asia/china/chinese-flag-waving-gif-animation-25.gif";
                ViewBag.photo = "https://www.ciee.org/study-abroad/images/programs/0789/headers/desktop/college-abroad-beijing-china-countryside.jpg";
            }
            return View();
        }

        
    }
}