using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using teamREQUIREMENTS;

namespace teamREQUIREMENTS.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20170512002249_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("teamREQUIREMENTS.Persistencia.Models.Modulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("modulos");
                });

            modelBuilder.Entity("teamREQUIREMENTS.Persistencia.Models.RegraDeNegocio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApiVersion");

                    b.Property<string>("Codigo");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("regrasdenegocio");
                });

            modelBuilder.Entity("teamREQUIREMENTS.Persistencia.Models.RequisitoFuncional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo");

                    b.Property<int?>("ModuloId");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<int>("modulo_id");

                    b.HasKey("Id");

                    b.HasIndex("ModuloId");

                    b.ToTable("requisitosfuncionais");
                });

            modelBuilder.Entity("teamREQUIREMENTS.Persistencia.Models.RequisitosFuncionaisRegrasDeNegocio", b =>
                {
                    b.Property<int>("RegraDeNegocioId");

                    b.Property<int>("RequisitoFuncionalId");

                    b.HasKey("RegraDeNegocioId", "RequisitoFuncionalId");

                    b.HasIndex("RequisitoFuncionalId");

                    b.ToTable("requisitosfuncionais_regrasdenegocio");
                });

            modelBuilder.Entity("teamREQUIREMENTS.Persistencia.Models.RequisitoFuncional", b =>
                {
                    b.HasOne("teamREQUIREMENTS.Persistencia.Models.Modulo")
                        .WithMany("RequisitosFuncionais")
                        .HasForeignKey("ModuloId");
                });

            modelBuilder.Entity("teamREQUIREMENTS.Persistencia.Models.RequisitosFuncionaisRegrasDeNegocio", b =>
                {
                    b.HasOne("teamREQUIREMENTS.Persistencia.Models.RegraDeNegocio", "RegraDeNegocio")
                        .WithMany()
                        .HasForeignKey("RegraDeNegocioId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("teamREQUIREMENTS.Persistencia.Models.RequisitoFuncional", "RequisitoFuncional")
                        .WithMany()
                        .HasForeignKey("RequisitoFuncionalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
