using HRMSoftware.Data.Entities;
using HRMSoftware.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace HRMSoftware.Data.EF
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Hre_Profile> Hre_Profiles { set;get; }
        public DbSet<Cat_JobTitle> Cat_JobTitles { set; get; }
        public DbSet<Cat_Position> Cat_Positions { set; get; }
        public override int SaveChanges()
        {
            var entities = ChangeTracker.Entries().Where(p => p.State == EntityState.Modified || p.State == EntityState.Added);
            foreach (var entity in entities)
            {
                if (entity is IHasTracking)
                {
                    var hasTracking = entity as IHasTracking;
                    if (entity.State == EntityState.Added)
                    {
                        if (entity is IHasTracking)
                        {
                            hasTracking.ID = Guid.NewGuid();
                            hasTracking.DateCreate = DateTime.Now;
                            hasTracking.DateUpdate = DateTime.Now;
                        }
                    }
                    else if (entity.State == EntityState.Modified)
                    {
                        hasTracking.DateUpdate = DateTime.Now;
                    }
                }
                
            }
            return base.SaveChanges();
        }
    }
}
