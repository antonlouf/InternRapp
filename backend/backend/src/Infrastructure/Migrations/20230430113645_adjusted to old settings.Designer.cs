﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.Infrastructure.Persistence;

#nullable disable

namespace backend.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230430113645_adjusted to old settings")]
    partial class adjustedtooldsettings
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc.2.22472.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InternShipLocation", b =>
                {
                    b.Property<int>("InternShipId")
                        .HasColumnType("int");

                    b.Property<int>("LocationsId")
                        .HasColumnType("int");

                    b.HasKey("InternShipId", "LocationsId");

                    b.HasIndex("LocationsId");

                    b.ToTable("InternShipLocation");
                });

            modelBuilder.Entity("backend.Domain.Entities.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("ObjectIdentifier")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasAlternateKey("Email");

                    b.HasIndex("ObjectIdentifier");

                    b.ToTable("ApplicationUsers");
                });

            modelBuilder.Entity("backend.Domain.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ManagerEmails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("backend.Domain.Entities.InternShip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte>("CurrentCountOfStudents")
                        .HasColumnType("tinyint");

                    b.Property<byte>("MaxStudents")
                        .HasColumnType("tinyint");

                    b.Property<int>("RequiredTrainingType")
                        .HasColumnType("int");

                    b.Property<string>("SchoolYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SchoolYear");

                    b.HasIndex("UnitId");

                    b.ToTable("InternShips");
                });

            modelBuilder.Entity("backend.Domain.Entities.InternShipContentTranslation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(350)
                        .HasColumnType("nvarchar(350)");

                    b.Property<int>("InternShipId")
                        .HasColumnType("int");

                    b.Property<string>("KnowledgeToDevelop")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("NeededKnowledge")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("TitleContent")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.HasIndex("InternShipId");

                    b.HasIndex("LanguageId");

                    b.ToTable("Translations");
                });

            modelBuilder.Entity("backend.Domain.Entities.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("backend.Domain.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("HouseNumber")
                        .HasColumnType("int");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("backend.Domain.Entities.PrefaceTranslation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("UnitId");

                    b.ToTable("PrefaceTranslation");
                });

            modelBuilder.Entity("InternShipLocation", b =>
                {
                    b.HasOne("backend.Domain.Entities.InternShip", null)
                        .WithMany()
                        .HasForeignKey("InternShipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Domain.Entities.Location", null)
                        .WithMany()
                        .HasForeignKey("LocationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("backend.Domain.Entities.InternShip", b =>
                {
                    b.HasOne("backend.Domain.Entities.Department", "Unit")
                        .WithMany("Internships")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("backend.Domain.Entities.InternShipContentTranslation", b =>
                {
                    b.HasOne("backend.Domain.Entities.InternShip", "InternShip")
                        .WithMany("Translations")
                        .HasForeignKey("InternShipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Domain.Entities.Language", "Language")
                        .WithMany("InternshipTranslations")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InternShip");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("backend.Domain.Entities.PrefaceTranslation", b =>
                {
                    b.HasOne("backend.Domain.Entities.Language", "Language")
                        .WithMany("PrefaceTranslations")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Domain.Entities.Department", "Unit")
                        .WithMany("PrefaceTranslations")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("backend.Domain.Entities.Department", b =>
                {
                    b.Navigation("Internships");

                    b.Navigation("PrefaceTranslations");
                });

            modelBuilder.Entity("backend.Domain.Entities.InternShip", b =>
                {
                    b.Navigation("Translations");
                });

            modelBuilder.Entity("backend.Domain.Entities.Language", b =>
                {
                    b.Navigation("InternshipTranslations");

                    b.Navigation("PrefaceTranslations");
                });
#pragma warning restore 612, 618
        }
    }
}
