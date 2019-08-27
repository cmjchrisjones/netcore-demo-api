﻿// <auto-generated />
using System;
using DemoAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoAPI.Migrations
{
    [DbContext(typeof(DemoApiDbContext))]
    partial class DemoApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("DemoAPI.Models.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("HireDate");

                    b.Property<string>("Name");

                    b.Property<DateTime>("RequestDate");

                    b.Property<Guid?>("RequestId");

                    b.HasKey("Id");

                    b.HasIndex("RequestId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("DemoAPI.Models.Request", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("RequestDate");

                    b.Property<string>("RequesterName");

                    b.HasKey("Id");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("DemoAPI.Models.Item", b =>
                {
                    b.HasOne("DemoAPI.Models.Request", "Request")
                        .WithMany("Items")
                        .HasForeignKey("RequestId");
                });
#pragma warning restore 612, 618
        }
    }
}
