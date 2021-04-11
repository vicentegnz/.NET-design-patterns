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
    public class PurchaseContext : IPurchaseContext<PurchaseRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseContext"/> class.
        /// </summary>
        /// <param name="purchaseRequest">Purchase request.</param>
        public PurchaseContext(PurchaseRequest purchaseRequest)
        {
            this.Request = purchaseRequest ?? throw new ArgumentNullException(nameof(purchaseRequest));
        }

        /// <summary>
        /// Gets purchase context's request.
        /// </summary>
        public PurchaseRequest Request { get; }

        /// <summary>
        /// Gets purchase context's request.
        /// </summary>
        public decimal Discount { get; private set; }

        /// <inheritdoc/>
        public void AddDiscount(decimal discount)
        {
            if (discount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(discount));
            }

            this.Discount += discount;
        }
    }
}
