using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V100.SystemInfo;

namespace GitHubTests
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_AssertMainPageTitle()
        {
            // Arrange
            // ChromeDriver instance
            var driver = new ChromeDriver();

            // Navigate to
            driver.Url = "https://github.com/";
            driver.Manage().Window.Maximize();

            // Act
            var expectedTitle = "GitHub: Where the world builds software · GitHub";

            // Assert
            Assert.That(driver.Title, Is.EqualTo(expectedTitle));

            driver.Quit();

        }

        

        [Test]
        public void AssertTeamTitle()
        {
            // Arrange
            // ChromeDriver instance
            var driver = new ChromeDriver();

            // Navigate to
            driver.Url = "https://github.com/";
            //Maximize browser window
            driver.Manage().Window.Maximize();

            // Act
            
            var teamElement = driver.FindElement(By.CssSelector("li:nth-of-type(2) > .HeaderMenu-link.d-block.d-lg-inline-block.no-underline.py-3"));            // Assert
            teamElement.Click();
            string expectedTitle = "GitHub for teams · Build like the best teams on the planet · GitHub";
            Assert.That(driver.Title, Is.EqualTo(expectedTitle));

            driver.Quit();

        }


    }
}