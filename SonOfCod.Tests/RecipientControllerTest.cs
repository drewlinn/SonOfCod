using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Controllers;
using SonOfCod.Models;
using Xunit;

namespace SonOfCod.Tests
{
    public class RecipientControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            RecipientController controller = new RecipientController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Get_ModelList_Index_Test()
        {
            //Arrange
            ViewResult indexView = new RecipientController().Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsType<List<Recipient>>(result);
        }
        [Fact]
        public void Get_ViewResult_Details_Test()
        {
            //Arrange
            RecipientController controller = new RecipientController();

            //Act
            var recipient = new Recipient();
            var result = controller.Details(recipient.id);

            //Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Get_ViewResult_Create_Test()
        {
            //Arrange
            RecipientController controller = new RecipientController();

            //Act
            var result = controller.Create();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Get_ViewResult_Edit_Test()
        {
            //Arrange
            RecipientController controller = new RecipientController();

            //Act
            var recipient = new Recipient();
            var result = controller.Edit(recipient.id);

            //Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Get_ViewResult_Delete_Test()
        {
            //Arrange
            RecipientController controller = new RecipientController();

            //Act
            var recipient = new Recipient();
            var result = controller.Delete(recipient.id);

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
