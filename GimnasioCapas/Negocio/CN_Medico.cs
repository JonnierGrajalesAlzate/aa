using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class CN_Medico
    {
        CD_Medico objMedico = new CD_Medico();
        public int codigoMed { get; set; }
        public string nombreMed { get; set; }
        public string especialidadMed { get; set; }
        public int consultorioMed { get; set; }

        public DataTable listarMedico()
        {
            return objMedico.listar();
        }
    }
}
