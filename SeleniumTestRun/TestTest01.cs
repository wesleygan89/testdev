using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeleniumTestRun
{
    class TestTest01
    {
        IWebDriver browser = new FirefoxDriver();
        [Test, Order(1)]
        public void site_header_is_on_home_page()
        {

            //Firefox's proxy driver executable is in a folder already
            //  on the host system's PATH environment variable.
            browser.Navigate().GoToUrl("http://bbxworld.com");
            System.Threading.Thread.Sleep(5000);
            IWebElement basetitle = browser.FindElement(By.XPath("//*[@href='Join']"));
            Assert.True(basetitle.Displayed);
            //IWebElement header = browser.FindElement(By.TagName("user-app"));
            ////IWebElement header2 = browser.FindElement(By.CssSelector("href*='Join'"));

            //Assert.True(header.Displayed);
            //browser.Close();
        }

        [Test, Order(2)]
        public void clicktoprocesstransaction()
        {
            //IWebDriver browser = new FirefoxDriver();
            ////Firefox's proxy driver executable is in a folder already
            ////  on the host system's PATH environment variable.
            //browser.Navigate().GoToUrl("http://bbxworld.com");
            browser.Navigate().GoToUrl("http://bbxworld.com/Member/Webipos");
            //IWebElement title = browser.FindElement(By.TagName("title"));
            //MessageBox.Show(browser.Title);
            System.Threading.Thread.Sleep(2000);
            if (browser.Title == "BBX Member Login")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
            //IWebElement header2 = browser.FindElement(By.CssSelector("href*='Join'"));

            //Assert.True(header.Displayed);
            //browser.Close();
        }

        [Test, Order(3)]
        public void Login()
        {
            IWebElement accountnumber = browser.FindElement(By.Id("AccountNumber"));
            IWebElement password = browser.FindElement(By.Id("Pin"));
            accountnumber.SendKeys("6220430100003821");
            password.SendKeys("Ekomoditi2018");
            IWebElement termcheckbox = browser.FindElement(By.XPath("//*[@ng-model='isTermsSelected']"));
            termcheckbox.Click();
            IWebElement loginbutton = browser.FindElement(By.XPath("//*[@title='Login']"));
            loginbutton.Click();

            System.Threading.Thread.Sleep(2000);
            if (browser.Title == "BBX Web iPOS")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

            //browser.Close();
        }

        [Test, Order(4)]
        public void Logout()
        {

            IWebElement logoutbutton = browser.FindElement(By.XPath("//*[@href='/Member/Account/Logout']"));
            logoutbutton.Click();
            System.Threading.Thread.Sleep(2000);
            //IWebElement  bbase =browser.FindElement(By.TagName("base"));
            IWebElement basetitle = browser.FindElement(By.XPath("//*[@href='Join']"));
            Assert.True(basetitle.Displayed);
            //if (basetitle.Text == "Join")
            //{
            //    Assert.Pass();
            //}
            //else
            //{
            //    Assert.Fail();
            //}
            browser.Close();
        }



    }
}
