


using DemoQASite;
using DemoQASite.Pages.HomePage;
using DemoQASite.Pages.ResizablePage;
using DemoQASite.Tests;
using NUnit.Framework;

namespace LiveDemoSeleniumAdvanced
{
    [TestFixture]
    class Resizable:BaseTest
    {
        private HomePage _homePage;
        private ResizablePagePart _resizablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Manage().Window.Maximize();
            _homePage = new HomePage(Driver);
            _resizablePage = new ResizablePagePart(Driver);
            _homePage.NavigateTo();


        }

        [Test]
        public void Check_Text_When_Resize_Element()
        {
            _homePage.CategoryButton("Interactions").Click();
            _resizablePage.ScrollTo(_resizablePage.ResizableButton);
            _resizablePage.ResizableButton.Click();

            string textBeforeResize = _resizablePage.ResizableBoxTxt.Text;

            Driver.ScrollTo(_resizablePage.ResizableBox);
            Builder.
                DragAndDropToOffset(_resizablePage.ResizableBox, 200, 200).
                Perform();

            string textAfterResize = _resizablePage.ResizableBoxTxt.Text;
            Assert.AreEqual(textBeforeResize, textAfterResize);

        }

        [Test]
        public void Check_if_Margin_Is_Kept_Of_The_Text_Botton_When_Resize_Element()
        {

            _homePage.CategoryButton("Interactions").Click();
            _resizablePage.ScrollTo(_resizablePage.ResizableButton);
            _resizablePage.ResizableButton.Click();


            var locationXOfBoxBefore = _resizablePage.ResizableBoxSecond.Location.X;
            var locationYOfBoxBefore = _resizablePage.ResizableBoxSecond.Location.Y;

            var locationXOfTextElementBottonBefore = _resizablePage.TexBoxtElementBotton.Location.X;
            var locationYOfTextElementBottonBefore = _resizablePage.TexBoxtElementBotton.Location.Y;

            Driver.ScrollTo(_resizablePage.ResizableBoxSecond);
            Builder.
                DragAndDropToOffset(_resizablePage.ResizableBoxSecond, 200, 200).
                Perform();

            var locationXOfBoxAfter = _resizablePage.ResizableBoxSecond.Location.X;
            var locationYOfBoxAfter = _resizablePage.ResizableBoxSecond.Location.Y;

            var locationXOfTextElementBottonAfter = _resizablePage.TexBoxtElementBotton.Location.X;
            var locationYOfTextElementBottonAfter = _resizablePage.TexBoxtElementBotton.Location.Y;

            Assert.AreEqual(locationYOfTextElementBottonBefore - locationYOfBoxBefore, locationYOfTextElementBottonAfter - locationYOfBoxAfter, 3);


        }
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

    } 
}
