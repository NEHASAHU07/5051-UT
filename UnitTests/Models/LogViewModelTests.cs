﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;

namespace UnitTests.Models
{
    [TestClass]
    public class LogViewModelUnitTests
    {
        [TestMethod]
        public void LogViewModel_Instantiate_Default_Should_Pass()
        {
            
            //Act
            var result = new LogViewModel();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LogViewModel_Get_Default_Should_Pass()
        {
            //Arrange
            var myTest = new LogViewModel();

            //Act
            var result = myTest.LogList;

            //Assert
            Assert.IsNotNull(result);
        }


    }
}
