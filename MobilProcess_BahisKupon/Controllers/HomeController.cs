using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobilProcess_BahisKupon.Controllers
{
    public class HomeController : Controller
    {
        TestDBEntities testDB = new TestDBEntities();
        public ActionResult Index()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Index(string memberId)
        {
            memberId=Request["MemberId"];
            int member_Id=Convert.ToInt32(memberId);   
            
            Models.MemberandCoupons memberandCoupons = new Models.MemberandCoupons();

            memberandCoupons.members= testDB.Members.Where(x => x.MemberId == member_Id).ToList();
            memberandCoupons.coupons= testDB.EventCouponMasters.Where(x => x.MemberId == member_Id && x.Status!=3).ToList();

            return View(memberandCoupons);
        }
    }
}