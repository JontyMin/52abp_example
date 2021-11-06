﻿using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyPortal.Authorization.Roles;
using MyPortal.Authorization.Users;
using MyPortal.MultiTenancy;
using MyPortal.Tasks;

namespace MyPortal.EntityFrameworkCore
{
    public class MyPortalDbContext : AbpZeroDbContext<Tenant, Role, User, MyPortalDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Task> Tasks { get; set; }
        
        public MyPortalDbContext(DbContextOptions<MyPortalDbContext> options)
            : base(options)
        {
        }
    }
}
