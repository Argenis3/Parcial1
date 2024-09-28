using Microsoft.AspNetCore.Mvc;
using Parcial1.API.Data;
using Microsoft.EntityFrameworkCore;
using Parcial1.Shared.Entities;

namespace Parcial1.API.Controllers
{
    [ApiController]
    [Route("/api/packages")]
    public class PackagesController:ControllerBase
    {
        private readonly DataContext dataContext;
        public PackagesController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await dataContext.Packages.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(Package package)
        {
            dataContext.Packages.Add(package);
            await dataContext.SaveChangesAsync();
            return Ok(package);
        }
    }
}
