using System.Collections.Generic;
using System.Threading.Tasks;
using AppService.appinterface;
using Data;
using Domain;
using DomainService;
using Microsoft.EntityFrameworkCore;

namespace AppService.concrete
{
    public class WineAppService : IWineAppService
    {
        
        private readonly WinestoreContext _dbContext;

        public WineAppService(WinestoreContext dbContext)
        {
            _dbContext = dbContext;
        }

        private WineDomainService _wineDomainService { get; set; }

        private WineDomainService wineDomainService
        {
            get
            {
                if (_wineDomainService == null)
                {
                    _wineDomainService = new WineDomainService(_dbContext);
                }
                return _wineDomainService;
            }
        }

        public async Task<List<Wine>> GetWinesAsync()
        {
            return await this.wineDomainService.Query.ToListAsync();
        }

        public async Task<Wine> GetWineAsync(int id)
        {
            return await this.wineDomainService.Query.FirstOrDefaultAsync(usu => usu.Id == id);
        }

        public async Task<Wine> AddAsync(Wine wine)
        {
            return await this.wineDomainService.AddWine(wine);
        }
    }
}