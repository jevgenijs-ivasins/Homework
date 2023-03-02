//using FluentAssertions;
//using FluentAssertions.Execution;
//using NUnit.Framework.Interfaces;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support.UI;

//namespace Bootcamp2023_QA
//{
//    public class ProdcutsTests : TestBase
//    {
//        [Test]
//        [TestCase("Product 1", "Condiments", "Unit 2", "18", "New Orleans Cajun Delight")]
//        public void AddProduct(string productName, string category, string unit, string price, string supplier)
//        {
//            WebDriver.FindElement(By.XPath("//button[text()='Add']")).Click();
//            WebDriver.FindElement(By.CssSelector("#productName")).SendKeys(productName);
//            SelectElement dropDownCategory = new SelectElement(WebDriver.FindElement(By.CssSelector("#productCategory")));
//            dropDownCategory.SelectByText(category);
//            WebDriver.FindElement(By.CssSelector("#productUnit")).SendKeys(unit);
//            WebDriver.FindElement(By.CssSelector("#productPrice")).SendKeys(price);
//            SelectElement dropDownSupplier = new SelectElement(WebDriver.FindElement(By.CssSelector("#productSupplier")));
//            dropDownSupplier.SelectByText(supplier);
//            WebDriver.FindElement(By.XPath("//button[text()='Save']")).Click();
//            WebDriver.Navigate().Refresh();

//            List<string> products = WebDriver.FindElements(By.CssSelector("tbody tr")).Select(elem => elem.Text).ToList();

//            using (new AssertionScope())
//            {
//                products.Should().Contain($"{productName}\r\n{category} {unit} {price} {supplier}\r\nDelete");
//                products.Count().Should().Be(4);
//            }
//            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
//            {
//                ScreenshotHelper.TakeAndSaveScreenshot(WebDriver);
//            }

//        }
//    }
//}