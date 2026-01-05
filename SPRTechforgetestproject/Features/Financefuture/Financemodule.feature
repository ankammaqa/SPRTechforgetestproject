#Feature: Financemodule
#
#user verify the Finance Module
#
#@SmokeTest
#Scenario Outline: verify that user can access Finance module
#	Given user navigate to login page
#	When user click on Finance module
#	And user click on NewEntry
#	And user click on income
#	And user Enter on income Fields
#	And user save the income entry
#	Then user should be able to access Finance module successfully
#@SmokeTest
#Scenario Outline: verify that user can click expense page
#	Given user navigate to login page
#	When user click on Finance module
#	And user click on NewEntry
#	And user click on expense module
#	And user click on expense
#	And user save the expense entry
#	Then user should be save  expense page successfully
#@SmokeTest
#Scenario Outline: verify that user can click Transfer page
#	Given user navigate to login page
#	When user click on Finance module
#	And user click on NewEntry
#	And user click on Transfer module
#	And user Enter on Transferdetails
#	And user save the Transferrecord entry
#	Then user should be save  Transfer page successfully
#@SmokeTest
#Scenario Outline: verify that user can click Refund page
#	Given user navigate to login page
#	When user click on Finance module
#	And user click on NewEntry
#	And user click on Refund module
#	And user Enter on Refunddetails
#	And user save the Refundrecord entry
#	Then user should be save  Refund page successfully