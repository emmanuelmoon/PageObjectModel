using System;
using OpenQA.Selenium;

namespace ST_Project.WebApp.LoginPage;

public class LogoutPage : CorePage
{
  By switchBtn = By.XPath("/html/body/div[2]/header/div[1]/div/ul/li[2]/span/button");
  By signoutBtn = By.XPath("/html/body/div[2]/header/div[1]/div/ul/li[2]/div/ul/li[3]/a");

  public void PerformLogout()
  {
    Click(switchBtn);
    Click(signoutBtn);
  }
}
