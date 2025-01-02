using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hoten_1234_2425_BAITHITEST_.Migrations
{
    /// <inheritdoc />
    public partial class tenenn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sinhvien",
                columns: table => new
                {
                    mssv = table.Column<string>(type: "TEXT", nullable: false),
                    hoten = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sinhvien", x => x.mssv);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sinhvien");
        }
    }
}
