using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VAOTracker.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace VAOTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new("title", "description", "10", "September 29, 2023");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "Test Title";
      Order newOrder = new(title, "description", "10", "September 29, 2023");
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetsTitle_String()
    {
      string title = "Test Title";
      Order newOrder = new(title, "description", "10", "September 29, 2023");
      string updatedTitle = "Revised Title";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;
      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "doughnuts";
      Order newOrder = new("title", description, "10", "September 29, 2023");
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetsDescription_String()
    {
      string description = "doughnuts";
      Order newOrder = new("title", description, "10", "September 29, 2023");
      string updatedDescription = "muffins";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      string price = "10";
      Order newOrder = new("title", "description", price, "September 29, 2023");
      int result = newOrder.Price;
      Assert.AreEqual(price, result.ToString());
    }

    [TestMethod]
    public void SetPrice_SetsPrice_Int()
    {
      string price = "10";
      Order newOrder = new("title", "description", price, "September 29, 2023");
      string updatedPrice = "8";
      int updatedPriceAsInt = Int32.Parse(updatedPrice);
      newOrder.Price = updatedPriceAsInt;
      int result = newOrder.Price;
      Assert.AreEqual(updatedPrice, result.ToString());
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      string date = "September 29, 2023";
      Order newOrder = new("title", "description", "10", date);
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void SetDate_SetsDate_String()
    {
      string date = "September 29, 2023";
      Order newOrder = new("title", "description", "10", date);
      string updatedDate = "October 31, 2023";
      newOrder.Date = updatedDate;
      string result = newOrder.Date;
      Assert.AreEqual(updatedDate, result);
    }

    [TestMethod]
    public void GetIDNumber_OrdersInstantiateWithAnIDAndGetterReturns_Int()
    {
      Order newOrder = new("title", "description", "10", "September 29, 2023");
      int result = newOrder.IDNumber;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string title01 = "Test Title 01";
      string title02 = "Test Title 02";
      string description01 = "doughnuts";
      string description02 = "muffins";
      string price01 = "10";
      string price02 = "8";
      string date01 = "September 29, 2023";
      string date02 = "October 31, 2023";
      Order newOrder1 = new(title01, description01, price01, date01);
      Order newOrder2 = new(title02, description02, price02, date02);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new() { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string title01 = "Test Title 01";
      string title02 = "Test Title 02";
      string description01 = "doughnuts";
      string description02 = "muffins";
      string price01 = "10";
      string price02 = "8";
      string date01 = "September 29, 2023";
      string date02 = "October 31, 2023";
      Order newOrder1 = new(title01, description01, price01, date01);
      Order newOrder2 = new(title02, description02, price02, date02);
      List<Order> newList = new() { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
