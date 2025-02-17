﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicTacToe.Data;

#nullable disable

namespace TicTacToe.Data.Migrations
{
    [DbContext(typeof(TicTacToeContext))]
    [Migration("20221013054342_ChangedField")]
    partial class ChangedField
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TicTacToe.Contracts.Game", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Board")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GameMode")
                        .HasColumnType("int");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<string>("OPlayerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Result")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("XPlayerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("XTurn")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("XPlayerId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("TicTacToe.Contracts.Player", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = "computer",
                            Email = "computer@gmail.com",
                            Name = "Computer",
                            Password = "12345678"
                        });
                });

            modelBuilder.Entity("TicTacToe.Contracts.Game", b =>
                {
                    b.HasOne("TicTacToe.Contracts.Player", "Creator")
                        .WithMany("Games")
                        .HasForeignKey("XPlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("TicTacToe.Contracts.Player", b =>
                {
                    b.Navigation("Games");
                });
#pragma warning restore 612, 618
        }
    }
}
