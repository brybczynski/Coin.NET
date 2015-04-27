Feature: SubtrackingCoins
	As a programmer 
	I want to subtract two Coin objects 
	so that I can perform basic math operations

Scenario: Subtraction operator
	Given I have the Coin object Coin1 with currency C
	And I have the Coin object Coin2 with currency C
	When I subtact Coin2 from Coin1 using Subtraction Operator
	Then the result is a newly created Coin object
	And its currency is set to C
	And its value is a difference between Coin1 value and Coin2 value

Scenario: Subtraction Assignment operator
	Given I have the Coin object Coin1 with currency C
	And I have the Coin object Coin2 with currency C
	When I subtact Coin2 from Coin1 using Subtraction Assignment Operator
	Then the value of Coin1 is a difference between Coin1 old value and Coin2 value

Scenario: Subtaction method
	Given I have the Coin object Coin1 with currency C
	And I have the Coin object Coin2 with currency C
	When I subtact Coin2 from Coin1 using Subtraction Method
	Then the result is a newly created Coin object
	And its currency is set to C
	And its value is a difference between Coin1 value and Coin2 value

Scenario: Subtaction Assignment method
	Given I have the Coin object Coin1 with currency C
	And I have the Coin object Coin2 with currency C
	When I subtact Coin2 from Coin1 using Subtraction Assignment Method
	Then the value of Coin1 is a difference between Coin1 old value and Coin2 value
