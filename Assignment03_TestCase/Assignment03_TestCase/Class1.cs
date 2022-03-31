//Divyesh Siddhapura



// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class DefaultSuiteTest
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;
    private String baseUrl;
    [SetUp]
    public void SetUp()
    {
        ChromeOptions option = new ChromeOptions();
        option.AcceptInsecureCertificates = true;
        driver = new ChromeDriver(option);
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
        
    }
    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }
    [Test]
    public void sellYourVehicle_AllValidInput_2020HondaCivic()
    {

        driver.Navigate().GoToUrl("https://localhost/Assignment03/");
        driver.Manage().Window.Size = new System.Drawing.Size(741, 824);
        driver.FindElement(By.CssSelector(".button")).Click();     
        driver.FindElement(By.Id("firstname")).SendKeys("DIVYESHKUMAR");
        driver.FindElement(By.Id("lastname")).SendKeys("SIDDHAPURA");
        driver.FindElement(By.Id("email")).SendKeys("divyeshsiddhapura19@gmail.com");   
        driver.FindElement(By.Id("address")).SendKeys("966,Main Street East");
        driver.FindElement(By.Id("city")).SendKeys("Hamilton");
        driver.FindElement(By.Id("provience")).Click();
        {
            var dropdown = driver.FindElement(By.Id("provience"));
            dropdown.FindElement(By.XPath("//option[. = 'ON']")).Click();
        }
       
        driver.FindElement(By.Id("postalcode")).SendKeys("L8M 1M8");
        driver.FindElement(By.Id("phonenumber")).SendKeys("905-336-1610");
        driver.FindElement(By.Id("make")).SendKeys("honda");
        driver.FindElement(By.Id("modelName")).SendKeys("civic");
        driver.FindElement(By.Id("year")).SendKeys("2020");
        driver.FindElement(By.Id("submit")).Click();
        driver.FindElement(By.Id("url")).Click();
        driver.FindElement(By.CssSelector("html")).Click();
        Assert.That(driver.FindElement(By.CssSelector(".heading-xxl")).Text, Is.EqualTo("2020 Honda Civic"));
    }
    [Test]
    public void sellYourVehicle_InvalidFormatForLastName_ErrorShowingForLastNameInput()
    {
        //Arrange
        baseUrl = "https://localhost/Assignment03/";

        //Act
        driver.Navigate().GoToUrl(baseUrl);
        driver.Manage().Window.Size = new System.Drawing.Size(730, 824);
        driver.FindElement(By.CssSelector(".button")).Click();
        driver.FindElement(By.Id("firstname")).Click();
        driver.FindElement(By.Id("firstname")).SendKeys("DIVYESHKUMAR");
        driver.FindElement(By.Id("lastname")).SendKeys("SIDDHAPURA");

        driver.FindElement(By.Id("phonenumber")).SendKeys("08401233392");
        driver.FindElement(By.Id("email")).SendKeys("divyeshsiddhapura19@gmail.com");
        driver.FindElement(By.CssSelector("html")).Click();
        driver.FindElement(By.Id("lastname")).SendKeys("12");
        driver.FindElement(By.CssSelector(".mb-1:nth-child(1)")).Click();
        driver.FindElement(By.CssSelector("#form1 > .form-group:nth-child(3)")).Click();
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("966,Main Street East");
        driver.FindElement(By.CssSelector(".col-lg-6:nth-child(2)")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Hamilton");
        driver.FindElement(By.Id("provience")).Click();
        {
            var dropdown = driver.FindElement(By.Id("provience"));
            dropdown.FindElement(By.XPath("//option[. = 'QB']")).Click();
        }
        driver.FindElement(By.Id("postalcode")).Click();
        driver.FindElement(By.CssSelector(".row:nth-child(4)")).Click();
        driver.FindElement(By.Id("postalcode")).SendKeys("L8M 1M8");
        driver.FindElement(By.CssSelector("html")).Click();
        driver.FindElement(By.Id("phonenumber")).SendKeys("111-222-3333");
        driver.FindElement(By.Id("make")).Click();
        driver.FindElement(By.Id("make")).SendKeys("honda");
        driver.FindElement(By.CssSelector(".col-lg-6:nth-child(3) form")).Click();
        driver.FindElement(By.Id("modelName")).Click();
        driver.FindElement(By.Id("modelName")).SendKeys("civic");
        driver.FindElement(By.Id("year")).Click();
        driver.FindElement(By.Id("year")).SendKeys("2022");
        driver.FindElement(By.Id("submit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("lastnameValidation")).Text, Is.EqualTo("*String Value Required"));
    }
    [Test]
    public void sellYourVehicle_InvalidFormatPhonenumber_ErrorShowingForPhonenumberFormat()
    {
        //Arrange
        baseUrl = "https://localhost/Assignment03/";

        //Act
        driver.Navigate().GoToUrl(baseUrl);
        driver.Manage().Window.Size = new System.Drawing.Size(736, 824);
        driver.FindElement(By.CssSelector(".button")).Click();
        driver.FindElement(By.Id("firstname")).Click();
        driver.FindElement(By.Id("firstname")).SendKeys("DIVYESHKUMAR");
        driver.FindElement(By.Id("lastname")).SendKeys("SIDDHAPURA");
        driver.FindElement(By.Id("phonenumber")).SendKeys("08401233392");
        driver.FindElement(By.Id("email")).SendKeys("divyeshsiddhapura19@gmail.com");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("966,Main Street East");
        driver.FindElement(By.CssSelector("html")).Click();
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Hamilton");
        driver.FindElement(By.Id("provience")).Click();
        {
            var dropdown = driver.FindElement(By.Id("provience"));
            dropdown.FindElement(By.XPath("//option[. = 'ON']")).Click();
        }
        driver.FindElement(By.CssSelector(".row:nth-child(4)")).Click();
        driver.FindElement(By.Id("postalcode")).SendKeys("L8M 1M8");
        driver.FindElement(By.Id("make")).Click();
        driver.FindElement(By.Id("make")).SendKeys("honda");
        driver.FindElement(By.Id("modelName")).Click();
        driver.FindElement(By.Id("modelName")).SendKeys("civic");
        driver.FindElement(By.Id("year")).Click();
        driver.FindElement(By.Id("year")).SendKeys("2013");
        driver.FindElement(By.Id("submit")).Click();
        driver.FindElement(By.CssSelector(".row > .form-group:nth-child(1)")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("phoneNumberValidation")).Text, Is.EqualTo("*PhoneNumber format Must be in 123-123-1234 or (123)123-1234)"));
    }
    [Test]
    public void sellYourVehicle_InvalidFormatPostalCode_ErrorShowingForPostalCode()
    {
        //Arrange
        baseUrl = "https://localhost/Assignment03/";

        //Act
        driver.Navigate().GoToUrl(baseUrl);
        driver.Manage().Window.Size = new System.Drawing.Size(743, 824);
        driver.FindElement(By.CssSelector(".button")).Click();
        driver.FindElement(By.Id("firstname")).Click();
        driver.FindElement(By.Id("firstname")).SendKeys("Robert");
        driver.FindElement(By.Id("form1")).Click();
        driver.FindElement(By.Id("lastname")).Click();
        driver.FindElement(By.Id("lastname")).SendKeys("Desuza");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("5114 shelterwood dr");
        driver.FindElement(By.Id("city")).SendKeys("Cleveland");
        driver.FindElement(By.Id("postalcode")).SendKeys("37312");
        {
            var element = driver.FindElement(By.Id("city"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).ClickAndHold().Perform();
        }
        {
            var element = driver.FindElement(By.Id("city"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Perform();
        }
        {
            var element = driver.FindElement(By.Id("city"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Release().Perform();
        }
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("provience")).Click();
        {
            var dropdown = driver.FindElement(By.Id("provience"));
            dropdown.FindElement(By.XPath("//option[. = 'QB']")).Click();
        }
        driver.FindElement(By.Id("form1")).Click();
        driver.FindElement(By.Id("postalcode")).Click();
        driver.FindElement(By.Id("postalcode")).SendKeys("L8M1M8");
        driver.FindElement(By.Id("phonenumber")).Click();
        driver.FindElement(By.Id("phonenumber")).SendKeys("336-112-1234");
        driver.FindElement(By.CssSelector(".row > .form-group:nth-child(2)")).Click();
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("robert@gmail.com");
        driver.FindElement(By.Id("make")).Click();
        driver.FindElement(By.Id("make")).SendKeys("toyota");
        driver.FindElement(By.Id("modelName")).SendKeys("camry");
        driver.FindElement(By.Id("year")).SendKeys("2022");
        driver.FindElement(By.Id("submit")).Click();
        driver.FindElement(By.CssSelector(".mb-1:nth-child(3)")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("postalCodeValidation")).Text, Is.EqualTo("*Postal Code Format Must be X1X 1X1"));
    }
    [Test]
    public void sellYourVehicle_OmitAllInputField_ErrorShowingForMissingInputField()
    {

        //Arrange
        baseUrl = "https://localhost/Assignment03/";

        //Act
        driver.Navigate().GoToUrl(baseUrl);
        driver.Manage().Window.Size = new System.Drawing.Size(744, 824);
        driver.FindElement(By.CssSelector(".button")).Click();
        driver.FindElement(By.Id("submit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("firstnameValidation")).Text, Is.EqualTo("*Firstname Required"));
        Assert.That(driver.FindElement(By.Id("lastnameValidation")).Text, Is.EqualTo("*Lastname Required"));
        Assert.That(driver.FindElement(By.Id("addressValidation")).Text, Is.EqualTo("*Address Required"));
        Assert.That(driver.FindElement(By.Id("cityValidation")).Text, Is.EqualTo("*City Required"));
        Assert.That(driver.FindElement(By.Id("provienceValidation")).Text, Is.EqualTo("*provience Required"));
        Assert.That(driver.FindElement(By.Id("postalCodeValidation")).Text, Is.EqualTo("*Postalcode Required"));
        Assert.That(driver.FindElement(By.Id("phoneNumberValidation")).Text, Is.EqualTo("*Phonenumber Required"));
        Assert.That(driver.FindElement(By.Id("emailValidation")).Text, Is.EqualTo("*Email Required"));
        Assert.That(driver.FindElement(By.Id("makeValidation")).Text, Is.EqualTo("*Make Required"));
        Assert.That(driver.FindElement(By.Id("modelValidation")).Text, Is.EqualTo("*Model Required"));
        Assert.That(driver.FindElement(By.Id("yearValidation")).Text, Is.EqualTo("*Year Required"));
    }
    [Test]
    public void sellYourVehicle_OmitFirstName_ErrorShowingForMissingFirstName()
    {
        //Arrange
        baseUrl = "https://localhost/Assignment03/";

        //Act
        driver.Navigate().GoToUrl(baseUrl);
        driver.Manage().Window.Size = new System.Drawing.Size(746, 824);
        driver.FindElement(By.CssSelector(".button")).Click();
        driver.FindElement(By.Id("lastname")).Click();
        driver.FindElement(By.Id("lastname")).SendKeys("SIDDHAPURA");;
        driver.FindElement(By.Id("email")).SendKeys("divyeshsiddhapura19@gmail.com");
        driver.FindElement(By.CssSelector("html")).Click();
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("966,Main Street East");
        driver.FindElement(By.Id("city")).SendKeys("Hamilton");
        driver.FindElement(By.Id("provience")).Click();
        {
            var dropdown = driver.FindElement(By.Id("provience"));
            dropdown.FindElement(By.XPath("//option[. = 'ON']")).Click();
        }
        driver.FindElement(By.CssSelector(".row:nth-child(4)")).Click();
        driver.FindElement(By.Id("postalcode")).SendKeys("L8M 1M8");
        driver.FindElement(By.CssSelector("html")).Click();
        driver.FindElement(By.Id("phonenumber")).SendKeys("365-336-1610");
        driver.FindElement(By.Id("make")).Click();
        driver.FindElement(By.Id("make")).SendKeys("honda");
        driver.FindElement(By.Id("modelName")).Click();
        driver.FindElement(By.Id("modelName")).SendKeys("accord");
        driver.FindElement(By.Id("year")).Click();
        driver.FindElement(By.Id("year")).SendKeys("2021");
        driver.FindElement(By.Id("submit")).Click();
        driver.FindElement(By.CssSelector(".col-lg-6:nth-child(2) > .card-body")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("firstnameValidation")).Text, Is.EqualTo("*Firstname Required"));
    }
    [Test]
    public void sellYourVehicle_OmitMakeField_ErrorShowingForMissingMakeField()
    { 
        //Arrange
        baseUrl = "https://localhost/Assignment03/";

        //Act
        driver.Navigate().GoToUrl(baseUrl);
        driver.Manage().Window.Size = new System.Drawing.Size(736, 824);
        driver.FindElement(By.CssSelector(".button")).Click();
        driver.FindElement(By.Id("firstname")).Click();
        driver.FindElement(By.Id("firstname")).SendKeys("DIVYESHKUMAR");
        driver.FindElement(By.Id("lastname")).SendKeys("SIDDHAPURA");
        driver.FindElement(By.Id("email")).SendKeys("divyeshsiddhapura19@gmail.com");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("966,Main Street East");
        driver.FindElement(By.CssSelector(".mb-1:nth-child(1)")).Click();
        driver.FindElement(By.Id("provience")).Click();
        {
            var dropdown = driver.FindElement(By.Id("provience"));
            dropdown.FindElement(By.XPath("//option[. = 'ON']")).Click();
        }
        driver.FindElement(By.CssSelector(".mb-1:nth-child(1)")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Hamilton");
        driver.FindElement(By.CssSelector(".row:nth-child(4)")).Click();
        driver.FindElement(By.Id("postalcode")).SendKeys("L8M 1M8");
        driver.FindElement(By.CssSelector("html")).Click();
        driver.FindElement(By.Id("phonenumber")).Click();
        driver.FindElement(By.Id("phonenumber")).Click();
        driver.FindElement(By.CssSelector("html")).Click();
        driver.FindElement(By.Id("phonenumber")).SendKeys("365-116-1890");
        driver.FindElement(By.Id("modelName")).Click();
        driver.FindElement(By.Id("modelName")).SendKeys("civic");
        driver.FindElement(By.Id("year")).Click();
        driver.FindElement(By.Id("year")).SendKeys("2019");
        driver.FindElement(By.Id("submit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("makeValidation")).Text, Is.EqualTo("*Make Required"));
    }
    [Test]
    public void sellYourVehicle_OmitModeInputlField_ErrorShowingForMissingModelInput()
    {
        //Arrange
        baseUrl = "https://localhost/Assignment03/";

        //Act
        driver.Navigate().GoToUrl(baseUrl);
        driver.Manage().Window.Size = new System.Drawing.Size(740, 824);
        driver.FindElement(By.CssSelector(".button")).Click();
        driver.FindElement(By.Id("firstname")).Click();
        driver.FindElement(By.Id("firstname")).SendKeys("DIVYESHKUMAR");
        driver.FindElement(By.Id("lastname")).SendKeys("SIDDHAPURA");
        driver.FindElement(By.Id("email")).SendKeys("divyeshsiddhapura19@gmail.com");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("966,Main Street East");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Hamilton");
        driver.FindElement(By.Id("provience")).Click();
        {
            var dropdown = driver.FindElement(By.Id("provience"));
            dropdown.FindElement(By.XPath("//option[. = 'ON']")).Click();
        }
        driver.FindElement(By.Id("postalcode")).Click();
        driver.FindElement(By.Id("postalcode")).SendKeys("L8M 1M8");
        driver.FindElement(By.CssSelector(".col-lg-6:nth-child(2)")).Click();
        driver.FindElement(By.Id("phonenumber")).SendKeys("365-336-1610");
        driver.FindElement(By.Id("make")).Click();
        driver.FindElement(By.Id("make")).SendKeys("honda");
        driver.FindElement(By.Id("year")).Click();
        driver.FindElement(By.Id("year")).SendKeys("2022");
        driver.FindElement(By.Id("submit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("modelValidation")).Text, Is.EqualTo("*Model Required"));
    }
    [Test]
    public void sellYourVehicle_OmitAddress_ErrorShowingForAddressinput()
    { 
        //Arrange
        baseUrl = "https://localhost/Assignment03/";

        //Act
        driver.Navigate().GoToUrl(baseUrl);
        driver.Manage().Window.Size = new System.Drawing.Size(732, 824);
        driver.FindElement(By.CssSelector(".button")).Click();
        driver.FindElement(By.Id("firstname")).Click();
        driver.FindElement(By.Id("firstname")).SendKeys("Divyesh");
        driver.FindElement(By.Id("lastname")).SendKeys("Siddhapura");
        driver.FindElement(By.Id("city")).SendKeys("Hamilton");
        driver.FindElement(By.Id("provience")).Click();
        {
            var dropdown = driver.FindElement(By.Id("provience"));
            dropdown.FindElement(By.XPath("//option[. = 'QB']")).Click();
        }
        driver.FindElement(By.Id("provience")).Click();
        {
            var dropdown = driver.FindElement(By.Id("provience"));
            dropdown.FindElement(By.XPath("//option[. = 'ON']")).Click();
        }
        driver.FindElement(By.Id("postalcode")).Click();
        driver.FindElement(By.Id("postalcode")).SendKeys("L8M 1M8");
        driver.FindElement(By.Id("phonenumber")).Click();
        driver.FindElement(By.Id("phonenumber")).SendKeys("365-335-1789");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("divyesh@gmail.com");
        driver.FindElement(By.Id("make")).Click();
        driver.FindElement(By.Id("make")).SendKeys("honda");
        driver.FindElement(By.Id("modelName")).Click();
        driver.FindElement(By.Id("modelName")).SendKeys("civic");
        driver.FindElement(By.Id("year")).Click();
        driver.FindElement(By.Id("year")).SendKeys("2021");
        driver.FindElement(By.Id("submit")).Click();
        
        //Assert
        Assert.That(driver.FindElement(By.Id("addressValidation")).Text, Is.EqualTo("*Address Required"));
    }
    [Test]
    public void sellYourVehicle_OmitCity_ErrorShowingForMissingCityInput()
    {
        //Arrange
        baseUrl = "https://localhost/Assignment03/";

        //Act
        driver.Navigate().GoToUrl(baseUrl);
        driver.Manage().Window.Size = new System.Drawing.Size(732, 824);
        driver.FindElement(By.CssSelector(".button")).Click();
        driver.FindElement(By.Id("firstname")).Click();
        driver.FindElement(By.Id("firstname")).SendKeys("Divyesh");
        driver.FindElement(By.Id("lastname")).SendKeys("Siddhapura");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("966");
        driver.FindElement(By.Id("address")).SendKeys("966 Main Street");
        driver.FindElement(By.Id("provience")).Click();
        {
            var dropdown = driver.FindElement(By.Id("provience"));
            dropdown.FindElement(By.XPath("//option[. = 'ON']")).Click();
        }
        driver.FindElement(By.Id("postalcode")).Click();
        driver.FindElement(By.Id("postalcode")).Click();
        driver.FindElement(By.Id("postalcode")).SendKeys("L8M 1M8");
        driver.FindElement(By.Id("phonenumber")).Click();
        driver.FindElement(By.Id("phonenumber")).SendKeys("111-222-3333");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("divyesh@gmail.com");
        driver.FindElement(By.CssSelector(".col-lg-6:nth-child(3) form")).Click();
        driver.FindElement(By.Id("make")).Click();
        driver.FindElement(By.Id("make")).SendKeys("honda");
        driver.FindElement(By.Id("modelName")).Click();
        driver.FindElement(By.Id("modelName")).SendKeys("civic");
        driver.FindElement(By.Id("year")).Click();
        driver.FindElement(By.Id("year")).SendKeys("2015");
        driver.FindElement(By.Id("submit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("cityValidation")).Text, Is.EqualTo("*City Required"));
    }
    [Test]
    public void sellYourVehicle_InvalidFormatForYearField_ErrorShowingForYearInputFormat()
    {
        //Arrange
        baseUrl = "https://localhost/Assignment03/";

        //Act
        driver.Navigate().GoToUrl(baseUrl);
        driver.Manage().Window.Size = new System.Drawing.Size(732, 824);
        driver.FindElement(By.CssSelector(".button")).Click();
        driver.FindElement(By.Id("form1")).Click();
        driver.FindElement(By.Id("firstname")).Click();
        driver.FindElement(By.Id("firstname")).SendKeys("DIVYESHKUMAR");
        driver.FindElement(By.Id("lastname")).SendKeys("SIDDHAPURA");
        driver.FindElement(By.Id("email")).SendKeys("divyeshsiddhapura19@gmail.com");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("966,Main Street East");
        driver.FindElement(By.CssSelector("html")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Hamilton");
        driver.FindElement(By.Id("provience")).Click();
        {
            var dropdown = driver.FindElement(By.Id("provience"));
            dropdown.FindElement(By.XPath("//option[. = 'ON']")).Click();
        }
        driver.FindElement(By.CssSelector(".row:nth-child(4)")).Click();
        driver.FindElement(By.Id("postalcode")).SendKeys("L8M 1M8");
        driver.FindElement(By.CssSelector("html")).Click();
        driver.FindElement(By.Id("phonenumber")).SendKeys("365-336-1610");
        driver.FindElement(By.Id("make")).Click();
        driver.FindElement(By.Id("make")).SendKeys("honda");
        driver.FindElement(By.Id("modelName")).Click();
        driver.FindElement(By.Id("modelName")).SendKeys("civic");
        driver.FindElement(By.Id("year")).Click();
        driver.FindElement(By.Id("year")).SendKeys("a123");
        driver.FindElement(By.Id("submit")).Click();
        driver.FindElement(By.CssSelector(".col-lg-6:nth-child(3) .form-group:nth-child(3)")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("yearValidation")).Text, Is.EqualTo("*Year Must be in Numeric form"));
    }
}

