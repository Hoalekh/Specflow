Feature: HomePage

A short summary of the feature


@positive
Scenario: validate the Home page
	Given I navigate to 'https://playwright.dev/dotnet/'
	Then I wait load page state
	And I choose language '.NET'
	Then I validate Get started button

