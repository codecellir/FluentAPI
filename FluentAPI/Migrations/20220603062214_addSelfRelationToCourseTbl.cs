using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FluentAPI.Migrations
{
    public partial class addSelfRelationToCourseTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PreCourseId",
                table: "Course",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Course_PreCourseId",
                table: "Course",
                column: "PreCourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Course_PreCourseId",
                table: "Course",
                column: "PreCourseId",
                principalTable: "Course",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Course_PreCourseId",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_PreCourseId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "PreCourseId",
                table: "Course");
        }
    }
}
