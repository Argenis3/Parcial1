using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parcial1.API.Data;
using Parcial1.Shared.Entities;

namespace Parcial1.API.Controllers
{
    [ApiController]
    [Route("/api/clients")]
    public class ClientsController:ControllerBase
    {
        private readonly DataContext dataContext;
        public ClientsController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await dataContext.Clients.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(Client client)
        {
            dataContext.Clients.Add(client);
            await dataContext.SaveChangesAsync();
            return Ok(client);
        }
    }
}
