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
    }
}