using Abstraccion;
using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public class BLLHallazgo : BLLPadreHallazgo, IGestor<BEHallazgo>
    {

        MPPHallazgo mPPHallazgo;

        public BLLHallazgo()
        {
            mPPHallazgo = new MPPHallazgo();
        }
        public BEHallazgo Agregar(BEHallazgo pHallazgo)
        {
         
            return mPPHallazgo.Agregar(pHallazgo);
        }
        public bool Actualizar(BEHallazgo Phallazgo)
        {

            return mPPHallazgo.Actualizar(Phallazgo);
        }

        public List<BEHallazgo> ListarTodo()
        {
            return mPPHallazgo.ListarTodo();
        }

        public List<BEHallazgo> ListarTodo(BEUnidad bEUnidad)
        {
            var hallazgos = mPPHallazgo.ListarTodo(bEUnidad);

            List<BEHallazgo> lista = hallazgos.OrderByDescending(x => x.FechaHallazgo).ToList();


            return lista;
        }
        public BEHallazgo ListarObjeto(BEHallazgo Phallazgo)
        {
            Phallazgo = ListarHallazgoElementos(Phallazgo);
            Phallazgo = ListarHallazgoPersonas(Phallazgo);
            return Phallazgo;
        }

        public BEHallazgo ListarHallazgoPersonas(BEHallazgo Phallazgo)
        {
            return mPPHallazgo.ListarHallazgoPersonas(Phallazgo);
        }

        public BEHallazgo ListarHallazgoElementos(BEHallazgo Phallazgo)
        {
            return mPPHallazgo.ListarHallazgoElementos(Phallazgo);
        }
        public bool Eliminar(BEHallazgo pHallazgo)
        {
            return mPPHallazgo.Eliminar(pHallazgo);
        }


        public List<BEHallazgo> ListarTodo(BEUnidad bEUnidad, DateTime fecha)
        {
            var hallazgos = mPPHallazgo.ListarTodo(bEUnidad, fecha);
            
            List<BEHallazgo> lista = hallazgos.OrderByDescending(x => x.FechaHallazgo).ToList();


            return lista;
        }

        public override int ObtenerNroActa(BEUnidad unidad, int anio)
        {
             string nroHallazgo = mPPHallazgo.ObtenerNroActa(unidad , anio); 

            int numeroSecuencial = 1;


            if (!string.IsNullOrEmpty(nroHallazgo) && nroHallazgo.Contains(unidad.Cod))
            {
                string numeroSecuencialStr = nroHallazgo.Substring(0, nroHallazgo.IndexOf(unidad.Cod));

                if (int.TryParse(numeroSecuencialStr, out int numeroParseado))
                {
                    numeroSecuencial = numeroParseado + 1;
                }
            }

            return numeroSecuencial;
        }

        public override int ExtraerNro(string NroActaHallago, BEUnidad unidad)
        {

            int numeroSecuencial = 0;

            string numeroSecuencialStr = NroActaHallago.Substring(0, NroActaHallago.IndexOf(unidad.Cod));

            if (int.TryParse(numeroSecuencialStr, out int numeroParseado))
            {
                numeroSecuencial = numeroParseado;
            }
            return numeroSecuencial;
        }
    }
}
