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
            //Arrange
           var myTest = new ReportViewModel();

            //Act
            var resultUsers = myTest.NumberOfUsers;

            //Assert
            Assert.IsNotNull(resultUsers);
        }

        [TestMethod]
        public void ReportViewModel_NumberOfUsers_Set_Default_Should_Pass()
        {
            //Arrange
            var myTest = new ReportViewModel();

            //Act
            myTest.NumberOfUsers = 3;
            var resultUsers = myTest.NumberOfUsers;

            //Assert
            Assert.AreEqual(3, resultUsers);
        }

        [TestMethod]
        public void ReportViewModel_LogViewModel_Get_Default_Should_Pass()
        {   
            //Arrange
            var myTest = new ReportViewModel();

            //act
            var result = myTest.LogViewModel;

            //asset
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_LogViewModel_Set_Default_Should_Pass()
        {
            //Arrange
            
            // Creating a new LogModel and adding it to the MyTest, with a PhoneID of "phone"
            var myTest = new LogViewModel();
            var myList = new List<LogModel>();
            myList.Add(new LogModel { PhoneID = "Phone" });
            var testReportViewModel = new ReportViewModel();


            //Act
            testReportViewModel.LogViewModel = myTest;
            var result = testReportViewModel.LogViewModel.LogList;

            //Assert
            Assert.AreEqual("Phone", result[0].PhoneID);
        }
    }

}

