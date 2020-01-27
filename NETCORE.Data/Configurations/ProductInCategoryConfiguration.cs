using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NETCORE.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCORE.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(t => new { t.CategoryId, t.ProductId});
            builder.ToTable("ProductInCategories");
            builder.HasOne(t => t.Product).WithMany(pc => pc.ProductInCategorys).
                HasForeignKey(pc => pc.ProductId);
            builder.HasOne(t => t.Cagetory).WithMany(pc => pc.ProductInCategorys).
                HasForeignKey(pc => pc.CategoryId);
        }
    }
}
