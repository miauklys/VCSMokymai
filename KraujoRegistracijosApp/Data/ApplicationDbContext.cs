using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using KraujoRegistracijosApp.Models;

namespace KraujoRegistracijosApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<KraujoRegistracijosApp.Models.KraujoAtsargos> KraujoAtsargos { get; set; }
    }
}
