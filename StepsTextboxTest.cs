// Generated by Selenium IDE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Xunit;
public class SuiteTests : IDisposable {
  public IWebDriver driver {get; private set;}
  public IDictionary<String, Object> vars {get; private set;}
  public IJavaScriptExecutor js {get; private set;}
  public SuiteTests()
  {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<String, Object>();
  }
  public void Dispose()
  {
    driver.Quit();
  }
  [Fact]
  public void StepsTextbox() {
    // Test name: StepsTextbox
    // Step # | name | target | value
    // 1 | open | https://demoqa.com/elements | 
    driver.Navigate().GoToUrl("https://demoqa.com/elements");
    // 2 | setWindowSize | 784x824 | 
    driver.Manage().Window.Size = new System.Drawing.Size(784, 824);
    // 3 | click | css=.show #item-0 > .text | 
    driver.FindElement(By.CssSelector(".show #item-0 > .text")).Click();
    // 4 | click | id=userName | 
    driver.FindElement(By.Id("userName")).Click();
    // 5 | type | id=userName | ${name}
    driver.FindElement(By.Id("userName")).SendKeys(vars["name"].ToString());
    // 6 | click | id=userEmail | 
    driver.FindElement(By.Id("userEmail")).Click();
    // 7 | type | id=userEmail | ${email}
    driver.FindElement(By.Id("userEmail")).SendKeys(vars["email"].ToString());
    // 8 | click | id=currentAddress | 
    driver.FindElement(By.Id("currentAddress")).Click();
    // 9 | type | id=currentAddress | ${address}
    driver.FindElement(By.Id("currentAddress")).SendKeys(vars["address"].ToString());
    // 10 | click | id=permanentAddress | 
    driver.FindElement(By.Id("permanentAddress")).Click();
    // 11 | type | id=permanentAddress | ${permAddress}
    driver.FindElement(By.Id("permanentAddress")).SendKeys(vars["permAddress"].ToString());
    // 12 | click | id=submit | 
    driver.FindElement(By.Id("submit")).Click();
    // 13 | assertText | id=name | Name:${name}
    Assert.Equal(driver.FindElement(By.Id("name")).Text, "Name:vars[\"name\"].ToString()");
    // 14 | assertText | id=email | Email:${email}
    Assert.Equal(driver.FindElement(By.Id("email")).Text, "Email:vars[\"email\"].ToString()");
    // 15 | assertText | css=.border > #currentAddress | Current Address :${address}
    Assert.Equal(driver.FindElement(By.CssSelector(".border > #currentAddress")).Text, "Current Address :vars[\"address\"].ToString()");
    // 16 | assertText | css=.border > #permanentAddress | Permananet Address :${permAddress}
    Assert.Equal(driver.FindElement(By.CssSelector(".border > #permanentAddress")).Text, "Permananet Address :vars[\"permAddress\"].ToString()");
  }
}