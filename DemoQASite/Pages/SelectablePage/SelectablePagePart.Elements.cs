using DemoQASite.Pages.DemoQAPage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQASite.Pages.SelectablePage
{
    public partial class SelectablePagePart: DemoQAPAge
    {
        public List<IWebElement> ListSelectableOptions => Driver.FindElements(By.XPath("//*[@id='verticalListContainer']//*")).ToList();
    }
}
