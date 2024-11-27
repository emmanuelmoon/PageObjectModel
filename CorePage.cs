using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace ST_Project;

public class CorePage
{
  public static IWebDriver driver;

  public static IWebDriver SeleniumInit(string browser)
  {
    if (browser == "Chrome")
    {
      IWebDriver chromeDriver = new ChromeDriver();
      driver = chromeDriver;
    }
    else if (browser == "Firefox")
    {
      IWebDriver firefoxDriver = new FirefoxDriver();
      driver = firefoxDriver;
    }
    return driver;
  }
}
