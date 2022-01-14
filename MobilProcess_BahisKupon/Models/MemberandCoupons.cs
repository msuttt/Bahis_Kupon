using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobilProcess_BahisKupon.Models
{
   
    public class MemberandCoupons
    {
        
       public List<Members> members = new List<Members>();
       public List<EventCouponMasters> coupons = new List<EventCouponMasters>();
    }
}