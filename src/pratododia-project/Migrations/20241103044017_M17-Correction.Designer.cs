﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pratododia_project.Models;

#nullable disable

namespace pratododia_project.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241103044017_M17-Correction")]
    partial class M17Correction
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("pratododia_project.Models.Comentario", b =>
                {
                    b.Property<int>("IdComentário")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdComentário"));

                    b.Property<DateTime>("DataComentario")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdReceita")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int>("NumCurtidas")
                        .HasColumnType("int");

                    b.Property<string>("Texto")
                        .HasColumnType("longtext");

                    b.HasKey("IdComentário");

                    b.HasIndex("IdReceita");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("pratododia_project.Models.Ingrediente", b =>
                {
                    b.Property<int>("IdIngrediente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdIngrediente"));

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Restricao")
                        .HasColumnType("int");

                    b.HasKey("IdIngrediente");

                    b.ToTable("Ingredientes");
                });

            modelBuilder.Entity("pratododia_project.Models.IngredienteReceita", b =>
                {
                    b.Property<int>("IdReceita")
                        .HasColumnType("int");

                    b.Property<int>("IdIngrediente")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("IdReceita", "IdIngrediente");

                    b.HasIndex("IdIngrediente");

                    b.ToTable("IngredientesReceitas");
                });

            modelBuilder.Entity("pratododia_project.Models.Receita", b =>
                {
                    b.Property<int>("IdReceita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdReceita"));

                    b.Property<int>("Acessos")
                        .HasColumnType("int");

                    b.Property<float>("Avaliacao")
                        .HasColumnType("float");

                    b.Property<string>("CaminhoImg")
                        .HasColumnType("longtext");

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataPublicacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(240)
                        .HasColumnType("varchar(240)");

                    b.Property<int>("Dificuldade")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("NomeReceita")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<int>("NumCurtidas")
                        .HasColumnType("int");

                    b.Property<string>("Passos")
                        .HasColumnType("longtext");

                    b.Property<int>("Rendimento")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("TempoPreparo")
                        .HasColumnType("time(6)");

                    b.HasKey("IdReceita");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Receitas");
                });

            modelBuilder.Entity("pratododia_project.Models.ReceitaAvaliada", b =>
                {
                    b.Property<int>("IdReceitaAvaliada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdReceitaAvaliada"));

                    b.Property<int>("IdReceita")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int>("Nota")
                        .HasColumnType("int");

                    b.HasKey("IdReceitaAvaliada");

                    b.HasIndex("IdReceita");

                    b.HasIndex("IdUsuario");

                    b.ToTable("ReceitaAvaliada");
                });

            modelBuilder.Entity("pratododia_project.Models.ReceitaPlanejada", b =>
                {
                    b.Property<int>("IdReceitaPlanejada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdReceitaPlanejada"));

                    b.Property<int>("IdReceita")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<DateTime>("dataPreparo")
                        .HasColumnType("datetime(6)");

                    b.HasKey("IdReceitaPlanejada");

                    b.HasIndex("IdReceita");

                    b.HasIndex("IdUsuario");

                    b.ToTable("ReceitasPlanejadas");
                });

            modelBuilder.Entity("pratododia_project.Models.ReceitaSalva", b =>
                {
                    b.Property<int>("IdReceitaSalva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdReceitaSalva"));

                    b.Property<int>("IdReceita")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdReceitaSalva");

                    b.HasIndex("IdReceita");

                    b.HasIndex("IdUsuario");

                    b.ToTable("ReceitasSalvas");
                });

            modelBuilder.Entity("pratododia_project.Models.RespostaComentario", b =>
                {
                    b.Property<int>("IdResposta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdResposta"));

                    b.Property<DateTime>("DataResposta")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("IdComentario")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int>("NumCurtidas")
                        .HasColumnType("int");

                    b.Property<string>("Texto")
                        .HasColumnType("longtext");

                    b.HasKey("IdResposta");

                    b.HasIndex("IdComentario");

                    b.HasIndex("IdUsuario");

                    b.ToTable("RespostasComentario");
                });

            modelBuilder.Entity("pratododia_project.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<string>("CaminhoImg")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("pratododia_project.Models.UsuarioIngrediente", b =>
                {
                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int>("IdIngrediente")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("IdUsuario", "IdIngrediente");

                    b.HasIndex("IdIngrediente");

                    b.ToTable("UsuarioIngredientes");
                });

            modelBuilder.Entity("pratododia_project.Models.Comentario", b =>
                {
                    b.HasOne("pratododia_project.Models.Receita", "Receita")
                        .WithMany("Comentarios")
                        .HasForeignKey("IdReceita")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("pratododia_project.Models.Usuario", "Usuario")
                        .WithMany("Comentarios")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receita");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("pratododia_project.Models.IngredienteReceita", b =>
                {
                    b.HasOne("pratododia_project.Models.Ingrediente", "Ingrediente")
                        .WithMany("IngredientesReceitas")
                        .HasForeignKey("IdIngrediente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("pratododia_project.Models.Receita", "Receita")
                        .WithMany("IngredientesReceitas")
                        .HasForeignKey("IdReceita")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingrediente");

                    b.Navigation("Receita");
                });

            modelBuilder.Entity("pratododia_project.Models.Receita", b =>
                {
                    b.HasOne("pratododia_project.Models.Usuario", "Usuario")
                        .WithMany("Receitas")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("pratododia_project.Models.ReceitaAvaliada", b =>
                {
                    b.HasOne("pratododia_project.Models.Receita", "Receita")
                        .WithMany()
                        .HasForeignKey("IdReceita")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("pratododia_project.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receita");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("pratododia_project.Models.ReceitaPlanejada", b =>
                {
                    b.HasOne("pratododia_project.Models.Receita", "Receita")
                        .WithMany("ReceitasPlanejadas")
                        .HasForeignKey("IdReceita")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("pratododia_project.Models.Usuario", "Usuario")
                        .WithMany("ReceitasPlanejadas")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receita");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("pratododia_project.Models.ReceitaSalva", b =>
                {
                    b.HasOne("pratododia_project.Models.Receita", "Receita")
                        .WithMany("ReceitasSalvas")
                        .HasForeignKey("IdReceita")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("pratododia_project.Models.Usuario", "Usuario")
                        .WithMany("ReceitasSalvas")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receita");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("pratododia_project.Models.RespostaComentario", b =>
                {
                    b.HasOne("pratododia_project.Models.Comentario", "Comentario")
                        .WithMany("RespostasComentario")
                        .HasForeignKey("IdComentario");

                    b.HasOne("pratododia_project.Models.Usuario", "Usuario")
                        .WithMany("RespostasComentario")
                        .HasForeignKey("IdUsuario");

                    b.Navigation("Comentario");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("pratododia_project.Models.UsuarioIngrediente", b =>
                {
                    b.HasOne("pratododia_project.Models.Ingrediente", "Ingrediente")
                        .WithMany("UsuarioIngredientes")
                        .HasForeignKey("IdIngrediente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("pratododia_project.Models.Usuario", "Usuario")
                        .WithMany("UsuarioIngredientes")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingrediente");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("pratododia_project.Models.Comentario", b =>
                {
                    b.Navigation("RespostasComentario");
                });

            modelBuilder.Entity("pratododia_project.Models.Ingrediente", b =>
                {
                    b.Navigation("IngredientesReceitas");

                    b.Navigation("UsuarioIngredientes");
                });

            modelBuilder.Entity("pratododia_project.Models.Receita", b =>
                {
                    b.Navigation("Comentarios");

                    b.Navigation("IngredientesReceitas");

                    b.Navigation("ReceitasPlanejadas");

                    b.Navigation("ReceitasSalvas");
                });

            modelBuilder.Entity("pratododia_project.Models.Usuario", b =>
                {
                    b.Navigation("Comentarios");

                    b.Navigation("Receitas");

                    b.Navigation("ReceitasPlanejadas");

                    b.Navigation("ReceitasSalvas");

                    b.Navigation("RespostasComentario");

                    b.Navigation("UsuarioIngredientes");
                });
#pragma warning restore 612, 618
        }
    }
}
