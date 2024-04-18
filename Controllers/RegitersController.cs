using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SIS.Data;
using SIS.Models;

namespace SIS.Controllers
{
    public class RegistersController : Controller
    {
        public readonly DatosContext _context;

                public RegistersController(DatosContext context)
            {
                _context = context;
            }/**/

        /*1.Index
        ************************************************************************/
            public async Task<IActionResult> Index(){
            return View(await _context.Registers.ToListAsync());
        }
        /**************************************************************************/
        /*2.Create
        ***************************************************************************/
        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Create(Register register) {
            _context.Registers.Add(register);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        /**************************************************************************/
        /*3.Editar
        *************************************************************************/
        public async Task<IActionResult> Edit(int? id){
            
            return View(await _context.Registers.FirstOrDefaultAsync(s=>s.Id == id));
        }      
        [HttpPost]
        public IActionResult Edit(int id, Register register){
            _context.Registers.Update(register);
            _context.SaveChanges();
            return RedirectToAction("Index");
        
        }
        /**************************************************************************/
    }
}

