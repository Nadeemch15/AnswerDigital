using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerDigital.Bas
{
  public class BasePage
    {
        public static IWebDriver driver { get; set; }
        public void Web_Init()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.Manage().Window.Maximize();
        }

        public void Imp_wait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        public void Close()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
