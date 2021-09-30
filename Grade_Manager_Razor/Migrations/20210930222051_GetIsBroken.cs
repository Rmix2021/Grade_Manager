using Microsoft.EntityFrameworkCore.Migrations;

namespace Grade_Manager_Razor.Migrations
{
    public partial class GetIsBroken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "ClassRoomId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "ClassRoomId",
                keyValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ClassRooms",
                columns: new[] { "ClassRoomId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "C#" },
                    { 2, false, "Java" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "ClassRoomId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "JimBob" },
                    { 2, 1, "Bradley" },
                    { 3, 1, "Steven" }
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "AssignmentId", "Grade", "IsComplete", "Name", "StudentId" },
                values: new object[,]
                {
                    { 1, 0.0, false, "Lab_1", 1 },
                    { 2, 0.0, false, "Lab_2", 1 },
                    { 3, 0.0, false, "Lab_3", 1 },
                    { 4, 0.0, false, "Lab_4", 1 }
                });
        }
    }
}
