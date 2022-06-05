using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
// Create New Chrome Browser Instance
var driver = new ChromeDriver();

// Navigate to GitHub
// driver.Url = "https://github.com/";
driver.Navigate().GoToUrl("https://github.com/");

//Print main page title
//Console.WriteLine($" The main page title is {driver.Title}");
Console.WriteLine("MAIN PAGE TITLE: " + driver.Title);
Console.WriteLine();

// Locate Search field by XPath
var searchField = driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[2]/div[2]/div[1]/div/div/form/label/input[1]")
    );


// Click on element
searchField.Click();

//Type search item and press enter 
//searchField.SendKeys("WebDriverTestsDemo" + Keys.Enter);
searchField.SendKeys("WebDriverTestsDemo");
searchField.SendKeys(Keys.Enter);
Console.Write($"Page title after search: {driver.Title}");
Console.WriteLine();


// Close browser
driver.Quit();

