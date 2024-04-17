using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIS.Data;
using SIS.Models;

namespace SIS.Controllers
{
    public class EmployeesController : Controller
    {
        public readonly DatosContext _context;

                public EmployeesController(DatosContext context)
            {
                _context = context;
            }/**/

        /*1.Index
        ************************************************************************/
            public async Task<IActionResult> Index(){
            return View(await _context.Employees.ToListAsync());
        }
        /**************************************************************************/
        /*2.Create
        ***************************************************************************/
        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employe employe) {
            _context.Employees.Add(employe);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        /**************************************************************************/
        /*3.Editar
        ****************************************************************************/
        public async Task<IActionResult> Edit(int? id){
            
            return View(await _context.Employees.FirstOrDefaultAsync(s=>s.Id == id));
        }      
        [HttpPost]
        public IActionResult Edit(int id, Employe employe){
            _context.Employees.Update(employe);
            _context.SaveChanges();
            return RedirectToAction("Index");
        
        }
        /**************************************************************************/
        /*4.Login
        **************************************************************************/
        [HttpPost]
    public ActionResult MostrarFechaHora()
    {
        // Crear un nuevo objeto Employe con la fecha y hora actual
        Register register = new Register
        {
            HoraEntrada = DateTime.Now
        };

        // Aquí puedes guardar la fecha y hora en tu base de datos o realizar otras operaciones necesarias

        // Devolver la vista con el modelo Employe
        return View("MostrarFechaHora", register);
    }
        
    }
}
