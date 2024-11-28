using System;
using OpenQA.Selenium;

namespace ST_Project.WebApp.MensPage;

public class MensPage : CorePage
{
  #region Locators
  By mensLink = By.LinkText("Men");
  By tankLink = By.LinkText("Argus All-Weather Tank");
  By tankExtraSmall = By.Id("option-label-size-143-item-166");
  By tankGray = By.Id("option-label-color-93-item-52");
  By tankQuantity = By.Id("qty");
  By addToCardBtn = By.ClassName("tocart");
  #endregion
  public void GoToMensSection()
  {
    Click(mensLink);
  }
  public void AddArgusAllWeatherTankToCard(string qty)
  {
    Click(tankLink);
    Click(tankExtraSmall);
    Click(tankGray);
    Clear(tankQuantity);
    Write(tankQuantity, "1");
    Click(addToCardBtn);
  }
}
