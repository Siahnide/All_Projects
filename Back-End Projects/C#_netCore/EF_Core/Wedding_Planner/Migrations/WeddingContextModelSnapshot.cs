﻿// <auto-generated />
using ;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Wedding_Planner.Migrations
{
    [DbContext(typeof(WeddingContext))]
    partial class WeddingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Wedding_Planner.Models.Guest", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("user_id");

                    b.Property<int>("wedding_id");

                    b.HasKey("id");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("Wedding_Planner.Models.RegUser", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Weddingid");

                    b.Property<string>("confirm")
                        .IsRequired();

                    b.Property<string>("email")
                        .IsRequired();

                    b.Property<string>("first_name")
                        .IsRequired();

                    b.Property<string>("last_name")
                        .IsRequired();

                    b.Property<string>("password")
                        .IsRequired();

                    b.HasKey("id");

                    b.HasIndex("Weddingid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Wedding_Planner.Models.Wedding", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("address");

                    b.Property<DateTime>("date");

                    b.Property<int?>("plannerid");

                    b.Property<string>("wedder_1");

                    b.Property<string>("wedder_2");

                    b.HasKey("id");

                    b.HasIndex("plannerid");

                    b.ToTable("Weddings");
                });

            modelBuilder.Entity("Wedding_Planner.Models.RegUser", b =>
                {
                    b.HasOne("Wedding_Planner.Models.Wedding")
                        .WithMany("guests")
                        .HasForeignKey("Weddingid");
                });

            modelBuilder.Entity("Wedding_Planner.Models.Wedding", b =>
                {
                    b.HasOne("Wedding_Planner.Models.RegUser", "planner")
                        .WithMany()
                        .HasForeignKey("plannerid");
                });
#pragma warning restore 612, 618
        }
    }
}
