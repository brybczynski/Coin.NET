Feature: ComparingCoins
	As a programmer 
	I want to be able to compare two different Coin objects, 
	so that I can indicate whether Coins are different or equal

Scenario: Coins are equal - CompareTo method
	Given I have the Coin object Coin1
	And I have the Coin object Coin2
	And values of Coin1 and Coin2 are equal
	And currencies of Coin1 and Coin2 are the same
	When I compare Coin1 with Coin2 using CompareTo method
	Then the comparison result is 0

Scenario: Coin1 is greater than Coin2 - CompareTo method
	Given I have the Coin object Coin1
	And I have the Coin object Coin2
	And value of Coin1 is greater than value of Coin2
	And currencies of Coin1 and Coin2 are the same
	When I compare Coin1 with Coin2 using CompareTo method
	Then the comparison result is greater than 0

Scenario: Coin1 is lesser than Coin2 - CompareTo method
	Given I have the Coin object Coin1
	And I have the Coin object Coin2
	And value of Coin1 is lesser than value of Coin2
	And currencies of Coin1 and Coin2 are the same
	When I compare Coin1 with Coin2 using CompareTo method
	Then the comparison result is lesser than 0

Scenario: Comparing the same object - CompareTo method
	Given I have the Coin object Coin with currency C
	When I compare Coin with Coin using CompareTo method
	Then the comparison result is 0

Scenario: Coins are equal - static Compare method
	Given I have the Coin object Coin1
	And I have the Coin object Coin2
	And values of Coin1 and Coin2 are equal
	And currencies of Coin1 and Coin2 are the same
	When I compare Coin1 with Coin2 using static Compare method
	Then the comparison result is 0

Scenario: Coin1 is greater than Coin2 - static Compare method
	Given I have the Coin object Coin1
	And I have the Coin object Coin2
	And value of Coin1 is greater than value of Coin2
	And currencies of Coin1 and Coin2 are the same
	When I compare Coin1 with Coin2 using static Compare method
	Then the comparison result is greater than 0

Scenario: Coin1 is lesser than Coin2 - static Compare method
	Given I have the Coin object Coin1
	And I have the Coin object Coin2
	And value of Coin1 is lesser than value of Coin2
	And currencies of Coin1 and Coin2 are the same
	When I compare Coin1 with Coin2 using static Compare method
	Then the comparison result is lesser than 0

Scenario: Comparing the same object - static Compare method
	Given I have the Coin object Coin with currency C
	When I compare Coin with Coin using static Compare method
	Then the comparison result is 0
