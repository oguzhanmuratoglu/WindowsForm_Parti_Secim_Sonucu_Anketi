﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parti_Secim_Anketi.DataAccess;

#nullable disable

namespace Parti_Secim_Anketi.Migrations
{
    [DbContext(typeof(DistrictContext))]
    partial class DistrictContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Parti_Secim_Anketi.Entities.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal?>("AParti")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("BParti")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("CParti")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("DParti")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("EParti")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Ilce")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Districts");
                });
#pragma warning restore 612, 618
        }
    }
}