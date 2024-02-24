using Microsoft.AspNetCore.Components.Forms;
using System.Reflection.Emit;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.ComponentModel.DataAnnotations.Schema;

namespace JoelMovies_JamesGoaslind.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }    
        public string Title { get; set; }
        [Required(ErrorMessage = "The Year field is required")] //Message when error
        [Range(1888, int.MaxValue, ErrorMessage = " Must be earlier than 1888")] 
        public int Year { get; set; }
        
        public string? Director { get; set; }
       
        public string? Rating { get; set; }
        [Required]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        [Required]
        public string CopiedToPlex { get; set; }

        [MaxLength(25)]
        public string? Notes { get; set; }
    }
}