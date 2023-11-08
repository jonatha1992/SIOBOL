using System.Collections.Generic;

namespace BE
{
    public class BECeac : BEDestino
    {
        public BECeac() { }
        public BECeac(int id)
        {
            Id = id;
        }
        public BECeac(int id , string nombre)
        {
            Id = id;
            Nombre= nombre;
        }
        public List<BEUrsa> Regiones { get; set; }

        public override object Clone()
        {
            return new BECeac
            {
                Id = this.Id,
                Nombre = this.Nombre,
                Regiones = this.Regiones!= null ? new List<BEUrsa>(this.Regiones) : null

            };
        }

    }
}
