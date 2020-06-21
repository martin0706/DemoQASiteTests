using DemoQASite.Pages.DemoQAPage;
using OpenQA.Selenium;
using OpenQA.Selenium.Html5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQASite.Pages.SortablePage
{
    public partial class SortablePagePart : DemoQAPAge
    {
        public List<IWebElement> ListFromSortableElements => Driver.FindElements(By.XPath("//*[@class='vertical-list-container mt-4']//div")).ToList();


    }
}
