using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecibosApi.Entidades;
using RecibosApi.Migrations;

namespace RecibosApi.Controllers
{
    [ApiController]
    [Route("api/vehiculos")]
    public class VehiculosController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public VehiculosController(ApplicationDbContext context)
        {
            this.context = context;
        }


        [HttpGet("{id:int}")]
        public  async Task<ActionResult<Vehiculo>>  Get(int id)
        {
            return await context.vehiculos.Include(x => x.miembros).FirstOrDefaultAsync( x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Vehiculo vehiculo)
        {


            var existemienbro = await context.Miembros.AnyAsync(x => x.iD == vehiculo.miembrosId);

            if(!existemienbro)
            {
                return BadRequest($"No existe el vehiculo del miembro: {vehiculo.Id}");
             }

            context.Add(vehiculo);
            await context.SaveChangesAsync();
            return Ok(); 
        }
    }
}
