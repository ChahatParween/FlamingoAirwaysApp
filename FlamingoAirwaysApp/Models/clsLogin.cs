using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FlamingoAirwaysApp.Models
{
    public class clsLogin
    {
        private string userid;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Required Field")]
        [Display(Name = "UserID")]
        public string UserID
        {
            get { return userid; }
            set { userid = value; }
        }
        private string pwd;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Required Field")]
        [Display(Name = "Password")]
        public string Password
        {
            get { return pwd; }
            set { pwd = value; }
        }

    }
}