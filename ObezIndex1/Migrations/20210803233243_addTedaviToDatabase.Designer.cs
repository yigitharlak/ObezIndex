﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ObezIndex1.Data;

namespace ObezIndex1.Migrations
{
    [DbContext(typeof(ObezIndexDbContext))]
    [Migration("20210803233243_addTedaviToDatabase")]
    partial class addTedaviToDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "6.0.0-preview.3.21201.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ObezIndex1.Models.Doktor", b =>
                {
                    b.Property<int>("doc_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("doc_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doc_info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doc_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doc_password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doc_profession")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doc_title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doc_username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("doc_ID");

                    b.ToTable("Doktor");
                });

            modelBuilder.Entity("ObezIndex1.Models.Hasta", b =>
                {
                    b.Property<int>("pat_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("pat_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pat_age")
                        .HasColumnType("int");

                    b.Property<string>("pat_gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pat_height")
                        .HasColumnType("int");

                    b.Property<string>("pat_info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pat_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pat_password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pat_username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pat_weight")
                        .HasColumnType("int");

                    b.HasKey("pat_ID");

                    b.ToTable("Hasta");
                });

            modelBuilder.Entity("ObezIndex1.Models.Hastalik", b =>
                {
                    b.Property<int>("ill_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ill_category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ill_description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ill_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ill_ID");

                    b.ToTable("Hastalik");
                });

            modelBuilder.Entity("ObezIndex1.Models.Tani", b =>
                {
                    b.Property<int>("dgn_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dgn_info")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("dgn_ID");

                    b.ToTable("Tani");
                });

            modelBuilder.Entity("ObezIndex1.Models.Tedavi", b =>
                {
                    b.Property<int>("tmt_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tmt_info")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("tmt_ID");

                    b.ToTable("Tedavi");
                });
#pragma warning restore 612, 618
        }
    }
}
