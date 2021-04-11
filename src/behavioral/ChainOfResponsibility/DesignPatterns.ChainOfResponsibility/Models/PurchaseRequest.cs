// <copyright file="PurchaseRequest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DesignPattern.ChainOfResponsibility.Models
{
    /// <summary>
    /// Purchase request.
    /// </summary>
    public class PurchaseRequest
    {
        /// <summary>
        /// Gets or sets purchase amount.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets purchase buyer Age.
        /// </summary>
        public int BuyerAge { get; set; }
    }
}
