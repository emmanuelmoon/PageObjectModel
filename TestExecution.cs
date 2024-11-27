using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ST_Project.WebApp.MensPage;

namespace ST_Project;

[TestClass]
public class UnitTest1
{
    #region Setups and Cleanups

    public TestContext instance;
    public TestContext TestContext
    {
        set { instance = value; }
        get { return instance; }
    }
    [ClassInitialize()]
    public static void ClassInit(TestContext context)
    {

    }

    [ClassCleanup()]
    public static void ClassCleanup()
    {

    }

    [TestInitialize()]
    public void TestInit()
    {
        CorePage.SeleniumInit("Chrome");
    }


    [TestCleanup()]
    public void TestCleanup()
    {
        CorePage.driver.Close();
    }
    #endregion
    LoginPage loginPage = new LoginPage();
    MensPage mensPage = new MensPage();
    // [TestMethod]
    // public void LoginWithValidEmailValidPassword()
    // {
    //     loginPage.Login("https://magento.softwaretestingboard.com/", "authorization-link",
    //     "emmenual123@gmail.com", "qDtP6zAYSktxT1");

    //     string expectedText = "Welcome, Emmanuel Parvez!";
    //     string actualText = CorePage.driver.FindElement(By.ClassName("logged-in")).Text;

    //     Assert.AreEqual(expectedText, actualText);

    // }
    // [TestMethod]
    // public void LoginWithInvalidEmailInvalidPassword()
    // {
    //     loginPage.Login("https://magento.softwaretestingboard.com/", "authorization-link",
    //     "emmenual1234@gmail.com", "qDtP6zAYSktxT12");

    //     string expectedText = "The account sign-in was incorrect or your account is disabled temporarily. Please wait and try again later.";
    //     string actualText = CorePage.driver.FindElement(By.ClassName("messages")).Text;

    //     Assert.AreEqual(expectedText, actualText);
    // }

    [TestMethod]
    public void LoginAndAddTankFromMensPage()
    {
        loginPage.Login("https://magento.softwaretestingboard.com/", "authorization-link",
        "emmenual123@gmail.com", "qDtP6zAYSktxT1");

        mensPage.GoToMensSection();
        mensPage.AddArgusAllWeatherTankToCard("2");

        string expectedText = "You added Argus All-Weather Tank to your shopping cart.";
        Thread.Sleep(20000);
        string actualText = CorePage.driver.FindElement(By.ClassName("messages")).Text;

        Assert.AreEqual(expectedText, actualText);
    }


}