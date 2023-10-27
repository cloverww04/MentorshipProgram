﻿// <auto-generated />
using System;
using MentorShipProgram;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MentorShipProgram.Migrations
{
    [DbContext(typeof(MentorDbContext))]
    partial class MentorDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MentorShipProgram.Models.Appointments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("MentorId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MentorId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            DateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MentorId = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("MentorShipProgram.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CategoryId"));

                    b.Property<int?>("AppointmentsId")
                        .HasColumnType("integer");

                    b.Property<string>("CategoryName")
                        .HasColumnType("text");

                    b.Property<int?>("MentorId")
                        .HasColumnType("integer");

                    b.HasKey("CategoryId");

                    b.HasIndex("AppointmentsId");

                    b.HasIndex("MentorId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Communications"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Professional Development"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Networking"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Leadership"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Career and Education Planning"
                        });
                });

            modelBuilder.Entity("MentorShipProgram.Models.Mentor", b =>
                {
                    b.Property<int>("MentorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MentorId"));

                    b.Property<int?>("AppointmentsId")
                        .HasColumnType("integer");

                    b.Property<string>("Bio")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.HasKey("MentorId");

                    b.HasIndex("AppointmentsId");

                    b.ToTable("Mentors");

                    b.HasData(
                        new
                        {
                            MentorId = 1,
                            Bio = "I am a Product Experience Manager with extensive experience in the corporate world.",
                            FirstName = "Adonis",
                            LastName = "Bridges"
                        },
                        new
                        {
                            MentorId = 2,
                            Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                            FirstName = "Michael",
                            LastName = "Perso"
                        },
                        new
                        {
                            MentorId = 3,
                            Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                            FirstName = "Kai",
                            LastName = "Okonko"
                        },
                        new
                        {
                            MentorId = 4,
                            Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                            FirstName = "Bri",
                            LastName = "Karter"
                        });
                });

            modelBuilder.Entity("MentorShipProgram.Models.MentorCategories", b =>
                {
                    b.Property<int>("MentorId")
                        .HasColumnType("integer");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int?>("AppointmentsId")
                        .HasColumnType("integer");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.HasKey("MentorId", "CategoryId");

                    b.HasIndex("AppointmentsId");

                    b.HasIndex("CategoryId");

                    b.ToTable("MentorCategories");
                });

            modelBuilder.Entity("MentorShipProgram.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<int?>("AppointmentsId")
                        .HasColumnType("integer");

                    b.Property<string>("Bio")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<int>("MentorId")
                        .HasColumnType("integer");

                    b.Property<string>("UID")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.HasIndex("AppointmentsId");

                    b.HasIndex("MentorId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore.",
                            FirstName = "Pam",
                            LastName = "Carson",
                            MentorId = 1
                        },
                        new
                        {
                            UserId = 2,
                            Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore.",
                            FirstName = "Austin",
                            LastName = "Barter",
                            MentorId = 2
                        });
                });

            modelBuilder.Entity("MentorShipProgram.Models.Category", b =>
                {
                    b.HasOne("MentorShipProgram.Models.Appointments", null)
                        .WithMany("Categories")
                        .HasForeignKey("AppointmentsId");

                    b.HasOne("MentorShipProgram.Models.Mentor", null)
                        .WithMany("Categories")
                        .HasForeignKey("MentorId");
                });

            modelBuilder.Entity("MentorShipProgram.Models.Mentor", b =>
                {
                    b.HasOne("MentorShipProgram.Models.Appointments", null)
                        .WithMany("Mentors")
                        .HasForeignKey("AppointmentsId");
                });

            modelBuilder.Entity("MentorShipProgram.Models.MentorCategories", b =>
                {
                    b.HasOne("MentorShipProgram.Models.Appointments", null)
                        .WithMany("MentorCategories")
                        .HasForeignKey("AppointmentsId");

                    b.HasOne("MentorShipProgram.Models.Category", "Categories")
                        .WithMany("MentorCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MentorShipProgram.Models.Mentor", "Mentor")
                        .WithMany("MentorCategories")
                        .HasForeignKey("MentorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");

                    b.Navigation("Mentor");
                });

            modelBuilder.Entity("MentorShipProgram.Models.User", b =>
                {
                    b.HasOne("MentorShipProgram.Models.Appointments", null)
                        .WithMany("Users")
                        .HasForeignKey("AppointmentsId");

                    b.HasOne("MentorShipProgram.Models.Mentor", "Mentor")
                        .WithMany("Users")
                        .HasForeignKey("MentorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mentor");
                });

            modelBuilder.Entity("MentorShipProgram.Models.Appointments", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("MentorCategories");

                    b.Navigation("Mentors");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("MentorShipProgram.Models.Category", b =>
                {
                    b.Navigation("MentorCategories");
                });

            modelBuilder.Entity("MentorShipProgram.Models.Mentor", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("MentorCategories");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
