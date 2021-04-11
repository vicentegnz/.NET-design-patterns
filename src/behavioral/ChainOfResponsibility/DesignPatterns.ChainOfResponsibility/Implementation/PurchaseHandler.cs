// <copyright file="PurchaseHandler.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace DesignPattern.ChainOfResponsibility.Implementation
{
    using System;
    using DesignPattern.ChainOfResponsibility.Core;
    using DesignPattern.ChainOfResponsibility.Models;

    /// <summary>
    /// Defines a specific implementation of <see cref="IHandler{TResponse}"/>
    /// that behaves as the final handler at the end of the chain of responsibility.
    /// Note that this handler does not inherit from <see cref="IPurchaseHandler{TRequest, TResponse}"/>
    /// as it is the final handler and does not have any successor.
    /// </summary>
    public class PurchaseHandler : IPurchaseHandler<PurchaseRequest, PurchaseResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseHandler"/> class.
        /// </summary>
        /// <param name="request">Initial context request.</param>
        public PurchaseHandler(IPurchaseContext<PurchaseRequest> request)
        {
            this.Context = request ?? throw new ArgumentNullException(nameof(request));
        }

        /// <summary>
        /// Gets purchase handler's request context.
        /// </summary>
        public IPurchaseContext<PurchaseRequest> Context { get; private set; }

        /// <summary>
        /// Executes the final logic of the purchase chain of responsibility.
        /// </summary>
        /// <returns>Returns the purchase receipt<see cref="PurchaseResponse"/>.</returns>
        public PurchaseResponse Execute()
        {
            PurchaseResponse purchaseReceipt = new PurchaseResponse(this.Context.Request.Amount, this.Context.Discount);
            purchaseReceipt.ApplyDiscount();

            return purchaseReceipt;
        }
    }
}
