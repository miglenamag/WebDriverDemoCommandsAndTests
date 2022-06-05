using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V100.SystemInfo;


    public class GitHubTests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            //var options = new ChromeOptions();
            //options.AddArguments("--headless", "--window-size=1920,1200");
            driver.Url = "https://github.com/";
            driver.Manage().Window.Maximize();
    }


    [TearDown]
        public void ShutDown()
        {
        driver.Quit();
        }

        [Test]
        public void Test_AssertMainPageTitle()
        {
            // Arrange
            // ChromeDriver instance
            //var driver = new ChromeDriver();

            // Navigate to
            //driver.Url = "https://github.com/";
            //driver.Manage().Window.Maximize();

            // Act
            var expectedTitle = "GitHub: Where the world builds software · GitHub";

            // Assert
            Assert.That(driver.Title, Is.EqualTo(expectedTitle));

            //driver.Quit();

        }

        

        [Test]
        public void AssertTeamTitle()
        {
            // Arrange
            // ChromeDriver instance
            //var driver = new ChromeDriver();

            // Navigate to
            //driver.Url = "https://github.com/";
            //Maximize browser window
            //driver.Manage().Window.Maximize();

            // Act
            
            var teamElement = driver.FindElement(By.CssSelector("li:nth-of-type(2) > .HeaderMenu-link.d-block.d-lg-inline-block.no-underline.py-3"));            // Assert
            teamElement.Click();
            string expectedTitle = "GitHub for teams · Build like the best teams on the planet · GitHub";
            Assert.That(driver.Title, Is.EqualTo(expectedTitle));
           

        //driver.Quit();

        }

        [Test]
        public void Test_Search_GitHub()
        {


        // Act
        var searchField = driver.FindElement(By.XPath("//form/label/input[1]"));
        searchField.Click();
        searchField.SendKeys("WebDriverTestsDemo");
        searchField.SendKeys(Keys.Enter);
        

        // Assert
        Assert.That(driver.Title, Is.EqualTo("Search · WebDriverTestsDemo · GitHub"));

        //driver.Quit();

        }

}
