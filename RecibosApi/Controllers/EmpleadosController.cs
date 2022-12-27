using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using RecibosApi.Entidades;
using System.Diagnostics.Contracts;

namespace RecibosApi.Controllers
{
    [ApiController]
    [Route("api/empleados")]
    public class EmpleadosController : ControllerBase
    {
        public ApplicationDbContext context { get; }

        public EmpleadosController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult> Post(Empleado empleado)
        {
            context.Add(empleado);
            await context.SaveChangesAsync();
            return Ok();

        }

        [HttpGet]
        public async Task<ActionResult<List<Empleado>>> Get()
        {
            return await context.empleados.ToListAsync(); 
            

        }

        [HttpPut]
        public async Task<ActionResult> Put(Empleado empleado, int id)
        {
            if(empleado.Id != id)
            {
                return BadRequest("El id del empleado no coincide con el id de la url");
            }
            context.Update(empleado);
            await context.SaveChangesAsync();
            return Ok(); 

        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.empleados.AnyAsync(x => x.Id == id);
            if(!existe)
            {
                return NotFound(); 

            }
            context.Remove(new Empleado() { Id = id });
            await context.SaveChangesAsync();
            return Ok(); 
        }




    }
}
