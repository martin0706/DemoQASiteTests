using AutoFixture;
using DemoQASite.Pages;
using DemoQASite.Pages.DragablePage;
using DemoQASite.Pages.HomePage;
using DemoQASite.Pages.SortablePage;
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

namespace DemoQASite.Tests
{
    [TestFixture]
    class DraggableTests : BaseTest
    {
        private HomePage _homePage;
        private DragablePagePart _daragablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Manage().Window.Maximize();
            _homePage = new HomePage(Driver);
            _daragablePage = new DragablePagePart(Driver);
            _homePage.NavigateTo();
        }


        [Test]
        public void Check_Location_When_Move_Element()
        {
            _homePage.CategoryButton("Interactions").Click();
            _daragablePage.ScrollTo(_daragablePage.DragableButton);
            _daragablePage.DragableButton.Click();

            var boxPossitionXBefore = _daragablePage.DragBox.Location.X;
            var boxPossitionYBefore = _daragablePage.DragBox.Location.Y;

            Builder
                .MoveToElement(_daragablePage.DragBox)
                .ClickAndHold()
                .MoveByOffset(300, 100)
                .Perform();


            var boxPossitionXAfter = _daragablePage.DragBox.Location.X;
            var boxPossitionYAfter = _daragablePage.DragBox.Location.Y;

            Assert.AreEqual(boxPossitionXBefore + 300, boxPossitionXAfter, 3);
            Assert.AreEqual(boxPossitionYBefore + 100, boxPossitionYAfter, 3);

        }

        [Test]

        public void Check_Location_is_Equal_When_Try_To_Move_Element_on_Another_One()
        {

            _homePage.CategoryButton("Interactions").Click();
            _daragablePage.ScrollTo(_daragablePage.DragableButton);
            _daragablePage.DragableButton.Click();
            _daragablePage.AxisButton.Click();


  
            Builder
                .DragAndDrop(_daragablePage.SourseBox, _daragablePage.TargetBox)
                .Perform();

            Assert.AreEqual(_daragablePage.SourseBox.Location.X, _daragablePage.TargetBox.Location.X, 1);
            Assert.AreEqual(_daragablePage.SourseBox.Location.Y, _daragablePage.TargetBox.Location.Y, 1);

        }

        [Test]
        public void Check_Location_When_Move_Element_Top_Left_Angle_On_Screen()
        {

            _homePage.CategoryButton("Interactions").Click();
            _daragablePage.ScrollTo(_daragablePage.DragableButton);
            _daragablePage.DragableButton.Click();

            var boxPossitionXBefore = _daragablePage.DragBox.Location.X;
            var boxPossitionYBefore = _daragablePage.DragBox.Location.Y;

            Builder
                .MoveToElement(_daragablePage.DragBox)
                .DragAndDropToOffset(_daragablePage.DragBox, -1 * boxPossitionXBefore, -1 * boxPossitionYBefore)
                .Perform();


            var boxPossitionXAfter = _daragablePage.DragBox.Location.X;
            var boxPossitionYAfter = _daragablePage.DragBox.Location.Y;

            Assert.AreEqual(0, boxPossitionXAfter, 3);
            Assert.AreEqual(0, boxPossitionYAfter, 3);

        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

    }
}
