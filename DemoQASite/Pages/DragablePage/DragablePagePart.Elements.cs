using DemoQASite.Pages.DemoQAPage;
using Docker.DotNet.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQASite.Pages.DragablePage
{
    public partial class DragablePagePart: DemoQAPAge
    {

        public IWebElement DragBox => Driver.FindElement(By.Id("dragBox"));

        public IWebElement AxisButton => Driver.FindElement(By.LinkText(@"Axis Restricted"));

        public IWebElement SourseBox => Driver.FindElement(By.Id("restrictedX"));

        public IWebElement TargetBox => Driver.FindElement(By.Id("restrictedY"));

      

    }
}
