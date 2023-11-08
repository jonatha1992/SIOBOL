using Abstraccion;
using System;
using System.Collections.Generic;

namespace BE
{
    public class BEHallazgo : BEPadreHallazgo, IEntidad, IComparable<BEHallazgo>
    {
        public BEHallazgo()
        {

            listaElementos = new List<BEElemento>();
        }
        public BEHallazgo(int id, string acta ="")
        {
            Id = id;
            NroActa = acta;
        }

      
        public int Id { get; set; }
        public DateTime FechaHallazgo { get; set; }
        public override int Anio
        {
            get { return FechaHallazgo.Year; }
        }
        public string LugarHallazgo { get; set; }

        
        public int CompareTo(BEHallazgo other)
        {
            if (this.FechaHallazgo > other.FechaHallazgo) return 1;
            else if (this.FechaHallazgo < other.FechaHallazgo) return -1;
            else return 0;
        }

        public override string ToString()
        {
            return NroActa.ToString();
        }
    }
}
