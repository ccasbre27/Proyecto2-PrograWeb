using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    [DataContract]
    public class Product
    {
        // se indica que este campo es auto generado
        // y es la llave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [DisplayName("Descripción")]
        [Required]
        public string Description { get; set; }

        [DisplayName("Precio")]
        [Required]
        public decimal Price { get; set; }

        [DataMember]
        [DisplayName("Categoría")]
        [Required]
        [RegularExpression(@"[1-5]", ErrorMessage = "Rango incorrecto")]
        public int Category { get; set; }

        public bool IsActive { get; set; }

        public Product()
        {
            IsActive = true;
        }

    }
}
