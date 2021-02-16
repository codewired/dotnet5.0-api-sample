using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleWebAPI.Models;

namespace SampleWebAPI.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
           : base(options)
        {
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Claim> Claims { get; set; }

   
    }
}
