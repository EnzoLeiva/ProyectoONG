using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.DTOs
{
    public class NewsDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        [MaxLength(65535)]
        public string Content { get; set; }
        [Required]
        [MaxLength(255)]
        public string Image { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}
