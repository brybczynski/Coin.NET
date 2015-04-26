using System;
using TechTalk.SpecFlow;

namespace Coin.NET.Tests.MathOperations
{
    [Binding]
    public class AddingCoinsSteps
    {
        [Given]
        public void GivenIHaveTheCoinObjectCoin1WithCurrencyC()
        {
            ScenarioContext.Current.Pending();
        }

        [Given]
        public void GivenIHaveTheCoinObjectCoin2WithCurrencyC()
        {
            ScenarioContext.Current.Pending();
        }

        [When]
        public void WhenIAddCoin1AndCoin2UsingAdditionOperator()
        {
            ScenarioContext.Current.Pending();
        }

        [When]
        public void WhenIAddCoin1ToCoin2UsingAdditionAssignmentOperator()
        {
            ScenarioContext.Current.Pending();
        }

        [When]
        public void WhenIAddCoin1AndCoin2UsingAdditionMethod()
        {
            ScenarioContext.Current.Pending();
        }

        [When]
        public void WhenIAddCoin1ToCoin2UsingAdditionAssignmentMethod()
        {
            ScenarioContext.Current.Pending();
        }

        [Then]
        public void ThenTheResultIsANewlyCreatedCoinObject()
        {
            ScenarioContext.Current.Pending();
        }

        [Then]
        public void ThenItsCurrencyIsSetToC()
        {
            ScenarioContext.Current.Pending();
        }

        [Then]
        public void ThenItsValueIsASumOfCoin1ValueAndCoin2Value()
        {
            ScenarioContext.Current.Pending();
        }

        [Then]
        public void ThenTheValueOfCoin1IsASumOfCoin1OldValueAndCoin2Value()
        {
            ScenarioContext.Current.Pending();
        }
    }
}