using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SampleWebFlow
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://yopmail.com/en/");
        }

        [Test]
        public void Test1()
        {
           // IWebElement Enterusername = WebDriver.FindElement(By.XPath("//input[@id='login']"));
           // Enterusername.SendKeys("Ron");
            

            Assert.Pass();
        }
    }
}
