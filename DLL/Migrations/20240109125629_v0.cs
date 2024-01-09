using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DLL.Migrations
{
    public partial class v0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LasttName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonCompany",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    PeopleId = table.Column<int>(type: "int", nullable: false),
                    CompaniesId = table.Column<int>(type: "int", nullable: false),
                    PeopleId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonCompany", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonCompany_Company_CompaniesId",
                        column: x => x.CompaniesId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    
                    table.ForeignKey(
                        name: "FK_PersonCompany_People_PeopleId",
                        column: x => x.PeopleId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonCompany_CompaniesId",
                table: "PersonCompany",
                column: "CompaniesId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonCompany_CompanyId",
                table: "PersonCompany",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonCompany_PeopleId",
                table: "PersonCompany",
                column: "PeopleId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonCompany_PeopleId1",
                table: "PersonCompany",
                column: "PeopleId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonCompany");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
