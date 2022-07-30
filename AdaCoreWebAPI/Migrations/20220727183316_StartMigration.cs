using Microsoft.EntityFrameworkCore.Migrations;

namespace AdaCoreWebAPI.Migrations
{
    public partial class StartMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Policies",
                columns: table => new
                {
                    PolicyNo = table.Column<string>(nullable: false),
                    Branch = table.Column<string>(nullable: true),
                    Premium = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policies", x => x.PolicyNo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Policies");
        }
    }
}
