// <copyright file="ElderlyDiscountHandler.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DesignPattern.ChainOfResponsibility.Implementation
{
    using DesignPattern.ChainOfResponsibility.Models;

    /// <summary>
    /// Defines a specific implementation of IChainHandler that inherits from <see cref="DiscountChainHandler"/>.
    /// </summary>
    public class ElderlyDiscountHandler : DiscountChainHandler
    {
        private const int ElderlyMinAge = 65;
        private const decimal ElderlyDiscount = 0.15M;

        /// <summary>
        /// Executes Elderly Discount chain handler logic.
        /// </summary>
        /// <returns>Purchase receipt.</returns>
        public override PurchaseResponse Execute()
        {
            if (this.Context.Request.BuyerAge <= ElderlyMinAge)
            {
                this.Context.AddDiscount(ElderlyDiscount);
            }

            return this.Sucessor.Execute();
        }
    }
}
