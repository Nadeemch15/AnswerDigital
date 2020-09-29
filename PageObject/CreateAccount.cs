using AnswerDigital.Bas;
using NUnit.Framework;
using OpenQA.Selenium;
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
    public class CreateAccount
    {
        public CreateAccount()
        {
            PageFactory.InitElements(BasePage.driver, this);
        }
        
        #region WebElement

        [FindsBy(How = How.ClassName, Using = "login")]
        public IWebElement SignInBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='email_create']")]
        public IWebElement EmailAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@id='create-account_form']//span[1]")]
        public IWebElement CreateAcccontBtn { get; set; }

        //SignInuser User
        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='submit']//span[1]")]
        public IWebElement SignInButtonRegsterUser { get; set; }


        //Registration page
        [FindsBy(How = How.Id, Using = "id_gender2")]
        public IWebElement Gender { get; set; }

        [FindsBy(How = How.Id, Using = "customer_firstname")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "customer_lastname")]
        public IWebElement LastName { get; set; }

        //[FindsBy(How = How.Id, Using = "passwd")]
        //public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "days")]
        public IWebElement Day { get; set; }

        [FindsBy(How = How.Id, Using = "months")]
        public IWebElement Month { get; set; }

        [FindsBy(How = How.Id, Using = "years")]
        public IWebElement Year { get; set; }

        [FindsBy(How = How.Id, Using = "optin")]
        public IWebElement CheckedSpecialOffer { get; set; }

        //Your Address

        [FindsBy(How = How.Id, Using = "firstname")]
        public IWebElement AddressFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "lastname")]
        public IWebElement AddressLastName { get; set; }

        [FindsBy(How = How.Id, Using = "company")]
        public IWebElement Company { get; set; }

        [FindsBy(How = How.Id, Using = "address1")]
        public IWebElement Address1 { get; set; }

        [FindsBy(How = How.Id, Using = "address2")]
        public IWebElement Address2 { get; set; }

        [FindsBy(How = How.Id, Using = "city")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.Id, Using = "id_state")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.Id, Using = "postcode")]
        public IWebElement PostCode { get; set; }

        [FindsBy(How = How.Id, Using = "other")]
        public IWebElement AdditionalInfo { get; set; }

        [FindsBy(How = How.Id, Using = "phone_mobile")]
        public IWebElement MobileNo { get; set; }

        [FindsBy(How = How.Id, Using = "alias")]
        public IWebElement AddressFutureRef { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Register')]")]
        public IWebElement ClickRegisterUser { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='logout']")]
        public IWebElement SignOut { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Nadeem')]")]
        public IWebElement VerifyUser { get; set; }

        [FindsBy(How = How.ClassName, Using = "page-heading")]
        public IWebElement Pageheading { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='alert alert-danger']")]
        public IWebElement CreatAnAccoutError { get; set; }
        #endregion

        public void EnterUserDetail()
        {            
            SignInBtn.Click();
            EmailAddress.SendKeys("Answ002@email.com");
            BasePage.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            CreateAcccontBtn.Click();

            // AC 4.1 create user account
            Gender.Click();
            FirstName.SendKeys("Nadeem");
            LastName.SendKeys("Digital");
            Password.SendKeys("123qwe");

            SelectElement DropDay = new SelectElement(Day);
            DropDay.SelectByValue("10");
            SelectElement DropMonth = new SelectElement(Month);
            DropMonth.SelectByValue("9");
            SelectElement DropYear = new SelectElement(Year);
            DropYear.SelectByValue("2020");

            CheckedSpecialOffer.Click();
            AddressFirstName.SendKeys("Nadeem");
            AddressLastName.SendKeys("Digital");
            Company.SendKeys("Test Digital Company");
            Address1.SendKeys("Leeds Town");
            Address2.SendKeys("LS1");
            City.SendKeys("Leeds");

            SelectElement DropDown = new SelectElement(State);
            DropDown.SelectByText("Florida");            

            PostCode.SendKeys("00012");
            AdditionalInfo.SendKeys("This is first programme of testig");
            MobileNo.SendKeys("123456789");
            AddressFutureRef.SendKeys("NB_Test");
            ClickRegisterUser.Click();

            //AC 4.4 verify account namme
            Assert.AreEqual("Nadeem Digital", VerifyUser.Text);
            Console.WriteLine(VerifyUser.Text+ " Displayed");

            Thread.Sleep(1000);

            //AC 4.3 verify user taken to MY ACCOUNT page
            Assert.IsTrue(Pageheading.Displayed);
            Console.WriteLine(Pageheading.Text + " Displayed");

            SignOut.Click();
        }
        
        public void EnterInvalidDetail()
        {
            SignInBtn.Click();          
           
                EmailAddress.SendKeys("Ans3@email.com");
                BasePage.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                CreateAcccontBtn.Click();
                Gender.Click();

            // first name and last name not entered to get the error
                FirstName.SendKeys("");
                LastName.SendKeys("");
                Password.SendKeys("123qwe");

                SelectElement DropDay = new SelectElement(Day);
                DropDay.SelectByValue("10");
                SelectElement DropMonth = new SelectElement(Month);
                DropMonth.SelectByValue("9");
                SelectElement DropYear = new SelectElement(Year);
                DropYear.SelectByValue("2020");

                CheckedSpecialOffer.Click();
                AddressFirstName.SendKeys("Nadeem");
                AddressLastName.SendKeys("Digital");
                Company.SendKeys("Test Digital Company");
                Address1.SendKeys("Leeds Town");
                Address2.SendKeys("LS1");
                City.SendKeys("Leeds");

                SelectElement DropDown = new SelectElement(State);
                DropDown.SelectByText("Florida");

                PostCode.SendKeys("00012");
                AdditionalInfo.SendKeys("This is first programme of testig");
                MobileNo.SendKeys("123456789");
                AddressFutureRef.SendKeys("NB_Test");
                ClickRegisterUser.Click();

            //AC 4.2 verify the error message 
            Assert.IsTrue(CreatAnAccoutError.Displayed);
            Console.WriteLine(CreatAnAccoutError.Text + " Displayed");
        }
    }
}
