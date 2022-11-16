﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using last_test_tech.Data;

namespace last_test_tech.Migrations
{
    [DbContext(typeof(candidaturedb))]
    partial class candidaturedbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("last_test_tech.Models.Candidat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("dn_employeur")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<int>("nbr_anne_exp")
                        .HasColumnType("int");

                    b.Property<string>("niveau_detude")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("prenom")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("tele")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Candidatures", "CD");
                });
#pragma warning restore 612, 618
        }
    }
}