using AnswerDigital.Bas;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerDigital.PageObject
{
    [TestFixture]
    class TakeScreenshot
    {
        public TakeScreenshot()
        {
            PageFactory.InitElements(BasePage.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Our stores')]")]
        IWebElement OurStoresLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='dismissButton']")]
        IWebElement GoogleDismissButton { get; set; }

        [FindsBy(How = How.XPath, Using = " //div[@class='gm-style']")]
        IWebElement SourceElement { get; set; }
        //div[@class='gm-style']

        public void OurStoreLink()
        {
            //click on our stores link 
            OurStoresLink.Click();

            // Click on OK button of Google message 
            GoogleDismissButton.Click();
        }
           
        public void Screenshot()
        {
            // Taking screenshot of Map page
            Screenshot screen = BasePage.driver.TakeScreenshot();
            screen.SaveAsFile("Screen4.jpeg", ScreenshotImageFormat.Jpeg);
        
         // location of screenshot 
         //   C:\Users\Nadeem\AppData\Local\Temp\Screen4.jpeg 
        }
        

        //public void ScrollThroughMap()
        //{
        //    SourceElement.Click();
        //    for (int i = 0; i < 5; i++)
        //    {
        //        IWebElement ele = BasePage.driver.FindElement(By.XPath("//div[@class='gm-style']//iframe"));
        //        ele.Click();
        //        IWebElement element = BasePage.driver.FindElement(By.XPath("//div[@class='gm-style']"));
        //        element.SendKeys(Keys.Control);
        //        element.SendKeys(Keys.Add);
        //    }

         //Actions action = new Actions(BasePage.driver);
        //action.DoubleClick(SourceElement);

        //  Actions action = new Actions(BasePage.driver);
        //  action.ClickAndHold();
        //  action.DragAndDropToOffset(SourceElement, 800, 300)
        //.Release()

        //  .Perform();
    }
}

//frame
//div[@class='gm-style']//iframe  