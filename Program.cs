using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main()
    {
        // Set the path to the ChromeDriver executable
        string chromeDriverPath = @"D:\AAA___RIJU\Projects -CS -CSE\AyuShi C#\proj\chromedriver-win64\chromedriver.exe";

        // Create a ChromeDriver instance
        IWebDriver driver = new ChromeDriver(chromeDriverPath);

        try
        {
            // Your Selenium code here
            // driver.Navigate().GoToUrl("https://programmerac.blogspot.com/");
            driver.Navigate().GoToUrl("https://finance.yahoo.com/quote/AAPL/");
            Console.WriteLine("Page Title: " + driver.Title);
            
            // Find the table element using its XPath or other selector
            IWebElement table = driver.FindElement(By.XPath("//table"));

            // Get all rows from the table
            var rows = table.FindElements(By.TagName("tr"));

            // Iterate through rows and extract data
            foreach (var row in rows)
            {
                var columns = row.FindElements(By.TagName("td"));

                foreach (var column in columns)
                {
                    // Extract and print cell text
                    Console.Write(column.Text + "\t");
                }

                Console.WriteLine(); // Move to the next row in the console
            }
        }
        finally
        {
            // Close the browser window
            driver.Quit();
        }
    }
}
