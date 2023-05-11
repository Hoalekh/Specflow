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
    public class APIPageStep
    {
        private readonly APIPage apiPage = null;
        public APIPageStep(Driver driver)
        {
            this.apiPage = new APIPage(driver.Page);


        }
        [Then(@"I click to API page")]
        public async Task ThenIClickToAPIPage()
        {
            await apiPage.ClickToAPIlnk();
        }

        [Then(@"I validate '([^']*)' tab")]
        public async Task ThenIValidateTab(string playwright)
        {
            Assert.AreEqual(await apiPage.GetText(APIPage.Playwrighttxt), playwright);
        }

        [Then(@"I validate left menu: API reference,\.\.\. Assertions")]
        public async Task ThenIValidateLeftMenuAPIReferenceAssertions()
        {
            Assert.IsTrue(await apiPage.IsElementVisible(APIPage.APIReferenceMenu));
            Assert.IsTrue(await apiPage.IsElementVisible(APIPage.AssertionsMenu));
            Assert.IsTrue(await apiPage.IsElementVisible(APIPage.PlaywrighMenu));
            Assert.IsTrue(await apiPage.IsElementVisible(APIPage.ClassesMenu));
        }

       

        [Then(@"I validate menu Properties: APIRequest, Chromium, Devices,Firefox, Selectors, Webkit")]
        public async Task ThenIValidateMenuPropertiesAPIRequestChromiumDevicesFirefoxSelectorsWebkit()
        {
            Assert.IsTrue(await apiPage.IsElementVisible(APIPage.Propertieslnk));
            Assert.IsTrue(await apiPage.IsElementVisible(APIPage.APIRequestlnk));
            Assert.IsTrue(await apiPage.IsElementVisible(APIPage.Chromiumlnk));
            Assert.IsTrue(await apiPage.IsElementVisible(APIPage.Deviceslnk));
            Assert.IsTrue(await apiPage.IsElementVisible(APIPage.Firefoxlnk));
            Assert.IsTrue(await apiPage.IsElementVisible(APIPage.Selectorslnk));
            Assert.IsTrue(await apiPage.IsElementVisible(APIPage.Webkitlnk));

        }

        [Then(@"I click to APIRequest")]
        public async Task ThenIClickToAPIRequest()
        {
           await apiPage.ClickToAPIRequestlnk();
        }

        [Then(@"I validate page scroll '([^']*)'")]
        public async Task ThenIValidatePageScroll(string aPIRequest)
        {
            Assert.IsTrue(await apiPage.IsContainText(APIPage.APIRequesttxt,aPIRequest));
        }


        [Then(@"I click to Chromium")]
        public async Task ThenIClickToChromium()
        {
            await apiPage.ClickToChromiumlnk();
        }

       
       
        [Then(@"I validate page scroll to '([^']*)'")]
        public async Task ThenIValidatePageScrollTo(string chromium)
        {
            Assert.IsTrue(await apiPage.IsContainText(APIPage.Chromiumtxt, chromium));
        }


    }
}
