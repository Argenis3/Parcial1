using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parcial1.API.Data;
using Parcial1.Shared.Entities;

namespace Parcial1.API.Controllers
{
    [ApiController]
    [Route("/api/services")]
    public class ServicesController:ControllerBase
    {
        private readonly DataContext dataContext;
        public ServicesController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await dataContext.Services.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(Service service)
        {
            dataContext.Services.Add(service);
            await dataContext.SaveChangesAsync();
            return Ok(service);
        }
    }
}
