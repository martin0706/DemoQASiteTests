using DemoQASite.Pages.DemoQAPage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQASite.Pages.ResizablePage
{
    public partial class ResizablePagePart: DemoQAPAge
    {
        public IWebElement ResizableBox => Driver.FindElement(By.XPath("//*[@id='resizableBoxWithRestriction']//span"));

        public IWebElement ResizableBoxTxt => Driver.FindElement(By.XPath("//*[@id='resizableBoxWithRestriction']//div"));

        public IWebElement TexBoxtElementBotton => Driver.FindElement(By.XPath("//*[@id='resizable']//span"));

        public IWebElement ResizableBoxSecond => Driver.FindElement(By.XPath("//*[@id='resizable']//span"));
    }
}
