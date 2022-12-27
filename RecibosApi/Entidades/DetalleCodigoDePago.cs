using Microsoft.AspNetCore.Components.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecibosApi.Entidades
{
    public class DetalleCodigoDePago
    {
        [Key]
        public int id { get; set; } 
        public string Codigo { get; set; }
        public CodigoDePago CodigoDePago { get; set; }  
        
        public Empleado Empleado { get; set; }
         

        [Description("Especifica si es el codigo de Pago Principal del empleado")]
        public bool Primario { get; set; }

        public bool DescuentoSFS { get; set; }
        public bool DescuentoAFP { get; set; }
        public bool DescuentoTSS { get; set; }
        public bool DescuentoISR { get; set; }


        public bool activo { get; set; }

        public string CreadoPor { get; set; }
        public DateTime FechaCrecion { get; set; }
        public String ModificadoPor { get; set; }
        public DateTime FechaModificacion { get; set; }

    }
}
