// <copyright file="Product.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BuilderPattern
{
    using System.Collections.Generic;

    /// <summary>
    /// The product class.
    /// </summary>
    public class Product
    {
        private readonly List<object> parts = new List<object>();

        /// <summary>
        /// Add product part.
        /// </summary>
        /// <param name="part">Part to be added.</param>
        public void Add(string part)
        {
            this.parts.Add(part);
        }

        /// <summary>
        /// List of parts.
        /// </summary>
        /// <returns>Products parts message.</returns>
        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this.parts.Count; i++)
            {
                str += this.parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Product parts: " + str + "\n";
        }
    }
}
