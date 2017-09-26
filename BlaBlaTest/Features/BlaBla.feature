Feature: BlaBla
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers
@mytag
Scenario: Authorization
Given User profile is visible

@mytag
Scenario: Serarch (unauthorized)
	Given I fill search field
	 | From | Destinatiom | DaysFromNow |
	 | Kiev | Fastov      |      0      |

@tag
Scenario: Repeat action every day for current week
Given Click user profile every day for current week


