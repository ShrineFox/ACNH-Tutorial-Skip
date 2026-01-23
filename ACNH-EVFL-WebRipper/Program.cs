using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ACNH_EVFL_WebRipper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            foreach (var fileName in File.ReadAllLines("evflFiles.txt"))
            {
                if (File.Exists(fileName))
                    continue;

                string url = "https://acnh.isomorphicbox.com/evfl/3.0.0/" + fileName + ".txt";


                try
                {
                    var options = new ChromeOptions();

                    // Run completely headless (no window)
                    options.AddArgument("--headless=new");
                    options.AddArgument("--disable-gpu");
                    options.AddArgument("--window-size=1920,1080");

                    // Optional but helpful for stability
                    options.AddArgument("--no-sandbox");
                    options.AddArgument("--disable-dev-shm-usage");

                    using (IWebDriver driver = new ChromeDriver(options))
                    {
                        driver.Navigate().GoToUrl(url);

                        // Create a WebDriverWait instance with a timeout (e.g., 30 seconds)
                        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                        string html = driver.PageSource
                            .Replace("<html><head><meta name=\"color-scheme\" content=\"light dark\"></head><body><pre " +
                                "style=\"word-wrap: break-word; white-space: pre-wrap;\">","")
                            .Replace("\r\n\r\n</pre></body></html>","");

                        File.WriteAllText(fileName, html);
                        Console.WriteLine(fileName);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
            */

            foreach(var evfl in Directory.GetFiles("D:\\GitHub\\ShrineFox\\ACNH-Tutorial-Skip\\Decompiled"))
            {
                string txt = File.ReadAllText(evfl);
                txt = txt.Replace("    ", "\t").Replace("&lt;","<").Replace("&gt;",">");
                File.WriteAllText(evfl, txt);
            }
        }
    }
}
