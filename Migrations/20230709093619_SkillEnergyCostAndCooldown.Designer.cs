﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnet_rpg.Data;

#nullable disable

namespace dotnetrpg.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230709093619_SkillEnergyCostAndCooldown")]
    partial class SkillEnergyCostAndCooldown
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CharacterSkill", b =>
                {
                    b.Property<int>("CharactersId")
                        .HasColumnType("int");

                    b.Property<int>("SkillsId")
                        .HasColumnType("int");

                    b.HasKey("CharactersId", "SkillsId");

                    b.HasIndex("SkillsId");

                    b.ToTable("CharacterSkill");
                });

            modelBuilder.Entity("dotnet_rpg.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Armor")
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Class")
                        .HasColumnType("int");

                    b.Property<int>("CurrentEnergy")
                        .HasColumnType("int");

                    b.Property<int>("CurrentHitPoints")
                        .HasColumnType("int");

                    b.Property<long>("Experience")
                        .HasColumnType("bigint");

                    b.Property<int?>("FightId")
                        .HasColumnType("int");

                    b.Property<int>("Intelligence")
                        .HasColumnType("int");

                    b.Property<bool>("IsPlayerCharacter")
                        .HasColumnType("bit");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("MaxEnergy")
                        .HasColumnType("int");

                    b.Property<int>("MaxHitPoints")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Resistance")
                        .HasColumnType("int");

                    b.Property<int>("Spirit")
                        .HasColumnType("int");

                    b.Property<int>("Stamina")
                        .HasColumnType("int");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FightId");

                    b.HasIndex("UserId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("dotnet_rpg.Models.Fight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Fights");
                });

            modelBuilder.Entity("dotnet_rpg.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CharacterClass")
                        .HasColumnType("int");

                    b.Property<int>("Cooldown")
                        .HasColumnType("int");

                    b.Property<int>("Damage")
                        .HasColumnType("int");

                    b.Property<int>("DamageType")
                        .HasColumnType("int");

                    b.Property<int>("EnergyCost")
                        .HasColumnType("int");

                    b.Property<int>("Healing")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TargetType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CharacterClass = 1,
                            Cooldown = 5,
                            Damage = 10,
                            DamageType = 1,
                            EnergyCost = 15,
                            Healing = 0,
                            Name = "Charge",
                            TargetType = 3
                        },
                        new
                        {
                            Id = 2,
                            CharacterClass = 1,
                            Cooldown = 5,
                            Damage = 5,
                            DamageType = 1,
                            EnergyCost = 10,
                            Healing = 0,
                            Name = "Rend",
                            TargetType = 3
                        },
                        new
                        {
                            Id = 3,
                            CharacterClass = 1,
                            Cooldown = 10,
                            Damage = 0,
                            DamageType = 1,
                            EnergyCost = 10,
                            Healing = 0,
                            Name = "Enrage",
                            TargetType = 1
                        },
                        new
                        {
                            Id = 4,
                            CharacterClass = 1,
                            Cooldown = 2,
                            Damage = 20,
                            DamageType = 1,
                            EnergyCost = 20,
                            Healing = 0,
                            Name = "Skillful Strike",
                            TargetType = 3
                        },
                        new
                        {
                            Id = 5,
                            CharacterClass = 2,
                            Cooldown = 10,
                            Damage = 0,
                            DamageType = 2,
                            EnergyCost = 15,
                            Healing = 0,
                            Name = "Arcane Barrier",
                            TargetType = 2
                        },
                        new
                        {
                            Id = 6,
                            CharacterClass = 2,
                            Cooldown = 2,
                            Damage = 20,
                            DamageType = 2,
                            EnergyCost = 20,
                            Healing = 0,
                            Name = "Ice Lance",
                            TargetType = 3
                        },
                        new
                        {
                            Id = 7,
                            CharacterClass = 2,
                            Cooldown = 3,
                            Damage = 5,
                            DamageType = 2,
                            EnergyCost = 10,
                            Healing = 0,
                            Name = "Combustion",
                            TargetType = 3
                        },
                        new
                        {
                            Id = 8,
                            CharacterClass = 2,
                            Cooldown = 10,
                            Damage = 10,
                            DamageType = 2,
                            EnergyCost = 30,
                            Healing = 0,
                            Name = "Lightning Storm",
                            TargetType = 3
                        },
                        new
                        {
                            Id = 9,
                            CharacterClass = 3,
                            Cooldown = 10,
                            Damage = 0,
                            DamageType = 2,
                            EnergyCost = 10,
                            Healing = 0,
                            Name = "Battle Meditation",
                            TargetType = 1
                        },
                        new
                        {
                            Id = 10,
                            CharacterClass = 3,
                            Cooldown = 3,
                            Damage = 0,
                            DamageType = 2,
                            EnergyCost = 15,
                            Healing = 20,
                            Name = "Miraclous Touch",
                            TargetType = 2
                        },
                        new
                        {
                            Id = 11,
                            CharacterClass = 3,
                            Cooldown = 2,
                            Damage = 20,
                            DamageType = 2,
                            EnergyCost = 20,
                            Healing = 0,
                            Name = "Holy Smite",
                            TargetType = 3
                        },
                        new
                        {
                            Id = 12,
                            CharacterClass = 3,
                            Cooldown = 3,
                            Damage = 5,
                            DamageType = 2,
                            EnergyCost = 10,
                            Healing = 0,
                            Name = "Cleansing Pain",
                            TargetType = 3
                        });
                });

            modelBuilder.Entity("dotnet_rpg.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("dotnet_rpg.Models.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("Damage")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("CharacterSkill", b =>
                {
                    b.HasOne("dotnet_rpg.Models.Character", null)
                        .WithMany()
                        .HasForeignKey("CharactersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dotnet_rpg.Models.Skill", null)
                        .WithMany()
                        .HasForeignKey("SkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("dotnet_rpg.Models.Character", b =>
                {
                    b.HasOne("dotnet_rpg.Models.Fight", "Fight")
                        .WithMany("Characters")
                        .HasForeignKey("FightId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("dotnet_rpg.Models.User", "User")
                        .WithMany("Characters")
                        .HasForeignKey("UserId");

                    b.Navigation("Fight");

                    b.Navigation("User");
                });

            modelBuilder.Entity("dotnet_rpg.Models.Weapon", b =>
                {
                    b.HasOne("dotnet_rpg.Models.Character", "Character")
                        .WithOne("Weapon")
                        .HasForeignKey("dotnet_rpg.Models.Weapon", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("dotnet_rpg.Models.Character", b =>
                {
                    b.Navigation("Weapon");
                });

            modelBuilder.Entity("dotnet_rpg.Models.Fight", b =>
                {
                    b.Navigation("Characters");
                });

            modelBuilder.Entity("dotnet_rpg.Models.User", b =>
                {
                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}
