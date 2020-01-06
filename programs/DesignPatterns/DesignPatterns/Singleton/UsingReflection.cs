//-----------------------------------------------------------------------
// <copyright file="UsingReflection.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// class to implement reflections
    /// </summary>
    public class UsingReflection
    {
        /// <summary>
        /// The count
        /// </summary>
        private static int count = 0;

        /// <summary>
        /// The using reflection
        /// </summary>
        private static UsingReflection usingReflection = new UsingReflection();

        /// <summary>
        /// Prevents a default instance of the <see cref="UsingReflection"/> class from being created.
        /// </summary>
        private UsingReflection()
        {
            count++;
            Console.WriteLine("Instance created : " + count);
        }
    }
}
