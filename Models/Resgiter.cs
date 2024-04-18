namespace SIS.Models
        {
          public class Register
          {
            public int Id {get; set;}            
            public DateTime? HoraEntrada {get; set;}            
            public DateTime? HoraSalida {get; set;}
            public DateOnly? Fecha {get; set;}
          }
        }