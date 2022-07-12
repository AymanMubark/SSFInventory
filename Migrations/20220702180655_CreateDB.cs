using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SSFInventory.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatgNumber = table.Column<string>(nullable: true),
                    CatgName = table.Column<string>(nullable: true),
                    Storeid = table.Column<int>(nullable: false),
                    CatgDesc = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifedBy = table.Column<int>(nullable: false),
                    ModifedDate = table.Column<DateTime>(nullable: false),
                    LockedBy = table.Column<int>(nullable: false),
                    LockedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
