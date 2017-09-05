using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace teamREQUIREMENTS.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_requisitosfuncionais_modulos_ModuloId",
                table: "requisitosfuncionais");

            migrationBuilder.DropIndex(
                name: "IX_requisitosfuncionais_ModuloId",
                table: "requisitosfuncionais");

            migrationBuilder.DropColumn(
                name: "ModuloId",
                table: "requisitosfuncionais");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "requisitosfuncionais",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "requisitosfuncionais",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApiVersion",
                table: "requisitosfuncionais",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "regrasdenegocio",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "regrasdenegocio",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_requisitosfuncionais_modulo_id",
                table: "requisitosfuncionais",
                column: "modulo_id");

            migrationBuilder.AddForeignKey(
                name: "FK_requisitosfuncionais_modulos_modulo_id",
                table: "requisitosfuncionais",
                column: "modulo_id",
                principalTable: "modulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_requisitosfuncionais_modulos_modulo_id",
                table: "requisitosfuncionais");

            migrationBuilder.DropIndex(
                name: "IX_requisitosfuncionais_modulo_id",
                table: "requisitosfuncionais");

            migrationBuilder.DropColumn(
                name: "ApiVersion",
                table: "requisitosfuncionais");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "requisitosfuncionais",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "requisitosfuncionais",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModuloId",
                table: "requisitosfuncionais",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "regrasdenegocio",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "regrasdenegocio",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_requisitosfuncionais_ModuloId",
                table: "requisitosfuncionais",
                column: "ModuloId");

            migrationBuilder.AddForeignKey(
                name: "FK_requisitosfuncionais_modulos_ModuloId",
                table: "requisitosfuncionais",
                column: "ModuloId",
                principalTable: "modulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
