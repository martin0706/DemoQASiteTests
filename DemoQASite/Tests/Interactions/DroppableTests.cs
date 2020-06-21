using AutoFixture;
using DemoQASite.Pages.DragablePage;
using DemoQASite.Pages.DroppablePage;
using DemoQASite.Pages.HomePage;
using DemoQASite.Tests;
using Docker.DotNet.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace LiveDemoSeleniumAdvanced
{
    [TestFixture]
    class DroppableTests:BaseTest
    {
        private HomePage _homePage;
        private DroppablePage _droppablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Manage().Window.Maximize();
            _homePage = new HomePage(Driver);
            _droppablePage = new DroppablePage(Driver);
            _homePage.NavigateTo();


        }

        [Test]
        public void Check_Backgound_Of_Target_Box_When_Drop_NotAcceptableBox_Box()
        {
            _homePage.CategoryButton("Interactions").Click();
            _droppablePage.ScrollTo(_droppablePage.DroppableButton);
            _droppablePage.DroppableButton.Click();
            _droppablePage.AcceptButton.Click();

            var backgroundColorInitial = _droppablePage.TargetBox.GetCssValue("background-color");

            Builder
                .ClickAndHold(_droppablePage.NotAcceptableBox)
                .MoveByOffset(250,0)
                .Click()
                .Perform();

            var backgroundColorAfterNotAcceptibleBoxIsDropped = _droppablePage.TargetBox.GetCssValue("background-color");

            
            Assert.AreEqual(backgroundColorInitial, backgroundColorAfterNotAcceptibleBoxIsDropped);

        }

        [Test]
        public void Check_Backgound_Of_Target_Box_When_Drop_AcceptableBox_Box()
        {
            _homePage.CategoryButton("Interactions").Click();
            _droppablePage.ScrollTo(_droppablePage.DroppableButton);
            _droppablePage.DroppableButton.Click();
            _droppablePage.AcceptButton.Click();

            var backgroundColorInitial = _droppablePage.TargetBox.GetCssValue("background-color");

            Builder
                .ClickAndHold(_droppablePage.AcceptableBox)
                .MoveByOffset(250, 0)
                .Click()
                .Perform();

            var backgroundColorAfterNotAcceptibleBoxIsDropped = _droppablePage.TargetBox.GetCssValue("background-color");
            Thread.Sleep(2000);

            Assert.AreNotEqual(backgroundColorInitial, backgroundColorAfterNotAcceptibleBoxIsDropped);

        }





        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
