using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialWorld.DataAccess.Migrations
{
    public partial class ForeignKey_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyTypeId",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CompanyTypeId",
                table: "Companies",
                column: "CompanyTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_CompanyTypes_CompanyTypeId",
                table: "Companies",
                column: "CompanyTypeId",
                principalTable: "CompanyTypes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_CompanyTypes_CompanyTypeId",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_CompanyTypeId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CompanyTypeId",
                table: "Companies");
        }
    }
}
