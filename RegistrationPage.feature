Feature: RegistrationPage
	In order to use Facebook application
	As a potential Facebook user
	I want to register trading account through Registration page

Scenario: Successful registration
	Given Registration page is opened
	When I input 'Anna' in FirstName field
	And I input 'Borodina' in LastName field
	And I input 'unique email' in email field
	And I input '123qwe' in password field
	And I click on Gender button
	And I choose bithday data
	And I click on Registration button
	Then Visibility of SignOut link is 'true'

Scenario: Validation of email field
	Given Registration page is opened
	When I input 'Anna' in FirstName field
	And I input 'Borodina' in LastName field
	And I input 'qwerty@' in email field
	And I input '123qwe' in password field
	And I click on Gender button
	And I choose bithday data
	And I click on Registration button
	Then Error message for email field is equals 'Email is invalid'

Scenario: Impossibility to registration with exist email
	Given Registration is completed with email 'unique email'
	When I try to register with exist email
	Then Error message is equals 'User with this email is already registered.'
	
