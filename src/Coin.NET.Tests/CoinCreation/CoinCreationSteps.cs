using System.Globalization;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace Coin.NET.Tests.CoinCreation
{
    [Binding]
    public class CoinCreationSteps
    {
        #region Private fields

        private Coin _coin;
        private decimal _sampleValue;
        private Currency _sampleCurrency;
        private CultureInfo _sampleCultureInfo;

        #endregion

        #region Empty steps

        [Given]
        public void GivenIAmAProgrammer() {}

        [Then]
        public void ThenNewCoinObjectIsCreated() {}

        #endregion

        #region When steps

        [When]
        public void WhenICreateACoinObjectUsingAConstructorWithoutAnyArguments()
        {
            _coin = new Coin();
        }

        [When]
        public void WhenICreateACoinObjectUsingAConstructorWithDecimalValue()
        {
            _sampleValue = 100.0M;
            _coin = new Coin(_sampleValue);
        }

        [When]
        public void WhenICreateACoinObjectUsingAConstructorWithCultureinfo()
        {
            _sampleCultureInfo = new CultureInfo("fr-FR");
            _coin = new Coin(_sampleCultureInfo);
        }

        [When]
        public void WhenICreateACoinObjectUsingAConstructorWithSpecificCurrency()
        {
            _sampleCurrency = Currency.Zloty;
            _coin = new Coin(_sampleCurrency);
        }

        #endregion 

        #region Then steps

        [Then]
        public void ThenItSDefaultCurrencyIsSetToProvidedValue()
        {
            _coin.Currency.Should().Be(_sampleCurrency);
        }

        [Then]
        public void ThenItSValueIsSetToZero()
        {
            _coin.Value.Should().Be(0);
        }

        [Then]
        public void ThenItSDefaultCurrencyIsSetToDollars()
        {
            _coin.Currency.Should().Be(Currency.USDollar);
        }

        [Then]
        public void ThenItSValueIsSetToProvidedValue()
        {
            _coin.Value.Should().Be(_sampleValue);
        }

        [Then]
        public void ThenItSDefaultCurrencyIsSetToCorrespondingTheProvidedCultureinfo()
        {
            _coin.Currency.Should().Be(Currency.Euro);
        }

        #endregion
    }
}