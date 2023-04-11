using Microsoft.CodeAnalysis;

namespace buffalo.Models
{
    public interface IBurialRepository
    {
        IQueryable<BurialMain> Burials { get; }
        //void SaveBurial(BurialMain burials);
    }
}
