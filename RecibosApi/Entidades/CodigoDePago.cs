using System.ComponentModel;

namespace RecibosApi.Entidades
{
    public class CodigoDePago 
    {
        public int Id { get; set; }

        public string Codigo { get; set; }
        [Description("Contiene la descripcion del Codigo de Pago ")]
        public  string Descripcion { get; set; }
        [Description("Especifica el tipo de codigo de Pago /Salario/Bonificacion/Doble sueldo")]
        public  string Tipo { get; set; }
        [Description("Periodo del Pago")]
        public TipoPeriodoPago Periodo { get; set; }
        public bool Activo { get; set; }
        

    }
}
