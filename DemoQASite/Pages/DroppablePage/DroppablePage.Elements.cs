using DemoQASite.Pages.DemoQAPage;
using Docker.DotNet.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQASite.Pages.DroppablePage
{
    public partial class DroppablePage: DemoQAPAge
    {
        public IWebElement AcceptButton => Driver.FindElement(By.LinkText(@"Accept"));

        public IWebElement AcceptableBox => Driver.FindElement(By.Id("acceptable"));

        public IWebElement NotAcceptableBox => Driver.FindElement(By.Id("notAcceptable"));

        public IWebElement TargetBox => Driver.FindElement(By.Id("droppable"));
        

    }
}
