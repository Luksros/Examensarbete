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
    [Migration("20230612113636_settingsLanguage")]
    partial class settingsLanguage
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
                            LastEditedDate = new DateTime(2023, 6, 12, 13, 36, 36, 581, DateTimeKind.Local).AddTicks(6043),
                            OwnerPublicId = new Guid("34cfd964-7c00-433b-b6b1-f0c83ebe0fc4"),
                            ProjectFileName = "Dubstep Heater v12",
                            PublicId = new Guid("18bd71f7-fbe5-4d9c-8e4d-605ec32b021a")
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Local),
                            DriveItemId = "FFAE75F410E7D5E9!113",
                            FileSize = 11942208,
                            LastEditedDate = new DateTime(2023, 6, 12, 13, 36, 36, 581, DateTimeKind.Local).AddTicks(6058),
                            OwnerPublicId = new Guid("34cfd964-7c00-433b-b6b1-f0c83ebe0fc4"),
                            ProjectFileName = "Shitty Beat",
                            PublicId = new Guid("1ffdf9af-a270-42ec-9225-05fa8a0f34c5")
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Local),
                            DriveItemId = "FFAE75F410E7D5E9!111",
                            FileSize = 27545588,
                            LastEditedDate = new DateTime(2023, 6, 12, 13, 36, 36, 581, DateTimeKind.Local).AddTicks(6072),
                            OwnerPublicId = new Guid("34cfd964-7c00-433b-b6b1-f0c83ebe0fc4"),
                            ProjectFileName = "We Ain't Makin It Out The Hood",
                            PublicId = new Guid("2462d10e-b1d2-44b9-a808-e92f892c82e9")
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
                            PublicId = new Guid("9fbb9ae5-b9e8-4ea8-918d-b01a64f2285c"),
                            Username = "Vorso"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}