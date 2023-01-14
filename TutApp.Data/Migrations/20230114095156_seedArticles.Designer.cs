﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tut.Model.SiteDbContext;

#nullable disable

namespace TutApp.Data.Migrations
{
    [DbContext(typeof(SiteDbContext))]
    [Migration("20230114095156_seedArticles")]
    partial class seedArticles
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "2c8034c5-be71-4a1f-89b9-7f9b4ea3a805",
                            ConcurrencyStamp = "574f2c97-e1bd-42ad-bbac-4b2bcc65ceb7",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "63e005a4-858b-4ea8-b94c-98b9f8f58623",
                            ConcurrencyStamp = "5b9f5aed-a463-441a-9a1e-098c742e39a8",
                            Name = "Creator",
                            NormalizedName = "CREATOR"
                        },
                        new
                        {
                            Id = "0d82efc3-1a93-4f35-95ce-5fd63b2ea136",
                            ConcurrencyStamp = "0400306e-abd4-4369-b0dd-7489888a4611",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TutApp.Data.Models.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("ImageId")
                        .HasColumnType("int");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.Property<int>("category")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "*",
                            Created = new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 1,
                            Stars = 5,
                            Title = "איך להשתמש ב-Github?",
                            UserId = "24d6f228-0992-4755-8a17-670efb9d10e0",
                            Views = 35643,
                            category = 0
                        },
                        new
                        {
                            Id = 2,
                            Content = "*",
                            Created = new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 2,
                            Stars = 3,
                            Title = "מה זה תכנות מונחה עצמים?",
                            UserId = "24d6f228-0992-4755-8a17-670efb9d10e0",
                            Views = 324576,
                            category = 0
                        },
                        new
                        {
                            Id = 3,
                            Content = "*",
                            Created = new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 3,
                            Stars = 4,
                            Title = "מבוא לאנגולר",
                            UserId = "917d992e-763c-4560-be77-96b1ebca3654",
                            Views = 15643,
                            category = 0
                        },
                        new
                        {
                            Id = 4,
                            Content = "*",
                            Created = new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 4,
                            Stars = 5,
                            Title = "תכנות אסינכרוני ב-JS",
                            UserId = "8bb44c37-2465-4d1c-ba34-85ef3c0a3d89",
                            Views = 152643,
                            category = 0
                        },
                        new
                        {
                            Id = 5,
                            Content = "*",
                            Created = new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 5,
                            Stars = 4,
                            Title = "10 טיפים לבית החכם",
                            UserId = "24d6f228-0992-4755-8a17-670efb9d10e0",
                            Views = 354342,
                            category = 2
                        },
                        new
                        {
                            Id = 6,
                            Content = "*",
                            Created = new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 6,
                            Stars = 2,
                            Title = "איך לתכנת את שואב הדייסון שלכם?",
                            UserId = "8bb44c37-2465-4d1c-ba34-85ef3c0a3d89",
                            Views = 3453,
                            category = 2
                        },
                        new
                        {
                            Id = 7,
                            Content = "*",
                            Created = new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 7,
                            Stars = 1,
                            Title = "התקנת מנעול חכם לבית",
                            UserId = "8bb44c37-2465-4d1c-ba34-85ef3c0a3d89",
                            Views = 5685,
                            category = 2
                        },
                        new
                        {
                            Id = 8,
                            Content = "*",
                            Created = new DateTime(2020, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 8,
                            Stars = 0,
                            Title = "5 מוצרים חכמים לכל בית",
                            UserId = "917d992e-763c-4560-be77-96b1ebca3654",
                            Views = 124,
                            category = 2
                        },
                        new
                        {
                            Id = 9,
                            Content = "*",
                            Created = new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 9,
                            Stars = 5,
                            Title = "איך להתקין חוסם פרסומות בדפדפן?",
                            UserId = "917d992e-763c-4560-be77-96b1ebca3654",
                            Views = 34564536,
                            category = 1
                        },
                        new
                        {
                            Id = 10,
                            Content = "*",
                            Created = new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 10,
                            Stars = 3,
                            Title = "מה זה קוד 404?",
                            UserId = "917d992e-763c-4560-be77-96b1ebca3654",
                            Views = 45643,
                            category = 1
                        },
                        new
                        {
                            Id = 11,
                            Content = "*",
                            Created = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 11,
                            Stars = 1,
                            Title = "7 טיפים לגלישה בטוחה באינטרנט",
                            UserId = "8bb44c37-2465-4d1c-ba34-85ef3c0a3d89",
                            Views = 356,
                            category = 1
                        },
                        new
                        {
                            Id = 12,
                            Content = "*",
                            Created = new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 12,
                            Stars = 2,
                            Title = "המדריך המלא ל-Gmail",
                            UserId = "24d6f228-0992-4755-8a17-670efb9d10e0",
                            Views = 27643,
                            category = 1
                        },
                        new
                        {
                            Id = 13,
                            Content = "*",
                            Created = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 13,
                            Stars = 5,
                            Title = "איך לעשות רקע שקוף לתמונה?",
                            UserId = "917d992e-763c-4560-be77-96b1ebca3654",
                            Views = 4565468,
                            category = 3
                        },
                        new
                        {
                            Id = 14,
                            Content = "*",
                            Created = new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 14,
                            Stars = 4,
                            Title = "המדריך המלא ל-Gimp",
                            UserId = "917d992e-763c-4560-be77-96b1ebca3654",
                            Views = 25643,
                            category = 3
                        },
                        new
                        {
                            Id = 15,
                            Content = "*",
                            Created = new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 15,
                            Stars = 5,
                            Title = "המדריך המלא ל-PhotoShop",
                            UserId = "8bb44c37-2465-4d1c-ba34-85ef3c0a3d89",
                            Views = 5675656,
                            category = 3
                        },
                        new
                        {
                            Id = 16,
                            Content = "*",
                            Created = new DateTime(2020, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 16,
                            Stars = 0,
                            Title = "איך ליצור תמונות מונפשות?",
                            UserId = "24d6f228-0992-4755-8a17-670efb9d10e0",
                            Views = 22643,
                            category = 3
                        });
                });

            modelBuilder.Entity("TutApp.Data.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<int>("CommentStatus")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("TutApp.Data.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Location = "/assets/Images/programming1.png",
                            Title = "Programming1"
                        },
                        new
                        {
                            Id = 2,
                            Location = "/assets/Images/programming2.png",
                            Title = "Programming2"
                        },
                        new
                        {
                            Id = 3,
                            Location = "/assets/Images/programming3.png",
                            Title = "Programming3"
                        },
                        new
                        {
                            Id = 4,
                            Location = "/assets/Images/programming4.png",
                            Title = "Programming4"
                        },
                        new
                        {
                            Id = 5,
                            Location = "/assets/Images/iot1.png",
                            Title = "Iot1"
                        },
                        new
                        {
                            Id = 6,
                            Location = "/assets/Images/iot2.png",
                            Title = "Iot2"
                        },
                        new
                        {
                            Id = 7,
                            Location = "/assets/Images/iot3.png",
                            Title = "Iot3"
                        },
                        new
                        {
                            Id = 8,
                            Location = "/assets/Images/iot4.png",
                            Title = "Iot4"
                        },
                        new
                        {
                            Id = 9,
                            Location = "/assets/Images/internet1.png",
                            Title = "Internet1"
                        },
                        new
                        {
                            Id = 10,
                            Location = "/assets/Images/internet2.png",
                            Title = "Internet2"
                        },
                        new
                        {
                            Id = 11,
                            Location = "/assets/Images/internet3.png",
                            Title = "Internet3"
                        },
                        new
                        {
                            Id = 12,
                            Location = "/assets/Images/internet4.png",
                            Title = "Internet4"
                        },
                        new
                        {
                            Id = 13,
                            Location = "/assets/Images/design1.png",
                            Title = "Design1"
                        },
                        new
                        {
                            Id = 14,
                            Location = "/assets/Images/design2.png",
                            Title = "Design2"
                        },
                        new
                        {
                            Id = 15,
                            Location = "/assets/Images/design3.png",
                            Title = "Design3"
                        },
                        new
                        {
                            Id = 16,
                            Location = "/assets/Images/design4.png",
                            Title = "Design4"
                        });
                });

            modelBuilder.Entity("TutApp.Data.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReciverId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SenderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReciverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("TutApp.Data.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AboutMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FavCategoriesList")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HobbiesList")
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

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("UserStatus")
                        .HasColumnType("int");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

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
                            Id = "f9bdc8d4-b7b0-477b-a1e4-44e72fcfb357",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6de79cd8-4373-4caf-9571-9dfc47104d46",
                            DOB = new DateTime(2023, 1, 14, 11, 51, 56, 605, DateTimeKind.Local).AddTicks(7400),
                            Email = "admin@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Password = "123#Abc123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6bde944f-a01f-417f-bb85-9ecbc5a14cc0",
                            TwoFactorEnabled = false,
                            UserName = "Admin",
                            UserStatus = 1,
                            UserType = 3
                        },
                        new
                        {
                            Id = "78de57a8-5a20-4608-a2d3-30acd510be78",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ca4107a4-688a-4569-a026-2013e15ae52b",
                            DOB = new DateTime(2023, 1, 14, 11, 51, 56, 605, DateTimeKind.Local).AddTicks(7447),
                            Email = "melon@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Password = "123#Abc123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2260aa90-a37d-4fca-9572-d84b13a6c0d6",
                            TwoFactorEnabled = false,
                            UserName = "Rickey Melon",
                            UserStatus = 1,
                            UserType = 1
                        },
                        new
                        {
                            Id = "3e42d3b7-69e1-45a7-8ecd-acd40413b3a7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "77524316-309d-4305-9442-da832926b1ae",
                            DOB = new DateTime(2023, 1, 14, 11, 51, 56, 605, DateTimeKind.Local).AddTicks(7455),
                            Email = "abed@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Password = "123#Abc123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "50367052-191d-411f-9c03-87bf602b00f6",
                            TwoFactorEnabled = false,
                            UserName = "Abed Zuhil",
                            UserStatus = 1,
                            UserType = 2
                        },
                        new
                        {
                            Id = "bca1aa50-df08-442d-99fd-eee79c190064",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "70e8baf4-ed06-4cfa-8321-46cd407dee22",
                            DOB = new DateTime(2023, 1, 14, 11, 51, 56, 605, DateTimeKind.Local).AddTicks(7464),
                            Email = "erik@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Password = "123#Abc123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6b621fce-f610-41c2-bd8a-bd461fda99d4",
                            TwoFactorEnabled = false,
                            UserName = "Erik Lemon",
                            UserStatus = 1,
                            UserType = 2
                        },
                        new
                        {
                            Id = "0b1fbb48-33dd-43de-994c-933cf41cfa9b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ba8a51fc-b279-4571-93d3-e922c2dd33af",
                            DOB = new DateTime(2023, 1, 14, 11, 51, 56, 605, DateTimeKind.Local).AddTicks(7474),
                            Email = "chan@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Password = "123#Abc123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "128a97bd-dda2-461c-815f-124ed0217d24",
                            TwoFactorEnabled = false,
                            UserName = "Chan Don Ma",
                            UserStatus = 1,
                            UserType = 1
                        },
                        new
                        {
                            Id = "2ee7c1aa-5fbc-48b0-9829-aad8807150d5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7379326f-5e26-441e-b11e-5b5e5638104d",
                            DOB = new DateTime(2023, 1, 14, 11, 51, 56, 605, DateTimeKind.Local).AddTicks(7482),
                            Email = "al@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Password = "123#Abc123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5eb72c2f-935f-4d21-9c01-b045828d25ec",
                            TwoFactorEnabled = false,
                            UserName = "Al Viss",
                            UserStatus = 1,
                            UserType = 2
                        },
                        new
                        {
                            Id = "3a03e7ae-a5c4-41c3-b7df-1b142ff3c8b0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "af447bf7-17d9-47f0-86fe-58592d16c5a7",
                            DOB = new DateTime(2023, 1, 14, 11, 51, 56, 605, DateTimeKind.Local).AddTicks(7489),
                            Email = "donna@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Password = "123#Abc123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5fe288ec-c5b7-41ee-b891-0cd911e108ff",
                            TwoFactorEnabled = false,
                            UserName = "Donna Eyzer",
                            UserStatus = 1,
                            UserType = 1
                        });
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
                    b.HasOne("TutApp.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TutApp.Data.Models.User", null)
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

                    b.HasOne("TutApp.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TutApp.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TutApp.Data.Models.Article", b =>
                {
                    b.HasOne("TutApp.Data.Models.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });

            modelBuilder.Entity("TutApp.Data.Models.Comment", b =>
                {
                    b.HasOne("TutApp.Data.Models.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("TutApp.Data.Models.Message", b =>
                {
                    b.HasOne("TutApp.Data.Models.User", "Reciver")
                        .WithMany()
                        .HasForeignKey("ReciverId");

                    b.HasOne("TutApp.Data.Models.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId");

                    b.Navigation("Reciver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("TutApp.Data.Models.Article", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("TutApp.Data.Models.Image", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
