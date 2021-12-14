using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialWorld.DataAccess.Migrations
{
    public partial class socialResponsibilityTypeadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialResponsibilities_JobTypes_JobTypeId",
                table: "SocialResponsibilities");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SocialResponsibilities_SocialResposibiltiyTypes_JobTypeId",
                table: "SocialResponsibilities",
                column: "JobTypeId",
                principalTable: "SocialResposibiltiyTypes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialResponsibilities_SocialResposibiltiyTypes_JobTypeId",
                table: "SocialResponsibilities");

            migrationBuilder.DropTable(
                name: "SocialResposibiltiyTypes");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialResponsibilities_JobTypes_JobTypeId",
                table: "SocialResponsibilities",
                column: "JobTypeId",
                principalTable: "JobTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
