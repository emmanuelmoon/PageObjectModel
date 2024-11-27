using OpenQA.Selenium;

namespace ST_Project;

public class LoginPage : CorePage
{
  By signInLink = By.ClassName("authorization-link");
  By emailField = By.Id("email");
  By passwordField = By.Id("pass");
  By signInBtn = By.Id("send2");
  public void Login(string url, string link, string email, string password)
  {
    driver.Url = url;
    driver.FindElement(signInLink).Click();
    driver.FindElement(emailField).SendKeys(email);
    driver.FindElement(passwordField).SendKeys(password);
    driver.FindElement(signInBtn).Click();
  }
}
