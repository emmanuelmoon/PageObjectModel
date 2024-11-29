using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
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
      var options = new ChromeOptions();
      // options.AddArgument("--headless");
      options.AddArgument("--disable-gpu");
      options.AddArgument("--no-sandbox");
      options.AddArgument("--disable-extensions");
      options.AddArgument("--incognito");
      IWebDriver chromeDriver = new ChromeDriver(options);
      driver = chromeDriver;
    }
    else if (browser == "Firefox")
    {
      IWebDriver firefoxDriver = new FirefoxDriver();
      driver = firefoxDriver;
    }
    return driver;
  }

  public void OpenUrl(string url)
  {
    driver.Url = url;
  }
  public void Write(By by, string setValue)
  {
    driver.FindElement(by).SendKeys(setValue);
  }
  public void Click(By by)
  {
    driver.FindElement(by).Click();
  }
  public void Clear(By by)
  {
    driver.FindElement(by).Clear();
  }

}
