using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FlamingoAirwaysApp.Models
{
    public class clsRegistration
    {

        private string Title;

        [Required]
        [Display(Name = "Title")]
        public string UserTitle
        {
            get { return Title; }
            set { Title = value; }
        }


        private string FName;
        [Required]
        [Display(Name = "First Name")]
        public string UserFname
        {
            get { return FName; }
            set { FName = value; }
        }

        private string LName;


        [Required]
        [Display(Name = "Last Name")]
        public string UserLname
        {
            get { return LName; }
            set { LName = value; }
        }

        private long Phone;

        [Required]
        [Display(Name = "Phone no.")]
        [MaxLength(10, ErrorMessage = "Maximum length expired")]
        public long UserPhone
        {
            get { return Phone; }
            set { Phone = value; }
        }

        private string Password;

        [Required]
        [Display(Name = "Password")]
        public string UserPassword
        {
            get { return Password; }
            set { Password = value; }
        }

        private DateTime DOB;

        [Required]
        [Display(Name = "Date Of Birth")]
        public DateTime UserDOB
        {
            get { return DOB; }
            set { DOB = value; }
        }

        private string Email;

        [Required]
        [Display(Name = "Email id/ User Name")]

        public string UserEmail
        {
            get { return Email; }
            set { Email = value; }
        }

        private string PANCard;
        [Required]
        [Display(Name = "Pan Card no.")]
        public string UserPAN
        {
            get { return PANCard; }
            set { PANCard = value; }
        }


        
        [Display(Name = "Confirm Password")]
        public void ConfirmPassword(string val1, string val2)
        {
            if (val1 == val2)
            {
                Password = val1;
            }
            else
            {
                Console.WriteLine("Password doesn't matched");
            }


        }
    }
}