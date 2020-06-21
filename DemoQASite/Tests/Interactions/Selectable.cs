

using DemoQASite.Pages.HomePage;
using DemoQASite.Pages.SelectablePage;
using DemoQASite.Tests;
using NUnit.Framework;
using System;
using System.Threading;

namespace LiveDemoSeleniumAdvanced
{
    [TestFixture]
    class Selectable:BaseTest
    {
        private HomePage _homePage;
        private SelectablePagePart _selectablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Manage().Window.Maximize();
            _homePage = new HomePage(Driver);
            _selectablePage = new SelectablePagePart(Driver);
            _homePage.NavigateTo();


        }

    

        [Test]
        public void Check_BackGround_Color_Wnen_Select_Element()
        {

            _homePage.CategoryButton("Interactions").Click();
            _selectablePage.ScrollTo(_selectablePage.SelectableButton);
            _selectablePage.SelectableButton.Click();

            var elementBackGroundBefore = _selectablePage.ListSelectableOptions[1].GetCssValue("background-color");

            _selectablePage.ListSelectableOptions[1].Click();
            Thread.Sleep(1000);

            var elementBackGroundAfter = _selectablePage.ListSelectableOptions[1].GetCssValue("background-color");

            Assert.AreNotEqual(elementBackGroundBefore, elementBackGroundAfter);

        }

       



        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

    }
}
