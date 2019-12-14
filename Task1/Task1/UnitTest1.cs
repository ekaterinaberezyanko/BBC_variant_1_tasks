using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace Task1
{

    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void CheckHeadlineName()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.bbc.com");

            IWebElement NewsButton = driver.FindElement(By.XPath("//div[@id='orb-nav-links']//li[@class = 'orb-nav-newsdotcom']"));
            NewsButton.Click();

            string expectedResult = "World's most profitable company to go public";

            IWebElement Title = driver.FindElement(By.XPath(".//*[contains(@class,'promo-heading__title')]"));

            string elementText = Title.Text;
            NUnit.Framework.Assert.AreEqual(expectedResult, elementText, $"The headline article is {elementText}, but expected is {expectedResult}");
            driver.Close();
        }


        [Test]
        public void CheckSecondaryItems()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.bbc.com");


            IWebElement NewsButton = driver.FindElement(By.XPath(".//*[@class='orb-nav-newsdotcom']"));
            NewsButton.Click();

            List<string> expectedSecondaryTitles = new List<string> { "Hong Kong protests: Knife attacker bites man's ear", "Nigel Farage will not stand as election candidate", "World's most profitable company to go public", "The Russian vegans cooking up a revolution", "'Comfort women' film to be shown in Japan amid row" };

            List<IWebElement> SecondaryTitle = new List<IWebElement>(driver.FindElements(By.XPath(".//*[contains(@class,'secondary-item')]//*[contains(@class,'title')]")));

            List<string> actualSecondaryTitles = new List<string>();
            foreach (IWebElement webElement in SecondaryTitle)
            {
                actualSecondaryTitles.Add(webElement.Text);
            }
            foreach (string actualelement in actualSecondaryTitles)
            {
                NUnit.Framework.Assert.IsTrue(expectedSecondaryTitles.Contains(actualelement));
            }
            driver.Close();
        }

        [Test]
        public void CheckSearchBar()
        {
            IWebDriver driver = new ChromeDriver();
           
            driver.Navigate().GoToUrl("https://www.bbc.com");

            IWebElement NewsButton = driver.FindElement(By.XPath(".//*[@class='orb-nav-newsdotcom']"));
            NewsButton.Click();

            IWebElement CategoryLink = driver.FindElement(By.XPath(".//*[contains(@aria-label,'From')]"));
            string TextFrom = CategoryLink.Text;

            IWebElement SearchBar = driver.FindElement(By.XPath(".//*[contains(@placeholder,'Search')]"));
            SearchBar.Click();

            SearchBar.SendKeys(TextFrom);
            IWebElement OrbSearchButton = driver.FindElement(By.XPath(".//*[@id='orb-search-button']"));
            OrbSearchButton.Click();

            IWebElement headline = driver.FindElement(By.XPath(".//*[@itemprop='headline']"));
            string FirstFound = headline.Text;

            NUnit.Framework.Assert.AreEqual(TextFrom, FirstFound, $"The headline article is {FirstFound}, expected is {TextFrom}");
            driver.Close();
        }
    }
}