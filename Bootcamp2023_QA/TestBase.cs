using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp2023_QA
{
    public class TestBase : Driver
    {
        public void SetupDB()
        {
            string source = Path.Combine(Directory.GetCurrentDirectory(), "db.json");
            string destination = "C:\\Users\\jevgenijs.ivasins\\Bootcamp\\ReactBootcampRepo\\api\\db.json";
            File.Copy(source, destination, true);
        }

        [SetUp]
        public void Setup()
        {
            SetupDB();
            WebDriver = new ChromeDriver();
            WebDriver.Navigate().GoToUrl("http://localhost:3000/");
        }

        [TearDown]
        public void TearDown()
        {
            WebDriver.Quit();
        }
    }
}
