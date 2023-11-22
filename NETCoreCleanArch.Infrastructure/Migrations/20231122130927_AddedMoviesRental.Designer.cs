﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NETCoreCleanArch.Infrastructure;

#nullable disable

namespace NETCoreCleanArch.Infrastructure.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20231122130927_AddedMoviesRental")]
    partial class AddedMoviesRental
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NETCoreCleanArch.Domain.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MemberId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RentalId")
                        .HasColumnType("int");

                    b.HasKey("MemberId");

                    b.HasIndex("RentalId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("NETCoreCleanArch.Domain.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"));

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("RentalCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RentalDuration")
                        .HasColumnType("int");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("NETCoreCleanArch.Domain.MovieRental", b =>
                {
                    b.Property<int>("RentalId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("RentalId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieRentals");
                });

            modelBuilder.Entity("NETCoreCleanArch.Domain.Rental", b =>
                {
                    b.Property<int>("RentalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RentalId"));

                    b.Property<DateTime>("RentalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RentalExpire")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("RentalId");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("NETCoreCleanArch.Domain.Member", b =>
                {
                    b.HasOne("NETCoreCleanArch.Domain.Rental", "Rental")
                        .WithMany("Members")
                        .HasForeignKey("RentalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rental");
                });

            modelBuilder.Entity("NETCoreCleanArch.Domain.MovieRental", b =>
                {
                    b.HasOne("NETCoreCleanArch.Domain.Movie", null)
                        .WithMany("MovieRentals")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NETCoreCleanArch.Domain.Movie", b =>
                {
                    b.Navigation("MovieRentals");
                });

            modelBuilder.Entity("NETCoreCleanArch.Domain.Rental", b =>
                {
                    b.Navigation("Members");
                });
#pragma warning restore 612, 618
        }
    }
}
