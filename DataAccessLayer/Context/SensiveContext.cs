using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class SensiveContext:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-I6T4N95;initial Catalog=SensiveBlogDb;integrated security=true;TrustServerCertificate=True;");
        }
        public DbSet <Category> categories { get; set; }
        public DbSet <Article> Articles { get; set; }
        public DbSet <Comment> Comments { get; set; }
        public DbSet <Contact> Contacts { get; set; }
        public DbSet <NewsLetter> NewsLetters { get; set; }
        public DbSet <TagCloud> TagClouds { get; set; }

    }
}
