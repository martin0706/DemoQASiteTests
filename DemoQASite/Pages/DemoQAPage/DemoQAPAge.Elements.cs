using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQASite.Pages.DemoQAPage
{
    public partial class DemoQAPAge : BasePage
    {
        public IWebElement LeftPanel => Driver.FindElement(By.XPath("//*[@class ='left-pannel']"));

        public IWebElement InteractionButton => LeftPanel.FindElement(By.XPath(".//*[normalize-space(text()) = 'Interactions']"));

        public IWebElement SortableButton => LeftPanel.FindElement(By.XPath(".//*[normalize-space(text()) = 'Sortable']"));

        public IWebElement DragableButton => LeftPanel.FindElement(By.XPath(".//*[normalize-space(text()) = 'Dragabble']"));

        public IWebElement DroppableButton => LeftPanel.FindElement(By.XPath(".//*[normalize-space(text()) = 'Droppable']"));

        public IWebElement ResizableButton => LeftPanel.FindElement(By.XPath(".//*[normalize-space(text()) = 'Resizable']"));

        public IWebElement SelectableButton => LeftPanel.FindElement(By.XPath(".//*[normalize-space(text()) = 'Selectable']"));


    }
}