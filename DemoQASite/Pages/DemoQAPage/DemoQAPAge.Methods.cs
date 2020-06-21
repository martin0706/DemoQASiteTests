using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQASite.Pages.DemoQAPage
{
    public partial class DemoQAPAge:BasePage
    {
        public DemoQAPAge(IWebDriver driver):base(driver)
        {

        }

        public override string URL => throw new NotImplementedException();      
    }
}
