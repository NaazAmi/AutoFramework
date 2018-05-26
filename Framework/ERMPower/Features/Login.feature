Feature: Login
	Verify the login functionality with different combination
	of data


Scenario: Check login with valid username and password
	Given I have navigate to the application
	And I see application opened
	Then I click Login link
	When I enter UserName and Password and uncheck Remember password
	| UserName  | Password    |
	| testingQA | testing1234 |
	Then I click login button
	Then Verify User Logged in
	Then I should be able to logout 
