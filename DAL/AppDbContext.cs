using DAL.Configurations;
using Microsoft.EntityFrameworkCore;
using OL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ObjAppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new ObjAppUserConfiguration());
            modelBuilder.ApplyConfiguration(new ObjAppUserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new ObjAppUserConfiguration());
            modelBuilder.ApplyConfiguration(new ObjBlogAppUserStatusConfiguration());
            modelBuilder.ApplyConfiguration(new ObjBlogConfiguration());
            modelBuilder.ApplyConfiguration(new ObjProvidedServiceConfiguration());
        }

        public DbSet<ObjAppRole> objAppRoles { get; set; }
        public DbSet<ObjAppUser> objAppUsers { get; set; }
        public DbSet<ObjAppUserRole> objAppUserRoles { get; set; }
        public DbSet<ObjBlog> objBlogs { get; set; }
        public DbSet<ObjBlogAppUser> blogAppUsers { get; set; }
        public DbSet<ObjBlogAppUserStatus> blogAppUserStatuses { get; set; }
        public DbSet<ObjProvidedService> objProvidedServices { get; set; }
    }
}
