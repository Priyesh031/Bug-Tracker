﻿// <auto-generated />
using System;
using BugTracker.Identity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BugTracker.Identity.Migrations
{
    [DbContext(typeof(IdentityDbContext))]
    partial class IdentityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BugTracker.Application.Model.Identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "55d3463f-e3bb-48bd-8ba0-0a6d4383d1c0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b042bd56-419d-4175-b3d9-1148c21d9247",
                            Email = "DemoAdmin@Admin.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "DEMOADMIN@ADMIN.COM",
                            NormalizedUserName = "DEMO ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEOsXzbrolUYq2n/ZRWZ49/StOQ7Ag8zF1OG4KEwd8i30l9kHHLZdYhHJG70EcxgJ+g==",
                            PhoneNumber = "XXXXXXXXXXXXX",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "Demo Admin"
                        },
                        new
                        {
                            Id = "21399238-742f-41ad-a127-0b1fcea7624b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "10a10947-d20f-43c6-9f99-d9e46a00604d",
                            Email = "DemoDev@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "DEMODEV@GMAIL.COM",
                            NormalizedUserName = "DEMO DEVELOPER",
                            PasswordHash = "AQAAAAEAACcQAAAAEC/ecCyNj4UIVSE9zIkzWn7V5jd3UtZkbo3cNLkunvySM65kxVVpc7AehvMp4qrAOg==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "Demo developer"
                        },
                        new
                        {
                            Id = "90615823-f14b-49d9-a10d-cbb9f13af03e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "07f94c37-d86a-4f29-b25f-5da3fa95050e",
                            Email = "john@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "JOHN@GMAIL.COM",
                            NormalizedUserName = "DEMO SUBMITTER",
                            PasswordHash = "AQAAAAEAACcQAAAAEGzcDXhhYMQTUSgoowEtuFTSDDjfCIT4vg6VV68B9+Y2NGM/wtXO2ZOnR542ntjsgQ==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "Demo submitter"
                        },
                        new
                        {
                            Id = "8437fecb-a97d-4d2c-ab9b-64d932ea2d80",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "788d4db2-95c0-461d-b9c6-14e93b3d21eb",
                            Email = "demoPM@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "DEMOPM@GMAIL.COM",
                            NormalizedUserName = "DEMO PROJECT MANAGER",
                            PasswordHash = "AQAAAAEAACcQAAAAEJeDmZHWsSBZ49vLkkko9fK+g4BIOXrWza9mC43qoam5nc3YwS280al9l9ikiqPWJg==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "Demo Project Manager"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "65a8ecd9-79f2-4c35-8fdb-944ba63f7f45",
                            ConcurrencyStamp = "533963e5-9922-486e-a27f-c65011b26c41",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "6d964e54-f153-42de-b7ff-e0a084f33483",
                            ConcurrencyStamp = "d77b1639-4c60-4491-ad63-7d36c8f69c08",
                            Name = "Project Manager",
                            NormalizedName = "PROJECT MANAGER"
                        },
                        new
                        {
                            Id = "7e9dec6f-1989-4e71-a1b1-5c83c7cea271",
                            ConcurrencyStamp = "609614a9-3131-46f5-9822-6f862af1b4d4",
                            Name = "Developer",
                            NormalizedName = "DEVELOPER"
                        },
                        new
                        {
                            Id = "90c06dda-1784-447e-a843-7823e40eff38",
                            ConcurrencyStamp = "a68fa864-8092-4f32-a1de-3eb299379aba",
                            Name = "Submitter",
                            NormalizedName = "SUBMITTER"
                        },
                        new
                        {
                            Id = "da17c38d-15b7-4666-95df-8e92ea84353e",
                            ConcurrencyStamp = "10f21b4e-443a-4ca3-9f99-8b38557880f8",
                            Name = "Demo Admin",
                            NormalizedName = "DEMO_ADMIN"
                        },
                        new
                        {
                            Id = "e7d29c58-ef33-4fc1-b5bb-706847c76e69",
                            ConcurrencyStamp = "0312f31d-c55d-420e-ac4d-4ba2083a7d27",
                            Name = " Demo Project Manager",
                            NormalizedName = "DEMO PROJECT MANAGER"
                        },
                        new
                        {
                            Id = "9a2901cc-dda4-415e-a4e3-618803535454",
                            ConcurrencyStamp = "ffc423ae-2dda-4690-ade5-a79bb7c25aa7",
                            Name = "Demo Developer",
                            NormalizedName = "DEMO DEVELOPER"
                        },
                        new
                        {
                            Id = "0c4c9da8-7bf2-42e1-aa56-ea769db55671",
                            ConcurrencyStamp = "3a1bb66a-13d8-499c-b476-dcedcba6ebd6",
                            Name = "Demo Submitter",
                            NormalizedName = "DEMO SUBMITTER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BugTracker.Application.Model.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BugTracker.Application.Model.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BugTracker.Application.Model.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BugTracker.Application.Model.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
