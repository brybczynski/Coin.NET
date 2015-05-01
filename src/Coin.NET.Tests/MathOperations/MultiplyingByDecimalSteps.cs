using System;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace Coin.NET.Tests.MathOperations
{
    [Binding]
    public class MultiplyingByDecimalSteps
    {
        [When]
        public void WhenIMultiplyCoinByDUsingMultiplicationOperator()
        {
            CommonSteps.OperationResult = CommonSteps.Coin * CommonSteps.Decimal;
        }

        [When]
        public void WhenIMultiplyCoinByDUsingMultiplicationAssignmentOperator()
        {
            CommonSteps.Coin *= CommonSteps.Decimal;
        }

        [When]
        public void WhenIMultiplyCoinByDUsingMultiplicationMethod()
        {
            CommonSteps.OperationResult =
                Coin.Multiply(CommonSteps.Coin, CommonSteps.Decimal);
        }

        [When]
        public void WhenIMultiplyCoinByDUsingMultiplicationAssignmentMethod()
        {
            CommonSteps.Coin.MultiplyBy(CommonSteps.Decimal);
        }

        [Then]
        public void ThenItsValueIsTheResultOfTheMultiplication()
        {
            CommonSteps.OperationResult.Value.Should()
                .Be(CommonSteps.Value1 * CommonSteps.DecimalValue);
        }

        [Then]
        public void
            ThenTheValueOfTheCoinObjectIsAResultOfMultiplyingTheOldValueByTheD()
        {
            CommonSteps.Coin.Value.Should()
                .Be(CommonSteps.Value1*CommonSteps.DecimalValue);
        }
    }
}