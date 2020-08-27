using System;
using System.Collections.Generic;

namespace DotaAnalyst.Models
{
    public class HeroRelations
    {
        public int Id { get; set; }

        public int IdHero { get; set; }

        public List<Item> MostUsedItems { get; set; }

        public List<Hero> BestVersus { get; set; }

        public List<Hero> WorstVersus { get; set; }
    }
}
