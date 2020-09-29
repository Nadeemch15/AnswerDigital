using AnswerDigital.Bas;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerDigital.PageObject
{
    class SelectSummerDresses
    {
        public SelectSummerDresses()
        {
            PageFactory.InitElements(BasePage.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@class='sf-with-ul'][contains(text(),'Women')]")]
        public IWebElement WomenTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@class='sfHover']//a[contains(text(),'Summer Dresses')]")]
        public IWebElement ClickSummerdress { get; set; }

        [FindsBy(How = How.ClassName, Using = "cat-name")]
        public IWebElement SummerDressTitle { get; set; }

        public void SummerDresses()
        {
            // Mouse-hover button 'WOMEN'
            Actions action = new Actions(BasePage.driver);           
            action.MoveToElement(WomenTab).Perform();
            ClickSummerdress.Click();
           
            // only Summer dresses displayed 
            Assert.AreEqual(SummerDressTitle.Text, "SUMMER DRESSES ");
            Console.WriteLine(SummerDressTitle.Text + " are displayed");
        }       
    }
}
