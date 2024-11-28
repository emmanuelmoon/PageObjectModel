using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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
    public static IEnumerable<object[]> AddTestData =>
    new List<object[]>
    {
        new object[] {"https://magento.softwaretestingboard.com/", "authorization-link",
        "emmenual123@gmail.com", "qDtP6zAYSktxT1", "logged-in", "Welcome, Emmanuel Parvez!" },
        new object [] {
            "https://magento.softwaretestingboard.com/", "authorization-link", "emmenual1234@gmail.com",
            "qDtP6zAYSktxT12", "messages", "The account sign-in was incorrect or your account is disabled temporarily. Please wait and try again later."
        }
    };


    // public void Add_ShouldReturnCorrectSum_DynamicData(int a, int b, int expected)
    // {
    //     var calculator = new Calculator();
    //     var result = calculator.Add(a, b);
    //     Assert.AreEqual(expected, result);
    // }

    [DataTestMethod]
    [DynamicData(nameof(AddTestData))]
    public void LoginWithValidEmailValidPassword(string url, string signInLink, string email, string password, string locator, string expectedText)
    {
        loginPage.Login(url, signInLink, email, password);

        WebDriverWait wait = new WebDriverWait(CorePage.driver, new TimeSpan(0, 1, 0));
        wait.Until(d => d.FindElement(By.ClassName(locator)));
        string actualText = CorePage.driver.FindElement(By.ClassName(locator)).Text;

        Assert.AreEqual(expectedText, actualText);

    }
    [TestMethod]
    public void LoginAndAddTankFromMensPage()
    {
        loginPage.Login("https://magento.softwaretestingboard.com/", "authorization-link",
        "emmenual123@gmail.com", "qDtP6zAYSktxT1");

        mensPage.GoToMensSection();
        mensPage.AddArgusAllWeatherTankToCard("2");

        string expectedText = "You added Argus All-Weather Tank to your shopping cart.";


        WebDriverWait wait = new WebDriverWait(CorePage.driver, new TimeSpan(0, 1, 0));
        wait.Until(d => d.FindElement(By.ClassName("messages")));
        string actualText = CorePage.driver.FindElement(By.ClassName("messages")).Text;

        Assert.AreEqual(expectedText, actualText);
    }


}