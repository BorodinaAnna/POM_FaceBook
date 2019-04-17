using System;
using ConsoleApp1.MyAccountPOM;
using Should;
using TechTalk.SpecFlow;

namespace MyAccount
{
    [Binding]
    public class RegistrationPageSteps : RegistrationPage
    {
        [Given(@"Registration page is opened")]
        public void GivenRegistrationPageIsOpened()
        {
            OpenRegistrationPage();
        }

        [Given(@"Registration is completed with email '(.*)'")]
        public void GivenRegistrationIsCompletedWithEmail(string email)
        {
            if (email == "unique email")
            {
                email = $"{DateTime.Now:ddMMMyyyyHHmmssf}@test.test";
            }

            ScenarioContext.Current["existedEmail"] = email;

            OpenRegistrationPage().FillEmailField(email).FillPasswordField("123qwe").ClickSubmitButton();
        }

        [When(@"I try to register with exist email")]
        public void WhenITryToRegisterWithExistEmail()
        {
            var existedEmail = (string)ScenarioContext.Current["existedEmail"];

            RefreshPage();
            OpenRegistrationPage().FillEmailField(existedEmail).FillPasswordField("123qwe")
               .ClickSubmitButton();
        }

        [When(@"I input '(.*)' in email field")]
        public void WhenIInputInEmailField(string email)
        {
            if (email == "unique email")
            {
                email = $"{DateTime.Now:ddMMMyyyyHHmmssf}@test.test";
            }

            FillEmailField(email);
        }
        
        [When(@"I input '(.*)' in password field")]
        public void WhenIInputInPasswordField(string password)
        {
            FillPasswordField(password);
        }
        
        [When(@"I input '(.*)' in confirm field")]
      

        [When(@"I click on Submit button")]
        public void WhenIClickOnSubmitButton()
        {
            ClickSubmitButton();
        }

        [Then(@"Visibility of SignOut link is '(.*)'")]
        public void ThenSignOutLinkIsDisplayed(bool visibility)
        {
            var res = new MyAccountPage().IsSignOutLinkVisible();
            res.ShouldEqual(visibility);
        }

        [Then(@"Error message for confirm field is equals '(.*)'")]
     

        [Then(@"Error message for email field is equals '(.*)'")]
        public void ThenErrorMessageForEmailFieldIsEquals(string errorMessage)
        {
            GetErrorForEmail().ShouldEqual(errorMessage);
        }

        [Then(@"Error message is equals '(.*)'")]
        public void ThenErrorMessageIsEquals(string errorMessage)
        {
            GetErrorMessage().ShouldEqual(errorMessage);
        }
    }
}
