﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQASite.Pages.HomePage
{
    public partial class HomePage:BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {

        }

        public override string URL => "http://www.demoqa.com/";
    }
}
