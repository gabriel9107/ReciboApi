namespace RecibosApi.Entidades
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string marca { get; set; }
        public string Modelo { get; set; }

        public string Chasis { get; set; }
        public string placa { get; set; }
        public string Año { get; set; }

        public bool activo { get; set; }

        public int miembrosId { get; set;  }
        public Miembros miembros { get; set; }




    }
}
