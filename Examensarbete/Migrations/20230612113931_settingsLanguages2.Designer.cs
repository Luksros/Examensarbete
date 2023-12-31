﻿// <auto-generated />
using System;
using Examensarbete.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Examensarbete.Migrations
{
    [DbContext(typeof(alsDbContext))]
    [Migration("20230612113931_settingsLanguages2")]
    partial class settingsLanguages2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Examensarbete.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Examensarbete.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DriveItemId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FileSize")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastEditedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("OwnerPublicId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProjectFileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PublicId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Local),
                            DriveItemId = "FFAE75F410E7D5E9!116",
                            FileSize = 28778828,
                            LastEditedDate = new DateTime(2023, 6, 12, 13, 39, 31, 180, DateTimeKind.Local).AddTicks(9064),
                            OwnerPublicId = new Guid("34cfd964-7c00-433b-b6b1-f0c83ebe0fc4"),
                            ProjectFileName = "Dubstep Heater v12",
                            PublicId = new Guid("e1aed9e5-15bf-4831-a00f-68459c2dbd55")
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Local),
                            DriveItemId = "FFAE75F410E7D5E9!113",
                            FileSize = 11942208,
                            LastEditedDate = new DateTime(2023, 6, 12, 13, 39, 31, 180, DateTimeKind.Local).AddTicks(9081),
                            OwnerPublicId = new Guid("34cfd964-7c00-433b-b6b1-f0c83ebe0fc4"),
                            ProjectFileName = "Shitty Beat",
                            PublicId = new Guid("8818e9c4-f3de-47d5-a927-4a7c6e1f4dc3")
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Local),
                            DriveItemId = "FFAE75F410E7D5E9!111",
                            FileSize = 27545588,
                            LastEditedDate = new DateTime(2023, 6, 12, 13, 39, 31, 180, DateTimeKind.Local).AddTicks(9094),
                            OwnerPublicId = new Guid("34cfd964-7c00-433b-b6b1-f0c83ebe0fc4"),
                            ProjectFileName = "We Ain't Makin It Out The Hood",
                            PublicId = new Guid("f02d8399-790d-47d2-9478-8c22958e3692")
                        });
                });

            modelBuilder.Entity("Examensarbete.Models.ProjectCollaborator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("ProjectPublicId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserPublicId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("ProjectCollaborators");
                });

            modelBuilder.Entity("Examensarbete.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PublicId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Clockvice@gmail.com",
                            Password = "TestPassword",
                            PublicId = new Guid("34cfd964-7c00-433b-b6b1-f0c83ebe0fc4"),
                            Username = "Clockvice"
                        },
                        new
                        {
                            Id = 2,
                            Email = "testcollaborator@email.com",
                            Password = "TestPassword",
                            PublicId = new Guid("b95e3ecf-a882-4662-b4b1-6d1cd8259f9c"),
                            Username = "Vorso"
                        });
                });

            modelBuilder.Entity("Examensarbete.Models.UserSettings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("DarkMode")
                        .HasColumnType("bit");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<Guid>("UserPublicId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("UserSettings");
                });

            modelBuilder.Entity("Examensarbete.Models.UserSettings", b =>
                {
                    b.HasOne("Examensarbete.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");
                });
#pragma warning restore 612, 618
        }
    }
}
