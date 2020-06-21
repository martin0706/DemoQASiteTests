using DemoQASite.Pages.DemoQAPage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQASite.Pages.SortablePage
{
    public partial class SortablePagePart: DemoQAPAge
    {
        public SortablePagePart(IWebDriver driver):base(driver)
        {

        }

        public override string URL => "http://www.demoqa.com/sortable";     
    }
}
