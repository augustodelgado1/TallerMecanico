﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.BaseDeDatos
{
    public class ClienteDao : ConeccionABaseDeDatos<Cliente>
    {
       
        public override bool Agregar(Cliente unElemento)
        {
            bool estado;
            estado = false;
            try
            {
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@email", unElemento.Email);
                comando.Parameters.AddWithValue("@clave", unElemento.Clave);
                comando.Parameters.AddWithValue("@Nombre", unElemento.Nombre);
                comando.Parameters.AddWithValue("@FechaDeNacimiento", unElemento.FechaDeNacimiento);
                comando.Parameters.AddWithValue("@dni", unElemento.Dni);

                coneccionSql.Open();
                comando.CommandText = "INSERT INTO Cliente(user,email,clave,dni) " +
                    "Values(@user,@email,@clave,@dni)";

                if (comando.ExecuteNonQuery() == 1)
                {
                    estado = true;
                }
            }
            catch (Exception e)
            {
                throw new ConeccionBaseDeDatosException("Ocurrio un problema al intentar obtener los archivos de la base de datos", e.InnerException);
            }
            finally
            {
                if (coneccionSql.State == ConnectionState.Open)
                {
                    coneccionSql.Close();
                }
            }

            return estado;
        }

        public override List<Cliente> Leer()
        {
            List<Cliente> list = null;

            try
            {
                coneccionSql.Open();
                comando.CommandText = $"Select * From Cliente";

                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    list = new List<Cliente>();
                    while (dataReader.Read())
                    {
                        list.Add(ObtenerUnElemento(dataReader));
                    }
                }
            }
            catch (Exception e)
            {
                throw new ConeccionBaseDeDatosException("Ocurrio un problema al intentar obtener los archivos de la base de datos", e.InnerException);
            }
            finally
            {
                if (coneccionSql.State == ConnectionState.Open)
                {
                    coneccionSql.Close();
                }
            }

            return list;
        }

        public override Cliente ObtenerUnElemento(SqlDataReader dataReader)
        {


            throw new ConeccionBaseDeDatosException("Ocurrio un problema al intentar obtener los archivos de la base de datos");
            /* return new Cliente(Convert.ToInt32(dataReader["ID"]), Convert.ToString(dataReader["user"]),
                 Convert.ToString(dataReader["email"]), Convert.ToString(dataReader["clave"]), 
                 Convert.ToString(dataReader["dni"]),null);*/
        }

       
    }
}
