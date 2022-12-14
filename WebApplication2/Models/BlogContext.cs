using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("blogDb") // base blogDb diyince aynı veritabanını tekrar olusturuyor
        {
            Database.SetInitializer(new BlogInitializer()); // veritabanı oluşturucu constructor
        }
        public DbSet<Blog> Bloglar { get; set; }
        public DbSet<Category> Kategoriler { get; set; }
    }
}