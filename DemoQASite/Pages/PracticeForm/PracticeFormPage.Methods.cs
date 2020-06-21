using AutoFixture;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DemoQASite.Pages.PracticeForm
{
    public partial class PracticeFormPage:BasePage
    {
        public PracticeFormPage(IWebDriver driver)
           : base(driver)
        {
        }


        public override string URL => "";

    }
}
