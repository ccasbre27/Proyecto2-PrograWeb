﻿using System;
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
        
        [DisplayName("Descripción")]
        [Required]
        [DataMember]
        public string Description { get; set; }

        [DisplayName("Precio")]
        [DataType(DataType.Currency)]
        [Required]
        [DataMember]
        public decimal Price { get; set; }

        [DisplayName("Rentabilidad del Producto")]
        [Required]
        [RegularExpression(@"[1-5]", ErrorMessage = "Rango incorrecto")]
        [DataMember]
        public int Category { get; set; }

        public Product()
        {
        }

    }
}
