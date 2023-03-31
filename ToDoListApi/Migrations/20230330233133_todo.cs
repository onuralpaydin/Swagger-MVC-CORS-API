using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoListApi.Migrations
{
    public partial class todo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_TodoList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDone = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_TodoList", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "tbl_TodoList",
                columns: new[] { "Id", "Name", "isDone" },
                values: new object[] { 1, "Api Çalış", false });

            migrationBuilder.InsertData(
                table: "tbl_TodoList",
                columns: new[] { "Id", "Name", "isDone" },
                values: new object[] { 2, "EF Çalış", true });

            migrationBuilder.InsertData(
                table: "tbl_TodoList",
                columns: new[] { "Id", "Name", "isDone" },
                values: new object[] { 3, "MVC Çalış", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_TodoList");
        }
    }
}
