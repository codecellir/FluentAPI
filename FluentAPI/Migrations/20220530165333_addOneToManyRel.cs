using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FluentAPI.Migrations
{
    public partial class addOneToManyRel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GradeId",
                table: "STD",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StudentGrade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentGrade", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_STD_GradeId",
                table: "STD",
                column: "GradeId");

            migrationBuilder.AddForeignKey(
                name: "FK_STD_StudentGrade_GradeId",
                table: "STD",
                column: "GradeId",
                principalTable: "StudentGrade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_STD_StudentGrade_GradeId",
                table: "STD");

            migrationBuilder.DropTable(
                name: "StudentGrade");

            migrationBuilder.DropIndex(
                name: "IX_STD_GradeId",
                table: "STD");

            migrationBuilder.DropColumn(
                name: "GradeId",
                table: "STD");
        }
    }
}
