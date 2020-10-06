using AnswerDigital.Bas;
using AnswerDigital.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace AnswerDigital.TestScript
{
    [TestFixture]
    public class Test_CreateAccount
    {
        BasePage bpage = new BasePage();

        [SetUp]
        public void Web_Initialise()
        {            
            bpage.Web_Init();
        }
        [TearDown]
        public void Close()
        {
            bpage.Close();
        }
        [Test]
        public void CreatAccount_Test()
        {
            CreateAccount Ca = new CreateAccount();

            //enter user detials
            Ca.EnterUserDetail();
           // Incomelet user detial for error message

           Ca.EnterInvalidDetail();

        }
        [Test]
        public void SelectSummerDress()
        {
            SelectSummerDresses SSD = new SelectSummerDresses();

            // summer dress method
            SSD.SummerDresses();
           

        }
        [Test]
        public void OurStoreSearch()
        {                                 
            TakeScreenshot ts = new TakeScreenshot();
            
            // our stores link
            ts.OurStoreLink();
            
            //ts.ScrollThroughMap();

            // taking screeshot
            ts.Screenshot();              
        }
        [Test]
        public void DeletItem()
        {
            SelectSummerDresses SSD = new SelectSummerDresses();
            
            //click summer dress option
            SSD.SummerDresses();
            Add_DeleteItem Item = new Add_DeleteItem();
            
            //Select dress
            Item.SelectDress();
            
            // implicit wait
            bpage.Imp_wait();

            // add item
            Item.AddItem();

            // delete item
            Item.DeleteItem();
        }
        [Test]
        public void SeletSlider()
        {
            SelectSummerDresses SSD = new SelectSummerDresses();
            SelectSlider SS = new SelectSlider();
            SSD.SummerDresses();
            SS.MoveSlider();
            
        }
    }
}
