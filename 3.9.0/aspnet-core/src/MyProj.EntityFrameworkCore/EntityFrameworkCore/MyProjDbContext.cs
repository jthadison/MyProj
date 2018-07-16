using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyProj.Authorization.Roles;
using MyProj.Authorization.Users;
using MyProj.MultiTenancy;
using MyProj.Propertys;

namespace MyProj.EntityFrameworkCore
{
    public class MyProjDbContext : AbpZeroDbContext<Tenant, Role, User, MyProjDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyInvestment> PropertyInvestments { get; set; }
        public MyProjDbContext(DbContextOptions<MyProjDbContext> options)
            : base(options)
        {
        }
    }
}

