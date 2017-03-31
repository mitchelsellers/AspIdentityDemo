using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConferenceDemo.Data.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ConferenceDemo.Data
{
    public class ConfenceDemoDbContext : IdentityDbContext<UserProfile>
    {
        public DbSet<ConferenceSession> Sessions { get; set; }

        public ConfenceDemoDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ConfenceDemoDbContext Create()
        {
            return new ConfenceDemoDbContext();
        }
    }
}
