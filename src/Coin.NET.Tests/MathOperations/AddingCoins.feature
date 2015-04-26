Feature: AddingCoins
	As a programmer 
	I want to add two Coin objects 
	so that I can perform basic math operations

Scenario: Addition operator
Given I have the Coin object Coin1 with currency C
And I have the Coin object Coin2 with currency C
When I add Coin1 and Coin2 using Addition Operator
Then the result is a newly created Coin object
And its currency is set to C
And its value is a sum of Coin1 value and Coin2 value

Scenario: Addition Assignment operator
Given I have the Coin object Coin1 with currency C
And I have the Coin object Coin2 with currency C
When I add Coin1 to Coin2 using Addition Assignment Operator
Then the value of Coin1 is a sum of Coin1 old value and Coin2 value

Scenario: Addition method
Given I have the Coin object Coin1 with currency C
And I have the Coin object Coin2 with currency C
When I add Coin1 and Coin2 using Addition Method
Then the result is a newly created Coin object
And its currency is set to C
And its value is a sum of Coin1 value and Coin2 value

Scenario: Addition Assignment method
Given I have the Coin object Coin1 with currency C
And I have the Coin object Coin2 with currency C
When I add Coin1 to Coin2 using Addition Assignment Method
Then the value of Coin1 is a sum of Coin1 old value and Coin2 value