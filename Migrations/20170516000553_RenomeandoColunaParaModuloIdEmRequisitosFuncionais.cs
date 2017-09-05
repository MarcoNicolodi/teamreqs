using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace teamREQUIREMENTS.Migrations
{
    public partial class RenomeandoColunaParaModuloIdEmRequisitosFuncionais : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_requisitosfuncionais_modulos_modulo_id",
                table: "requisitosfuncionais");

            migrationBuilder.RenameColumn(
                name: "modulo_id",
                table: "requisitosfuncionais",
                newName: "ModuloId");

            migrationBuilder.RenameIndex(
                name: "IX_requisitosfuncionais_modulo_id",
                table: "requisitosfuncionais",
                newName: "IX_requisitosfuncionais_ModuloId");

            migrationBuilder.AddForeignKey(
                name: "FK_requisitosfuncionais_modulos_ModuloId",
                table: "requisitosfuncionais",
                column: "ModuloId",
                principalTable: "modulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_requisitosfuncionais_modulos_ModuloId",
                table: "requisitosfuncionais");

            migrationBuilder.RenameColumn(
                name: "ModuloId",
                table: "requisitosfuncionais",
                newName: "modulo_id");

            migrationBuilder.RenameIndex(
                name: "IX_requisitosfuncionais_ModuloId",
                table: "requisitosfuncionais",
                newName: "IX_requisitosfuncionais_modulo_id");

            migrationBuilder.AddForeignKey(
                name: "FK_requisitosfuncionais_modulos_modulo_id",
                table: "requisitosfuncionais",
                column: "modulo_id",
                principalTable: "modulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
