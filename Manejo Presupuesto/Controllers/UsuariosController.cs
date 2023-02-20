using Manejo_Presupuesto.Models;
using Microsoft.AspNetCore.Mvc;

namespace Manejo_Presupuesto.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Resgistro(RegistroViewModel modelo)
        {
            if (!ModelState.IsValid)
            {
                return View(modelo);
            }

            return RedirectToAction("Index", "Transacciones");
        }
    }
}
