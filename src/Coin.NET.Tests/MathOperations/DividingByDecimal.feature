Feature: DividingByDecimal
	As a programmer 
	I want to divide the Coin object by some decimal value 
	so that I can divide the amount of stored money

Scenario: Division operator
	Given I have the Coin object Coin with currency C
	And I have some decimal value D
	When I divide Coin by D using Division operator
	Then the result is a newly created Coin object
	And its currency is set to C
	And its value is the result of the division

Scenario: Division Assignment operator
	Given I have the Coin object Coin with currency C
	And I have some decimal value D
	When I divide Coin by D using Division Assignment operator
	Then the value of the Coin object is a result of dividing the old value by the D

Scenario: Division method
	Given I have the Coin object Coin with currency C
	And I have some decimal value D
	When I divide Coin by D using Division method
	Then the result is a newly created Coin object
	And its currency is set to C
	And its value is the result of the division

Scenario: Division Assignment method
	Given I have the Coin object Coin with currency C
	And I have some decimal value D
	When I divide Coin by D using Division Assignment method
	Then the value of the Coin object is a result of dividing the old value by the D
