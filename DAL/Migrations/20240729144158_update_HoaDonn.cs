using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class update_HoaDonn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_giamGias_giamGiaId",
                table: "HoaDons");

            migrationBuilder.AlterColumn<int>(
                name: "giamGiaId",
                table: "HoaDons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_giamGias_giamGiaId",
                table: "HoaDons",
                column: "giamGiaId",
                principalTable: "giamGias",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_giamGias_giamGiaId",
                table: "HoaDons");

            migrationBuilder.AlterColumn<int>(
                name: "giamGiaId",
                table: "HoaDons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_giamGias_giamGiaId",
                table: "HoaDons",
                column: "giamGiaId",
                principalTable: "giamGias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
