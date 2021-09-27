using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myWebApp.Models
{
    public class Fish
    {
        public int ID { get; set; }
        [Display(Name = "Fish Type")]
        public string FishType { get; set; }
        
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Size { get; set; }
        public string Place { get; set; }
    }
}