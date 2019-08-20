using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace WindowsFormsApplication1.Clases
{
    class Datos
    {
        //conectar a la bd
        private OleDbConnection conexion = new OleDbConnection();
        //vamos a usar comandos 
        private OleDbCommand comando = new OleDbCommand();
        private string cadenaConexion = @"Provider=SQLNCLI11;Data Source=maquis;User ID=avisuales1;Initial Catalog=BD_bugs;Password=avisuales1";
        //DEFINIR METODOS PARA ESTA CLASE
        private void conectar()
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType=CommandType.Text;
        }
        private void desconectar()
        {
            conexion.Close();
        }
        public DataTable consultar(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            this.conectar();
            comando.CommandText=consultaSQL;
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());
            return tabla;
        }
    }
}
