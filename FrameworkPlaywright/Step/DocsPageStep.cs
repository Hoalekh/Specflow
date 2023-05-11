using FrameworkPlaywright.Drivers;
using FrameworkPlaywright.Pages;
using Microsoft.Playwright;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace FrameworkPlaywright.Step
{
    [Binding]
    public class DocsPageStep
    {
        private readonly DocsPage docsPage = null;

        public DocsPageStep(Driver driver)
        {
            this.docsPage = new DocsPage(driver.Page);


        }
        

        [Then(@"I click to Get started button")]
        public async Task ThenIClickToGetStartedButton()
        {
            await docsPage.ClickToGetStartedBtn();
        }

        [Then(@"I validate '([^']*)' page")]
        public async void ThenIValidatePage(string installation)
        {
            Assert.AreEqual(await docsPage.GetText(DocsPage.Installationtxt), installation);
        }

        [Then(@"I validate menu Add Example Tests, Running the Example Tests, What's Next")]
        public async Task ThenIValidateMenuAddExampleTestsRunningTheExampleTestsWhatsNext()
        {
            Assert.IsTrue(await docsPage.IsElementVisible(DocsPage.AddExamplelnk));
            Assert.IsTrue(await docsPage.IsElementVisible(DocsPage.RunExamplelnk));
            Assert.IsTrue(await docsPage.IsElementVisible(DocsPage.WhatsNextlnk));
        }

        [Then(@"I click to Add Example Tests")]
        public async Task ThenIClickToAddExampleTests()
        {
            await docsPage.ClickToAddExampe();
        }

        [Then(@"I validate page scroll to Add Example Tests")]
        public async Task ThenIValidatePageScrollToAddExampleTests()
        {
            Assert.IsTrue(await docsPage.IsElementVisible(DocsPage.AddExampletxt));
        }


        [Then(@"I click to Running the Example Tests")]
        public async Task ThenIClickToRunningTheExampleTests()
        {
            await docsPage.ClickToRunExampe();
            //   
        }


        [Then(@"I validate page scroll to Running the Example Tests")]
        public async Task ThenIValidatePageScrollToRunningTheExampleTests()
        {
            Assert.IsTrue(await docsPage.IsElementVisible(DocsPage.RunExampletxt));
        }

        [Then(@"I click to Search button")]
        public async Task ThenIClickToSearchButton()
        {
            await docsPage.ClickSearchBtn();

        }
        [Then(@"I enter '([^']*)' in search box")]
        public async Task ThenIEnterInSearchBox(string assertion)
        {
            await docsPage.Search(assertion);
        }

        [Then(@"I validate search correct: '([^']*)'")]
        public async Task ThenIValidateSearchCorrect(string assertion)
        {
            Assert.AreEqual(await docsPage.GetText(DocsPage.Assertiontxt), assertion);
        }


    }
}
