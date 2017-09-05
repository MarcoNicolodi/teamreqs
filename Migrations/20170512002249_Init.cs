using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace teamREQUIREMENTS.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "modulos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modulos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "regrasdenegocio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApiVersion = table.Column<int>(nullable: false),
                    Codigo = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_regrasdenegocio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "requisitosfuncionais",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(nullable: true),
                    ModuloId = table.Column<int>(nullable: true),
                    Nome = table.Column<string>(nullable: false),
                    modulo_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_requisitosfuncionais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_requisitosfuncionais_modulos_ModuloId",
                        column: x => x.ModuloId,
                        principalTable: "modulos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "requisitosfuncionais_regrasdenegocio",
                columns: table => new
                {
                    RegraDeNegocioId = table.Column<int>(nullable: false),
                    RequisitoFuncionalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_requisitosfuncionais_regrasdenegocio", x => new { x.RegraDeNegocioId, x.RequisitoFuncionalId });
                    table.ForeignKey(
                        name: "FK_requisitosfuncionais_regrasdenegocio_regrasdenegocio_RegraDeNegocioId",
                        column: x => x.RegraDeNegocioId,
                        principalTable: "regrasdenegocio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_requisitosfuncionais_regrasdenegocio_requisitosfuncionais_RequisitoFuncionalId",
                        column: x => x.RequisitoFuncionalId,
                        principalTable: "requisitosfuncionais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_requisitosfuncionais_ModuloId",
                table: "requisitosfuncionais",
                column: "ModuloId");

            migrationBuilder.CreateIndex(
                name: "IX_requisitosfuncionais_regrasdenegocio_RequisitoFuncionalId",
                table: "requisitosfuncionais_regrasdenegocio",
                column: "RequisitoFuncionalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "requisitosfuncionais_regrasdenegocio");

            migrationBuilder.DropTable(
                name: "regrasdenegocio");

            migrationBuilder.DropTable(
                name: "requisitosfuncionais");

            migrationBuilder.DropTable(
                name: "modulos");
        }
    }
}
