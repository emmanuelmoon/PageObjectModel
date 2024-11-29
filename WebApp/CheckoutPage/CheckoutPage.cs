using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ST_Project.WebApp.CheckoutPage;

public class CheckoutPage : CorePage
{
  #region locators
  By cartBtn = By.ClassName("showcart");
  By checkoutBtn = By.Id("top-cart-btn-checkout");
  By addNewAddress = By.ClassName("action-show-popup");
  By firstName = By.Name("firstname");
  By lastName = By.Name("lastname");
  By companyName = By.Name("company");
  By address = By.Name("street[0]");
  By city = By.Name("city");
  By state = By.XPath("//select[@name='region_id']");
  By zipcode = By.Name("postcode");
  By country = By.Name("country_id");
  By phoneNo = By.Name("telephone");
  By saveAddress = By.ClassName("action-save-address");
  By selectShippingRate = By.CssSelector("input[type='radio'][value='tablerate_bestway']");
  By next = By.CssSelector("button[data-role='opc-continue']");
  By orderBtn = By.ClassName("checkout");
  #endregion

  public void PerformCheckout()
  {
    Click(cartBtn);
    Click(checkoutBtn);
    WebDriverWait wait = new WebDriverWait(CorePage.driver, new TimeSpan(0, 1, 0));
    wait.Until(d => d.FindElement(addNewAddress));
    Thread.Sleep(2000);
    Click(addNewAddress);
    wait.Until(d => d.FindElement(firstName));
    Thread.Sleep(2000);
    Clear(firstName);
    Write(firstName, "John");
    Clear(lastName);
    Write(lastName, "Doe");
    Write(companyName, "FAST University");
    Write(address, "800, XYZ Street");
    Write(city, "New York");
    var select = driver.FindElement(state);
    select.Click();
    select.SendKeys(Keys.Down);
    select.SendKeys(Keys.Enter);
    Thread.Sleep(2000);
    Write(zipcode, "10001");
    Write(phoneNo, "1234567890");
    Click(saveAddress);
    Thread.Sleep(2000);
    Click(selectShippingRate);
    Click(next);
    Thread.Sleep(20000);
    Click(orderBtn);
    Thread.Sleep(20000);
  }

}
