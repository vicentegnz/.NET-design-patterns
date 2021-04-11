// <copyright file="IPurchaseContext`1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DesignPattern.ChainOfResponsibility.Core
{
    /// <summary>
    /// Defines a generic interface to be implemented and used
    /// in purchase handlers.
    /// </summary>
    /// <typeparam name="TRequest">Purchase request.</typeparam>
    public interface IPurchaseContext<TRequest>
    {
        /// <summary>
        /// Gets purchase context's request.
        /// </summary>
        public TRequest Request { get; }

        /// <summary>
        /// Gets purchase context discount.
        /// </summary>
        public decimal Discount { get; }

        /// <summary>
        /// Adds discount to the purchase context.
        /// </summary>
        /// <param name="discount">Discount to be applied in the purchase.</param>
        public void AddDiscount(decimal discount);
    }
}
