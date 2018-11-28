using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Controllers;
using ToDoList.Models;

namespace ToDoList.Tests
{
    [TestClass]
    public class ItemControllerTest
    {

      [TestMethod]
      public void Create_ReturnsCorrectActionType_RedirectToActionResult()
      {
        //Arrange
        ItemsController controller = new ItemsController();

        //Act
        IActionResult view = controller.Create("Walk the dog");

        //Assert
        Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
      }

      [TestMethod]
      public void Create_RedirectsToCorrectAction_Index()
      {
        //Arrange
        ItemsController controller = new ItemsController();
        RedirectToActionResult actionResult = controller.Create("Walk the dog") as RedirectToActionResult;

        //Act
        string result = actionResult.ActionName;

        //Assert
        Assert.AreEqual(result, "Index");
      }

      [TestMethod]
      public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
      {
        //Arrange
        string description = "Walk the dog.";
        Item newItem = new Item(description);

        //Act
        int result = newItem.GetId();

        //Assert
        Assert.AreEqual(1, result);
      }

    }
}
