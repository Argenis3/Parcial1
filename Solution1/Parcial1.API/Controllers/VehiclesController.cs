using Microsoft.AspNetCore.Mvc;
using Parcial1.API.Data;

namespace Parcial1.API.Controllers
{
    [ApiController]
    [Route("/api/vehicles")]
    public class VehiclesController
    {
        private readonly DataContext dataContext;

        public VehiclesController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
    }
}
