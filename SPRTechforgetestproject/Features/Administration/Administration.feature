Feature: Administration

A short summary of the feature

Scenario Outline: Tc_01 verify that user can Administration

	Given user navigate to logs page
	When user click on Administration
	And user click on User Management
	And user click on Adduser
	And user fill with details "<Fullname>" "<Email>" "<Role>" "<Accesmodule>"
	Then user should be added saveuser successfully
	Examples: 
	| Fullname | Email                 | Role  | Accesmodule                               |
	| Gudari   | Gudari.qa@gmail.com  | Staff | Finance (Transactions, Accounts, Reports) |