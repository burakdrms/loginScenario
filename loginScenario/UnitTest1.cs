using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace loginScenario
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;
        [TestMethod]
        public void userSignInTR()
        {
            driver = new ChromeDriver();

            driver.Url = "https://mutlubiev.com/";

            driver.FindElement(By.XPath("//a[contains(.,'Üye Ol')]")).Click();

            driver.FindElement(By.CssSelector("#memberpage > div.main-holder > div.left-section > div:nth-child(1) > div > div > div:nth-child(2) > div > input")).SendKeys("Burak Durmuş");
            driver.FindElement(By.XPath("//input[@type='email']")).SendKeys("bd.burak.durmus@gmail.com");
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("burakşifre123");
            driver.FindElement(By.XPath("//input[@name='phone']")).SendKeys("5312210031");
            driver.FindElement(By.CssSelector("#memberpage > div.main-holder > div.left-section > div:nth-child(1) > div > div > div:nth-child(6) > span > label > span.square-radio-box.pull-left")).Click();
           
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Quit();
        }
        [TestMethod]
        public void userSignInAssertionTR()
        {
            driver = new ChromeDriver();

            driver.Url = "https://mutlubiev.com/";

            driver.FindElement(By.XPath("//a[contains(.,'Üye Ol')]")).Click();

            driver.FindElement(By.CssSelector("#memberpage > div.main-holder > div.left-section > div:nth-child(1) > div > div > div:nth-child(2) > div > input")).SendKeys("");
            driver.FindElement(By.XPath("//input[@type='email']")).SendKeys("");
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("");
            driver.FindElement(By.XPath("//input[@name='phone']")).SendKeys("");
            
            driver.FindElement(By.XPath("//button[contains(.,'Üye Ol')]")).Click();

            driver.FindElement(By.XPath("//small[@class='red-text'][contains(.,'Ad ve Soyad boş bırakılamaz.')]"));
            driver.FindElement(By.XPath("//small[@class='red-text'][contains(.,'Geçersiz e-posta adresi')]"));
            driver.FindElement(By.XPath("//small[@class='red-text'][contains(.,'En az 6 karakterlik bir şifre belirlemelisin')]"));
            driver.FindElement(By.XPath("//small[@class='red-text'][contains(.,'Telefon numarası boş bırakılamaz.')]"));
            driver.FindElement(By.XPath("//small[@class='red-text'][contains(.,'Üyelik sözleşmesini onaylamanız gerekmektedir.')]"));
            
            driver.Quit();
        }

        [TestMethod]

        public void UserLogInTR()
        {
            driver = new ChromeDriver();

            driver.Url = "https://mutlubiev.com/";

            driver.FindElement(By.XPath("//a[contains(.,'Giriş Yap')]")).Click();

            driver.FindElement(By.Id("Email")).SendKeys("bd.burak.durmus@gmail.com");
            driver.FindElement(By.Id("Password")).SendKeys("burakşifre123");
            driver.FindElement(By.XPath("//button[contains(.,'Giriş Yap')]")).Click();

            
            driver.Quit();
        }
        [TestMethod]
        public void UserLogInAssertionTR()
        {
            driver = new ChromeDriver();

            driver.Url = "https://mutlubiev.com/";

            driver.FindElement(By.XPath("//a[contains(.,'Giriş Yap')]")).Click();

            driver.FindElement(By.Id("Email")).SendKeys("");
            driver.FindElement(By.Id("Password")).SendKeys("");
            driver.FindElement(By.XPath("//button[contains(.,'Giriş Yap')]")).Click();

            driver.FindElement(By.XPath("//div[@class='alert alert-warning'][contains(.,'Mail ya da şifre yanlış.')]"));

            
            driver.Quit();
        }

        [TestMethod]
        public void userSignIn()
        {
            driver = new ChromeDriver();

            driver.Url = "https://cleanzy.com/uk-en";

            driver.FindElement(By.XPath("//a[contains(.,'Register')]")).Click();

            driver.FindElement(By.CssSelector("#memberpage > div.main-holder > div.left-section > div:nth-child(1) > div > div > div:nth-child(2) > div > input")).SendKeys("Burak Durmuş");
            driver.FindElement(By.XPath("//input[@type='email']")).SendKeys("bd.burak.durmus@gmail.com");
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("burakşifre123");
            driver.FindElement(By.XPath("//input[@name='phone']")).SendKeys("905312210031");
            driver.FindElement(By.CssSelector("#memberpage > div.main-holder > div.left-section > div:nth-child(1) > div > div > div:nth-child(6) > span > label > span.square-radio-box.pull-left")).Click();
            driver.FindElement(By.XPath("//button[contains(.,'Register')]")).Click();

           
            driver.Quit();
        }
        [TestMethod]
        public void userSignInAssertion()
        {
            driver = new ChromeDriver();

            driver.Url = "https://cleanzy.com/uk-en/member";

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.XPath("//a[contains(.,'Register')]")).Click();
           
            driver.FindElement(By.XPath("//input[@name='name']")).SendKeys("");
            driver.FindElement(By.XPath("//input[@type='email']")).SendKeys("");
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("");
            driver.FindElement(By.XPath("//input[@name='phone']")).SendKeys("");

            driver.FindElement(By.XPath("//button[contains(.,'Register')]")).Click();
            
            driver.FindElement(By.XPath("//small[@class='red-text'][contains(.,'Name and surname cannot be blank.')]"));
            driver.FindElement(By.XPath("//small[@class='red-text'][contains(.,'Please write your e-mail address')]"));
            driver.FindElement(By.XPath("//small[@class='red-text'][contains(.,'You must set a password of at least 6 characters')]"));
            driver.FindElement(By.XPath("//small[@class='red-text'][contains(.,'The phone number can not be blank.')]"));
            driver.FindElement(By.XPath("//small[@class='red-text'][contains(.,'You must approve the membership agreement.')]"));

            
            driver.Quit();
        }

        [TestMethod]

        public void UserLogIn()
        {
            driver = new ChromeDriver();

            driver.Url = "https://cleanzy.com/uk-en";

            driver.FindElement(By.XPath("//a[contains(.,'Login')]")).Click();

            driver.FindElement(By.Id("Email")).SendKeys("bd.burak.durmus@gmail.com");
            driver.FindElement(By.Id("Password")).SendKeys("burakşifre123");
            driver.FindElement(By.XPath("//button[@type='submit'][contains(.,'Login')]")).Click();

            
            driver.Quit();
        }
        [TestMethod]
        public void UserLogInAssertion()
        {
            driver = new ChromeDriver();

            driver.Url = "https://cleanzy.com/uk-en";

            driver.FindElement(By.XPath("//a[contains(.,'Login')]")).Click();

            driver.FindElement(By.Id("Email")).SendKeys("");
            driver.FindElement(By.Id("Password")).SendKeys("");
            driver.FindElement(By.XPath("//button[contains(.,'Login')]")).Click();

            driver.FindElement(By.XPath("//div[@class='alert alert-warning'][contains(.,'Mail or password is incorrect.')]"));

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Quit();

        }
    }
}
