using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EjecicioSeccionB.Models
{
    public class PersonaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Permite manejar en la tabla un secuencial
        [Display(Name = "Código de Persona")]
        public int CodigoPersona { get; set; }

        [Required (ErrorMessage = "El nombre de la persona es obligatorio")] //Será un campo requerido en el formulario
        [Column(TypeName = "varchar(35)")] //Defino tamaño y tipo de campo en la base de datos
        [Display(Name ="Nombre de la Persona")]
        public string NombrePersona { get; set; }

        [Required] //Será un campo requerido en el formulario
        [Column(TypeName = "varchar(35)")] //Defino tamaño y tipo de campo en la base de datos
        [Display(Name = "Apellido de la Persona")]
        public string ApellidoPersona { get; set; }

        [Required] //Será un campo requerido en el formulario
        [Column(TypeName = "int")] //Defino tamaño y tipo de campo en la base de datos
        [Display(Name = "Edad de la Persona")]
        public int Edad { get; set; }

        [Required] //Será un campo requerido en el formulario
        [Column(TypeName = "varchar(3)")] //Defino tamaño y tipo de campo en la base de datos
        [Display(Name = "Estado de la Persona")]
        public string EstadoPersona { get; set; } = "ACT";
    }
}
