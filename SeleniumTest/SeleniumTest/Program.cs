using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


namespace SeleniumTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test started");
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://www.google.com/");
            //Thread.Sleep(2000);
            //IWebElement ele = driver.FindElement(By.Name("q"));
            //ele.SendKeys("mahammad mustafayev");
            //Thread.Sleep(2000);
            //IWebElement ele2 = driver.FindElement(By.Name("btnK"));
            //ele2.Click();
            //Thread.Sleep(3000);
            //driver.Close();


            // var chromeDriverService = ChromeDriverService.CreateDefaultService();
            new DriverManager().SetUpDriver(new ChromeConfig());
            var chromeOptions = new ChromeOptions();
            using (var driver = new ChromeDriver( chromeOptions))
            {
                //driver.Navigate().GoToUrl("https://www.google.com");
                driver.Navigate().GoToUrl("https://mahammadmustafayev.vercel.app/");
                IWebElement name= driver.FindElement(By.Id("name"));
                IWebElement email= driver.FindElement(By.Id("email"));
                IWebElement subject= driver.FindElement(By.Id("subject"));
                IWebElement comments= driver.FindElement(By.Id("comments"));
                IWebElement submit= driver.FindElement(By.Id("submit"));

                name.SendKeys("Selena");
                Thread.Sleep(1500);
                email.SendKeys("mmmyev125@gmail.com");
                Thread.Sleep(1500);
                subject.SendKeys("Backend test");
                Thread.Sleep(1500);
                comments.SendKeys("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");
                Thread.Sleep(1500);
                submit.Click();
                // Find the search box using its name attribute
                // IWebElement searchBox = driver.FindElement(By.Name("q"));

                // Enter text into the search box
                // searchBox.SendKeys("Mahammad Mustafayev - Software Developer");

                // Submit the form
                // searchBox.Submit();

                // Wait for a bit to see the results
               // System.Threading.Thread.Sleep(2000);

                //WebDriverWait wait= new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("h3")));

                //IWebElement firstResult = driver.FindElement(By.CssSelector("h3"));
                //string firstResultText = firstResult.Text;
                //if (firstResultText.Contains("Mahammad Mustafayev - Software Developer"))
                //{
                //    firstResult.Click();
                //}
                //else
                //{
                //    Console.WriteLine("Hedef metin bulunamadı.");
                //}
                System.Threading.Thread.Sleep(5000);

                // Close the browser
                driver.Close();

                //Console.ReadKey();
            }
            Console.WriteLine("Test passed");
        }
    }
}
