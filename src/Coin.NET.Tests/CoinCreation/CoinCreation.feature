Feature: CoinCreation
	As a programmer 
	I want to create a new Coin object 
	so that I can have a representation of some money

Scenario: Default Constructor 
	Given I am a programmer
	When I create a Coin object using a constructor without any arguments
	Then new Coin object is created
	And it's value is set to zero
	And it's default currency is set to dollars

Scenario: Construct with value
	Given I am a programmer
	When I create a Coin object using a constructor with decimal value
	Then new Coin object is created
	And it's value is set to provided value

Scenario: Construct with CultureInfo
	Given I am a programmer
	When I create a Coin object using a constructor with cultureinfo
	Then new Coin object is created
	And it's default currency is set to corresponding the provided cultureinfo

Scenario: Construct with currency
	Given I am a programmer
	When I create a Coin object using a constructor with specific currency
	Then new Coin object is created
	And it's default currency is set to provided value
