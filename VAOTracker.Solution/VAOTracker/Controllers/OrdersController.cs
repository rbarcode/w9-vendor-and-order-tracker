using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using VAOTracker.Models;

namespace VAOTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorID}/orders/new")]
    public ActionResult New(int vendorID)
    {
      Vendor vendor = Vendor.Find(vendorID);
      return View(vendor);
    }

  }
}