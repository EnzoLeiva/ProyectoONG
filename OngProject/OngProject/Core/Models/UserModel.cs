using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.Models
{
    public class UserModel : EntityBase
    {

        [MaxLength(255)]
        [Required]
        public string firstName { get; set; }

        [MaxLength(255)]
        [Required]
        public string lastName { get; set; }

        [MaxLength(320)]
        [Required]
        [EmailAddress]
        public string email { get; set; }

        [MaxLength(20)]
        [Required]
        public string password { get; set; }

        [MaxLength(255)]
        public string photo { get; set; }
        
        public int roleId { get; set; } // Clave foranea hacia ID de Role
        [ForeignKey("roleId")]
        public virtual RoleModel RoleModel { get; set;}
        
    }
}
