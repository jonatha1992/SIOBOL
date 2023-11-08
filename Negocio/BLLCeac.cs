using Abstraccion;
using BE;
using MPP;
using System.Collections.Generic;

namespace Negocio
{
    public class BLLCeac : IGestor<BECeac>
    {
        MPPCeac mPPceac;

        public BLLCeac()
        {
            mPPceac = new MPPCeac();
        }

        public bool Actualizar(BECeac Object)
        {
            throw new System.NotImplementedException();
        }

        public BECeac Agregar(BECeac Object)
        {
            throw new System.NotImplementedException();
        }

        public bool Eliminar(BECeac Object)
        {
            throw new System.NotImplementedException();
        }

        public BECeac ListarObjeto(BECeac Object)
        {
            return mPPceac.ListarObjeto(Object);
        }

        public List<BECeac> ListarTodo()
        {
            throw new System.NotImplementedException();

        }

    }
}
