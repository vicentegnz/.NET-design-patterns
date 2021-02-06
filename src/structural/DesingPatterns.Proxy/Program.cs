// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DesingPatterns
{
    using System;
    using DesignPatterns.Proxy;
    using DesignPatterns.Proxy.Core;

    /// <summary>
    /// The program class.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main method.
        /// </summary>
#pragma warning disable CA1303 // Do not pass literals as localized parameters
        public static void Main()
        {
            Client client = new Client();

            Console.WriteLine("Client: Executing the client code with a real gold price:");
            RealActualPrices realGoldPrice = new RealActualPrices();
            client.ClientCode(realGoldPrice);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            var proxy = new ProxyActualPrices(realGoldPrice);
            client.ClientCode(proxy);
        }
#pragma warning restore CA1303 // Do not pass literals as localized parameters
    }
}
