using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppDemo.Enttities
{
    public class User
    {


        public int UserId { get; set; }
        [Required(ErrorMessage ="Please Enter User Name")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }

    }
}
