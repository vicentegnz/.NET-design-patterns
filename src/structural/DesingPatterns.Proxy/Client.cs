// <copyright file="Client.cs" company=".NetDesignPatterns">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DesignPatterns.Proxy
{
    using DesignPatterns.Proxy.Core;

    /// <summary>
    /// The client class.
    /// </summary>
    internal class Client
    {
        /// <summary>
        /// The client code is supposed to work with all objects (both subjects
        /// and proxies) via the Subject interface in order to support both real
        /// subjects and proxies. In real life, however, clients mostly work with
        /// their real subjects directly. In this case, to implement the pattern
        /// more easily, you can extend your proxy from the real subject's class.
        /// </summary>
        /// <param name="subject">The subject param.</param>
        public void ClientCode(IActualPrices subject)
        {
            // ...
            subject.RequestGoldPrice();

            // ...
        }
    }
}
