// <copyright file="PurchaseContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DesignPattern.ChainOfResponsibility.Models
{
    using System;
    using DesignPattern.ChainOfResponsibility.Core;

    /// <summary>
    /// Purchase Context.
    /// </summary>
    public class PurchaseContext : IChainContext<PurchaseRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseContext"/> class.
        /// </summary>
        /// <param name="purchaseRequest">Purchase request.</param>
        public PurchaseContext(PurchaseRequest purchaseRequest)
        {
            this.Request = purchaseRequest ?? throw new ArgumentNullException(nameof(purchaseRequest));
            this.PurchaseAmount = this.Request.Amount;
        }

        /// <summary>
        /// Gets context's request.
        /// </summary>
        public PurchaseRequest Request { get; }

        /// <summary>
        /// Gets or sets the current purchase amount.
        /// </summary>
        public decimal PurchaseAmount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether if the purchase has some discount applied.
        /// </summary>
        public bool HasDiscountApplied { get; set; }
    }
}
