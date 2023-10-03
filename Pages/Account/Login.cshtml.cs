using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SecurityApp.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public UserCredential Credential { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            if(!ModelState.IsValid) return;

            // verify credential

            if (Credential.UserName == "niloy" && Credential.Password == "123")
            {


            }
        }

        public class UserCredential
        {
            [Required]
            public string UserName { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
            

        }
    }
}
