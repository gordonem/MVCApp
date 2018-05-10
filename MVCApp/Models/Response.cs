using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace MVCApp.Models
{
    public enum StateDropDown
    {
        [Display(Name="Please Select a State")]
        SelectState,
        AK,
        AL,
        AR,
        AZ,
        CA,
        CO,
        CT,
        DE,
        FL,
        GA,
        HI,
        IA,
        ID,
        IL,
        IN,
        KS,
        KY,
        LA,
        MA,
        MD,
        ME,
        MI,
        MN,
        MO,
        MS,
        MT,
        NC,
        ND,
        NE,
        NH,
        NJ,
        NM,
        NV,
        NY,
        OH,
        OK,
        OR,
        PA,
        RI,
        SC,
        SD,
        TN,
        TX,
        UT,
        VA,
        VT,
        WA,
        WI,
        WV,
        WY
    }
    public class Response
    {
        [Required(ErrorMessage = "Please enter your First Name")]
        [StringLength(25, ErrorMessage = "First Name cannot exceed 25 characters!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your Last Name")]
        [StringLength(50, ErrorMessage = "Last Name cannot exceed 50 characters!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your Street Address")]
        public string StreetAddress { get; set; }
        
        //Suit/Apartment number field is not required
        public string SuitApartmentNum { get; set; }

        [Required(ErrorMessage = "Please enter your City")]
        [StringLength(75, ErrorMessage = "City name cannot exceed 75 characters!")]
        public string City { get; set; }

        []
        public StateDropDown State { get; set; }

        [Required(ErrorMessage = "Please enter your Zip Code")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Please enter a valid Zip Code")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string PhoneNum { get; set; }


    }
}