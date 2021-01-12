using System;
using System.Collections.Generic;
using FactoryMethod.ConcreteCreator;
using FactoryMethod.Creator;

namespace FactoryMethod
{
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Document constructors call Factory Method
            var documents = new List<Document> { new Resume(), new Report() };

            // Display document pages
            foreach (var document in documents)
            {
                Console.WriteLine(document + "--");
                foreach (var page in document.Pages)
                {
                    Console.WriteLine(" " + page);
                }
                Console.WriteLine();
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}
