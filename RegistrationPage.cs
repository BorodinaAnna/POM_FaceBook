using OpenQA.Selenium;

namespace MyAccount
{
    public class RegistrationPage : SeleniumWrapper
    {
        internal static By FirstName = By.Name("firstname");
        internal static By LastName = By.Name("lastname");
        internal static By EmailField = By.Name("reg_email__");
        internal static By PasswordField = By.Name("reg_passwd__");
        internal static By FemaleBtn = By.Id("u_0_6");
        internal static By BthDay = By.Id("day");
        internal static By BthMonth = By.Id("month");
        internal static By BthYear = By.Id("year");
        internal static By BtnSubmit = By.Id("u_0_15");
        internal static By ErrorMessage = By.CssSelector("div.alert.alert-danger");

        /// <summary>
        /// This method open Registration page of MyAccount.
        /// </summary>
        /// <returns></returns>
        public RegistrationPage OpenRegistrationPage()
        {
            OpenPage("https://www.facebook.com/");
            return this;
        }
        public RegistrationPage FillFirstNameField(string firstname)
        {
            FindElement(FirstName).SendKeys(firstname);
            return this;
        }

        public RegistrationPage FillLastField(string lastname)
        {
            FindElement(LastName).SendKeys(lastname);
            return this;
        }

        /// <summary>
        /// This method fill text in Email field.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public RegistrationPage FillEmailField(string email)
        {
            FindElement(EmailField).SendKeys(email);
            return this;
        }

        /// <summary>
        /// This method fill text in Password field.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public RegistrationPage FillPasswordField(string password)
        {
            FindElement(PasswordField).SendKeys(password);
            return this;
        }
        /// <summary>
        /// This method choose female.
        /// </summary>
        /// <returns></returns>
        public RegistrationPage GenderBtn(bool female)
        {
            FindElement(FemaleBtn);
            return this;
        }
        /// <summary>
        /// This method choose day of bithday.
        /// </summary>
        /// <returns></returns>
        public RegistrationPage ChooseBthDay(int day)
        {
            FindElement(BthDay);
            return this;
        }
        /// <summary>
        /// This method choose month of bithday.
        /// </summary>
        /// <returns></returns>
        public RegistrationPage ChooseBthMonth(string month)
        {
            FindElement(BthMonth).SendKeys(month);
            return this;
        }
        /// <summary>
        /// This method choose year of bithday.
        /// </summary>
        /// <returns></returns>
        public RegistrationPage ChooseBthYear(int year)
        {
            FindElement(BthYear);
            return this;
        }
        /// <summary>
        /// This method click on button Submit.
        /// </summary>
        /// <returns></returns>
        public RegistrationPage ClickSubmitButton()
        {
            FindElement(BtnSubmit).Click();
            return this;
        }

        /// <summary>
        /// Get error text for email field.
        /// </summary>
        /// <returns></returns>
        public string GetErrorForEmail()
        {
            return GetErrorForField(FindElement(EmailField));
        }

        /// <summary>
        /// Get error text for password field.
        /// </summary>
        /// <returns></returns>
        public string GetErrorForPassword()
        {
            return GetErrorForField(FindElement(PasswordField));
        }


        /// <summary>
        /// Get error for trying to register with existed in DB email
        /// </summary>
        /// <returns></returns>
        public string GetErrorMessage()
        {
            return FindElement(ErrorMessage).Text;
        }
    }
}
