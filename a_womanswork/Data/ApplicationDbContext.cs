using System;
using System.Collections.Generic;
using System.Text;
using a_womanswork.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace a_womanswork.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> DbUsers { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
