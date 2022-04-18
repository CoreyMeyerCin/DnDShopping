﻿// <auto-generated />
using System;
using DungeonsAndDragons.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DungeonsAndDragons.Migrations
{
    [DbContext(typeof(AppDbcontext))]
    [Migration("20220414133732_init2")]
    partial class init2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DungeonsAndDragons.Model.Campaign", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DungeonMasterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("DungeonsAndDragons.Model.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CampaignId")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("Gold")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlayerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CampaignId");

                    b.HasIndex("CityId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("DungeonsAndDragons.Model.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CampaignId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CampaignId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("DungeonsAndDragons.Model.DungeonMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("PlayerId");

                    b.ToTable("DungeonMasters");
                });

            modelBuilder.Entity("DungeonsAndDragons.Model.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CharacterId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("RarityString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RarityValue")
                        .HasColumnType("int");

                    b.Property<int?>("StockId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("StockId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("DungeonsAndDragons.Model.NPCharacter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CampaignId")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CampaignId");

                    b.HasIndex("CityId");

                    b.ToTable("NPCharacter");
                });

            modelBuilder.Entity("DungeonsAndDragons.Model.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Birthdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CampaignId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CampaignId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Players");
                });

            modelBuilder.Entity("DungeonsAndDragons.Model.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("NPCharacterId")
                        .HasColumnType("int");

                    b.Property<int>("StockId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("NPCharacterId");

                    b.HasIndex("StockId");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("DungeonsAndDragons.Model.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Gold")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("DungeonsAndDragons.Model.Character", b =>
                {
                    b.HasOne("DungeonsAndDragons.Model.Campaign", null)
                        .WithMany("Character")
                        .HasForeignKey("CampaignId");

                    b.HasOne("DungeonsAndDragons.Model.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DungeonsAndDragons.Model.Player", null)
                        .WithMany("Character")
                        .HasForeignKey("PlayerId");

                    b.Navigation("City");
                });

            modelBuilder.Entity("DungeonsAndDragons.Model.City", b =>
                {
                    b.HasOne("DungeonsAndDragons.Model.Campaign", null)
                        .WithMany("City")
                        .HasForeignKey("CampaignId");
                });

            modelBuilder.Entity("DungeonsAndDragons.Model.DungeonMaster", b =>
                {
                    b.HasOne("DungeonsAndDragons.Model.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("DungeonsAndDragons.Model.Item", b =>
                {
                    b.HasOne("DungeonsAndDragons.Model.Character", null)
                        .WithMany("Item")
                        .HasForeignKey("CharacterId");

                    b.HasOne("DungeonsAndDragons.Model.Stock", null)
                        .WithMany("Item")
                        .HasForeignKey("StockId");
                });

            modelBuilder.Entity("DungeonsAndDragons.Model.NPCharacter", b =>
                {
                    b.HasOne("DungeonsAndDragons.Model.Campaign", null)
                        .WithMany("NPCharacter")
                        .HasForeignKey("CampaignId");

                    b.HasOne("DungeonsAndDragons.Model.City", "City")
                        .WithMany("NPCharacter")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("DungeonsAndDragons.Model.Player", b =>
                {
                    b.HasOne("DungeonsAndDragons.Model.Campaign", null)
                        .WithMany("Players")
                        .HasForeignKey("CampaignId");
                });

            modelBuilder.Entity("DungeonsAndDragons.Model.Shop", b =>
                {
                    b.HasOne("DungeonsAndDragons.Model.City", null)
                        .WithMany("Shop")
                        .HasForeignKey("CityId");

                    b.HasOne("DungeonsAndDragons.Model.NPCharacter", "NPCharacter")
                        .WithMany()
                        .HasForeignKey("NPCharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DungeonsAndDragons.Model.Stock", "Stock")
                        .WithMany()
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NPCharacter");

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("DungeonsAndDragons.Model.Campaign", b =>
                {
                    b.Navigation("Character");

                    b.Navigation("City");

                    b.Navigation("NPCharacter");

                    b.Navigation("Players");
                });

            modelBuilder.Entity("DungeonsAndDragons.Model.Character", b =>
                {
                    b.Navigation("Item");
                });

            modelBuilder.Entity("DungeonsAndDragons.Model.City", b =>
                {
                    b.Navigation("NPCharacter");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("DungeonsAndDragons.Model.Player", b =>
                {
                    b.Navigation("Character");
                });

            modelBuilder.Entity("DungeonsAndDragons.Model.Stock", b =>
                {
                    b.Navigation("Item");
                });
#pragma warning restore 612, 618
        }
    }
}
