using Microsoft.AspNetCore.Mvc;
using MvcEmpleados.Data;
using MvcEmpleados.Models;
using Microsoft.EntityFrameworkCore;

namespace MvcEmpleados.Controllers
{
    public class EmpleadoController : Controller
    {
        // variable para trabajar con la bd
        private readonly AppDbContext _appDbContext;

        public EmpleadoController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        [HttpGet]
        public async Task<IActionResult> Lista()
        {
            List<Empleado> lista = await _appDbContext.Empleados.ToListAsync();
            return View(lista);
        }
    }
}