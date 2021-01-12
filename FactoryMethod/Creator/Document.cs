using System.Collections.Generic;
using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    abstract class Document
    {
        public Document()
        {
            this.CreatePages();
        }

        // Gets list of document pages
        public List<Page> Pages { get; protected set; }

        // Factory Method
        public abstract void CreatePages();

        // Override
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}