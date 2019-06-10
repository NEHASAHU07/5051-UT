using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;
using System.Collections.Generic;

namespace UnitTests.Models
{
    [TestClass]
    public class ReportViewModelUnitTest
    {
        [TestMethod]
        //Instantiate test case get the 42.86% coverage
        public void ReportViewModel_Instantiate_Default_Should_Pass()
        {
            //Arrange
            

            //Act
            var result = new ReportViewModel();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_NumberOfUsers_Get_Default_Should_Pass()
        {
            // Arrange

            //Act

            //Assert
        }





    }

}

