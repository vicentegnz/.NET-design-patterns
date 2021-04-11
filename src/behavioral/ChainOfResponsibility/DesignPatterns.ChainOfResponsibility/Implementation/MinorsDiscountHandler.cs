// <copyright file="MinorsDiscountHandler.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DesignPattern.ChainOfResponsibility.Implementation
{
    using DesignPattern.ChainOfResponsibility.Models;

    /// <summary>
    /// Defines a specific implementation of IChainHandler that inherits from <see cref="DiscountChainHandler"/>.
    /// </summary>
    public class MinorsDiscountHandler : DiscountChainHandler
    {
        private const int MinorsMaxAge = 18;
        private const decimal MinorsDiscount = 0.1M;

        /// <summary>
        /// Executes Minors Discount chain handler logic.
        /// </summary>
        /// <returns>Purchase receipt.</returns>
        public override PurchaseResponse Execute()
        {
            if (this.Context.Request.BuyerAge <= MinorsMaxAge)
            {
                this.Context.AddDiscount(MinorsDiscount);
            }

            return this.Sucessor.Execute();
        }
    }
}
