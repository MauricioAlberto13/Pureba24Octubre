using DL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Usuarios
    {
        private readonly Prueba16octubreContext _context;

        public Usuarios(Prueba16octubreContext context)
        {
              _context= context;

        }

        public ML.Result Add(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                int filasAfectas = _context.Database.ExecuteSql($"SP_Insertar {usuario.Nombre},{usuario.Apellidos},{usuario.Edad},{usuario.Fecha} ");

                if (filasAfectas > 0)
                {
                    result.Correct = true;
                }
                else
                {
                    result.Correct = false;
                    result.ErrorMessage = "Ocurrio un error al insertar con SP";
                }
            }
            catch (Exception Ex)
            {

                result.Correct = false;
                result.ErrorMessage = Ex.Message;
                result.Ex = Ex;
            }

            return result;


        }


        public ML.Result Update(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                int filasAfectas = _context.Database.ExecuteSql($"SP_UpdateUsuario {usuario.IdUsuario}, {usuario.Nombre},{usuario.Apellidos},{usuario.Edad},{usuario.Fecha} ");

                if (filasAfectas > 0)
                {
                    result.Correct = true;
                }
                else
                {
                    result.Correct = false;
                    result.ErrorMessage = "Ocurrio un error al actualizar con SP";
                }
            }
            catch (Exception Ex)
            {

                result.Correct = false;
                result.ErrorMessage = Ex.Message;
                result.Ex = Ex;
            }

            return result;
        }



        public ML.Result Delete (int IdUsuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                int filasAfectas = _context.Database.ExecuteSql($"SP_DeleteUser {IdUsuario}");

                if (filasAfectas > 0)
                {
                    result.Correct = true;
                }
                else
                {
                    result.Correct = false;
                    result.ErrorMessage = "Ocurrio un error al eliminar con SP";
                }
            }
            catch (Exception Ex)
            {

                result.Correct = false;
                result.ErrorMessage = Ex.Message;
                result.Ex = Ex;
            }

            return result;
        }


        public ML.Result GetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
              //  var query= _context.VwgetAlls.FromSqlRaw("VWGetAll").ToList();

                var query = _context.VwgetAlls.FromSqlRaw("select * from VWGetAll ").ToList();
                result.Objects = new List<object> ();  
                if (query.Count >0)
                {
                    foreach (var item in query)
                    {
                        ML.Usuario usu = new ML.Usuario();

                        usu.IdUsuario = item.IdUsuario;
                        usu.Nombre = item.Nombre;
                        usu.Apellidos = item.Apellidos;
                        usu.Edad = Convert.ToInt16(item.Edad);
                        usu.Fecha =(item.Fecha).ToString();

                        result.Objects.Add(usu);
                    }

                    result.Correct = true;
                }
                else
                {
                    result.Correct = false;
                    result.ErrorMessage = "Ocurrio un error con el SP";
                }
            }
            catch (Exception Ex)
            {

                result.Correct = false;
                result.ErrorMessage = Ex.Message;
                result.Ex = Ex;
            }

            return result;
        }

        public ML.Result GetByID(int IdUsuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                var query = _context.VwgetAlls.FromSqlRaw($"SP_GetByID {IdUsuario}").AsEnumerable().FirstOrDefault();


                result.Objects = new List<object>();
                if (query != null)
                {
                  
                        ML.Usuario usu = new ML.Usuario();

                        usu.IdUsuario = query.IdUsuario;
                        usu.Nombre = query.Nombre;
                        usu.Apellidos = query.Apellidos;
                        usu.Edad = Convert.ToInt16(query.Edad);
                        usu.Fecha = (query.Fecha).ToString();

                        result.Objects.Add(usu);
                    

                    result.Correct = true;
                }
                else
                {
                    result.Correct = false;
                    result.ErrorMessage = "Ocurrio un error al buscar SP";
                }
            }
            catch (Exception Ex)
            {

                result.Correct = false;
                result.ErrorMessage = Ex.Message;
                result.Ex = Ex;
            }

            return result;
        }

    }
}
