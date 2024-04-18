using Microsoft.EntityFrameworkCore;
using SIS.Models;
  namespace SIS.Data
  {
    public class DatosContext: DbContext
    {
      public DatosContext(DbContextOptions<DatosContext> options):base(options){

      }
      /*Aqui registramos nuestros modelos*/
      public DbSet<Employe> Employees {get;set;}
      public DbSet<Register> Registers {get;set;}
    }
  }