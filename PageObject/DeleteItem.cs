using AnswerDigital.Bas;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AnswerDigital.PageObject
{
    class Add_DeleteItem :BasePage
    {
        public Add_DeleteItem()
        {
            PageFactory.InitElements(BasePage.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Add to cart')]")]
        IWebElement AddtoCartBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Proceed to checkout')]")]
        IWebElement ProceedtoCheckout { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[@class='icon-trash']")]
        IWebElement DeleteIcon { get; set; }

        [FindsBy(How = How.XPath, Using = " //h1[@id='cart_title']")]
        IWebElement CartTitle { get; set; }


        [FindsBy(How = How.XPath, Using = "//p[@class='alert alert-warning']")]
        IWebElement WarningBanner { get; set; }

        public void AddItem()
        {
            AddtoCartBtn.Click();
           
            ProceedtoCheckout.Click();
        }

        public void DeleteItem()
        {
            // AC 1.1 - Delete Icon
            Boolean ImagePresent = DeleteIcon.Displayed;
            Assert.IsTrue(ImagePresent, "No Image exist");
            Console.WriteLine(DeleteIcon.Text + " Delete Button exist");
            
            //AC 1.2 Item removed from cart
            DeleteIcon.Click();

            BasePage.driver.Navigate().Refresh();

            //Shopping cart summary (title)
            Assert.AreEqual(CartTitle.Text, "SHOPPING-CART SUMMARY");
            Console.WriteLine(CartTitle.Text + " title is displayed");
            
            // AC 1.3  Warning banner displayed
            Assert.AreEqual(WarningBanner.Text, "Your shopping cart is empty.");
            Console.WriteLine(WarningBanner.Text + " banner is displayed");
        }
        public void SelectDress()
        {
            WebDriverWait wait = new WebDriverWait(BasePage.driver, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("right-block")));
            Actions action = new Actions(BasePage.driver);
            action.MoveToElement(element).Perform();
        }
    }
}

