using AutoFixture;
using DemoQASite;
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

namespace LiveDemoSeleniumAdvanced
{
    [TestFixture]
    class Sortable: BaseTest
    {
      
        private HomePage _homePage;
        private SortablePagePart _sortablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Manage().Window.Maximize();
            _homePage = new HomePage(Driver);
            _sortablePage = new SortablePagePart(Driver);
            _homePage.NavigateTo();

        }


        [Test]
        public void Check_Sort_Of_Elements_When_Move_One_Element()
        {
            _homePage.CategoryButton("Interactions").Click();
            _sortablePage.ScrollTo(_sortablePage.SortableButton);
            _sortablePage.SortableButton.Click();

            Builder.
                DragAndDropToOffset(_sortablePage.ListFromSortableElements[0], 0, 100)
                .Perform();

            Assert.AreEqual("Two", _sortablePage.ListFromSortableElements[0]);

        }

        [TestCase (1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(0)]
        [TestCase(4)]
        [TestCase(5)]
        [Test]
        public void Check_Element_If_Revert_When_Drag_and_Drob_Out_Of_Range(int index)
        {
            _sortablePage.SortableButton.Click();

            var locationXBefore = _sortablePage.ListFromSortableElements[index].Location.X;
            var locationYBefore = _sortablePage.ListFromSortableElements[index].Location.Y;


            Builder.
                DragAndDropToOffset(_sortablePage.ListFromSortableElements[index], 100, 0)
                .Perform();

            var locationXAfter = _sortablePage.ListFromSortableElements[index].Location.X;
            var locationYAfter = _sortablePage.ListFromSortableElements[index].Location.Y;

            Assert.AreEqual(locationXBefore, locationXAfter);
            Assert.AreEqual(locationYBefore, locationYAfter);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
