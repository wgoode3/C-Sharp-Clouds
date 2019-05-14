using System;
using System.ComponentModel.DataAnnotations;

namespace Clouds.Models
{
    public class Cloud
    {
        [Required (ErrorMessage = "Altitude is required!")]
        [Range(0, 80000, ErrorMessage = "Altitude must be between 0 and 80K!")]
        [Display (Name="Altitude...")]
        public int altitude{get;set;}
        [Required (ErrorMessage = "Type is required!")]
        [MinLength(3, ErrorMessage = "Type must be 3 characters or more!")]
        [Display (Name="Type...")]
        public string type{get;set;}

    }
}