using Abstraccion;
using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public class BLLEntrega : BLLPadreHallazgo, IGestor<BEEntrega>
    {

        MPPEntrega mmPEntrega;
        MPPElemento mPPElemento;

        public BLLEntrega()
        {
            mmPEntrega = new MPPEntrega();
            mPPElemento = new MPPElemento();
        }

        

        public BEEntrega Agregar(BEEntrega entrega)
        {
            var verificarExisteNroActa = ListarTodo().Exists(x => x.NroActa == entrega.NroActa);
            if (!verificarExisteNroActa) // SI NO EXISTE QUE LO AGREGUE
            {
                return mmPEntrega.Agregar(entrega);
            }
            else return entrega;

        }
        public BEEntrega ListarObjeto(BEEntrega entrega)
        {
            entrega = ListarEntregaElementos(entrega);
            entrega = ListarEntregaPersonas(entrega);
            return entrega;

        }

        public BEEntrega ListarEntregaPersonas(BEEntrega entrega)
        {
            return mmPEntrega.ListarEntregaPersonas(entrega);
        }
        public BEEntrega ListarEntregaElementos(BEEntrega entrega)
        {
            return mmPEntrega.ListarEntregaElementos(entrega);
        }
        public bool Actualizar(BEEntrega entrega)
        {
            return mmPEntrega.Actualizar(entrega);
        }

        public bool Eliminar(BEEntrega pEntrega)
        {
            BLLElemento bLLElemento = new BLLElemento();

            if (pEntrega.listaElementos != null)
            {
                foreach (var item in pEntrega.listaElementos)
                {
                    bLLElemento.EliminarElementoEntrega(pEntrega, item);
                }
            }

            return mmPEntrega.Eliminar(pEntrega);
        }

        public List<BEEntrega> ListarTodo()
        {
            return mmPEntrega.ListarTodo();
        }


        public List<BEEntrega> ListarTodo(BEUnidad bEUnidad, DateTime Fecha)
        {
            var entregas = mmPEntrega.ListarTodo(bEUnidad, Fecha);
            var Lista =   entregas.OrderByDescending(x => x.FechaEntrega).ToList();

            return Lista;
        }
        public List<BEEntrega> ListarTodo(BEUnidad bEUnidad)
        {
            var entregas = mmPEntrega.ListarTodo(bEUnidad);
            var Lista = entregas.OrderByDescending(x => x.FechaEntrega).ToList();

            return Lista;
        }
        public override int ObtenerNroActa(BEUnidad unidad, int anio)
        {
            string nroEntrega = mmPEntrega.ObtenerNroActa(unidad, anio);
           
            int numeroSecuencial = 1;

            if (!string.IsNullOrEmpty(nroEntrega) && nroEntrega.Contains(unidad.Cod))
            {
                string numeroSecuencialStr = nroEntrega.Substring(0, nroEntrega.IndexOf(unidad.Cod));

                if (int.TryParse(numeroSecuencialStr, out int numeroParseado))
                {
                    numeroSecuencial = numeroParseado + 1;
                }
            }

            return numeroSecuencial;
        }

        public override int ExtraerNro(string NroActa, BEUnidad unidad)
        {

            int numeroSecuencial = 0;

            string numeroSecuencialStr = NroActa.Substring(0, NroActa.IndexOf(unidad.Cod));

            if (int.TryParse(numeroSecuencialStr, out int numeroParseado))
            {
                numeroSecuencial = numeroParseado;
            }
            return numeroSecuencial;
        }
    }
}
