using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public String ProfilePictureUrl { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage ="Please Enter Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage ="Please Enter Biography")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Please Enter Text Between 3 to 50")]
        public string Bio { get; set; }
        //Relationships
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
