using FrameworkPlaywright.Drivers;
using FrameworkPlaywright.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkPlaywright.Step
{
    [Binding]
    public class HomePageStep
    {
        private readonly HomePage homePage = null;
        public HomePageStep(Driver driver)
        {
            this.homePage = new HomePage(driver.Page);


        }

        [Given(@"I navigate to '([^']*)'")]
        public async Task GivenINavigateTo(string p0)
        {
            await homePage.NavigatePage(p0);
        }

        [Then(@"I wait load page state")]
        public async Task ThenIWaitLoadPageState()
        {
            await homePage.LoadPageSuccess();
        }

        [Then(@"I choose language '([^']*)'")]
        public async void ThenIChooseLanguage(string p0)
        {
            await homePage.ChooseLanguage(p0);

        }

        [Then(@"I validate Get started button")]
        public async Task ThenIValidateGetStartedButton()
        {
            Assert.IsTrue(await homePage.IsElementVisible(HomePage.GetStartedBtn));
        }


    }
}
