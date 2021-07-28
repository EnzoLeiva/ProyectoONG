using OngProject.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace OngProject.Infrastructure.Data
{
    public class MembersModel : EntityBase
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string Image { get; set; }
    }
}