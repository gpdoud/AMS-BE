using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AMS_BE.Models;
using Utility;

namespace AMS_BE.Controllers
{
    public class UsersController : Controller
    {
        private AMS_Context db = new AMS_Context();

		public ActionResult List() {
			return new JsonNetResult(db.Users.ToList());
		}
		public ActionResult Get(int? Id) {
			return new EmptyResult();
		}
		public ActionResult Add([System.Web.Http.FromBody] User user) {
			return new EmptyResult();
		}
		public ActionResult Change([System.Web.Http.FromBody] User user) {
			return new EmptyResult();
		}
		public ActionResult Remove([System.Web.Http.FromBody] User user) {
			return new EmptyResult();
		}

		protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
