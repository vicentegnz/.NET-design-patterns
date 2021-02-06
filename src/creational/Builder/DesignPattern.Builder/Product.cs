// <copyright file="Product.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DesignPattern.Builder
{
    using System.Collections.Generic;

    /// <summary>
    /// The product class.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets product parts.
        /// </summary>
        public IList<string> Parts { get; } = new List<string>();

        /// <summary>
        /// Add product part.
        /// </summary>
        /// <param name="part">Part to be added.</param>
        public void Add(string part)
        {
            this.Parts.Add(part);
        }
    }
}
