using Abstraccion;
using BE;
using DAL;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;

namespace MPP
{
    public class MPPCeac : IGestor<BECeac>
    {
        Conexion conexion = new Conexion();
        public bool Actualizar(BECeac Object)
        {
            throw new NotImplementedException();
        }

        public BECeac Agregar(BECeac Object)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BECeac Object)
        {
            throw new NotImplementedException();
        }


        public BECeac ListarObjeto(BECeac ceac)
        {
            MPPUrsa mPPUursas = new MPPUrsa();
            var regiones = mPPUursas.ListarTodo();
            // Preparar la consulta y los parámetros 
            ceac.Regiones = regiones;

            return ceac;

        }
        public List<BECeac> ListarTodo()
        {
            throw new NotImplementedException();

        }
    }
}
