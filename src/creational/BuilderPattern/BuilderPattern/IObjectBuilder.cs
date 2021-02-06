// <copyright file="IObjectBuilder.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BuilderPattern
{
    /// <summary>
    /// The Builder interface specifies methods for creating the different parts
    /// of the Product objects.
    /// </summary>
    public interface IObjectBuilder
    {
        /// <summary>
        ///  Build object part !.
        /// </summary>
        void BuildPartA();

        /// <summary>
        ///  Build object part B.
        /// </summary>
        void BuildPartB();

        /// <summary>
        ///  Build object part C.
        /// </summary>
        void BuildPartC();
    }
}
