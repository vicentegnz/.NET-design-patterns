// <copyright file="RealActualPrices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DesignPattern.Proxy.Core
{
    using System;

    /// <summary>
    /// The RealActualPrices contains some core business logic. Usually, RealActualPrices
    /// are capable of doing some useful work which may also be very slow or
    /// sensitive - e.g. correcting input data. A Proxy can solve these issues
    /// without any changes to the RealActualPrices's code.
    /// </summary>
    public class RealActualPrices : IActualPrices
    {
        /// <inheritdoc/>
#pragma warning disable CA1303 // Do not pass literals as localized parameters
        public string RequestGoldPrice()
        {
            return "RequestGoldPriceReal";
        }
#pragma warning restore CA1303 // Do not pass literals as localized parameters
    }
}
