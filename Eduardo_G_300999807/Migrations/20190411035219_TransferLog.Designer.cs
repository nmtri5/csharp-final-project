﻿// <auto-generated />
using System;
using Eduardo_G_300999807.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Eduardo_G_300999807.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190411035219_TransferLog")]
    partial class TransferLog
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Eduardo_G_300999807.Models.Club", b =>
                {
                    b.Property<int>("ClubId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("League");

                    b.Property<string>("Name");

                    b.HasKey("ClubId");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("Eduardo_G_300999807.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<int?>("ClubId");

                    b.Property<string>("Name");

                    b.Property<int>("Overall");

                    b.HasKey("PlayerId");

                    b.HasIndex("ClubId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Eduardo_G_300999807.Models.TransferLog", b =>
                {
                    b.Property<int>("TransferId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int?>("FromClubClubId");

                    b.Property<int?>("PlayerId");

                    b.Property<int?>("ToClubClubId");

                    b.HasKey("TransferId");

                    b.HasIndex("FromClubClubId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("ToClubClubId");

                    b.ToTable("TransferLog");
                });

            modelBuilder.Entity("Eduardo_G_300999807.Models.Player", b =>
                {
                    b.HasOne("Eduardo_G_300999807.Models.Club", "Club")
                        .WithMany("Players")
                        .HasForeignKey("ClubId");
                });

            modelBuilder.Entity("Eduardo_G_300999807.Models.TransferLog", b =>
                {
                    b.HasOne("Eduardo_G_300999807.Models.Club", "FromClub")
                        .WithMany()
                        .HasForeignKey("FromClubClubId");

                    b.HasOne("Eduardo_G_300999807.Models.Player")
                        .WithMany("TransferLog")
                        .HasForeignKey("PlayerId");

                    b.HasOne("Eduardo_G_300999807.Models.Club", "ToClub")
                        .WithMany()
                        .HasForeignKey("ToClubClubId");
                });
#pragma warning restore 612, 618
        }
    }
}
