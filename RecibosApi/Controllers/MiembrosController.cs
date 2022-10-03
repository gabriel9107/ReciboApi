using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using RecibosApi.Entidades;
using System.Security.Cryptography.X509Certificates;

namespace RecibosApi.Controllers
{
    [ApiController]
    [Route("api/mienbros")]
    public class MiembrosController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public MiembrosController(ApplicationDbContext context)
        {
            this.context = context; 

        }

        public ApplicationDbContext Context { get; }

        [HttpGet]
        public async Task<ActionResult<List<Miembros>>> Get()
        {
            return await context.Miembros.Include(x => x.vehiculos).ToListAsync(); 
        }


        [HttpPut("{id:int}")]
        public async Task<ActionResult> put(Miembros miembros, int id)
        {
            if(miembros.iD != id)
            {
                return BadRequest("El id del miembro no esta en la URL");
            }

            var existe = await context.Miembros.AnyAsync(x => x.iD == id);
            
            if(!existe)
            {
                return NotFound(); 
            }

            context.Update(miembros);
            await context.SaveChangesAsync();
            return Ok(); 
                
             

        }



        [HttpPost]
        public async Task<ActionResult> Post(Miembros miembros)
        {
            context.Add(miembros);
            await context.SaveChangesAsync();
            return Ok(); 
        }

    }
}
