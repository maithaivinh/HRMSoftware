using HRMSoftware.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRMSoftware.Data.Configurations
{
    public class Hre_ProfileConfiguration : IEntityTypeConfiguration<Hre_Profile>
    {
        public void Configure(EntityTypeBuilder<Hre_Profile> builder)
        {
            builder.ToTable("Hre_Profiles");
            builder.HasKey(p => p.ID);
            builder.Property(p => p.CodeEmp)
                .HasColumnType("varchar")
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            builder.Property(p => p.ProfileName)
                .HasColumnType("nvarchar")
                .IsRequired()
                .HasMaxLength(255);
            builder.Property(p => p.Gender)
                .IsUnicode(false)
                .HasColumnType("varchar")
                .HasMaxLength(50);
            builder.Property(p => p.PlaceOfBirth)
                .HasColumnType("nvarchar")
                .HasMaxLength(500);
            //builder.HasOne(p => p.JobTitleID)
            //    .WithOne(p => p.JobTitle)
            //    .HasForeignKey<Cat_JobTitle>(p => p.JobTitleForeignkey); 
        }
    }
}
