using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class CategoryTests
  {

    [TestMethod]
    public void CategoryConstructor_CreatesInstanceOfCategory_Category()
    {
      string name = "Test Category";
      Category newCategory = new Category("test category");
      

      string result = newCategory.Name;

      Assert.AreEqual(name, result);

      
    }
  }
}