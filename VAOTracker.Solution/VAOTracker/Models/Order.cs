using System;
using System.Collections.Generic;

namespace VAOTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int IDNumber { get; }
    private static List<Order> _listOfOrders = new();

    public Order(string orderTitle, string orderDescription, int orderPrice, string orderDate)
    {
      Title = orderTitle;
      Description = orderDescription;
      Price = orderPrice;
      Date = orderDate;
      _listOfOrders.Add(this);
      IDNumber = _listOfOrders.Count;
    }

    public static Order Find(int searchID)
    {
      return _listOfOrders[searchID - 1];
    }

    public static List<Order> GetAll()
    {
      return _listOfOrders;
    }

    public static void ClearAll()
    {
      _listOfOrders.Clear();
    }

    public void RemoveOrder()
    {
      _listOfOrders.Remove(this);
    }

    // public static void RemoveOrder(int searchID)
    // {
    //   int indexToBeRemoved = searchID - 1;
    //   _listOfOrders.RemoveAt(indexToBeRemoved);
    // }
  }
}