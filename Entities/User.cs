using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        // se indica que este campo es auto generado
        // y es la llave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public int DNI { get; set; }

        public string FullName { get; set; }

        public string Password { get; set; }

        public UserType Type { get; set; }
    }
    
}
