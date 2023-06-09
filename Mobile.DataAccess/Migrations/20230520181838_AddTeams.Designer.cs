﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mobile.DataAccess.Contexts;

#nullable disable

namespace Mobile.DataAccess.Migrations
{
    [DbContext(typeof(MobileReadContext))]
    [Migration("20230520181838_AddTeams")]
    partial class AddTeams
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Mobile.DataAccess.Models.ColorScheme", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("BackgoundColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ButtonsColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TextColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ColorSchemes", (string)null);
                });

            modelBuilder.Entity("Mobile.DataAccess.Models.Device", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DeviceCode")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DeviceModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActivated")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Devices", (string)null);
                });

            modelBuilder.Entity("Mobile.DataAccess.Models.Place", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Places", (string)null);
                });

            modelBuilder.Entity("Mobile.DataAccess.Models.Position", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Positions", (string)null);
                });

            modelBuilder.Entity("Mobile.DataAccess.Models.Settings", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("ColorSchemeId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EnableAutoPayment")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("ShowAdv")
                        .HasColumnType("bit");

                    b.Property<string>("UseLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ColorSchemeId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Settings", (string)null);
                });

            modelBuilder.Entity("Mobile.DataAccess.Models.Team", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams", (string)null);
                });

            modelBuilder.Entity("Mobile.DataAccess.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Mobile.DataAccess.Models.Admin", b =>
                {
                    b.HasBaseType("Mobile.DataAccess.Models.User");

                    b.Property<long>("TeamId")
                        .HasColumnType("bigint");

                    b.HasIndex("TeamId");

                    b.ToTable("Admins", (string)null);
                });

            modelBuilder.Entity("Mobile.DataAccess.Models.Coach", b =>
                {
                    b.HasBaseType("Mobile.DataAccess.Models.User");

                    b.Property<long>("PositionId")
                        .HasColumnType("bigint");

                    b.Property<long>("TeamId")
                        .HasColumnType("bigint");

                    b.HasIndex("PositionId");

                    b.HasIndex("TeamId");

                    b.ToTable("Coaches", (string)null);
                });

            modelBuilder.Entity("Mobile.DataAccess.Models.Player", b =>
                {
                    b.HasBaseType("Mobile.DataAccess.Models.User");

                    b.Property<long>("PlaceId")
                        .HasColumnType("bigint");

                    b.Property<long>("TeamId")
                        .HasColumnType("bigint");

                    b.HasIndex("PlaceId");

                    b.HasIndex("TeamId");

                    b.ToTable("Players", (string)null);
                });

            modelBuilder.Entity("Mobile.DataAccess.Models.Device", b =>
                {
                    b.HasOne("Mobile.DataAccess.Models.User", "User")
                        .WithMany("Devices")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Mobile.DataAccess.Models.Settings", b =>
                {
                    b.HasOne("Mobile.DataAccess.Models.ColorScheme", "ColorScheme")
                        .WithOne("Settings")
                        .HasForeignKey("Mobile.DataAccess.Models.Settings", "ColorSchemeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Mobile.DataAccess.Models.User", "User")
                        .WithOne("Settings")
                        .HasForeignKey("Mobile.DataAccess.Models.Settings", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ColorScheme");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Mobile.DataAccess.Models.Admin", b =>
                {
                    b.HasOne("Mobile.DataAccess.Models.User", null)
                        .WithOne()
                        .HasForeignKey("Mobile.DataAccess.Models.Admin", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mobile.DataAccess.Models.Team", "Team")
                        .WithMany("Admins")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("Mobile.DataAccess.Models.Coach", b =>
                {
                    b.HasOne("Mobile.DataAccess.Models.User", null)
                        .WithOne()
                        .HasForeignKey("Mobile.DataAccess.Models.Coach", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mobile.DataAccess.Models.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mobile.DataAccess.Models.Team", "Team")
                        .WithMany("Coaches")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Position");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("Mobile.DataAccess.Models.Player", b =>
                {
                    b.HasOne("Mobile.DataAccess.Models.User", null)
                        .WithOne()
                        .HasForeignKey("Mobile.DataAccess.Models.Player", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mobile.DataAccess.Models.Place", "Place")
                        .WithMany()
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mobile.DataAccess.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Place");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("Mobile.DataAccess.Models.ColorScheme", b =>
                {
                    b.Navigation("Settings")
                        .IsRequired();
                });

            modelBuilder.Entity("Mobile.DataAccess.Models.Team", b =>
                {
                    b.Navigation("Admins");

                    b.Navigation("Coaches");

                    b.Navigation("Players");
                });

            modelBuilder.Entity("Mobile.DataAccess.Models.User", b =>
                {
                    b.Navigation("Devices");

                    b.Navigation("Settings")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
