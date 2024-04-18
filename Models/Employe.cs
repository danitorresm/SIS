namespace SIS.Models
        {
          public class Employe
          {
            public int Id {get; set;}
            public string? Name {get; set;}
            public string? LastName {get; set;}
            public string? Cedula {get; set;}
            public string? Email {get; set;}
            public string? Phone {get; set;}
            public string? Password {get; set;}
            public string? Status {get; set;}/*debe de ser un select con Activo/Inactivo*/
            public int? Register_id {get; set;}
          
          }
          
        }
        
       