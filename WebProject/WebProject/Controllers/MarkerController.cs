using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebProject.Models;
using System.Web.Helpers;

namespace WebProject.Controllers
{
    [Authorize]
    public class MarkerController : Controller
    {
        //
        // Post: /Search/UserMap
        [HttpPost]
        public void ToDataBase(string watever)
        {
            var watever2 = System.Web.Helpers.Json.Decode(watever);
            Marker db = new Marker();
            var markerId = db.Id;
            var Money = db.Money;
            var Color = db.Color;
            var userId = db.userId;
        }
    }
}