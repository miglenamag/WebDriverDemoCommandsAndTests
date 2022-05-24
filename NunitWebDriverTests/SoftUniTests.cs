using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NunitWebDriverTests
{
    public class SoftUniTests
    {
        private WebDriver driver;

        [OneTimeSetUp]
        public void OpenBrowserAndNavigate()
        {
            // Arrange
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://softuni.bg";
            
        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            driver.Quit();

        }


        [Test]
        public void Test_AssertMainTitle()
        {

            // Arrange
            // var driver = new ChromeDriver();


            //Act
            driver.Url = "https://softuni.bg";
            string expectedTitle = "Обучение по програмиране - Софтуерен университет";

            //Assert
            Assert.That(driver.Title, Is.EqualTo(expectedTitle));


            //driver.Quit();

        }

        [Test]
        public void Test_AssertAboutUsTitle()
        {

            // Arrange
            //var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            

            //Act
           //driver.Url = "https://softuni.bg";
           
            var zaNasElement = driver.FindElement(By.CssSelector("li:nth-of-type(1) > .nav-link > .cell"));
            zaNasElement.Click();

            string expectedTitle = "За нас - Софтуерен университет";

            //Assert
            Assert.That(driver.Title, Is.EqualTo(expectedTitle));


            //driver.Quit();

        }
    }
}