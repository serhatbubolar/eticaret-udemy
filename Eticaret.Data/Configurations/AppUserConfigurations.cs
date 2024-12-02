﻿using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Data.Configurations
{
    public class AppUserConfigurations : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x=>x.Name).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x=>x.Surname).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x=>x.Email).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x=>x.Phone).HasColumnType("varchar(15)").HasMaxLength(15);
            builder.Property(x => x.Password).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x => x.UserName).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.HasData(
                new AppUser {
                        ID = 1,
                        CreateDate = DateTime.Now,
                        UserName = "Admin",
                        Email = "admin@eticaret.io",
                        isActive = true,
                        isAdmin = true,
                        Name = "Test",
                        Surname = "User",
                        Password = "123456*",
                }
                );
        }
    }
}
