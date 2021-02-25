// <copyright file="MinorsDiscountHandlers.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DesignPattern.ChainOfResponsibility.Implementation
{
    using System;
    using DesignPattern.ChainOfResponsibility.Models;

    /// <summary>
    /// Defines a specific implementation of IChainHandler that inherits from DiscountChainHandler.
    /// </summary>
    public class MinorsDiscountHandlers : DiscountChainHandler
    {
        /// <summary>
        /// Executes Minors Discount chain handler logic.
        /// </summary>
        /// <returns>Purchase receipt.</returns>
        public override PurchaseReceipt Execute()
        {
            return new PurchaseReceipt(); // TODO
        }
    }
}
