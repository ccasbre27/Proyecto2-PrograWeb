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
    public class UserType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [DataMember]
        public int Id { get; set; }
        
        [DisplayName("Nombre")]
        [Required]
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public bool IsActive { get; set; }
    }
}
