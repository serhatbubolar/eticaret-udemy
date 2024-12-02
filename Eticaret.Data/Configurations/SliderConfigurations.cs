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
    public class SliderConfigurations : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.Property(x => x.Title).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(500);
            builder.Property(x => x.Image).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Link).IsRequired().HasMaxLength(100);
        }
    }
}
