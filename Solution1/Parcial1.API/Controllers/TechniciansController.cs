using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parcial1.API.Data;
using Parcial1.Shared.Entities;

namespace Parcial1.API.Controllers
{
    [ApiController]
    [Route("/api/technicians")]
    public class TechniciansController:ControllerBase
    {
        private readonly DataContext dataContext;
        public TechniciansController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await dataContext.Technicians.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(Technician technician)
        {
            dataContext.Technicians.Add(technician);
            await dataContext.SaveChangesAsync();
            return Ok(technician);
        }
    }
}
