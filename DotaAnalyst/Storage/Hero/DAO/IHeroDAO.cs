using System;
using System.Collections.Generic;
using DotaAnalyst.Models;

namespace DotaAnalyst.Database
{
    public interface IHeroDAO
    {
        List<Hero> GetHeroes();
    }
}
