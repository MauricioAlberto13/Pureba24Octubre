using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class UsuarioController : Controller
    {

        private readonly BL.Usuarios _usuario;

        public UsuarioController(BL.Usuarios usuarios)
        {
        _usuario=usuarios;

        }
        public IActionResult GetAll()
        {
            ML.Usuario usuario = new ML.Usuario();
            ML.Result result = _usuario.GetAll();
            if (result.Correct)
            {
                 usuario.Usuarios= result.Objects;
            }
            else
            {
                return View();
            }

            return View(usuario);
        }
    }
}
