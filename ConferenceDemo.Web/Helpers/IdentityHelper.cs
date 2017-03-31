using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;

namespace ConferenceDemo.Web.Helpers
{
    public static class IdentityHelper
    {
        /// <summary>
        ///     Gets the display name.
        /// </summary>
        /// <param name="principal">The principal.</param>
        /// <returns>System.String.</returns>
        public static string GetTwitterAccount(this IIdentity principal)
        {
            var claimsPrincipal = principal as ClaimsIdentity;
            if (claimsPrincipal == null)
                return string.Empty;

            var personNameClaim = claimsPrincipal.Claims.FirstOrDefault(c => c.Type == "MC:TwitterAccount");
            if (personNameClaim == null)
                return string.Empty;

            return personNameClaim.Value;
        }
    }
}