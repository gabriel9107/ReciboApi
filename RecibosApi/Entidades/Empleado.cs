using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;

namespace RecibosApi.Entidades
{
    public class Empleado
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set;  }
        public string FechaNacimiento { get; set;  }
        public string Direccion { get; set;  }
        public string Telefono { get; set;  }
        public string Celular { get; set;  }
        public bool Activo { get; set; }    

          
    }
}
