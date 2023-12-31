﻿using Abstraccion;
using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Negocio
{
    public class BLLElemento : IGestor<BEElemento>
    {
        MPPElemento mPPElemento;

        public BLLElemento()
        {
            mPPElemento = new MPPElemento();
        }

        public bool Actualizar(BEElemento pElemento)
        {
            return mPPElemento.Actualizar(pElemento);
        }
        public bool AgregarElementoHallazgo(BEHallazgo eHallazgo, BEElemento elemento)
        {

            return mPPElemento.Agregar_Elemento_Hallazgo(eHallazgo, elemento);
        }
        public bool AgregarElementoEntrega(BEEntrega eEntrega, BEElemento elemento)
        {
            BLLEstado_Elemento bLLEstado_Elemento = new BLLEstado_Elemento();
            var estadoEntregado = bLLEstado_Elemento.ListarTodo().Find(x => x.Nombre == "ENTREGADO");

            elemento.Estado = estadoEntregado;
            return mPPElemento.Agregar_Elemento_Entrega(eEntrega, elemento);
        }
        public bool EliminarElementoEntrega(BEEntrega eEntrega, BEElemento elemento)
        {
            BLLEstado_Elemento bLLEstado_Elemento = new BLLEstado_Elemento();
            var estadoResguardo = bLLEstado_Elemento.ListarTodo().Find(x => x.Nombre == "RESGUARDO");

            elemento.Estado = estadoResguardo;
            elemento.Entrega = null;    
            return mPPElemento.Eliminar_Elemento_Entrega(elemento);
        }

        public BEElemento Agregar(BEElemento pElemeto)
        {
            return mPPElemento.Agregar(pElemeto);
        }

        public bool Eliminar(BEElemento pElemento)
        {
            return mPPElemento.Eliminar(pElemento);
        }
        public List<BEElemento> ListarTodo()
        {
            return mPPElemento.ListarTodo();
        }

        public BEElemento ListarObjeto(BEElemento pElemento)
        {
            return mPPElemento.ListarObjeto(pElemento);
        }

        public string ObtenerNroHallazgo(BEElemento pElemento)
        {
            string NroActa = mPPElemento.ObtenerNroHallazgo(pElemento);
            return NroActa;
        }

        public async Task<List<ElementoBusqueda>> BusquedaElementos(DateTime? desde, DateTime? hasta, BECategoria bECategoria, BEArticulo bEArticulo, string lugar, string descripcion, BEUnidad unidad, string nrohallazgo)
        {
            var result= await mPPElemento.BusquedaElementos(desde, hasta, bECategoria, bEArticulo, lugar, descripcion, unidad, nrohallazgo);
            return result; 
        }

        public BEElemento CovertirElemento(ElementoBusqueda elementoBusqueda)
        {
            BEElemento bEElemento = ListarObjeto(new BEElemento(elementoBusqueda.Id));
            return bEElemento;

        }

        public List<ElementoBusqueda> BusquedaElementosHallazgo(string NroActa)
        {
            return mPPElemento.BusquedaElementosHallazgo(NroActa);
        }



    }
}
