Feature: MultiplyingByDecimal
	As a programmer 
	I want to multiply the Coin object by some decimal value 
	so that I can multiply the amount of stored money

Scenario: Multiplication operator
	Given I have the Coin object Coin with currency C
	And I have some decimal value D
	When I multiply Coin by D using Multiplication operator
	Then the result is a newly created Coin object
	And its currency is set to C
	And its value is the result of the multiplication

Scenario: Multiplication Assignment operator
	Given I have the Coin object Coin with currency C
	And I have some decimal value D
	When I multiply Coin by D using Multiplication Assignment operator
	Then the value of the Coin object is a result of multiplying the old value by the D

Scenario: Multiplication method
	Given I have the Coin object Coin with currency C
	And I have some decimal value D
	When I multiply Coin by D using Multiplication method
	Then the result is a newly created Coin object
	And its currency is set to C
	And its value is the result of the multiplication

Scenario: Multiplication Assignment method
	Given I have the Coin object Coin with currency C
	And I have some decimal value D
	When I multiply Coin by D using Multiplication Assignment method
	Then the value of the Coin object is a result of multiplying the old value by the D
