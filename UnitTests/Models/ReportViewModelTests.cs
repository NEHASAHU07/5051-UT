using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;

namespace UnitTests.Models
{
    [TestClass]
    public class ReportViewModelUnitTest
    {
        [TestMethod]
        //Instantiate test case get the 42% coverage
        public void ReportViewModel_Instantiate_Default_Should_Pass()
        {
            //Arrange
            

            //Act
            var result = new ReportViewModel();

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
