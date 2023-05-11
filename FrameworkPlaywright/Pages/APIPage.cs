using FrameworkPlaywright.page;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkPlaywright.Pages
{
    public class APIPage : BasePage
    {
        public APIPage(IPage page) : base(page)
        {
        }
        public static string APIlnk => "//a[text()='API']";
        public static string Playwrighttxt = "//h1";
        public static string APIReferenceMenu = "//a[text()='API reference']";
        public static string PlaywrighMenu = "//a[text()='Playwright']";
        public static string ClassesMenu = "//a[text()='Classes']";
        public static string AssertionsMenu = "//a[text()='Assertions']";

        public static string APIRequestlnk = "//ul//a[@href='#playwright-request']";
        public static string Propertieslnk = "//ul//a[@href='#properties']";
        public static string Chromiumlnk = "//ul//a[@href='#playwright-chromium']";
        public static string Deviceslnk = "//a[text()='Devices']";
        public static string Firefoxlnk = "//a[text()='Firefox']";
        public static string Selectorslnk = "//a[text()='Selectors']";
        public static string Webkitlnk = "//a[text()='Webkit']";

        public static string APIRequesttxt => "//h3[@id='playwright-request']";
        public static string Chromiumtxt => "//h3[@id='playwright-chromium']";
        public async Task ClickToAPIlnk()
        {
            await ClickToButtonByLocator(APIlnk);
        }
        public async Task ClickToAPIRequestlnk()
        {
            await ClickToButtonByLocator(APIRequestlnk);
        }

        public async Task ClickToChromiumlnk()
        {
            await ClickToButtonByLocator(Chromiumlnk);
        }
    }

}
