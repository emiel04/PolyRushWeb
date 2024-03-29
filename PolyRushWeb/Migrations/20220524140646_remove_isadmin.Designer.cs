﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PolyRushWeb.Data;

#nullable disable

namespace PolyRushWeb.Migrations
{
    [DbContext(typeof(PolyRushWebContext))]
    [Migration("20220524140646_remove_isadmin")]
    partial class remove_isadmin
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8_general_ci")
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8");

            modelBuilder.Entity("Achievement", b =>
                {
                    b.Property<int>("Idachievement")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AchievementDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("AchievementName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Idachievement")
                        .HasName("PRIMARY");

                    b.ToTable("achievement", (string)null);

                    MySqlEntityTypeBuilderExtensions.HasCharSet(b, "latin1");
                    MySqlEntityTypeBuilderExtensions.UseCollation(b, "latin1_swedish_ci");

                    b.HasData(
                        new
                        {
                            Idachievement = 1,
                            AchievementDescription = "Gather 25 coins in a single game",
                            AchievementName = "25 coins in one game"
                        },
                        new
                        {
                            Idachievement = 2,
                            AchievementDescription = "Gather 100 coins in a single game",
                            AchievementName = "100 coins in one game"
                        },
                        new
                        {
                            Idachievement = 3,
                            AchievementDescription = "Gather 250 coins in a single game",
                            AchievementName = "250 coins in one game"
                        },
                        new
                        {
                            Idachievement = 4,
                            AchievementDescription = "Gather 500 coins in a single game",
                            AchievementName = "500 coins in one game"
                        },
                        new
                        {
                            Idachievement = 5,
                            AchievementDescription = "Gather 1000 coins in a single game",
                            AchievementName = "1000 coins in one game"
                        },
                        new
                        {
                            Idachievement = 6,
                            AchievementDescription = "Take the number one position on the leaderboard",
                            AchievementName = "Numero uno"
                        },
                        new
                        {
                            Idachievement = 7,
                            AchievementDescription = "Buy something from the shop",
                            AchievementName = "Shopper"
                        },
                        new
                        {
                            Idachievement = 8,
                            AchievementDescription = "Play the game for the first time.",
                            AchievementName = "Player"
                        },
                        new
                        {
                            Idachievement = 9,
                            AchievementDescription = "Reach a highscore of 1000.",
                            AchievementName = "1000 highscore"
                        },
                        new
                        {
                            Idachievement = 10,
                            AchievementDescription = "Reach a highscore of 2500.",
                            AchievementName = "2500 highscore"
                        },
                        new
                        {
                            Idachievement = 11,
                            AchievementDescription = "Reach a highscore of 10000.",
                            AchievementName = "10000 highscore"
                        },
                        new
                        {
                            Idachievement = 12,
                            AchievementDescription = "Reach a highscore of 50000.",
                            AchievementName = "50000 highscore"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("role", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "80d8ef83-8777-4763-a1df-b5954d208a3f",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("roleclaim", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("userclaim", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("userlogin", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("userrole", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("usertoken", (string)null);
                });

            modelBuilder.Entity("PolyRushLibrary.Discount", b =>
                {
                    b.Property<int>("Iddiscount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("IDDiscount");

                    b.Property<int>("DiscountPercentage")
                        .HasColumnType("int(11)");

                    b.Property<DateTime>("Enddate")
                        .HasColumnType("datetime");

                    b.Property<int>("ItemId")
                        .HasColumnType("int(11)")
                        .HasColumnName("ItemID");

                    b.Property<DateTime>("Startdate")
                        .HasColumnType("datetime");

                    b.HasKey("Iddiscount")
                        .HasName("PRIMARY");

                    b.ToTable("discount", (string)null);

                    MySqlEntityTypeBuilderExtensions.HasCharSet(b, "latin1");
                    MySqlEntityTypeBuilderExtensions.UseCollation(b, "latin1_swedish_ci");
                });

            modelBuilder.Entity("PolyRushLibrary.Gamesession", b =>
                {
                    b.Property<int>("IdgameSession")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("IDGameSession");

                    b.Property<int>("CoinsGathered")
                        .HasColumnType("int(11)");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("PeoplePassed")
                        .HasColumnType("int(11)");

                    b.Property<int>("ScoreGathered")
                        .HasColumnType("int(11)");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("UserId")
                        .HasColumnType("int(11)")
                        .HasColumnName("UserID");

                    b.HasKey("IdgameSession")
                        .HasName("PRIMARY");

                    b.ToTable("gamesession", (string)null);

                    MySqlEntityTypeBuilderExtensions.HasCharSet(b, "latin1");
                    MySqlEntityTypeBuilderExtensions.UseCollation(b, "latin1_swedish_ci");
                });

            modelBuilder.Entity("PolyRushLibrary.Item", b =>
                {
                    b.Property<int>("Iditem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("IDItem");

                    b.Property<int>("ItemTypeId")
                        .HasColumnType("int(11)")
                        .HasColumnName("ItemTypeID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("int(11)");

                    b.HasKey("Iditem")
                        .HasName("PRIMARY");

                    b.ToTable("item", (string)null);

                    MySqlEntityTypeBuilderExtensions.HasCharSet(b, "latin1");
                    MySqlEntityTypeBuilderExtensions.UseCollation(b, "latin1_swedish_ci");

                    b.HasData(
                        new
                        {
                            Iditem = 1,
                            ItemTypeId = 2,
                            Name = "Double score",
                            Price = 69
                        },
                        new
                        {
                            Iditem = 2,
                            ItemTypeId = 2,
                            Name = "Forcefield",
                            Price = 200
                        },
                        new
                        {
                            Iditem = 3,
                            ItemTypeId = 1,
                            Name = "Playerskin1",
                            Price = 200
                        },
                        new
                        {
                            Iditem = 4,
                            ItemTypeId = 1,
                            Name = "Playerskin2",
                            Price = 1000
                        },
                        new
                        {
                            Iditem = 5,
                            ItemTypeId = 1,
                            Name = "Playerskin3",
                            Price = 5000
                        },
                        new
                        {
                            Iditem = 6,
                            ItemTypeId = 1,
                            Name = "Playerskin4",
                            Price = 20000
                        });
                });

            modelBuilder.Entity("PolyRushLibrary.Itemtype", b =>
                {
                    b.Property<int>("IditemType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("IDItemType");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IditemType")
                        .HasName("PRIMARY");

                    b.ToTable("itemtype", (string)null);

                    MySqlEntityTypeBuilderExtensions.HasCharSet(b, "latin1");
                    MySqlEntityTypeBuilderExtensions.UseCollation(b, "latin1_swedish_ci");

                    b.HasData(
                        new
                        {
                            IditemType = 1,
                            Name = "Skin"
                        },
                        new
                        {
                            IditemType = 2,
                            Name = "Ability"
                        });
                });

            modelBuilder.Entity("PolyRushLibrary.Setting", b =>
                {
                    b.Property<int>("Idsetting")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("IDSetting");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Idsetting")
                        .HasName("PRIMARY");

                    b.ToTable("setting", (string)null);

                    MySqlEntityTypeBuilderExtensions.HasCharSet(b, "latin1");
                    MySqlEntityTypeBuilderExtensions.UseCollation(b, "latin1_swedish_ci");

                    b.HasData(
                        new
                        {
                            Idsetting = 1,
                            Description = "The master volume of the game (0-100)",
                            Name = "Master Volume"
                        },
                        new
                        {
                            Idsetting = 2,
                            Description = "Are the sounds effects of the game enabled?",
                            Name = "Sfx"
                        },
                        new
                        {
                            Idsetting = 3,
                            Description = "Is the music in the game enabled?",
                            Name = "Music"
                        });
                });

            modelBuilder.Entity("PolyRushLibrary.Useritem", b =>
                {
                    b.Property<int>("IduserItem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("IDUserItem");

                    b.Property<int>("Amount")
                        .HasColumnType("int(11)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int(11)")
                        .HasColumnName("ItemID");

                    b.Property<int>("UserId")
                        .HasColumnType("int(11)")
                        .HasColumnName("UserID");

                    b.HasKey("IduserItem")
                        .HasName("PRIMARY");

                    b.ToTable("useritem", (string)null);

                    MySqlEntityTypeBuilderExtensions.HasCharSet(b, "latin1");
                    MySqlEntityTypeBuilderExtensions.UseCollation(b, "latin1_swedish_ci");
                });

            modelBuilder.Entity("PolyRushLibrary.Usersetting", b =>
                {
                    b.Property<int>("IduserSetting")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("IDUserSetting");

                    b.Property<int>("SettingId")
                        .HasColumnType("int(11)")
                        .HasColumnName("SettingID");

                    b.Property<int>("State")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasDefaultValueSql("'1'");

                    b.Property<int>("UserId")
                        .HasColumnType("int(11)")
                        .HasColumnName("UserID");

                    b.HasKey("IduserSetting")
                        .HasName("PRIMARY");

                    b.ToTable("usersetting", (string)null);

                    MySqlEntityTypeBuilderExtensions.HasCharSet(b, "latin1");
                    MySqlEntityTypeBuilderExtensions.UseCollation(b, "latin1_swedish_ci");
                });

            modelBuilder.Entity("PolyRushWeb.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("Coins")
                        .HasColumnType("int");

                    b.Property<int>("Coinsgathered")
                        .HasColumnType("int");

                    b.Property<int>("Coinsspent")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Highscore")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<int>("Itemspurchased")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastLoginTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Scoregathered")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool?>("SeesAds")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Timespassed")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("user", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            Coins = 0,
                            Coinsgathered = 0,
                            Coinsspent = 0,
                            ConcurrencyStamp = "n8754226-b405-4519-9beb-a9281053f355",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "emiel.delaey@sintjozefbrugge.be",
                            EmailConfirmed = true,
                            Firstname = "Admin",
                            Highscore = 0,
                            IsActive = false,
                            Itemspurchased = 0,
                            LastLoginTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Lastname = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "EMIEL.DELAEY@SINTJOZEFBRUGGE.BE",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAECXyt6FzojMSckIeKQbn/woZvzzTaRCIyumUasLJbxfluPcIrfhhnz698Xp25MqIgw==",
                            PhoneNumberConfirmed = false,
                            Scoregathered = 0,
                            SecurityStamp = "V3PFRDAS3MJWQD5TSW2GWPRADBFEZINA",
                            Timespassed = 0,
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("UserAchievement", b =>
                {
                    b.Property<int>("IduserAchievement")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AchievementId")
                        .HasColumnType("int(11)");

                    b.Property<int>("UserId")
                        .HasColumnType("int(11)");

                    b.HasKey("IduserAchievement")
                        .HasName("PRIMARY");

                    b.ToTable("userachievement", (string)null);

                    MySqlEntityTypeBuilderExtensions.HasCharSet(b, "latin1");
                    MySqlEntityTypeBuilderExtensions.UseCollation(b, "latin1_swedish_ci");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("PolyRushWeb.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("PolyRushWeb.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PolyRushWeb.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("PolyRushWeb.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
