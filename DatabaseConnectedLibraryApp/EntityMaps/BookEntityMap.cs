using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseConnectedLibraryApp.EntityMaps
{
    class BookEntityMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Id).ValueGeneratedOnAdd();
            builder.Property(_ => _.Title).HasMaxLength(20);
            builder.Property(_ => _.LibraryId).IsRequired();
            builder.HasOne(_ => _.Library).WithMany().HasForeignKey(_ => _.LibraryId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
