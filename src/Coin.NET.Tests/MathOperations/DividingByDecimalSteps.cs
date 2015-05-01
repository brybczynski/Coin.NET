using FluentAssertions;
using TechTalk.SpecFlow;

namespace Coin.NET.Tests.MathOperations
{
    [Binding]
    public class DividingByDecimalSteps
    {
        [When]
        public void WhenIDivideCoinByDUsingDivisionOperator()
        {
            CommonSteps.OperationResult = CommonSteps.Coin / CommonSteps.Decimal;
        }

        [When]
        public void WhenIDivideCoinByDUsingDivisionAssignmentOperator()
        {
            CommonSteps.Coin /= CommonSteps.Decimal;
        }

        [When]
        public void WhenIDivideCoinByDUsingDivisionMethod()
        {
            CommonSteps.OperationResult = Coin.Divide(CommonSteps.Coin,
                CommonSteps.Decimal);
        }

        [When]
        public void WhenIDivideCoinByDUsingDivisionAssignmentMethod()
        {
            CommonSteps.Coin.DivideBy(CommonSteps.Decimal);
        }

        [Then]
        public void ThenItsValueIsTheResultOfTheDivision()
        {
            CommonSteps.OperationResult.Value.Should()
                .Be(CommonSteps.Value1/CommonSteps.DecimalValue);
        }

        [Then]
        public void
            ThenTheValueOfTheCoinObjectIsAResultOfDividingTheOldValueByTheD()
        {
            CommonSteps.Coin.Value.Should()
                .Be(CommonSteps.Value1/CommonSteps.DecimalValue);
        }
    }
}