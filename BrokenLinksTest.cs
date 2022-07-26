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
  public void BrokenLinks() {
    // Test name: BrokenLinks
    // Step # | name | target | value
    // 1 | open | https://demoqa.com/elements | 
    driver.Navigate().GoToUrl("https://demoqa.com/elements");
    // 2 | setWindowSize | 788x824 | 
    driver.Manage().Window.Size = new System.Drawing.Size(788, 824);
    // 3 | click | css=.show #item-6 > .text | 
    driver.FindElement(By.CssSelector(".show #item-6 > .text")).Click();
    // 4 | assertElementPresent | css=img:nth-child(2) | 
    {
      IReadOnlyCollection<IWebElement> elements = driver.FindElements(By.CssSelector("img:nth-child(2)"));
      Assert.True(elements.Count > 0);
    }
    // 5 | storeAttribute | css=img:nth-child(6)@src | brokenImgLink
    {
      var element = driver.FindElement(By.CssSelector("img:nth-child(6)"));
      string attribute = element.GetAttribute("src");
      vars["brokenImgLink"] = attribute;
    }
    // 6 | click | linkText=Click Here for Valid Link | 
    driver.FindElement(By.LinkText("Click Here for Valid Link")).Click();
    // 7 | executeScript | return window.location.href | pageurl
    vars["pageurl"] = js.ExecuteScript("return window.location.href");
    // 8 | assert | pageurl | https://demoqa.com/
    Assert.Equal(vars["pageurl"].ToString(), "https://demoqa.com/");
    // 10 | click | linkText=Click Here for Broken Link | 
    driver.FindElement(By.LinkText("Click Here for Broken Link")).Click();
    // 11 | executeScript | return window.location.href | brokenPageUrl
    vars["brokenPageUrl"] = js.ExecuteScript("return window.location.href");
    // 12 | assert | brokenImgLink | /images/Toolsqa.jpg
    Assert.Equal(vars["brokenImgLink"].ToString(), "/images/Toolsqa.jpg");
    // 13 | assert | brokenPageUrl | https://demoqa.com/
    Assert.Equal(vars["brokenPageUrl"].ToString(), "https://demoqa.com/");
  }
}
