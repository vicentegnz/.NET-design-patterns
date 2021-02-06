// <copyright file="ProxyActualPrices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DesignPatterns.Proxy.Core
{
    using System;

    /// <summary>
    /// The Proxy interface identical to the RealActualPrices.
    /// </summary>
#pragma warning disable CA1303 // Do not pass literals as localized parameters
    public class ProxyActualPrices : IActualPrices
    {
        private readonly IActualPrices realActualPrices;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProxyActualPrices"/> class.
        /// </summary>
        /// <param name="realActualPrices">The real actual prices implementation.</param>
        public ProxyActualPrices(IActualPrices realActualPrices)
        {
            this.realActualPrices = realActualPrices;
        }

        /// <summary>
        /// The most common applications of the Proxy pattern are lazy loading,
        /// caching, controlling the access, logging, etc. A Proxy can perform
        /// one of these things and then, depending on the result, pass the
        /// execution to the same method in a linked RealActualPrices object.
        /// </summary>
        /// <returns>The price.</returns>
        public string RequestGoldPrice()
        {
            if (this.CheckAccess())
            {
                this.realActualPrices.RequestGoldPrice();
            }

            return "RequestGoldPriceProxy";
        }

        private bool CheckAccess()
        {
            // Some real checks should go here.
            return false;
        }
    }
#pragma warning restore CA1303 // Do not pass literals as localized parameters
}
