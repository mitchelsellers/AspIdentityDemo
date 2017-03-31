using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ConferenceDemo.Data.Models
{
    public class UserProfile : IdentityUser
    {
        public string TwitterAccount { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<UserProfile> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            userIdentity.AddClaims(new[]
                                   {
                                       new Claim("MC:TwitterName", TwitterAccount)
                                   });
            // Add custom user claims here
            return userIdentity;
        }

        public virtual ICollection<ConferenceSession> Sessions { get; set; }
    }
}
