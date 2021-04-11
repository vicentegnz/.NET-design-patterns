// <copyright file="PurchaseResponse.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace DesignPattern.ChainOfResponsibility.Models
{
    /// <summary>
    /// PurchaseResponse defines the result of the chain of responsibility execution.
    /// </summary>
    public class PurchaseResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseResponse"/> class.
        /// Defines a receipt for the purchase.
        /// </summary>
        /// <param name="amount">Initial purchase amount.</param>
        /// <param name="discount">Discount to be applied.</param>
        public PurchaseResponse(decimal amount, decimal discount)
        {
            this.Amount = this.InitialAmount = amount;
            this.Discount = discount;
        }

        /// <summary>
        /// Gets purchase's initial amount.
        /// </summary>
        public decimal InitialAmount { get; private set; }

        /// <summary>
        /// Gets purchase's discount.
        /// </summary>
        public decimal Discount { get; private set; }

        /// <summary>
        /// Gets purchase final amount.
        /// </summary>
        public decimal Amount { get; private set; }

        /// <summary>
        /// Applies the purchase's discount.
        /// </summary>
        public void ApplyDiscount()
        {
            if (this.Discount > 0)
            {
                this.Amount = this.InitialAmount * this.Discount;
            }
        }
    }
}
