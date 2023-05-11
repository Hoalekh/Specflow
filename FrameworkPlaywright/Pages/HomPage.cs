using FrameworkPlaywright.page;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkPlaywright.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IPage page) : base(page)
        {

        }
        public static string SearchBar => "//input[@id='docsearch-input']";
        public static string SearchBtn => "//span[@class='DocSearch-Button-Container']";
        public static string GetStartedBtn => "//a[text()='Get started']";
        public static string PlaywrightLogo => "//div[@class='navbar__logo']";
        public static string GitHubLogo => "//a[@aria-label='GitHub repository']";
        public static string Communitylnk => "//a[text()='Community']";

        public static string APIlnk => "//a[text()='API']";
        public static string Docslnk => "//a[text()='Docs']";
        public static string Languagelnk => "//div[@class='navbar__item dropdown dropdown--hoverable']";
        public static string LanguageNETlnk => "//ul[@class='dropdown__menu']//a[text()='.NET']";
        public async Task NavigatePlaywrightPage(string url)
        {
            await NavigatePage(url);
            await CheckTitleAsync(url);

        }


        public async Task LoadPageSuccess()
        {
            await IsElementVisible(PlaywrightLogo);
            await IsElementVisible(GitHubLogo);
            await IsElementVisible(Communitylnk);
            await IsElementVisible(APIlnk);
            await IsElementVisible(Docslnk);

        }

        public async Task ChooseLanguage(string language)
        {

            await MoveToElement(Languagelnk);
            await ClickToButtonByLocator(Languagelnk);
        }

    }
}
