using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Tweet10.Models;

namespace Tweet10.Areas.Identity.Data;

// Add profile data for application users by adding properties to the User class
public class User : IdentityUser
{

    public ICollection<User> ApplicationUser { get; set; }

    public ICollection<User> Follows { get; set; }

    public ICollection<Tweet> Tweets { get; set; }
    

}

