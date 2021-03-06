﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Controllers;
using SonOfCod.Models;
using Xunit;

namespace SonOfCod.Tests
{
    public class HomeControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Get_ViewResult_Marketing_Test()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            var result = controller.Marketing();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Get_ViewResult_About_Test()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            var result = controller.About();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Get_ViewResult_Contact_Test()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            var result = controller.Contact();

            //Assert
            Assert.IsType<ViewResult>(result);

        }
    }
}
