using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace VAOTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int IDNumber { get; }
    private static List<Vendor> _listOfVendors = new List<Vendor>();
    // public List<Order> Orders { get; set; }

    public Vendor(string vendorName, string vendorDescription)
    {
      Name = vendorName;
      Description = vendorDescription;
      _listOfVendors.Add(this);
      IDNumber = _listOfVendors.Count;
      // Orders = new List<Order>();
    }

    public static Vendor Find(int searchID)
    {
      return _listOfVendors[searchID-1];
    }

    public static List<Vendor> GetAll()
    {
      return _listOfVendors;
    }

    public static void ClearAll()
    {
      _listOfVendors.Clear();
    }

    // public void AddOrder(Order order)
    // {
    //   Orders.Add(order);
    // }
  }
}