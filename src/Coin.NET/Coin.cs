using System.Collections.Generic;
using System.Globalization;

namespace Coin.NET
{
    /// <summary>
    ///     A representation of object, which can store some amount of money and automatically perform
    ///     any needed conversion between currencies.
    /// </summary>
    public class Coin
    {
        private static readonly Dictionary<string, Currency> CurrencyIsoSymbolMapper = new Dictionary<string, Currency>
        {
            {"USD", Currency.USDollar},
            {"PLN", Currency.Zloty},
            {"EUR", Currency.Euro}
        };

        #region Initialization

        /// <summary>
        ///     Initializes a new instance of the <see cref="Coin"/> class.
        /// </summary>
        /// <param name="value">The amount of the money to store in the object.</param>
        /// <param name="currency">The currency of constructed Coin object.</param>
        public Coin(decimal value = 0, Currency currency = Currency.USDollar)
        {
            Value = value;
            Currency = currency;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Coin"/> object.
        /// </summary>
        /// <param name="currency">The currency of constructed Coin object.</param>
        public Coin(Currency currency)
            : this(0, currency)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Coin"/> object.
        ///     Currency of the Coin object constructed in a such way is based on the provided culture.
        /// </summary>
        /// <param name="value">The amount of the money to store in the object.</param>
        /// <param name="cultureInfo">
        ///     An instance of the <see cref="CultureInfo"/> class.
        /// </param>
        public Coin(decimal value, CultureInfo cultureInfo)
            : this(value, CurrencyIsoSymbolMapper[new RegionInfo(cultureInfo.Name).ISOCurrencySymbol])
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Coin"/> object.
        ///     Currency of the Coin object constructed in a such way is based on the provided culture.
        /// </summary>
        /// <param name="cultureInfo">
        ///     An instance of the <see cref="CultureInfo"/> class.
        /// </param>
        public Coin(CultureInfo cultureInfo)
            : this(0, cultureInfo)
        {
        }

        #endregion

        #region Public properties

        /// <summary>
        ///     The amount of money stored in current object.
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        ///     The current currency.
        /// </summary>
        public Currency Currency { get; set; }

        #endregion

        #region Mathematical operations

        /// <summary>
        ///     Add two instances of the <see cref="Coin"/> class.
        /// </summary>
        /// <param name="coin1">An instance of the <see cref="Coin"/> class (first operand).</param>
        /// <param name="coin2">An instance of the <see cref="Coin"/> class (second operand).</param>
        /// <returns>
        ///     A new instance of the <see cref="Coin"/> class,
        ///     whose value is the sum of the values from operands.
        /// </returns>
        public static Coin operator +(Coin coin1, Coin coin2)
        {
            return Add(coin1, coin2);
        }

        /// <summary>
        ///     Add two instances of the <see cref="Coin"/> class.
        /// </summary>
        /// <param name="coin1">An instance of the <see cref="Coin"/> class (first operand).</param>
        /// <param name="coin2">An instance of the <see cref="Coin"/> class (second operand).</param>
        /// <returns>
        ///     A new instance of the <see cref="Coin"/> class,
        ///     whose value is the sum of the values from operands.
        /// </returns>
        public static Coin Add(Coin coin1, Coin coin2)
        {
            var result = new Coin(coin1.Value + coin2.Value, coin1.Currency);
            return result;
        }

        /// <summary>
        ///     Add instance of the <see cref="Coin"/> class to the current <see cref="Coin"/> object.
        /// </summary>
        /// <param name="coin">An instance of the <see cref="Coin"/> class.</param>
        /// <returns>
        ///     Current instance of the <see cref="Coin"/> class after addition operation.
        /// </returns>
        public Coin Add(Coin coin)
        {
            Value += coin.Value;
            return this;
        }

        /// <summary>
        ///     Subtact one instance of the <see cref="Coin"/> class from another.
        /// </summary>
        /// <param name="coin1">An instance of the <see cref="Coin"/> class (first operand).</param>
        /// <param name="coin2">An instance of the <see cref="Coin"/> class (second operand).</param>
        /// <returns>
        ///     A new instance of the <see cref="Coin"/> class,
        ///     whose value is the difference between the values from operands.
        /// </returns>
        public static Coin operator -(Coin coin1, Coin coin2)
        {
            return Subtract(coin1, coin2);
        }

        /// <summary>
        ///     Subtact one instance of the <see cref="Coin"/> class from another.
        /// </summary>
        /// <param name="coin1">An instance of the <see cref="Coin"/> class (first operand).</param>
        /// <param name="coin2">An instance of the <see cref="Coin"/> class (second operand).</param>
        /// <returns>
        ///     A new instance of the <see cref="Coin"/> class,
        ///     whose value is the difference between the values from operands.
        /// </returns>
        public static Coin Subtract(Coin coin1, Coin coin2)
        {
            var result = new Coin(coin1.Value - coin2.Value, coin1.Currency);
            return result;
        }

        /// <summary>
        ///     Subtact instance of the <see cref="Coin"/> class from the current <see cref="Coin"/> object.
        /// </summary>
        /// <param name="coin">An instance of the <see cref="Coin"/> class.</param>
        /// <returns>
        ///     Current instance of the <see cref="Coin"/> class after subtaction operation.
        /// </returns>
        public Coin Subtract(Coin coin)
        {
            Value -= coin.Value;
            return this;
        }

        #endregion
    }
}