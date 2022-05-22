using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NunitWebDriverTests
{
    public class SoftUniTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_AssertMainTitle()
        {

            // Arrange
            var driver = new ChromeDriver();


            //Act
            driver.Url = "https://softuni.bg";
            string expectedTitle = "Обучение по програмиране - Софтуерен университет";

            //Assert
            Assert.That(driver.Title, Is.EqualTo(expectedTitle));


            driver.Quit();

        }
        public void Test_AssertAboutUsTitle()
        {

            // Arrange
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();


            //Act
            driver.Url = "https://softuni.bg";
            var ZaNasElement = driver.FindElement(By.CssSelector("header-nav > div.toggle-nav.toggle-holder.toggle-active > ul > li:nth-child(1) > a > span"));
            string expectedTitle = "За нас - Софтуерен университет";

            //Assert
            Assert.That(driver.Title, Is.EqualTo(expectedTitle));


            driver.Quit();

        }
    }
}