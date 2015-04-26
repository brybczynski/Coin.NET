Feature: ChangingValue
	As a programmer 
	I want to change value of a Coin object, 
	so that I am able to store different amoun of money in this same object

Scenario: Changing Value
Given I have created a Coin object
When I assign a new value to the Value property
Then it's value is changed to provided one
