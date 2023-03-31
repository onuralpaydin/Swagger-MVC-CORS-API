﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoListApi.Models;

#nullable disable

namespace ToDoListApi.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20230330233133_todo")]
    partial class todo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ToDoListApi.Models.ToDoList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDone")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("tbl_TodoList");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Api Çalış",
                            isDone = false
                        },
                        new
                        {
                            Id = 2,
                            Name = "EF Çalış",
                            isDone = true
                        },
                        new
                        {
                            Id = 3,
                            Name = "MVC Çalış",
                            isDone = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}