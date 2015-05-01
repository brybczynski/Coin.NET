using FluentAssertions;
using TechTalk.SpecFlow;

namespace Coin.NET.Tests.MathOperations
{
    [Binding]
    public class SubtrackingCoinsSteps
    {
        [When]
        public void WhenISubtactCoin2FromCoin1UsingSubtractionOperator()
        {
            CommonSteps.OperationResult = CommonSteps.Coin1 - CommonSteps.Coin2;
        }

        [When]
        public void
            WhenISubtactCoin2FromCoin1UsingSubtractionAssignmentOperator()
        {
            CommonSteps.Coin1 -= CommonSteps.Coin2;
        }

        [When]
        public void WhenISubtactCoin2FromCoin1UsingSubtractionMethod()
        {
            CommonSteps.OperationResult = Coin.Subtract(CommonSteps.Coin1, CommonSteps.Coin2);
        }

        [When]
        public void WhenISubtactCoin2FromCoin1UsingSubtractionAssignmentMethod()
        {
            CommonSteps.Coin1.Subtract(CommonSteps.Coin2);
        }

        [Then]
        public void ThenItsValueIsADifferenceBetweenCoin1ValueAndCoin2Value()
        {
            CommonSteps.OperationResult.Value.Should()
                .Be(CommonSteps.Value1 - CommonSteps.Value2);
        }

        [Then]
        public void ThenTheValueOfCoin1IsADifferenceBetweenCoin1OldValueAndCoin2Value()
        {
            CommonSteps.Coin1.Value.Should()
                .Be(CommonSteps.Value1 - CommonSteps.Value2);
        }
    }
}