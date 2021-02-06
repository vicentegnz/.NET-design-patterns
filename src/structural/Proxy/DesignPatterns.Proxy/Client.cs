// <copyright file="Client.cs" company=".NetDesignPatterns">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DesignPatterns.Proxy
{
    using System;
    using DesignPatterns.Proxy.Core;

    /// <summary>
    /// The client class.
    /// </summary>
    public class Client
    {
        private readonly IActualPrices actualPrices;

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="actualPrices">The actual prices interface.</param>
        public Client(IActualPrices actualPrices)
        {
            this.actualPrices = actualPrices ?? throw new ArgumentNullException(nameof(actualPrices));
        }

        /// <summary>
        /// The client code is supposed to work with all objects (both subjects
        /// and proxies) via the Subject interface in order to support both real
        /// subjects and proxies. In real life, however, clients mostly work with
        /// their real subjects directly. In this case, to implement the pattern
        /// more easily, you can extend your proxy from the real subject's class.
        /// </summary>
        /// <returns>The price.</returns>
        public string ClientCode()
        {
           return this.actualPrices?.RequestGoldPrice();
        }
    }
}
