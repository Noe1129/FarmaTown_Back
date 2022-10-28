﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using farmatown.Modelos;

namespace farmatown.Controllers
{
    class ArticleController
    {
        public string StrConnection { get; }
        public SqlCommand Command { get; }
        public SqlConnection Conn { get; }

        public ArticleController()
        {
            StrConnection = Properties.Resources.strConnection;
            Conn = new SqlConnection(StrConnection);
            Command = new SqlCommand();
        }

        //METODOS GENERICOS ABRIR CONEXION SI ESTA CERRADA, CERRAR CONEXION SI ESTA ABIERTA, SETEAR COMANDO
        public void OpenConn()
        {
            if (Conn.State.Equals(ConnectionState.Closed))
                Conn.Open();
        }

        public void CloseConn()
        {
            if (Conn.State.Equals(ConnectionState.Open))
                Conn.Close();
        }

        public void SetCommand(CommandType type, string CommandText)
        {
            Command.Connection = Conn;
            Command.CommandType = type;
            Command.CommandText = CommandText;
        }

        //-------------------------METODOS-------------

        public DataTable obtenerArticulosComboBox()
        {
            DataTable table = new DataTable();
            Command.Parameters.Clear();
            OpenConn();

            SetCommand(CommandType.StoredProcedure, "SP_CONSULTAR_ARTICULOS_COMBO_BOX");
            table.Load(Command.ExecuteReader());
            CloseConn();

            return table;
        }

        public DataTable obtenerTiposArticulosComboBox()
        {
            DataTable table = new DataTable();
            Command.Parameters.Clear();
            OpenConn();

            SetCommand(CommandType.StoredProcedure, "SP_CONSULTAR_TIPO_ARTICULOS_COMBO_BOX");
            table.Load(Command.ExecuteReader());
            CloseConn();

            return table;
        }

        public DataTable obtenerDrogasComboBox()
        {
            DataTable table = new DataTable();
            Command.Parameters.Clear();
            OpenConn();

            SetCommand(CommandType.StoredProcedure, "SP_CONSULTAR_DROGAS_COMBO_BOX_ARTICULOS");
            table.Load(Command.ExecuteReader());
            CloseConn();

            return table;
        }

        public DataTable obtenerLaboratoriosComboBox()
        {
            DataTable table = new DataTable();
            Command.Parameters.Clear();
            OpenConn();

            SetCommand(CommandType.StoredProcedure, "SP_CONSULTAR_LABORATORIOS_COMBO_BOX_ARTICULOS");
            table.Load(Command.ExecuteReader());
            CloseConn();

            return table;
        }

        internal void CrearArticulo(Articulo articulo)
        {
            try
            {
                 
                Command.Parameters.Clear();
                OpenConn();
                Command.Parameters.AddWithValue("@nombreArticulo", articulo.nomArticulo);
                Command.Parameters.AddWithValue("@stock", articulo.Stock);
                Command.Parameters.AddWithValue("@precio", articulo.preUnitario);
                Command.Parameters.AddWithValue("@tipoArticulo", articulo.tipoArticulo.IdTipoArticulo);
                SetCommand(CommandType.StoredProcedure, "SP_INSERTAR_ARTICULO");
                Command.ExecuteReader();
            }
            catch (Exception e)
            {
                throw e;
            } finally
            {
                CloseConn();
            }
            
        }

        public DataTable obtenerArticulosGrilla()
        {
            DataTable table = new DataTable();
            Command.Parameters.Clear();
            OpenConn();

            SetCommand(CommandType.StoredProcedure, "SP_CONSULTAR_ARTICULOS_GRILLA");
            table.Load(Command.ExecuteReader());
            CloseConn();

            return table;
        }

        public DataTable ObtenerArticulosConFiltro(string nombre)
        {
            DataTable table = new DataTable();
            Command.Parameters.Clear();
            OpenConn();
            Command.Parameters.AddWithValue("@nombre", nombre);
            SetCommand(CommandType.StoredProcedure, "SP_CONSULTAR_ARTICULOS_POR_NOMBRE");
            table.Load(Command.ExecuteReader());
            CloseConn();

            return table;
        }

        public DataTable ObtenerArticulosConFiltroDroga(string droga)
        {
            DataTable table = new DataTable();
            Command.Parameters.Clear();
            OpenConn();
            Command.Parameters.AddWithValue("@droga", droga);
            SetCommand(CommandType.StoredProcedure, "SP_CONSULTAR_ARTICULOS_POR_DROGA");
            table.Load(Command.ExecuteReader());
            CloseConn();

            return table;
        }

        public int ObtenerStock(int idArticulo)
        {
            OpenConn();
            //asegurase de mantener limpios los parametros
            Command.Parameters.Clear();
            //creo el comando y le asigno la transaccion 
            SetCommand(CommandType.StoredProcedure, "SP_CONSULTAR_STOCK");
            Command.Parameters.AddWithValue("@idArticulo", idArticulo);

            //parametros de salida de SQL
            SqlParameter stock = new SqlParameter("@stock", SqlDbType.Int);
            stock.Direction = ParameterDirection.Output;
            Command.Parameters.Add(stock);

            Command.ExecuteNonQuery();
            CloseConn();
            return (int)stock.Value;

        }

      /*  internal void EliminarArticulo(int idArticulo)
        {
            OpenConn();
            //asegurase de mantener limpios los parametros
            Command.Parameters.Clear();
            //creo el comando 
            SetCommand(CommandType.StoredProcedure, "SP_ELIMINAR_ARTICULO");
            Command.Parameters.AddWithValue("@idArticulo", idArticulo);
            Command.ExecuteNonQuery();
            CloseConn();
        }*/

        public bool ModificarArticulo(Articulo articulo)
        {   
            try
            {
                OpenConn();

                SetCommand(CommandType.StoredProcedure, "SP_MODIFICAR_ARTICULO");
                Command.Parameters.AddWithValue("@idArticulo", articulo.idArticulo);
                Command.Parameters.AddWithValue("@nombre", articulo.nomArticulo);
                Command.Parameters.AddWithValue("@stock", articulo.Stock);
                Command.Parameters.AddWithValue("@precio", articulo.preUnitario);
                Command.Parameters.AddWithValue("@idTipoArticulo", articulo.tipoArticulo.IdTipoArticulo);
                Command.Parameters.AddWithValue("@idDroga", articulo.droga.IdDroga);
                Command.Parameters.AddWithValue("@idLaboratorio", articulo.laboratorio.IdLab);

                int filasAfectadas = Command.ExecuteNonQuery();
                return filasAfectadas == 1;
            }
            catch (Exception e)
            {

                throw e;
            } finally
            {
                CloseConn();
            }
            
        }


    }
}
