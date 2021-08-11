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
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
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
            modelBuilder.ApplyConfiguration(new ObjCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ObjNumberConfiguration());
            modelBuilder.ApplyConfiguration(new ObjNumberCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ObjNumberCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ObjAddressConfiguration());
            modelBuilder.ApplyConfiguration(new ObjMailConfiguration());
            modelBuilder.ApplyConfiguration(new ObjSocialMediaAccountConfiguration());
            modelBuilder.ApplyConfiguration(new ObjWorkingHourConfiguration());
        }

        public DbSet<ObjAppRole> objAppRoles { get; set; }
        public DbSet<ObjAppUser> objAppUsers { get; set; }
        public DbSet<ObjAppUserRole> objAppUserRoles { get; set; }
        public DbSet<ObjBlog> objBlogs { get; set; }
        public DbSet<ObjBlogAppUser> blogAppUsers { get; set; }
        public DbSet<ObjBlogAppUserStatus> blogAppUserStatuses { get; set; }
        public DbSet<ObjProvidedService> objProvidedServices { get; set; }
        public DbSet<ObjCategory> objCategories { get; set; }
        public DbSet<ObjNumber> objNumbers { get; set; }
        public DbSet<ObjNumberCategory> objNumberCategories { get; set; }
        public DbSet<ObjAddress> objAddresses { get; set; }
        public DbSet<ObjMail> objMails { get; set; }
        public DbSet<ObjSocialMediaAccount> objSocialMediaAccounts { get; set; }
        public DbSet<ObjWorkingHour> ObjWorkingHours { get; set; }
    }
}
