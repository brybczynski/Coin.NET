using FluentAssertions;
using TechTalk.SpecFlow;

namespace Coin.NET.Tests.MathOperations
{
    [Binding]
    public class AddingCoinsSteps
    {
        [When]
        public void WhenIAddCoin1AndCoin2UsingAdditionOperator()
        {
            CommonSteps.OperationResult = CommonSteps.Coin1 + CommonSteps.Coin2;
        }

        [When]
        public void WhenIAddCoin1ToCoin2UsingAdditionAssignmentOperator()
        {
            CommonSteps.Coin1 += CommonSteps.Coin2;
        }

        [When]
        public void WhenIAddCoin1AndCoin2UsingAdditionMethod()
        {
            CommonSteps.OperationResult = Coin.Add(CommonSteps.Coin1, CommonSteps.Coin2);
        }

        [When]
        public void WhenIAddCoin1ToCoin2UsingAdditionAssignmentMethod()
        {
            CommonSteps.Coin1.Add(CommonSteps.Coin2);
        }

        [Then]
        public void ThenItsValueIsASumOfCoin1ValueAndCoin2Value()
        {
            CommonSteps.OperationResult.Value.Should().Be(CommonSteps.Value1 + CommonSteps.Value2);
        }

        [Then]
        public void ThenTheValueOfCoin1IsASumOfCoin1OldValueAndCoin2Value()
        {
            CommonSteps.Coin1.Value.Should().Be(CommonSteps.Value1 + CommonSteps.Value2);
        }
    }
}