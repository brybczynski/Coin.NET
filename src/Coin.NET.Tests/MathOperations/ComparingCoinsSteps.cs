using System;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace Coin.NET.Tests.MathOperations
{
    [Binding]
    public class ComparingCoinsSteps
    {
        [Given]
        public void GivenValuesOfCoin1AndCoin2AreEqual()
        {
            CommonSteps.Coin1.Value = CommonSteps.Coin2.Value = CommonSteps.Value1;
        }

        [Given]
        public void GivenCurrenciesOfCoin1AndCoin2AreTheSame()
        {
            CommonSteps.Coin1.Currency = CommonSteps.Coin2.Currency = CommonSteps.Currency;
        }

        [Given]
        public void GivenValueOfCoin1IsGreaterThanValueOfCoin2()
        {
            CommonSteps.Coin1.Value = CommonSteps.Coin2.Value = CommonSteps.Value1;
            CommonSteps.Coin1.Value += 1000;
        }

        [Given]
        public void GivenValueOfCoin1IsLesserThanValueOfCoin2()
        {
            CommonSteps.Coin1.Value = CommonSteps.Coin2.Value = CommonSteps.Value1;
            CommonSteps.Coin2.Value += 1000;
        }

        [When]
        public void WhenICompareCoin1WithCoin2UsingCompareToMethod()
        {
            CommonSteps.ComparisonResult = CommonSteps.Coin1.CompareTo(CommonSteps.Coin2);
        }

        [When]
        public void WhenICompareCoinWithCoinUsingCompareToMethod()
        {
            CommonSteps.ComparisonResult = CommonSteps.Coin.CompareTo(CommonSteps.Coin);
        }

        [When]
        public void WhenICompareCoin1WithCoin2UsingStaticCompareMethod()
        {
            CommonSteps.ComparisonResult = Coin.Compare(CommonSteps.Coin1, CommonSteps.Coin2);
        }

        [When]
        public void WhenICompareCoinWithCoinUsingStaticCompareMethod()
        {
            CommonSteps.ComparisonResult = Coin.Compare(CommonSteps.Coin, CommonSteps.Coin);
        }

        [Then]
        public void ThenTheComparisonResultIs0()
        {
            CommonSteps.ComparisonResult.Should().Be(0);
        }

        [Then]
        public void ThenTheComparisonResultIsGreaterThan0()
        {
            CommonSteps.ComparisonResult.Should().BeGreaterThan(0);
        }

        [Then]
        public void ThenTheComparisonResultIsLesserThan0()
        {
            CommonSteps.ComparisonResult.Should().BeLessThan(0);
        }
    }
}