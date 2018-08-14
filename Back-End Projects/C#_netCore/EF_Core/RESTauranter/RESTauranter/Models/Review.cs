using System;
using System.ComponentModel.DataAnnotations;

namespace RESTauranter.Models
{
    public class Review
    {
        [Key]
        public int id {get;set;}
        [Required]
        public string Name {get;set;}
        [Required]
        public string RestaurantName {get;set;}
        [Required]
        public string Content {get;set;}
        [Required]
        public DateTime Visited {get;set;}
        [Required]
        public int Rating {get;set;}
    }

}