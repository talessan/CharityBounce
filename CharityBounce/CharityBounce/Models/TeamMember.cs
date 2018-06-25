using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //V 3.5 //Display
using System.ComponentModel; //V1 of the .NET framework //DisplayName
using System.Linq;
using System.Web;
using CharityBounce.Validation;

namespace CharityBounce.Models
{
    //Model - The representation of the data needed by the application

    //Enitiy model / Data Model
    //Domain Model
    //View Model

  
    public class TeamMember
    {


        public int Id { get; set; }

        [Required]
        [StringLength(75)]
        public string Name { get; set; }

        //Not required, because some members are just raising for the team as a whole
        [DataType(DataType.Url)]
        [Display(Name = "Charity Page")]
        [StringLength(255)]
        public string CharityPage { get; set; } //Ugly Url

        [Required]
        [LettersOnly(ErrorMessage = "{0} must be 3 - 10 letters")]
        [Display(Name = "Short Name")]
        [StringLength(10)]
        public string Token { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? Registered { get; set; }

    }
}