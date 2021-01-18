using System.Linq;
using System.Threading.Tasks;
using Data;
using Domain;

namespace DomainService
{
    public class WineDomainService
    {
        private readonly WinestoreContext _context;
        public WineDomainService(WinestoreContext context)
        {
            _context = context;
        }


        public IQueryable<Wine> Query { get{ return this._context.Wines; } }

        public async Task<Wine> AddWine(Wine wine)
        {
            await this._context.Wines.AddAsync(wine);
            await this._context.SaveChangesAsync();

            return wine;
        }
    }
}