using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Web;

namespace APISTUDENT.Models
{
    public class Student
    {
        [Key]                          // validaciones
        [Required]                     // este daato es requerido,si no lo ingresa es un error
        [Range(1, 9999)]               //tiene que ir numero dentro de ese rango
        public int StudentID { get; set; }    //prop tab tab

        [StringLength(30)]             //lo maximo son 30 caracteres
        [Required(ErrorMessage = "You must enter the field {0}")]  //el 0 indentifica al dato
        public string LastName { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must contain between {2} and {1} characters", MinimumLength = 2)]    //el dato debe ser de 2 a 30 caracteres, el {2}representa a minimo 2 , el {1}representa maximo 30
        [Required(ErrorMessage = "You must enter the file {0}")]
        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]  //la forma de escribir la fecha
        public DateTime EnrollmentDate { get; set; }






    }

}