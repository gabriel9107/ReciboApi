using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecibosApi.Entidades;

namespace RecibosApi.Controllers
{
    [ApiController]
    [Route("api/Codigodepago")]

    public class CodigoDePagoController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public CodigoDePagoController(ApplicationDbContext context )
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<CodigoDePago>> Get(int id )
        {
            return await context.CodigoDePagos.FirstOrDefaultAsync(x => x.Id == id);

            
        }


        

    }
}
