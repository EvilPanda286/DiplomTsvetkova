// <auto-generated />
using System;
using DiplomTsvetkova;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DiplomTsvetkova.Migrations
{
    [DbContext(typeof(DiplomTsvetkovaContext))]
    [Migration("20220606194216_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DiplomTsvetkova.Models.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<double>("Longitude")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NumberPhone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("DiplomTsvetkova.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductStorageId")
                        .HasColumnType("uuid");

                    b.Property<int>("Quatity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("ProductStorageId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DiplomTsvetkova.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e81"),
                            Image = "1.jpg",
                            Name = "BANAN1",
                            Price = 1m
                        },
                        new
                        {
                            Id = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e82"),
                            Image = "1.jpg",
                            Name = "BANAN2",
                            Price = 12m
                        },
                        new
                        {
                            Id = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e83"),
                            Image = "1.jpg",
                            Name = "BANAN3",
                            Price = 123m
                        },
                        new
                        {
                            Id = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e84"),
                            Image = "1.jpg",
                            Name = "BANAN4",
                            Price = 1234m
                        },
                        new
                        {
                            Id = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e85"),
                            Image = "1.jpg",
                            Name = "BANAN5",
                            Price = 12345m
                        });
                });

            modelBuilder.Entity("DiplomTsvetkova.Models.ProductStorage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<Guid>("StorageId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("StorageId");

                    b.ToTable("ProductStorages", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("698857d4-21e3-42f0-a744-a772d415b2e8"),
                            ProductId = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e81"),
                            Quantity = 100,
                            StorageId = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e11")
                        },
                        new
                        {
                            Id = new Guid("e1e10b2a-a35d-4339-bd0d-673336e7a4a1"),
                            ProductId = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e82"),
                            Quantity = 100,
                            StorageId = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e13")
                        },
                        new
                        {
                            Id = new Guid("5684de6b-e6b3-48ad-92fc-cd797fb43a08"),
                            ProductId = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e82"),
                            Quantity = 100,
                            StorageId = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e12")
                        },
                        new
                        {
                            Id = new Guid("0dc8f6f5-6ad7-4e9a-abe8-fa91a816da3d"),
                            ProductId = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e83"),
                            Quantity = 100,
                            StorageId = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e12")
                        },
                        new
                        {
                            Id = new Guid("b0f01730-f221-410e-a513-5762ee5061c5"),
                            ProductId = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e84"),
                            Quantity = 100,
                            StorageId = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e13")
                        },
                        new
                        {
                            Id = new Guid("473aa405-5dd8-44cb-9176-23d3790f5f76"),
                            ProductId = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e81"),
                            Quantity = 100,
                            StorageId = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e13")
                        },
                        new
                        {
                            Id = new Guid("8dfd89bb-307f-40b7-80a2-ac38dcb11894"),
                            ProductId = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e85"),
                            Quantity = 100,
                            StorageId = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e12")
                        },
                        new
                        {
                            Id = new Guid("dd0eab9e-494f-4fda-8385-ab9adc00e7a0"),
                            ProductId = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e85"),
                            Quantity = 100,
                            StorageId = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e11")
                        },
                        new
                        {
                            Id = new Guid("d0a312f6-ee5f-456c-8b6a-ebd16fadc167"),
                            ProductId = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e81"),
                            Quantity = 100,
                            StorageId = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e12")
                        });
                });

            modelBuilder.Entity("DiplomTsvetkova.Models.Storage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<double>("Longitude")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Storages");

                    b.HasData(
                        new
                        {
                            Id = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e11"),
                            Address = "Ново-Московская ул., 2/8, Смоленск, Смоленская обл., 214000",
                            Latitude = 54.795332076323433,
                            Longitude = 32.055647589620733,
                            Name = "BANANOSKLAD1"
                        },
                        new
                        {
                            Id = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e12"),
                            Address = "ул. 25 Сентября, 35А, Смоленск, Смоленская обл., 214031",
                            Latitude = 54.770775521219925,
                            Longitude = 32.079753946338514,
                            Name = "BANANOSKLAD2"
                        },
                        new
                        {
                            Id = new Guid("774ae5ac-ca59-49f2-8c07-c36dd7826e13"),
                            Address = "ул. Нормандии-Неман, 35, Смоленск, Смоленская обл., 214025",
                            Latitude = 54.780128699072407,
                            Longitude = 32.016695035303151,
                            Name = "BANANOSKLAD3"
                        });
                });

            modelBuilder.Entity("DiplomTsvetkova.Models.Order", b =>
                {
                    b.HasOne("DiplomTsvetkova.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DiplomTsvetkova.Models.ProductStorage", "ProductStorage")
                        .WithMany("Orders")
                        .HasForeignKey("ProductStorageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("ProductStorage");
                });

            modelBuilder.Entity("DiplomTsvetkova.Models.ProductStorage", b =>
                {
                    b.HasOne("DiplomTsvetkova.Models.Product", "Product")
                        .WithMany("ProductStorages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DiplomTsvetkova.Models.Storage", "Storage")
                        .WithMany("ProductStorages")
                        .HasForeignKey("StorageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Storage");
                });

            modelBuilder.Entity("DiplomTsvetkova.Models.Product", b =>
                {
                    b.Navigation("ProductStorages");
                });

            modelBuilder.Entity("DiplomTsvetkova.Models.ProductStorage", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DiplomTsvetkova.Models.Storage", b =>
                {
                    b.Navigation("ProductStorages");
                });
#pragma warning restore 612, 618
        }
    }
}
