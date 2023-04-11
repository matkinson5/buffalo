using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace buffalo.Models
{
    public class EFBurialRepository : IBurialRepository
    {
        private BuffaloContext context;

        public EFBurialRepository(BuffaloContext temp)
        {
            context = temp;
        }

        public IQueryable<BurialMain> Burials => context.Burials;

    }
}
