using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CD_Medico
    {
        public int codigoMed { get; set; }
        public string nombreMed { get; set; }
        public string especialidadMed { get; set; }
        public int consultorioMed { get; set; }

        //Instancia para conctar y desconectar de la BD
        private CD_Conexion conexion = new CD_Conexion();

        //Variable para lectura de datos en la BD
        private SqlDataReader lector = null;

        //Variable para ejecutar los comandos SQL
        private SqlCommand comando = null;

        public DataTable listar()
        {
            DataTable tabla = new DataTable();
            comando = new SqlCommand("dbo.ListarMedico");
            comando.Connection = conexion.conectar();//Conectar a la BD
            //Indicar que el comando es de tipo procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure;

            //Crear un adaptador para el comando
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tabla);

            comando.ExecuteNonQuery();
            conexion.desconectar();
            return tabla;
        }
    }
}
