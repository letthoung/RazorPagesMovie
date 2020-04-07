using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }
        
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "The first letter is required to be uppercase. White space, numbers, and special characters are not allowed.")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [Column(TypeName= "decimal(18,2)")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$", ErrorMessage = "Requires that the first character be an uppercase letter.")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }
    }
}
