Feature: BlaBla
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Serarch (unauthorized)
	Given I fill search field
	 | From | Destinatiom | DaysFromNow |
	 | Kiev | Fastov      |      0      |

@mytag
Scenario: Authorization
Given User profile is visible

@tag
Scenario: Logout


