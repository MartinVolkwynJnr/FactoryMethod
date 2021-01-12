using System.Collections.Generic;
using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreator
{
    class Resume : Document
    {
        public override void CreatePages()
        {
            Pages = new List<Page>
            { new SkillsPage(),
                new EducationPage(),
                new ExperiencePage() };
        }
    }
}