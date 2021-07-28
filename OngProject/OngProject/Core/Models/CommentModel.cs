using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.Models
{
    public class CommentModel : EntityBase
    {
        [Required]
    public int User_id { get; set; }
        [Required]
    public int post_id { get; set; }
        public string Body { get; set; }



    }
}
