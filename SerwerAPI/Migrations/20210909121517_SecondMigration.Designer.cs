﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SerwerAPI.Models;

namespace SerwerAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210909121517_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("SerwerAPI.Models.ZoneLocationModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("latitude")
                        .HasColumnType("REAL");

                    b.Property<double>("longitude")
                        .HasColumnType("REAL");

                    b.Property<int>("shapeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("ZoneLocation");
                });

            modelBuilder.Entity("SerwerAPI.UsersLocationModel", b =>
                {
                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<double>("latitude")
                        .HasColumnType("REAL");

                    b.Property<double>("longtitude")
                        .HasColumnType("REAL");

                    b.HasKey("name");

                    b.ToTable("UsersLocation");
                });
#pragma warning restore 612, 618
        }
    }
}