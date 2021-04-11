// <copyright file="DiscountChainHandler.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DesignPattern.ChainOfResponsibility.Implementation
{
    using System;
    using DesignPattern.ChainOfResponsibility.Core;
    using DesignPattern.ChainOfResponsibility.Models;

    /// <summary>
    /// DiscountChainHandler implements the <see cref="IPurchaseHandler{TRequest, TResponse}"/> interface and defines
    /// the base class for concrete chain handlers.
    /// </summary>
    public abstract class DiscountChainHandler : IPurchaseHandler<PurchaseRequest, PurchaseResponse>
    {
        /// <inheritdoc/>
        public IPurchaseContext<PurchaseRequest> Context => this.Sucessor?.Context;

        /// <summary>
        /// Gets Chain Handler sucessor.
        /// </summary>
        protected IPurchaseHandler<PurchaseRequest, PurchaseResponse> Sucessor { get; private set; }

        /// <inheritdoc/>
        /// <remarks>The concrete chain handlers will implement their specific execution.</remarks>
        public abstract PurchaseResponse Execute();

        /// <summary>
        /// Sets IPurchaseHandler sucessor.
        /// </summary>
        /// <param name="sucessor">The sucessor IPurchaseHandler to be executed.</param>
        /// <returns>IPurchaseHandler.</returns>
        public IPurchaseHandler<PurchaseRequest, PurchaseResponse> SetSucesor(IPurchaseHandler<PurchaseRequest, PurchaseResponse> sucessor)
        {
            this.Sucessor = sucessor ?? throw new ArgumentNullException(nameof(sucessor));
            return this;
        }
    }
}
