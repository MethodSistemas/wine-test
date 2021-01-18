using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppService.appinterface;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace winestore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WineController : ControllerBase
    {
        private readonly ILogger<WineController> _logger;
        private readonly IWineAppService _wineAppService;

        public WineController(ILogger<WineController> logger, IWineAppService wineAppService)
        {
            _logger = logger;
            _wineAppService = wineAppService;
        }

        [HttpGet]
        public async Task<List<Wine>> Get()
        {
            return await this._wineAppService.GetWinesAsync();
        }

        [HttpPost]
        public async Task<Wine> Add(Wine wine)
        {
            return await this._wineAppService.AddAsync(wine);
        }
    }
}
