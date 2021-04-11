// <copyright file="ProxyTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DesignPattern.Proxy.Tests
{
    using DesignPattern.Proxy;
    using DesignPattern.Proxy.Core;
    using FluentAssertions;
    using Xunit;

    /// <summary>
    /// The proxy test class.
    /// </summary>
    public class ProxyTests
    {
        /// <summary>
        /// Proxy pattern tests.
        /// </summary>
        [Fact]
        public void ProxyPatternOk()
        {
            // Client: Executing the client code with a real gold price
            IActualPrices realGoldPrice = new RealActualPrices();
            Client client1 = new Client(realGoldPrice);
            string resultReal = client1.ClientCode();

            resultReal.Should().Be("RequestGoldPriceReal");

            // Client: Executing the same client code with a proxy
            var proxy = new ProxyActualPrices(realGoldPrice);
            Client client2 = new Client(proxy);
            string resultProxy = client2.ClientCode();

            resultProxy.Should().Be("RequestGoldPriceProxy");
        }
    }
}
