using DL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly BL.Usuarios _usuario;
        //No olvidar inyectar la conexion
        public UsuarioController(BL.Usuarios usuarios)
        {

            _usuario = usuarios;
        }

        //public IActionResult GetAll()
        //{
        //    ML.Result result = _usuario.GetAll();

        //    if (result.Correct)
        //    {

        //        return Ok(result);
        //    }
        //    return BadRequest();

        //}        //private readonly BL.Usuarios  _usuario;
        ////No olvidar inyectar la conexion
        //public UsuarioController(BL.Usuarios usuarios)
        //{

        //    _usuario = usuarios;
        //}

        //public IActionResult GetAll()
        //{
        //    ML.Result result = _usuario.GetAll();

        //    if (result.Correct)
        //    {

        //        return Ok(result);
        //    }
        //    return BadRequest();

        //}
        [HttpGet]
        [Route("GetAll")]

        public IActionResult GetAll()
        {

            ML.Result result = _usuario.GetAll();
            if (result.Correct)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Add([FromBody] ML.Usuario usuario)
        {

            ML.Result result = _usuario.Add(usuario);
            if (result.Correct)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update([FromBody] ML.Usuario usuario)
        {

            ML.Result result = _usuario.Update(usuario);
            if (result.Correct)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
                
            }
        }
        [HttpDelete]
        [Route("Delete/{IdUsuario}")]
        public IActionResult Delete(int IdUsuario)
        {
            ML.Result result = _usuario.Delete(IdUsuario);
            if (result.Correct)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }

        }
        [HttpGet]
        [Route("GetByID")]
        public IActionResult GetById (int IdUsuario)
        {
            ML.Result result = _usuario.GetByID(IdUsuario);

            if (result.Correct)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
         
    }
}
