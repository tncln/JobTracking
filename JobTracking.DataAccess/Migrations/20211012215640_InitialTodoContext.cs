﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobTracking.DataAccess.Migrations
{
    public partial class InitialTodoContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(nullable: true),
                    Soyadi = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Calismalar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(nullable: true),
                    Aciklaması = table.Column<string>(nullable: true),
                    AciklamaTarihi = table.Column<DateTime>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calismalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calismalar_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calismalar_KullaniciId",
                table: "Calismalar",
                column: "KullaniciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calismalar");

            migrationBuilder.DropTable(
                name: "Kullanicilar");
        }
    }
}
