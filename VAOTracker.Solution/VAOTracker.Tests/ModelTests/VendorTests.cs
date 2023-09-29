using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VAOTracker.Models;

namespace VAOTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new("Test Name", "Test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Name";
      Vendor newVendor = new(name, "Test description");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetName_SetsName_String()
    {
      string name = "Test Name";
      Vendor newVendor = new(name, "Test description");
      string updatedName = "Revised Name";
      newVendor.Name = updatedName;
      string result = newVendor.Name;
      Assert.AreEqual(updatedName, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Test description";
      Vendor newVendor = new("Test Name", description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetsDescription_String()
    {
      string description = "Test description";
      Vendor newVendor = new("Test Name", description);
      string updatedDescription = "Revised description";
      newVendor.Description = updatedDescription;
      string result = newVendor.Description;
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetIDNumber_VendorsInstantiateWithAnIDAndGetterReturns_Int()
    {
      Vendor newVendor = new("Test Name", "Test description");
      int result = newVendor.IDNumber;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "Test Name 01";
      string name02 = "Test Name 02";
      string description01 = "Test description 01";
      string description02 = "Test description 02";
      Vendor newVendor1 = new(name01, description01);
      Vendor newVendor2 = new(name02, description02);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorList()
    {
      List<Vendor> newList = new() { };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsVendors_VendorList()
    {
      string name01 = "Test Name 01";
      string name02 = "Test Name 02";
      string description01 = "Test description 01";
      string description02 = "Test description 02";
      Vendor newVendor1 = new(name01, description01);
      Vendor newVendor2 = new(name02, description02);
      List<Vendor> newList = new() { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      Order newOrder = new("title", "description", "10", "September 29, 2023");
      List<Order> newList = new() { newOrder };
      Vendor newVendor = new("Test Name", "Test description");
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}