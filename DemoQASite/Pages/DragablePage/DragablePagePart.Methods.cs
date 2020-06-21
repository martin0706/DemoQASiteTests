using DemoQASite.Pages.DemoQAPage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQASite.Pages.DragablePage
{
    public partial class DragablePagePart : DemoQAPAge
    {
        public DragablePagePart(IWebDriver driver):base(driver)
        {

        }

        public override string URL => "http://www.demoqa.com/dragabble";
    }
}
