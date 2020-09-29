using AnswerDigital.Bas;
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
    class SelectSlider
    {
        public SelectSlider()
        {
            PageFactory.InitElements(BasePage.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//div[@id='left_column']//a[2]")]
        IWebElement Slider { get; set; }
        
        public void MoveSlider()
        {   //slider change the price                   
            Actions move = new Actions(BasePage.driver);
            move.DragAndDropToOffset(Slider, -182, 0).Perform();
            /*price has been changed - but there is defect in website it's loading 
             * the page indefinitely */

        }
    }    
}
