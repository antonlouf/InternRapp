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
    [Migration("20230515071100_seed2")]
    partial class seed2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc.2.22472.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ManagerEmails = "anton.louf@student.ehb.be",
                            Name = ".net"
                        },
                        new
                        {
                            Id = 2,
                            ManagerEmails = "anton.louf@student.ehb.be",
                            Name = "Java"
                        },
                        new
                        {
                            Id = 3,
                            ManagerEmails = "anton.louf@student.ehb.be",
                            Name = "Low Code"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CurrentCountOfStudents = (byte)0,
                            MaxStudents = (byte)10,
                            RequiredTrainingType = 0,
                            SchoolYear = "2023-2024",
                            UnitId = 1
                        },
                        new
                        {
                            Id = 2,
                            CurrentCountOfStudents = (byte)0,
                            MaxStudents = (byte)10,
                            RequiredTrainingType = 1,
                            SchoolYear = "2023-2024",
                            UnitId = 2
                        },
                        new
                        {
                            Id = 3,
                            CurrentCountOfStudents = (byte)0,
                            MaxStudents = (byte)15,
                            RequiredTrainingType = 2,
                            SchoolYear = "2023-2024",
                            UnitId = 3
                        });
                });

            modelBuilder.Entity("backend.Domain.Entities.InternShipContentTranslation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("InternShipId")
                        .HasColumnType("int");

                    b.Property<string>("KnowledgeToDevelop")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("NeededKnowledge")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("TitleContent")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.HasIndex("InternShipId");

                    b.HasIndex("LanguageId");

                    b.ToTable("Translations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "<p>required diploma for this internship is: Bachelor<p>",
                            Description = "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p>",
                            InternShipId = 1,
                            KnowledgeToDevelop = "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>",
                            LanguageId = 1,
                            NeededKnowledge = "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>",
                            TitleContent = "InternRapp"
                        },
                        new
                        {
                            Id = 2,
                            Comment = "<p>required diploma for this internship is: Master<p>",
                            Description = "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p>",
                            InternShipId = 2,
                            KnowledgeToDevelop = "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>",
                            LanguageId = 2,
                            NeededKnowledge = "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>",
                            TitleContent = "Mobile App"
                        },
                        new
                        {
                            Id = 3,
                            Comment = "<p>required diploma for this internship is: MasterAfterMaster<p>",
                            Description = "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p>",
                            InternShipId = 3,
                            KnowledgeToDevelop = "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>",
                            LanguageId = 3,
                            NeededKnowledge = "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>",
                            TitleContent = "Android App"
                        });
                });

            modelBuilder.Entity("backend.Domain.Entities.InternShipLocation", b =>
                {
                    b.Property<int>("InternShipId")
                        .HasColumnType("int");

                    b.Property<int>("LocationsId")
                        .HasColumnType("int");

                    b.HasKey("InternShipId", "LocationsId");

                    b.HasIndex("LocationsId");

                    b.ToTable("InternShipLocation");

                    b.HasData(
                        new
                        {
                            InternShipId = 1,
                            LocationsId = 1
                        },
                        new
                        {
                            InternShipId = 1,
                            LocationsId = 2
                        },
                        new
                        {
                            InternShipId = 1,
                            LocationsId = 3
                        },
                        new
                        {
                            InternShipId = 2,
                            LocationsId = 1
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Code = "eng",
                            Name = "engels"
                        },
                        new
                        {
                            Id = 3,
                            Code = "fr",
                            Name = "frans"
                        },
                        new
                        {
                            Id = 1,
                            Code = "nl",
                            Name = "nederlands"
                        });
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

                    b.Property<int?>("InternShipId")
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

                    b.HasIndex("InternShipId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Huizingen",
                            HouseNumber = 42,
                            StreetName = "Vaucampslaan",
                            ZipCode = "1654"
                        },
                        new
                        {
                            Id = 2,
                            City = "Gent",
                            HouseNumber = 4,
                            StreetName = "Gaston Crommenlaan",
                            ZipCode = "9050"
                        },
                        new
                        {
                            Id = 3,
                            City = "Kontich",
                            HouseNumber = 26,
                            StreetName = "Prins Boudewijnlaan",
                            ZipCode = "2550"
                        });
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

                    b.ToTable("PrefaceTranslations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Dit is het voorwoord voor de .net competence center",
                            LanguageId = 1,
                            UnitId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "Dit is het voorwoord voor het Java departement center",
                            LanguageId = 3,
                            UnitId = 2
                        },
                        new
                        {
                            Id = 3,
                            Content = "Dit is het voorwoord voor het Low Code departement center",
                            LanguageId = 2,
                            UnitId = 3
                        });
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

            modelBuilder.Entity("backend.Domain.Entities.InternShipLocation", b =>
                {
                    b.HasOne("backend.Domain.Entities.InternShip", "InternShip")
                        .WithMany("InternShipLocations")
                        .HasForeignKey("InternShipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Domain.Entities.Location", "Location")
                        .WithMany("InternShipLocations")
                        .HasForeignKey("LocationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InternShip");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("backend.Domain.Entities.Location", b =>
                {
                    b.HasOne("backend.Domain.Entities.InternShip", null)
                        .WithMany("Locations")
                        .HasForeignKey("InternShipId");
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
                    b.Navigation("InternShipLocations");

                    b.Navigation("Locations");

                    b.Navigation("Translations");
                });

            modelBuilder.Entity("backend.Domain.Entities.Language", b =>
                {
                    b.Navigation("InternshipTranslations");

                    b.Navigation("PrefaceTranslations");
                });

            modelBuilder.Entity("backend.Domain.Entities.Location", b =>
                {
                    b.Navigation("InternShipLocations");
                });
#pragma warning restore 612, 618
        }
    }
}
