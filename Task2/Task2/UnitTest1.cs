using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Task2
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
        [Test]
        public void Submit_question_140_numbers()
        {
            driver.Navigate().GoToUrl("https://www.bbc.com");

            IWebElement NewsButton = driver.FindElement(By.XPath("//a[contains(text(), 'News')]"));
            NewsButton.Click();

            IWebElement MoreButton = driver.FindElement(By.XPath("//span[contains(text(), 'More')]"));
            MoreButton.Click();

            IWebElement HaveYourSayButton = driver.FindElement(By.XPath("//span[contains(text(), 'Have Your Say')]"));
            HaveYourSayButton.Click();

            IWebElement DoYouHaveAQuestionForBBC = driver.FindElement(By.XPath("//div[@class ='gs-c-promo gs-t-News nw-c-promo gs-o-faux-block-link gs-u-pb gs-u-pb+@m nw-p-default gs-c-promo--inline gs-c-promo--stacked@m gs-c-promo--flex']"));
            DoYouHaveAQuestionForBBC.Click();
            string url = driver.Url;

            driver.FindElement(By.XPath("//input[@aria-label = 'Name']")).SendKeys("Maria");
            driver.FindElement(By.XPath("//input[@aria-label = 'Email address']")).SendKeys("maria@gmail.com");
            driver.FindElement(By.XPath("//input[@aria-label = 'Age']")).SendKeys("20");
            driver.FindElement(By.XPath("//input[@aria-label = Postcode']")).SendKeys("03245");
            driver.FindElement(By.XPath("//textarea[@class = 'text-input--long']")).SendKeys("I fill this form with 140 characters 111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111");

            IWebElement SubmitButton = driver.FindElement(By.XPath("//button[@class = 'button']"));
            SubmitButton.Click();
            string url2 = driver.Url;

            Assert.AreEqual(url, url2);
        }

        [Test]
        public void Submit_question_141_numbers()
        {
            driver.Navigate().GoToUrl("https://www.bbc.com");

            IWebElement NewsButton = driver.FindElement(By.XPath("//a[contains(text(), 'News')]"));
            NewsButton.Click();

            IWebElement MoreButton = driver.FindElement(By.XPath("//span[contains(text(), 'More')]"));
            MoreButton.Click();

            IWebElement HaveYourSayButton = driver.FindElement(By.XPath("//span[contains(text(), 'Have Your Say')]"));
            HaveYourSayButton.Click();

            IWebElement DoYouHaveAQuestionForBBC = driver.FindElement(By.XPath("//div[@class ='gs-c-promo gs-t-News nw-c-promo gs-o-faux-block-link gs-u-pb gs-u-pb+@m nw-p-default gs-c-promo--inline gs-c-promo--stacked@m gs-c-promo--flex']"));
            DoYouHaveAQuestionForBBC.Click();
            string url = driver.Url;

            driver.FindElement(By.XPath("//input[@aria-label = 'Name']")).SendKeys("Maria");
            driver.FindElement(By.XPath("//input[@aria-label = 'Email address']")).SendKeys("maria@gmail.com");
            driver.FindElement(By.XPath("//input[@aria-label = 'Age']")).SendKeys("20");
            driver.FindElement(By.XPath("//input[@aria-label = Postcode']")).SendKeys("03245");
            driver.FindElement(By.XPath("//textarea[@class = 'text-input--long']")).SendKeys("I fill this form with 141 characters 1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111");

            string url2 = driver.Url;
            Assert.AreNotEqual(url, url2);
        }

        [Test]
        public void Submit_question_name_empty()
        {
            driver.Navigate().GoToUrl("https://www.bbc.com");

            IWebElement NewsButton = driver.FindElement(By.XPath("//a[contains(text(), 'News')]"));
            NewsButton.Click();

            IWebElement MoreButton = driver.FindElement(By.XPath("//span[contains(text(), 'More')]"));
            MoreButton.Click();

            IWebElement HaveYourSayButton = driver.FindElement(By.XPath("//span[contains(text(), 'Have Your Say')]"));
            HaveYourSayButton.Click();

            IWebElement DoYouHaveAQuestionForBBC = driver.FindElement(By.XPath("//div[@class ='gs-c-promo gs-t-News nw-c-promo gs-o-faux-block-link gs-u-pb gs-u-pb+@m nw-p-default gs-c-promo--inline gs-c-promo--stacked@m gs-c-promo--flex']"));
            DoYouHaveAQuestionForBBC.Click();
            string url = driver.Url;

            driver.FindElement(By.XPath("//input[@aria-label = 'Email address']")).SendKeys("maria@gmail.com");
            driver.FindElement(By.XPath("//input[@aria-label = 'Age']")).SendKeys("20");
            driver.FindElement(By.XPath("//input[@aria-label = Postcode']")).SendKeys("03245");
            driver.FindElement(By.XPath("//textarea[@class = 'text-input--long']")).SendKeys("I fill this form with 140 characters 111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111");

            IWebElement SubmitButton = driver.FindElement(By.XPath("//button[@class = 'button']"));
            SubmitButton.Click();
            string url2 = driver.Url;

            Assert.AreEqual(url, url2);

        }

        [Test]
        public void Submit_question_email_empty()
        {
            driver.Navigate().GoToUrl("https://www.bbc.com");

            IWebElement NewsButton = driver.FindElement(By.XPath("//a[contains(text(), 'News')]"));
            NewsButton.Click();

            IWebElement MoreButton = driver.FindElement(By.XPath("//span[contains(text(), 'More')]"));
            MoreButton.Click();

            IWebElement HaveYourSayButton = driver.FindElement(By.XPath("//span[contains(text(), 'Have Your Say')]"));
            HaveYourSayButton.Click();

            IWebElement DoYouHaveAQuestionForBBC = driver.FindElement(By.XPath("//div[@class ='gs-c-promo gs-t-News nw-c-promo gs-o-faux-block-link gs-u-pb gs-u-pb+@m nw-p-default gs-c-promo--inline gs-c-promo--stacked@m gs-c-promo--flex']"));
            DoYouHaveAQuestionForBBC.Click();
            string url = driver.Url;

            driver.FindElement(By.XPath("//input[@aria-label = 'Name']")).SendKeys("Maria");
            driver.FindElement(By.XPath("//input[@aria-label = 'Age']")).SendKeys("20");
            driver.FindElement(By.XPath("//input[@aria-label = Postcode']")).SendKeys("03245");
            driver.FindElement(By.XPath("//textarea[@class = 'text-input--long']")).SendKeys("I fill this form with 140 characters 111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111");

            IWebElement SubmitButton = driver.FindElement(By.XPath("//button[@class = 'button']"));
            SubmitButton.Click();
            string url2 = driver.Url;
            Assert.AreEqual(url, url2);

        }
       
    }
}