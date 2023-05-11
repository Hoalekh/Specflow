using FrameworkPlaywright.page;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkPlaywright.Pages
{
    public class DocsPage : BasePage
    {
        public DocsPage(IPage page) : base(page)
        {

        }
        public static string SearchBar => "//input[@id='docsearch-input']";
        public static string SearchBtn => "//span[@class='DocSearch-Button-Container']";
       
        public static string APIlnk => "//a[text()='API']";
        public static string Docslnk => "//a[text()='Docs']";
        public static string Languagelnk => "//div[@class='navbar__item dropdown dropdown--hoverable']";
        public static string LanguageNETlnk => "//ul[@class='dropdown__menu']//a[text()='.NET']";
        public static string Installationtxt => "//h1";
        public static string AddExamplelnk => "//ul//a[@href='#add-example-tests']";
        public static string RunExamplelnk => "//ul//a[@href='#running-the-example-tests']";
        public static string WhatsNextlnk => "//ul//a[@href='#whats-next']";
        public static string AddExampletxt => "//h2[@id='add-example-tests']";
        public static string RunExampletxt => "//h2[@id='running-the-example-tests']";
        public static string WhatsNexttxt => "//h2[@id='whats-next']";

        public static string Assertiontxt => "h1";
      
        public async Task ClickToGetStartedBtn()
        {
            await ClickToButtonByLocator(HomePage.GetStartedBtn);
        }
        public async Task ClickToAddExampe()
        {
            await ClickToButtonByLocator(AddExamplelnk);
        }

        public async Task ClickToRunExampe()
        {
            await ClickToButtonByLocator(RunExamplelnk);
        }
        public async Task ClickSearchBtn()
        {
            await ClickToButtonByLocator(SearchBtn);
        }
        public async Task Search(string searchText)
        {

            await InputTextByLocator(SearchBar, searchText);
            await PressEnterButton(SearchBar);
        }

    }
}
