using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parcial1.API.Data;
using Parcial1.Shared.Entities;

namespace Parcial1.API.Controllers
{
    [ApiController]
    [Route("/api/classifications")]
    public class ClassificationsController:ControllerBase
    {
        private readonly DataContext dataContext;
        public ClassificationsController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await dataContext.Classifications.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(Classification classification)
        {
            dataContext.Classifications.Add(classification);
            await dataContext.SaveChangesAsync();
            return Ok(classification);
        }
    }
}
