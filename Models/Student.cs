using System.ComponentModel.DataAnnotations;

namespace Studentmgmt.Models
{
    public class Student{
        public int Id { get; set; }

        [Display(Name="Student Name")]
        [Required]
        public string Name{ get;set; }

        [Required]
        public string Address{ get;set; }
    }
}