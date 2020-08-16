using System;
using System.Collections.Generic;

namespace DotaAnalyst.Models
{
    public class HeroRelations
    {
        private int Id { get; set; }

        private int IdHero { get; set; }

        private List<Item> MostUsedItems { get; set; }

        private List<Hero> BestVersus { get; set; }

        private List<Hero> WorstVersus { get; set; }
    }
}
