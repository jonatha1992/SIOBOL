using Abstraccion;
using BE;
using MPP;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class BLLEstado_Elemento : IGestor<BEEstado_Elemento>
    {
        MPPEstado_Elemento mPPEstado_Elemento;
        public BLLEstado_Elemento()
        {
            mPPEstado_Elemento = new MPPEstado_Elemento();
        }
        public bool Actualizar(BEEstado_Elemento Object)
        {
            throw new NotImplementedException();
        }

        public BEEstado_Elemento Agregar(BEEstado_Elemento Object)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BEEstado_Elemento Object)
        {
            throw new NotImplementedException();
        }

        public BEEstado_Elemento ListarObjeto(BEEstado_Elemento Object)
        {
            return mPPEstado_Elemento.ListarObjeto(Object);
        }

        public List<BEEstado_Elemento> ListarTodo()
        {
            return mPPEstado_Elemento.ListarTodo();
        }

        public List<BEEstado_Elemento> ListarEstadoHallazgo()
        {
            var estados = mPPEstado_Elemento.ListarTodo();
            estados.Reverse();
            return estados.FindAll(x => x.Nombre == "RESGUARDO" || x.Nombre == "DESTRUIDO");
        }
        public List<BEEstado_Elemento> ListarEstadoEntrega()
        {
            return mPPEstado_Elemento.ListarTodo().FindAll(x => x.Nombre != "RESGUARDO");
        }

    }
}
