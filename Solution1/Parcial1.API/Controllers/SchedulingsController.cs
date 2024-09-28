using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parcial1.API.Data;
using Parcial1.Shared.Entities;

namespace Parcial1.API.Controllers
{
    [ApiController]
    [Route("/api/schedulings")]
    public class SchedulingsController:ControllerBase
    {
        private readonly DataContext dataContext;
        public SchedulingsController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await dataContext.Schedulings.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(Scheduling scheduling)
        {
            dataContext.Schedulings.Add(scheduling);
            await dataContext.SaveChangesAsync();
            return Ok(scheduling);
        }
    }
}
