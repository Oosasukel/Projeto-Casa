using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ProjetoCasaDeShow.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the WebApp1User class
    public class ProjetoCasaDeShowUser : IdentityUser
    {
        [PersonalData]
        public string Nome { get; set; }
    }
}
