using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;

namespace Negocio
{
    public class CN_Paciente
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public string genero { get; set; }
        public string eps { get; set; }

        public bool encontro = false;

        private CD_Paciente objCliente=new CD_Paciente();
        public void insertarPaciente(int id,string nom,string ape, int edad)
        {
            objCliente.insertar(id,nom,ape,edad);
        }

        public void actualizarPaciente(int id, string nom, string ape, int edad)
        {
            objCliente.actualizar(id, nom, ape, edad);
        }

        public void eliminarPaciente(int id)
        {
            objCliente.eliminar(id);
           
        }
        public void buscarPaciente(int id)
        {
            objCliente.buscar(id);
            if (objCliente.encontro)
            {
                this.codigo = objCliente.codigo;
                this.nombre = objCliente.nombre;
                this.apellido = objCliente.apellido;
                this.edad = objCliente.edad;
                this.genero = objCliente.genero;
                this.eps = objCliente.eps;
                encontro = true;
            }
            else
            {
                encontro = false;
            }
        }

        public DataTable listarPaciente()
        {
            return objCliente.listar();
        }
    }//clase
}
