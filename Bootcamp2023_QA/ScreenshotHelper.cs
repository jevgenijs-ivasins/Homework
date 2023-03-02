using OpenQA.Selenium;

public static class ScreenshotHelper
{
    public static void TakeAndSaveScreenshot(IWebDriver driver)
    {
        string fileName = $"screenshot-{TestContext.CurrentContext.Test.MethodName}.png";
        string startupPath = Directory.GetCurrentDirectory();
        var folderPath = Path.Combine(startupPath, "Screenshots");
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }
        var fullPath = Path.Combine(folderPath, fileName);
        ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(fullPath, ScreenshotImageFormat.Png);
        TestContext.AddTestAttachment(fullPath);
    }
}