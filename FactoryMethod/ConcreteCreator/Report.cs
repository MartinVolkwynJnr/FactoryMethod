﻿using System.Collections.Generic;
using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreator
{
    class Report : Document
    {
        public override void CreatePages()
        {
            Pages = new List<Page>
            {
                new IntroductionPage(),
                new ResultsPage(),
                new ConclusionPage(),
                new SummaryPage(),
                new BibliographyPage()
            };
        }
    }
}