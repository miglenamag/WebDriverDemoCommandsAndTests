using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class WebDriverTestsCalculator
{
    
    IWebDriver driver;
    //private string valueFirstNum;
    //private string valueSecondNum;
    //private string valueResultField;


    [OneTimeSetUp]
        public void OpenAndNavigate()
        {
        driver = new ChromeDriver();
        driver.Url = "https://sum-numbers.nakov.repl.co";
        IWebElement firstNum = driver.FindElement(By.Id("number1"));
        IWebElement secondNum = driver.FindElement(By.Id("number2"));
        IWebElement calcBtn = driver.FindElement(By.Id("calcButton"));
        IWebElement resetBtn = driver.FindElement(By.Id("resetButton"));
        IWebElement resultField = driver.FindElement(By.Id("result"));

    }

        [OneTimeTearDown]

        public void Shutdown()
        {   
        driver.Quit();
        }

        // [Test]
        public void TestAddTwoNumbers_Valid()
       
        {
        //Arrange
        IWebElement firstNum = driver.FindElement(By.Id("number1"));
        IWebElement secondNum = driver.FindElement(By.Id("number2"));
        IWebElement calcBtn = driver.FindElement(By.Id("calcButton"));
        IWebElement resetBtn = driver.FindElement(By.Id("resetButton"));
        IWebElement resultField = driver.FindElement(By.Id("result"));

        // Act
        resetBtn.Click();
        firstNum.SendKeys("5");
        secondNum.SendKeys("6");
        calcBtn.Click();

        string expectedResult = "Sum: 11";

        //Assert
        Assert.That(expectedResult, Is.EqualTo(resultField.Text));

        }

    [Test]
    public void TestAddTwoNumbers_InValidInput()

    {
        //Arrange
        IWebElement firstNum = driver.FindElement(By.Id("number1"));
        IWebElement secondNum = driver.FindElement(By.Id("number2"));
        IWebElement calcBtn = driver.FindElement(By.Id("calcButton"));
        IWebElement resetBtn = driver.FindElement(By.Id("resetButton"));
        IWebElement resultField = driver.FindElement(By.Id("result"));

        // Act
        resetBtn.Click();
        firstNum.SendKeys("Hello");
        secondNum.SendKeys("");
        calcBtn.Click();

        string expectedResult = "Sum: invalid input";

        //Assert
        Assert.That(expectedResult, Is.EqualTo(resultField.Text));


    }

    [Test]
    public void TestAddTwoNumbers_Reset()

    {
        //Arrange
        IWebElement firstNum = driver.FindElement(By.Id("number1"));
        IWebElement secondNum = driver.FindElement(By.Id("number2"));
        IWebElement calcBtn = driver.FindElement(By.Id("calcButton"));
        IWebElement resetBtn = driver.FindElement(By.Id("resetButton"));
        IWebElement resultField = driver.FindElement(By.Id("result"));


        // Act - filling the form

        firstNum.SendKeys("3");
        secondNum.SendKeys("4");
        calcBtn.Click();
        var valueFirstNum = firstNum.GetAttribute("value");
        var valueSecondNum = secondNum.GetAttribute("value");
        var valueResultField = resultField.Text;


        //Assert - fields are non-empty
        // Assert.That("", Is.Not.EqualTo(firstNum.GetAttribute("value")));
        // Assert.That("", Is.Not.EqualTo(secondNum.GetAttribute("value")));
        //  Assert.That("", Is.Not.EqualTo(resultField.GetAttribute("value")));


        Assert.IsNotEmpty(valueFirstNum);


        Assert.IsNotEmpty(valueSecondNum);


        Assert.IsNotEmpty(valueResultField);


        // Act - reset the form
        resetBtn.Click();
        valueFirstNum = firstNum.GetAttribute("value");
        valueSecondNum = secondNum.GetAttribute("value");
        valueResultField = resultField.Text;

        // Assert - all fields are empty
        Assert.IsEmpty(valueFirstNum);
        Assert.IsEmpty(valueSecondNum);
        Assert.IsEmpty(valueResultField);

    }    
        
        // Test valid integer
        [TestCase("5", "6", "Sum: 11")]
        [TestCase("7", "9", "Sum: 16")]

        // Test valid decimal
        [TestCase("5.5", "6.2", "Sum: 11.7")]
        [TestCase("5.9", "6.4", "Sum: 12.3")]

        // Test invalid input
         [TestCase("", "6.1", "Sum: invalid input")]
         [TestCase("hi", "6.4", "Sum: invalid input")]

    public void TestCalculatorWeb(string num1, string num2, string res)

        {
            //Arrange
            IWebElement firstNum = driver.FindElement(By.Id("number1"));
            IWebElement secondNum = driver.FindElement(By.Id("number2"));
            IWebElement calcBtn = driver.FindElement(By.Id("calcButton"));
            IWebElement resetBtn = driver.FindElement(By.Id("resetButton"));
            IWebElement resultField = driver.FindElement(By.Id("result"));

            // Act
            resetBtn.Click();
            firstNum.SendKeys(num1);
            secondNum.SendKeys(num2);
            calcBtn.Click();

            string expectedResult = res;

            //Assert
            Assert.That(expectedResult, Is.EqualTo(resultField.Text));

        }


    
}
