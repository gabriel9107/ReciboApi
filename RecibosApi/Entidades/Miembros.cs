namespace RecibosApi.Entidades
{
    public class Miembros
    {
        public int iD { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string Direccion { get; set; }   
        public string Cedula { get; set; }
        public string Telefono { get; set;  }
        public string cuentaBanco { get; set; }

        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set;  }
        public string CreadoPor { get; set;  }
        public string ModificadoPor { get; set;  }

        public List<Vehiculo> vehiculos { get; set; }

        
        //public bool Activo { get; set; }


    }
}
