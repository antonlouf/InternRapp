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
    [Migration("20230509143016_third")]
    partial class third
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "recep@inetum-realdolmen.world",
                            ObjectIdentifier = new Guid("d550c298-765c-48b7-a6e7-6e48079bc1fd")
                        },
                        new
                        {
                            Id = 2,
                            Email = "Anton@inetum-realdolmen.world",
                            ObjectIdentifier = new Guid("faccb848-eaca-4e58-8e8b-635efdb54973")
                        },
                        new
                        {
                            Id = 3,
                            Email = "Nils@inetum-realdolmen.world",
                            ObjectIdentifier = new Guid("458b66a1-2bcb-43d6-865f-085fb362ddc0")
                        });
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
                            ManagerEmails = "recep@inetum-realdolmen.world",
                            Name = "Java"
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
                        .HasColumnType("nvarchar(max)");

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

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Comment = "<p>required diploma for this internship is: Bachelor<p>",
                            Description = "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p>",
                            InternShipId = 1,
                            KnowledgeToDevelop = "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>",
                            LanguageId = 2,
                            Location = "new location",
                            NeededKnowledge = "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>",
                            TitleContent = "InternRapp"
                        },
                        new
                        {
                            Id = 2,
                            Comment = "<p>required diploma for this internship is: Bachelor<p>",
                            Description = "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p>",
                            InternShipId = 1,
                            KnowledgeToDevelop = "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>",
                            LanguageId = 3,
                            Location = "new location",
                            NeededKnowledge = "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>",
                            TitleContent = "InternRapp"
                        },
                        new
                        {
                            Id = 1,
                            Comment = "<p>required diploma for this internship is: Bachelor<p>",
                            Description = "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p>",
                            InternShipId = 1,
                            KnowledgeToDevelop = "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>",
                            LanguageId = 1,
                            Location = "new location",
                            NeededKnowledge = "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>",
                            TitleContent = "InternRapp"
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
                            Id = 1,
                            Code = "nl",
                            Name = "Nederlands"
                        },
                        new
                        {
                            Id = 2,
                            Code = "en",
                            Name = "Engels"
                        },
                        new
                        {
                            Id = 3,
                            Code = "fr",
                            Name = "French"
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "antwerpen",
                            HouseNumber = 51,
                            StreetName = "ellermanstraat",
                            ZipCode = "2260"
                        },
                        new
                        {
                            Id = 2,
                            City = "antwerpen",
                            HouseNumber = 51,
                            StreetName = "elleboogtraat",
                            ZipCode = "2260"
                        });
                });

            modelBuilder.Entity("backend.Domain.Entities.PrefaceTranslation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
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
                            Content = "blabla",
                            LanguageId = 1,
                            UnitId = 1
                        });
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
