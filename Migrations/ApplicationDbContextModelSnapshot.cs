﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMovie.Data;

#nullable disable

namespace hoten_1234_2425_BAITHITEST_.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("hoten_1234_2425_baithitest.sinhvien", b =>
                {
                    b.Property<string>("mssv")
                        .HasColumnType("TEXT");

                    b.Property<string>("hoten")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("mssv");

                    b.ToTable("sinhvien");
                });
#pragma warning restore 612, 618
        }
    }
}