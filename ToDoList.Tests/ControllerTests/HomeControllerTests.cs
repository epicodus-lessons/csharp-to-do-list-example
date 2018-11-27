using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Controllers;
using ToDoList.Models;

namespace ToDoList.Tests
{
    [TestClass]
    public class HomeControllerTest
    {

      [TestMethod]
      public void Index_ReturnsCorrectView_True()
      {
        //Arrange
        HomeController controller = new HomeController();

        //Act
        ActionResult indexView = controller.Index();

        //Assert
        Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }

      [TestMethod]
      public void Index_HasCorrectModelType_ItemList()
      {
        //Arrange
        HomeController controller = new HomeController();
        ViewResult indexView = controller.Index() as ViewResult;

        //Act
        ViewResult result = indexView.ViewData.Model;

        //Assert
        Assert.IsInstanceOfType(result, typeof(List<Item>));
      }

    }
}
