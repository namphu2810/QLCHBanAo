using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLCHBanAo.Migrations
{
    /// <inheritdoc />
    public partial class KhoiTaoCSDL2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BienThe_ChatLieu_ChatLieuId",
                table: "BienThe");

            migrationBuilder.DropForeignKey(
                name: "FK_BienThe_KichThuoc_KichThuocId",
                table: "BienThe");

            migrationBuilder.DropForeignKey(
                name: "FK_BienThe_MauSac_MauSacId",
                table: "BienThe");

            migrationBuilder.DropForeignKey(
                name: "FK_BienThe_SanPham_SanPhamId",
                table: "BienThe");

            migrationBuilder.DropForeignKey(
                name: "FK_BienThe_ThuongHieu_ThuongHieuId",
                table: "BienThe");

            migrationBuilder.DropForeignKey(
                name: "FK_TonKhoSP_BienThe_BienTheId",
                table: "TonKhoSP");

            migrationBuilder.DropForeignKey(
                name: "FK_TonKhoSP_CuaHang_CuaHangId",
                table: "TonKhoSP");

            migrationBuilder.AlterColumn<int>(
                name: "CuaHangId",
                table: "TonKhoSP",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BienTheId",
                table: "TonKhoSP",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ThuongHieuId",
                table: "BienThe",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SanPhamId",
                table: "BienThe",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MauSacId",
                table: "BienThe",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "KichThuocId",
                table: "BienThe",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ChatLieuId",
                table: "BienThe",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_BienThe_ChatLieu_ChatLieuId",
                table: "BienThe",
                column: "ChatLieuId",
                principalTable: "ChatLieu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BienThe_KichThuoc_KichThuocId",
                table: "BienThe",
                column: "KichThuocId",
                principalTable: "KichThuoc",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BienThe_MauSac_MauSacId",
                table: "BienThe",
                column: "MauSacId",
                principalTable: "MauSac",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BienThe_SanPham_SanPhamId",
                table: "BienThe",
                column: "SanPhamId",
                principalTable: "SanPham",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BienThe_ThuongHieu_ThuongHieuId",
                table: "BienThe",
                column: "ThuongHieuId",
                principalTable: "ThuongHieu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TonKhoSP_BienThe_BienTheId",
                table: "TonKhoSP",
                column: "BienTheId",
                principalTable: "BienThe",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TonKhoSP_CuaHang_CuaHangId",
                table: "TonKhoSP",
                column: "CuaHangId",
                principalTable: "CuaHang",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BienThe_ChatLieu_ChatLieuId",
                table: "BienThe");

            migrationBuilder.DropForeignKey(
                name: "FK_BienThe_KichThuoc_KichThuocId",
                table: "BienThe");

            migrationBuilder.DropForeignKey(
                name: "FK_BienThe_MauSac_MauSacId",
                table: "BienThe");

            migrationBuilder.DropForeignKey(
                name: "FK_BienThe_SanPham_SanPhamId",
                table: "BienThe");

            migrationBuilder.DropForeignKey(
                name: "FK_BienThe_ThuongHieu_ThuongHieuId",
                table: "BienThe");

            migrationBuilder.DropForeignKey(
                name: "FK_TonKhoSP_BienThe_BienTheId",
                table: "TonKhoSP");

            migrationBuilder.DropForeignKey(
                name: "FK_TonKhoSP_CuaHang_CuaHangId",
                table: "TonKhoSP");

            migrationBuilder.AlterColumn<int>(
                name: "CuaHangId",
                table: "TonKhoSP",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BienTheId",
                table: "TonKhoSP",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ThuongHieuId",
                table: "BienThe",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SanPhamId",
                table: "BienThe",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MauSacId",
                table: "BienThe",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KichThuocId",
                table: "BienThe",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ChatLieuId",
                table: "BienThe",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BienThe_ChatLieu_ChatLieuId",
                table: "BienThe",
                column: "ChatLieuId",
                principalTable: "ChatLieu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BienThe_KichThuoc_KichThuocId",
                table: "BienThe",
                column: "KichThuocId",
                principalTable: "KichThuoc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BienThe_MauSac_MauSacId",
                table: "BienThe",
                column: "MauSacId",
                principalTable: "MauSac",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BienThe_SanPham_SanPhamId",
                table: "BienThe",
                column: "SanPhamId",
                principalTable: "SanPham",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BienThe_ThuongHieu_ThuongHieuId",
                table: "BienThe",
                column: "ThuongHieuId",
                principalTable: "ThuongHieu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TonKhoSP_BienThe_BienTheId",
                table: "TonKhoSP",
                column: "BienTheId",
                principalTable: "BienThe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TonKhoSP_CuaHang_CuaHangId",
                table: "TonKhoSP",
                column: "CuaHangId",
                principalTable: "CuaHang",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
