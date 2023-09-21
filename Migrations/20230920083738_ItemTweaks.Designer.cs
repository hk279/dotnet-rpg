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
    [Migration("20230920083738_ItemTweaks")]
    partial class ItemTweaks
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.Property<int>("InventorySize")
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

                    b.Property<int?>("WeaponId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FightId");

                    b.HasIndex("UserId");

                    b.HasIndex("WeaponId");

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

            modelBuilder.Entity("dotnet_rpg.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CharacterId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Intelligence")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rarity")
                        .HasColumnType("int");

                    b.Property<int>("Spirit")
                        .HasColumnType("int");

                    b.Property<int>("Stamina")
                        .HasColumnType("int");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("Item");

                    b.HasDiscriminator<int>("Type");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("dotnet_rpg.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CharacterClass")
                        .HasColumnType("int");

                    b.Property<int?>("CharacterId")
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

                    b.Property<int>("RemainingCooldown")
                        .HasColumnType("int");

                    b.Property<int>("TargetType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

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
                            RemainingCooldown = 0,
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
                            RemainingCooldown = 0,
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
                            RemainingCooldown = 0,
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
                            RemainingCooldown = 0,
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
                            RemainingCooldown = 0,
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
                            RemainingCooldown = 0,
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
                            RemainingCooldown = 0,
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
                            RemainingCooldown = 0,
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
                            RemainingCooldown = 0,
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
                            RemainingCooldown = 0,
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
                            RemainingCooldown = 0,
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
                            RemainingCooldown = 0,
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

            modelBuilder.Entity("dotnet_rpg.Models.ArmorPiece", b =>
                {
                    b.HasBaseType("dotnet_rpg.Models.Item");

                    b.Property<int>("Armor")
                        .HasColumnType("int");

                    b.Property<int>("Resistance")
                        .HasColumnType("int");

                    b.Property<int>("Slot")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue(2);
                });

            modelBuilder.Entity("dotnet_rpg.Models.Weapon", b =>
                {
                    b.HasBaseType("dotnet_rpg.Models.Item");

                    b.Property<int>("MaxDamage")
                        .HasColumnType("int");

                    b.Property<int>("MinDamage")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue(1);
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

                    b.HasOne("dotnet_rpg.Models.Weapon", "Weapon")
                        .WithMany()
                        .HasForeignKey("WeaponId");

                    b.Navigation("Fight");

                    b.Navigation("User");

                    b.Navigation("Weapon");
                });

            modelBuilder.Entity("dotnet_rpg.Models.Item", b =>
                {
                    b.HasOne("dotnet_rpg.Models.Character", null)
                        .WithMany("Inventory")
                        .HasForeignKey("CharacterId");
                });

            modelBuilder.Entity("dotnet_rpg.Models.Skill", b =>
                {
                    b.HasOne("dotnet_rpg.Models.Character", null)
                        .WithMany("Skills")
                        .HasForeignKey("CharacterId");
                });

            modelBuilder.Entity("dotnet_rpg.Models.Character", b =>
                {
                    b.Navigation("Inventory");

                    b.Navigation("Skills");
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
