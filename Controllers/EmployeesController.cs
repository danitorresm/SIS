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
        /*Login
        ****************************************************************************/
         public IActionResult Login(){
            return View();
        }

        public IActionResult Inicio_Sesion(){
            return View();
        }
            
        [HttpPost]
        public IActionResult verifica(string Cedula, string Password)
        {
           var usuarioEncontrado = _context.Employees.FirstOrDefault(u => u.Cedula == Cedula && u.Password == Password);  
            if (usuarioEncontrado != null)
        {
           return RedirectToAction("Inicio_Sesion", "Employees"); // Puedes pasar el ID u otro parámetro si lo necesitas
        }
        else
        {   var Mensaje ="Datos incorrectos";
            ModelState.AddModelError(string.Empty,"Datos incorrectos");
            return RedirectToAction("Login", new{Mensaje} );
        }
        
        }



        public IActionResult MostrarFechaHora(){
            return View();
        }
        [HttpPost]
        public ActionResult RegistrarHoraFecha(Register register)


        {

            _context.Registers.Update(register);
            _context.SaveChanges();
            
            // Capturar la hora y la fecha actual
            DateTime fechaHoraActual = DateTime.Now;

            // Aquí puedes realizar las operaciones necesarias, como guardar la hora y la fecha en una base de datos
            
            // Por ejemplo, si deseas mostrar un mensaje con la hora y la fecha registradas
            ViewBag.Mensaje = fechaHoraActual;

            // Redirigir a la vista Index o a cualquier otra vista según sea necesario
            return RedirectToAction("MostrarFechaHora");
        }
        
        
        
        
        
        
        /*Registrar hora
        **************************************************************************/
        /*[HttpPost]
        public ActionResult MostrarFechaHora()
        {
        // Crear un nuevo objeto Employe con la fecha y hora actual
        Register register = new Register
        {
            HoraEntrada = DateTime.Now
        };

        // Aquí puedes guardar la fecha y hora en tu base de datos o realizar otras operaciones necesarias

        // Devolver la vista con el modelo Employe
        return View("MostrarFechaHora", register);*/
    }
        
    }



