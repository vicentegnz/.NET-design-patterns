// <copyright file="IActualPrices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DesignPatterns.Proxy.Core
{
    /// <summary>
    /// The ActualPrices interface declares common operations for both RealActualPrices and
    /// the ProxyActualPrices. As long as the client works with ActualPrices using this
    /// interface, you'll be able to pass it a proxy instead of a real gold price.
    /// </summary>
    public interface IActualPrices
    {
        /// <summary>
        ///  Request gold price method.
        /// </summary>
        /// <returns>The price.</returns>
        string RequestGoldPrice();
    }
}
