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
    public class User
    {
        // se indica que este campo es auto generado
        // y es la llave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [DataMember]
        public int Id { get; set; }

        [DisplayName("Número de Cédula")]
        [Required]
        [DataMember]
        public int DNI { get; set; }

        [DisplayName("Nombre Completo")]
        [Required]
        [DataMember]
        public string FullName { get; set; }

        [DisplayName("Clave")]
        [Required]
        [DataMember]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [ForeignKey("UserTypeID")]
        [DataMember]
        public UserType UserType { get; set; }

        [DisplayName("Tipo de Usuario")]
        [Required]
        [DataMember]
        public UserTypeEnum UserTypeID { get; set; }

        public User()
        {
            UserTypeID = UserTypeEnum.User;
        }
    }
    
}
