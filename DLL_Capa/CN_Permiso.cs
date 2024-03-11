using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DLL_Capa;
using CapaEntidad;


namespace DLL_Capa
{
    public class CN_Permiso
    {
        private CD_PERMISO objcd_permiso = new CD_PERMISO();

        public List<Permiso> Listar(int IdUsuario)
        {
            return objcd_permiso.Listar(IdUsuario);
        }

    }
}
