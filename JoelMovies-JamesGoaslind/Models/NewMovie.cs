using Microsoft.AspNetCore.Components.Forms;
using System.Reflection.Emit;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace JoelMovies_JamesGoaslind.Models
{
    public class NewMovie
    {
        [Key]
        [Required]
        public int NewMovieID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
       
        public bool Edited { get; set; }
        public string Lent_To { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }
    }
}