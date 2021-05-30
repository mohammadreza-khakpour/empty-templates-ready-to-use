using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmptyTemplatesReadyToUse.Migration.Migrations
{
    [Migration(202105300926)]
    public class _202105300926_AddLibrariesAndBooksTables : FluentMigrator.Migration
    {
        public override void Down()
        {
            Delete.ForeignKey("FK_Libraries_Books").OnTable("Books");
            Delete.Table("Books");
            Delete.Table("Libraries");
        }

        public override void Up()
        {
            Create.Table("Libraries")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity().NotNullable()
                .WithColumn("Address").AsString(120).Nullable();
            Create.Table("Books")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity().NotNullable()
                .WithColumn("Title").AsString(20).Nullable()
                .WithColumn("LibraryId").AsInt32().NotNullable()
                .ForeignKey("FK_Libraries_Books", "Libraries", "Id").OnDelete(System.Data.Rule.Cascade);
        }
    }
}
