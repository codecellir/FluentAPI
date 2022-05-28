using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FluentAPI.Migrations
{
    public partial class myMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "STD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false, computedColumnSql: "[Name]+' '+[LastName]"),
                    NationalCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Age = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)10),
                    Score = table.Column<double>(type: "float", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STD", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_STD_Age_NationalCode",
                table: "STD",
                columns: new[] { "Age", "NationalCode" });

            migrationBuilder.CreateIndex(
                name: "IX_STD_NationalCode",
                table: "STD",
                column: "NationalCode",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "STD");
        }
    }
}
