using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class NUnitTest_SearchSites
{
    IWebDriver driver;
   

    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }




 
    [Test]
    public void SearchNakovCom()
    {
        driver.Navigate().GoToUrl("https://nakov.com/");
        driver.Manage().Window.Size = new System.Drawing.Size(1050, 580);
        driver.FindElement(By.CssSelector("#sh > .smoothScroll")).Click();
        driver.FindElement(By.Id("s")).Click();
        driver.FindElement(By.Id("s")).SendKeys("QA");
        driver.FindElement(By.Id("s")).SendKeys(Keys.Enter);
        driver.FindElement(By.CssSelector(".entry-title")).Click();
        Assert.That(driver.FindElement(By.CssSelector(".entry-title")).Text, Is.EqualTo("Search Results for – \"QA\""));
        driver.Close();
    }
    
    [Test]
    public void SearchSoftUni()
    {
        //Arrange
        driver.Navigate().GoToUrl("https://softuni.bg");

        // Act
             // Click on Search Button
        driver.FindElement(By.CssSelector(".header-search-dropdown-link .fa-search")).Click();

        // Type search item and press enter
        var searchBox = driver.FindElement(By.CssSelector("div#search-dropdown  form[method='get']  input#search-input"));
        searchBox.Click();
        searchBox.SendKeys("QA" + Keys.Enter);

        // Assert
        var resultField = driver.FindElement(By.CssSelector(".search-title")).Text;

        var expectedVaue = "Резултати от търсене на “QA”";

        Assert.That(resultField, Is.EqualTo(expectedVaue));
        driver.Close();
    }

    [Test]
    public void SearchGoogleCom()
    {
        
        // Navigate to Google
        driver.Url = "https://google.com";

        driver.FindElement(By.CssSelector("#L2AGLb")).Click();

        // Search for "Selenium"
        var queryInput = driver.FindElement(By.CssSelector("input[name=q]"));
        queryInput.Click();
        queryInput.SendKeys("Selenium");
        queryInput.SendKeys(Keys.Enter);

        // Open the first search result
        var firstLink = driver.FindElements(By.CssSelector(".g a"))[0];
        firstLink.Click();

        // Assert that the site open is "https://www.selenium.dev/" with the correct window title
        
        Assert.AreEqual("https://www.selenium.dev/", driver.Url);
        Assert.AreEqual("Selenium", driver.Title);
    }

}
