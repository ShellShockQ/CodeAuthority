using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.BusinessLogic
{
    using System.ComponentModel.DataAnnotations;
    using System.Text.RegularExpressions;

    using CA.BusinessLogic.Helpers;

    using Detrick.Common.Core;

    public class Contact
    {
        [Required(ErrorMessage = "First Name is Required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "A valid Email Address is Required")]
        [EmailAddress(ErrorMessage = "Your Email was not a valid email address. Try Again!")]
        public string EmailAddress { get; set; }
        
        [Required(ErrorMessage = "A Valid Phone Number is Required")]

        [RegularExpression("(1-)?\\p{N}{3}-\\p{N}{3}-\\p{N}{4}\\b",ErrorMessage = "Oops! The Phone Number is not valid. Try Again!")]
        public string PhoneNumber { get; set; }
        
   [ValidContactDate(ErrorMessage = "Oops! Please Select M - F Between 9AM and 6PM")]
       public DateTime BesTimeToCall { get; set; }
        
        public bool EmailAddressIsValid(string testemailaddress)
        {
            if (string.IsNullOrWhiteSpace(testemailaddress)) throw new ArgumentException("Email Address Cannot Be Null");
            bool isEmailValid = false;
            isEmailValid = RegularExpressions.EmailAddressValidation(testemailaddress);
            return isEmailValid;
        }

        public bool FirstNameIsValid()
        {
            if (string.IsNullOrWhiteSpace(this.FirstName)) throw new ArgumentException("First Name Cannot Be Null");
            bool isValid = false;
            isValid = Regex.IsMatch(this.FirstName, @"^[a-zA-Z]+$");
            return isValid;

        }

        public bool LastNameIsValid(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName)) throw new ArgumentException("Last Name Cannot Be Null");
            bool isValid = false;
            isValid = Regex.IsMatch(lastName, @"^[a-zA-Z]+$");
            return isValid;
        }

        public bool PhoneNumberIsValid(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber)) throw new ArgumentException("Phone Number Cannot Be Null");
            bool isPhoneNumberValid = false;
            isPhoneNumberValid = RegularExpressions.PhoneNumberValidation(phoneNumber);
            return isPhoneNumberValid;
        }

        
    }
}
