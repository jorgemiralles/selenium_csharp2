using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Microsoft.Extensions.Options;

namespace MVCSelenium.Tests
{
    public class UITests
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("--headless");
            //option.AddArguments("--remote-debugging-port=35449");
            driver = new ChromeDriver(option);

        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("http://localhost/");
            Assert.That(driver.FindElement(By.CssSelector(".display-4")).Text, Is.EqualTo("Welcome"));
            driver.Close();
        }
    }
}
