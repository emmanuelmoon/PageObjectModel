using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ST_Project;

public class CorePage
{
  public static IWebDriver driver;

  public static IWebDriver SeleniumInit()
  {
    IWebDriver chromeDriver = new ChromeDriver();
    driver = chromeDriver;
    return driver;
  }
}
