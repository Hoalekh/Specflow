Feature: DocsPage

A short summary of the feature

Feature: AnimatedGiftCardsCartTotalAmountValidation
Simple test cases for validation of total amount value

Background:
	Given I navigate to 'https://playwright.dev/dotnet/'
	Then I wait load page state
	And I choose language '.NET'
	Then I click to Get started button

@positive
Scenario: validate the Installation page
	Then I validate 'Installation' page
	And I validate menu Add Example Tests, Running the Example Tests, What's Next
	Then I click to Add Example Tests
	And I validate page scroll to Add Example Tests
	Then I click to Running the Example Tests
	And I validate page scroll to Running the Example Tests
	
@positive
Scenario: validate search box
	Then I click to Search button
	And I enter 'Assertions' in search box
	Then I validate search correct: 'Assertions'

