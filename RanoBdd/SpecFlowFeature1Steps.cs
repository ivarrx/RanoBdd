using System;
using TechTalk.SpecFlow;

namespace RanoBdd
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "www.eksisozluk.com");

        }
        
        [Given(@"I have navigated eksisozluk login page")]
        public void GivenIHaveNavigatedEksisozlukLoginPage()
        {
            Ranorex.WebDocument webDocument = "/dom[@domain='eksisozluk.com']";
            Ranorex.ATag login = webDocument.FindSingle(".//a[#'top-login-link']");
            login.Click();
        }
        [Given(@"I have entered my credentials")]
        public void GivenIHaveEnteredMyCredentials()
        {
            Ranorex.WebDocument webDocument = "/dom[@domain='eksisozluk.com']";
            Ranorex.InputTag userName = webDocument.FindSingle(".///input[#'username']");
            userName.PressKeys("ulassoyubey");
            Ranorex.InputTag password = webDocument.FindSingle(".///input[#'password']");
            password.PressKeys("1234567");

        }
        
        [When(@"I press login")]
        public void WhenIPressLogin()
        {
            Ranorex.WebDocument webDocument = "/dom[@domain='eksisozluk.com']";
            Ranorex.ButtonTag login = webDocument.FindSingle(".//div[#'login-form-container']/form[@action='https://eksisozluk.com/giris']//button[@innertext='giriş yapmaya çabala']");
            login.Click();
        }
        
        [Then(@"I need to be succesfully logged")]
        public void ThenINeedToBeSuccesfullyLogged()
        {
            Ranorex.WebDocument webDocument = "/dom[@domain='eksisozluk.com']";
            Ranorex.SpanTag errorMessage = webDocument.FindSingle(".///div[#'login-form-container']/?/?/span[]");
        }
     

    }
}
