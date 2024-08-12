using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EF
{
    public class BaseProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.; DataBase=Pestraid; TrustServerCertificate=True; Encrypt=True; Trusted_Connection=True");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsCategory> NewsCategories { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<ProductToCategory> ProductToCategories { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }



    }
}
