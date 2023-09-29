using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using VAOTracker.Models;

namespace VAOTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{IDNumber}")]
    public ActionResult Show(int IDNumber)
    {
      Dictionary<string, object> model = new();
      Vendor selectedVendor = Vendor.Find(IDNumber);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorID}/orders")]
    public ActionResult Create(int vendorID, string orderTitle, string orderDescription, int orderPrice, string orderDate)
    {
      Dictionary<string, object> model = new();
      Vendor foundVendor = Vendor.Find(vendorID);
      Order newOrder = new(orderTitle, orderDescription, orderPrice, orderDate);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("vendor", foundVendor);
      model.Add("orders", vendorOrders);
      return View("Show", model);
    }
  }
}