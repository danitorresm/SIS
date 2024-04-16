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
    }
}

