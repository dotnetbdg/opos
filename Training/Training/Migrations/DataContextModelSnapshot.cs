﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Training.Data;

namespace Training.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Training.Model.Barang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HargaBarang");

                    b.Property<int>("IdKategori");

                    b.Property<string>("NamaBarang");

                    b.Property<int>("StokBarang");

                    b.HasKey("Id");

                    b.HasIndex("IdKategori");

                    b.ToTable("Barang");
                });

            modelBuilder.Entity("Training.Model.KategoriBarang", b =>
                {
                    b.Property<int>("IdKategori")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NamaKategori");

                    b.HasKey("IdKategori");

                    b.ToTable("KategoriBarang");
                });

            modelBuilder.Entity("Training.Model.Barang", b =>
                {
                    b.HasOne("Training.Model.KategoriBarang", "KategoriBarang")
                        .WithMany()
                        .HasForeignKey("IdKategori")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
