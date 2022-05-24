using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// Create new Chrome browser instance
var driver = new ChromeDriver();

// Navigate to wikipedia
driver.Url = "https://wikipedia.org";

// Locate search by Id
var searchField = driver.FindElement(By.Id("searchInput"));

// Click on element
searchField.Click();

// Fill QA and press Enter button
searchField.SendKeys("QA" + Keys.Enter);

System.Console.WriteLine("Title after search: " + driver.Title);

//Close browser
driver.Quit();
