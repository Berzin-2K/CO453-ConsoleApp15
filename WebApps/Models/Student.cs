using System;
using System.ComponentModel1.DataAnnotations;
using.Tasks;

namespace Webapp.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        
        [StringLength(20), Required]

        public String Name { get; set; }

    [Range(0, 100)]
    public int Mark { get; set; }
}
}
