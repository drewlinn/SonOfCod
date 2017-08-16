using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Controllers;
using SonOfCod.Models;
using Xunit;

namespace SonOfCod.Tests
{
    public class NewsletterControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            NewsletterController controller = new NewsletterController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Get_ModelList_Index_Test()
        {
            //Arrange
            ViewResult indexView = new NewsletterController().Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsType<List<Newsletter>>(result);
        }
        [Fact]
        public void Get_ViewResult_Details_Test()
        {
            //Arrange
            NewsletterController controller = new NewsletterController();

            //Act
            var newsletter = new Newsletter();
            var result = controller.Details(newsletter.id);

            //Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Get_ViewResult_Create_Test()
        {
            //Arrange
            NewsletterController controller = new NewsletterController();

            //Act
            var result = controller.Create();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Get_ViewResult_Edit_Test()
        {
            //Arrange
            NewsletterController controller = new NewsletterController();

            //Act
            var newsletter = new Newsletter();
            var result = controller.Edit(newsletter.id);

            //Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Get_ViewResult_Delete_Test()
        {
            //Arrange
            NewsletterController controller = new NewsletterController();

            //Act
            var newsletter = new Newsletter();
            var result = controller.Delete(newsletter.id);

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
