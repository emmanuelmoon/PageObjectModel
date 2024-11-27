using System;
using OpenQA.Selenium;

namespace ST_Project.WebApp.MensPage;

public class MensPage : CorePage
{
  By mensLink = By.LinkText("Men");
  By tankLink = By.LinkText("Argus All-Weather Tank");
  By tankExtraSmall = By.Id("option-label-size-143-item-166");
  By tankGray = By.Id("option-label-color-93-item-52");
  By tankQuantity = By.Id("qty");
  By addToCardBtn = By.ClassName("tocart");
  public void GoToMensSection()
  {
    driver.FindElement(mensLink).Click();
  }
  public void AddArgusAllWeatherTankToCard(string qty)
  {
    driver.FindElement(tankLink).Click();
    driver.FindElement(tankExtraSmall).Click();
    driver.FindElement(tankGray).Click();
    driver.FindElement(tankQuantity).Clear();
    driver.FindElement(tankQuantity).SendKeys("1");
    driver.FindElement(addToCardBtn).Click();
  }
}
