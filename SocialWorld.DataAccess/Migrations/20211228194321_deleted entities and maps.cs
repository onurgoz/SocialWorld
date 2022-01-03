using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialWorld.DataAccess.Migrations
{
    public partial class deletedentitiesandmaps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applicants_SocialResponsibilities_JobId",
                table: "Applicants");

            migrationBuilder.DropTable(
                name: "SocialResponsibilities");

            migrationBuilder.DropTable(
                name: "SocialResposibiltiyTypes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SocialResposibiltiyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialResposibiltiyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialResponsibilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    JobTypeId = table.Column<int>(type: "int", nullable: false),
                    LastEdit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhotoString = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialResponsibilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialResponsibilities_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SocialResponsibilities_SocialResposibiltiyTypes_JobTypeId",
                        column: x => x.JobTypeId,
                        principalTable: "SocialResposibiltiyTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SocialResponsibilities_CompanyId",
                table: "SocialResponsibilities",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialResponsibilities_JobTypeId",
                table: "SocialResponsibilities",
                column: "JobTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applicants_SocialResponsibilities_JobId",
                table: "Applicants",
                column: "JobId",
                principalTable: "SocialResponsibilities",
                principalColumn: "Id");
        }
    }
}
