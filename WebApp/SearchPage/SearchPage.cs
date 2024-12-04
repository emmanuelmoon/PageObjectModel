using System;
using OpenQA.Selenium;

namespace ST_Project.WebApp.SearchPage;

public class SearchPage : CorePage
{
  By searchField = By.Id("search");
  By itemLink = By.LinkText("Adrienne Trek Jacket");
  By xsmall = By.Id("option-label-size-143-item-166");
  By graycolor = By.Id("option-label-color-93-item-52");
  By qty = By.Id("qty");
  By addToCardBtn = By.Id("product-addtocart-button");

  public void SearchProduct(string productName)
  {
    Write(searchField, productName);
    driver.FindElement(searchField).SendKeys(Keys.Enter);
  }

  public void SearchProductAndOrder()
  {
    SearchProduct("Jacket");
    Click(itemLink);
    Click(xsmall);
    Click(graycolor);
    Clear(qty);
    Write(qty, "1");
    Click(addToCardBtn);
  }
}
