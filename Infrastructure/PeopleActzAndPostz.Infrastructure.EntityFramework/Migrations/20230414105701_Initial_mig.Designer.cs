﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PeopleActzAndPostz.Infrastructure.EntityFramework.DbContext;

#nullable disable

namespace PeopleActzAndPostz.Infrastructure.EntityFramework.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230414105701_Initial_mig")]
    partial class Initial_mig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PeopleActzAndPostz.Domain.Models.DbEntities.Comment", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AppUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BodyContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities.AppRole", b =>
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

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "EE72CC84-0CFB-4BA5-8A51-55C3C85D23F2",
                            ConcurrencyStamp = "307d7c0d-26c1-4c3b-a424-5b8037c22843",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = "E4E7B010-DEB1-4BC9-BB59-572332E969D7",
                            ConcurrencyStamp = "038ffb28-94d6-4ec8-b808-f8e6a7ef90a6",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "3DF53752-2022-47E8-898E-0CEA6206A47E",
                            ConcurrencyStamp = "21496fdb-d06f-4d1e-bdfb-378f926c40ca",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RefreshTokenExpiryTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "b6eeeb2e-9361-44bf-b189-3ed9bb58e495",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "01d33cb9-a888-4902-afb0-c3bd27feb69b",
                            Email = "superAdmin@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                            NormalizedUserName = "SUPERADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEA19+GyHStiZQWRTiko7pUm3D60iL1YuiYFEakqfUlhSn9MofAdG3eBbiS70EXMZbA==",
                            PhoneNumber = "+90535999999",
                            PhoneNumberConfirmed = true,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "b725fea7-c5fe-4252-acba-8a54e2fccc92",
                            TwoFactorEnabled = false,
                            UserName = "superAdmin@gmail.com"
                        },
                        new
                        {
                            Id = "b9c6085d-d150-43e0-b2e2-1b7d05477d1b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2214bdd3-6a5c-4811-a17f-52b81405bfa9",
                            Email = "Admin@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJePri7d/PZERPZL/Quq6m/e9QEf2rTQQXs6PfuDm/eK1gusyYaYewfa0Qd/qnVk9Q==",
                            PhoneNumber = "+90535999999",
                            PhoneNumberConfirmed = true,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "47b11e09-642c-441a-ac34-1fe253299977",
                            TwoFactorEnabled = false,
                            UserName = "Admin@gmail.com"
                        });
                });

            modelBuilder.Entity("PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities.AppUserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "b6eeeb2e-9361-44bf-b189-3ed9bb58e495",
                            RoleId = "ee72cc84-0cfb-4ba5-8a51-55c3c85d23f2"
                        },
                        new
                        {
                            UserId = "b9c6085d-d150-43e0-b2e2-1b7d05477d1b",
                            RoleId = "e4e7b010-deb1-4bc9-bb59-572332e969d7"
                        });
                });

            modelBuilder.Entity("PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities.AppUserToken", b =>
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PeopleActzAndPostz.Domain.Models.DbEntities.Post", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BodyContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("PeopleActzAndPostz.Domain.Models.DbEntities.SubComment", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CommentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ContentBody")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("SubComments");
                });

            modelBuilder.Entity("PeopleActzAndPostz.Domain.Models.DbEntities.Comment", b =>
                {
                    b.HasOne("PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities.AppUser", "appUser")
                        .WithMany("Comments")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PeopleActzAndPostz.Domain.Models.DbEntities.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("appUser");
                });

            modelBuilder.Entity("PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities.AppRoleClaim", b =>
                {
                    b.HasOne("PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities.AppUserClaim", b =>
                {
                    b.HasOne("PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities.AppUserLogin", b =>
                {
                    b.HasOne("PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities.AppUserRole", b =>
                {
                    b.HasOne("PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities.AppUserToken", b =>
                {
                    b.HasOne("PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PeopleActzAndPostz.Domain.Models.DbEntities.Post", b =>
                {
                    b.HasOne("PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities.AppUser", "AppUser")
                        .WithMany("Posts")
                        .HasForeignKey("AppUserId");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("PeopleActzAndPostz.Domain.Models.DbEntities.SubComment", b =>
                {
                    b.HasOne("PeopleActzAndPostz.Domain.Models.DbEntities.Comment", "Comment")
                        .WithMany("SubComments")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PeopleActzAndPostz.Domain.Models.DbEntities.Post", null)
                        .WithMany("SubComments")
                        .HasForeignKey("PostId");

                    b.HasOne("PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities.AppUser", "User")
                        .WithMany("SubComments")
                        .HasForeignKey("UserId");

                    b.Navigation("Comment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PeopleActzAndPostz.Domain.Models.DbEntities.Comment", b =>
                {
                    b.Navigation("SubComments");
                });

            modelBuilder.Entity("PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities.AppUser", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Posts");

                    b.Navigation("SubComments");
                });

            modelBuilder.Entity("PeopleActzAndPostz.Domain.Models.DbEntities.Post", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("SubComments");
                });
#pragma warning restore 612, 618
        }
    }
}