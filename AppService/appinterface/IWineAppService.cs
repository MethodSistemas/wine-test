using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;

namespace AppService.appinterface
{
    public interface IWineAppService
    {
        Task<List<Wine>> GetWinesAsync();
        Task<Wine> GetWineAsync(int id);

        Task<Wine> AddAsync(Wine wine);
    }
}