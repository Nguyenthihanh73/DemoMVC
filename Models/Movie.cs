using System;
using System.ComponentModel.DataAnnotations;

namespace demoMVC.Models
{
    public class Movie
    
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        [Required (ErrorMessage="Title is required.")]
        [MaxLength(15)]
        [MinLength(3)]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public int MyProperty { get; set; }
    }
}