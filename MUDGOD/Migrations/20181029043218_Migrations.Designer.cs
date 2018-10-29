﻿// <auto-generated />
using System;
using MUDGOD.Resources.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MUDGOD.Migrations
{
    [DbContext(typeof(SqliteDbContext))]
    [Migration("20181029043218_Migrations")]
    partial class Migrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("MUDGOD.PlayerCharacter", b =>
                {
                    b.Property<ulong>("playerId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accuracyPoints");

                    b.Property<int>("bodySize");

                    b.Property<int>("currency");

                    b.Property<int>("defPoints");

                    b.Property<int>("dexPoints");

                    b.Property<int>("fighterLevel");

                    b.Property<int>("healthPoints");

                    b.Property<int>("healthPointsMax");

                    b.Property<int>("intPoints");

                    b.Property<int>("lckPoints");

                    b.Property<int>("level");

                    b.Property<int>("locationX");

                    b.Property<int>("locationY");

                    b.Property<int>("magicianLevel");

                    b.Property<int>("manaPoints");

                    b.Property<int>("manaPointsMax");

                    b.Property<int>("myClassIdHolder");

                    b.Property<int?>("myClassid");

                    b.Property<int>("myRaceIdHolder");

                    b.Property<int?>("myRaceid");

                    b.Property<string>("name");

                    b.Property<int>("passiveDodgePoints");

                    b.Property<int>("peasantLevel");

                    b.Property<string>("playerName");

                    b.Property<int>("rangerLevel");

                    b.Property<int>("strPoints");

                    b.Property<int>("wisPoints");

                    b.HasKey("playerId");

                    b.HasIndex("myClassid");

                    b.HasIndex("myRaceid");

                    b.ToTable("playerList");
                });

            modelBuilder.Entity("MUDGOD.PlayerClass", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("defMulti");

                    b.Property<string>("description");

                    b.Property<float>("dexMulti");

                    b.Property<float>("hpMulti");

                    b.Property<float>("intMulti");

                    b.Property<float>("lckMulti");

                    b.Property<int>("level");

                    b.Property<float>("mpMulti");

                    b.Property<string>("name");

                    b.Property<float>("strMulti");

                    b.Property<float>("wisMulti");

                    b.HasKey("id");

                    b.ToTable("PlayerClass");
                });

            modelBuilder.Entity("MUDGOD.PlayerRace", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("defMulti");

                    b.Property<string>("description");

                    b.Property<float>("dexMulti");

                    b.Property<float>("hpMulti");

                    b.Property<float>("intMulti");

                    b.Property<float>("lckMulti");

                    b.Property<float>("mpMulti");

                    b.Property<string>("name");

                    b.Property<float>("strMulti");

                    b.Property<float>("wisMulti");

                    b.HasKey("id");

                    b.ToTable("PlayerRace");
                });

            modelBuilder.Entity("MUDGOD.PlayerCharacter", b =>
                {
                    b.HasOne("MUDGOD.PlayerClass", "myClass")
                        .WithMany()
                        .HasForeignKey("myClassid");

                    b.HasOne("MUDGOD.PlayerRace", "myRace")
                        .WithMany()
                        .HasForeignKey("myRaceid");
                });
#pragma warning restore 612, 618
        }
    }
}
