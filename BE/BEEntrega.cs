using Abstraccion;
using System;
using System.Collections.Generic;

namespace BE
{
    public class BEEntrega : BEPadreHallazgo, IEntidad, IComparable<BEEntrega>
    {
        public BEEntrega()
        {
            listaElementos = new List<BEElemento>();
        }
        public BEEntrega(int id, string acta)
        {
            Id = id;
            NroActa = acta;
        }

        public int Id { get; set; }

        public DateTime FechaEntrega { get; set; }
        public override int Anio
        {
            get { return FechaEntrega.Year; }
        }
        public int CompareTo(BEEntrega other)
        {
            if (this.FechaEntrega > other.FechaEntrega) return 1;
            else if (this.FechaEntrega < other.FechaEntrega) return -1;
            else return 0;
        }

        public override string ToString()
        {
            return NroActa.ToString();
        }
    }
}
