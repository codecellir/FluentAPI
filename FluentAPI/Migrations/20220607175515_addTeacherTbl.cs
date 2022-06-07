using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FluentAPI.Migrations
{
    public partial class addTeacherTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Family = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "Id", "Code", "Family", "Name" },
                values: new object[] { 1, "1", "F1", "T1" });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "Id", "Code", "Family", "Name" },
                values: new object[] { 2, "2", "F2", "T2" });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "Id", "Code", "Family", "Name" },
                values: new object[] { 3, "3", "F3", "T3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teacher");
        }
    }
}
