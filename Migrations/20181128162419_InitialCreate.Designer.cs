﻿// <auto-generated />
using EntityFrameworkMvc.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BloggingEngine.Migrations
{
    [DbContext(typeof(BloggingContext))]
    [Migration("20181128162419_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("EntityFrameworkMvc.DataAccess.Comment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("postId");

                    b.Property<string>("text");

                    b.HasKey("id");

                    b.HasIndex("postId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("EntityFrameworkMvc.DataAccess.Post", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("author");

                    b.Property<string>("content");

                    b.Property<string>("date");

                    b.Property<string>("title");

                    b.HasKey("id");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("EntityFrameworkMvc.DataAccess.Comment", b =>
                {
                    b.HasOne("EntityFrameworkMvc.DataAccess.Post")
                        .WithMany("Comments")
                        .HasForeignKey("postId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}