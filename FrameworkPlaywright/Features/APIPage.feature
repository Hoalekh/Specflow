Feature: APIPage

A short summary of the feature

Feature: AnimatedGiftCardsCartTotalAmountValidation
Simple test cases for validation of total amount value

Background:
	Given I navigate to 'https://playwright.dev/dotnet/'
	Then I wait load page state
	And I choose language '.NET'
	Then I click to API page

@positive
Scenario: validate the left menu
	Then I validate 'Playwright' tab
	And I validate left menu: API reference,... Assertions

@positive
Scenario: validate the Playwright
	Then I validate 'Playwright' tab
	And I validate menu Properties: APIRequest, Chromium, Devices,Firefox, Selectors, Webkit
	Then I click to APIRequest
	And I validate page scroll 'APIRequest'
	Then I click to Chromium
	And I validate page scroll to 'Chromium'
	


