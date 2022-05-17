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
        Driver.Url = "https://softuni.bg";
            string expectedTitle = "Обучение по програмиране - Софтуерен университет";
            Assert.AreEqual()

            driver.FindElement()

        }
    }
}