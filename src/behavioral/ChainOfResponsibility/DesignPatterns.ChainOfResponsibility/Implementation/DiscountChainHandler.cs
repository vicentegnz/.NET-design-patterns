// <copyright file="DiscountChainHandler.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DesignPattern.ChainOfResponsibility.Implementation
{
    using System;
    using DesignPattern.ChainOfResponsibility.Core;
    using DesignPattern.ChainOfResponsibility.Models;

    /// <summary>
    /// DiscountChainHandler implements the IChainHandler interface and defines the base class for concrete chain handlers.
    /// </summary>
    public abstract class DiscountChainHandler : IChainHandler<PurchaseRequest, PurchaseReceipt>
    {
        /// <inheritdoc/>
        public IChainContext<PurchaseRequest> Context => this.Sucessor?.Context;

        /// <summary>
        /// Gets Chain Handler sucessor.
        /// </summary>
        protected IChainHandler<PurchaseRequest, PurchaseReceipt> Sucessor { get; private set; }

        /// <inheritdoc/>
        /// <remarks>The concrete chain handlers will implement their specific execution.</remarks>
        public abstract PurchaseReceipt Execute();

        /// <inheritdoc/>
        public IChainHandler<PurchaseRequest, PurchaseReceipt> SetSucesor(IChainHandler<PurchaseRequest, PurchaseReceipt> sucessor)
        {
            this.Sucessor = sucessor ?? throw new ArgumentNullException(nameof(sucessor));
            return this;
        }
    }
}
