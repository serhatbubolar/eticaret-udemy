using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Data.Configurations
{
    public class CategoryConfigurations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Image).IsRequired().HasMaxLength(50);
            builder.HasData(
                new Category
            {
                Name = "Elektronik",
                ID = 1,
                isActive = true,
                isTopMenu = true,
                parentId = 0,
                OrderNo = 1,
            },
                new Category
                {
                    Name = "Bilgisayar",
                    ID = 2,
                    isActive = true,
                    isTopMenu = true,
                    parentId = 0,
                    OrderNo = 2,
                }
                );
            
        }
    }
}
