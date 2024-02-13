﻿// <auto-generated />
using System;
using Hotel_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hotel_System.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20240212212528_PaymentFixMig")]
    partial class PaymentFixMig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence("PersonSequence");

            modelBuilder.Entity("Hotel_System.Models.CommonTable", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Key");

                    b.ToTable("CommonTable");
                });

            modelBuilder.Entity("Hotel_System.Models.FeedBack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("FoodQuality")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("FeedBacks", t =>
                        {
                            t.HasCheckConstraint("FoodRange", "[FoodQuality] > 0 and [FoodQuality] < 11");

                            t.HasCheckConstraint("RateRange", "[Rate] > 0 and [Rate] < 6");
                        });
                });

            modelBuilder.Entity("Hotel_System.Models.MemberShip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte>("Advantages")
                        .HasColumnType("tinyint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("Id");

                    b.HasIndex("Advantages")
                        .IsUnique();

                    b.ToTable("Memberships");

                    b.HasDiscriminator<string>("Name").HasValue("MemberShip");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Hotel_System.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<float>("TargetAmount")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ClientId", "Date")
                        .IsUnique();

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Hotel_System.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR [PersonSequence]");

                    SqlServerPropertyBuilderExtensions.UseSequence(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("NId")
                        .IsRequired()
                        .HasMaxLength(14)
                        .IsUnicode(false)
                        .HasColumnType("varchar(14)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasDefaultValue("m@S*n!S#");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("NId")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable((string)null);

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("Hotel_System.Models.Reservation", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.HasKey("ClientId", "RoomId", "ReservationDate");

                    b.HasIndex("PaymentId");

                    b.HasIndex("RoomId");

                    b.ToTable("Reservations", t =>
                        {
                            t.HasCheckConstraint("CheckInValidation", "[CheckInDate] > GetDate()");

                            t.HasCheckConstraint("CheckOutValidation", "[CheckOutDate] > [CheckInDate]");
                        });
                });

            modelBuilder.Entity("Hotel_System.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<byte>("Type")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("Rooms", t =>
                        {
                            t.HasCheckConstraint("RateRange", "[Rate] > 0 and [Rate] < 6")
                                .HasName("RateRange1");

                            t.HasCheckConstraint("TypeRange", "[Type] > 0 and [Type] < 3");
                        });
                });

            modelBuilder.Entity("Hotel_System.Models.Client", b =>
                {
                    b.HasBaseType("Hotel_System.Models.Person");

                    b.Property<int?>("MemberShipId")
                        .HasColumnType("int");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.HasIndex("MemberShipId");

                    b.ToTable("Clients", t =>
                        {
                            t.HasCheckConstraint("EmailValidation", "[Email] like '%[a-zA-z0-9.]@__%.__%' and [Email] not like '%[-+/*]%'");

                            t.HasCheckConstraint("NidValidation", "len([NId]) = 14");
                        });
                });

            modelBuilder.Entity("Hotel_System.Models.Employee", b =>
                {
                    b.HasBaseType("Hotel_System.Models.Person");

                    b.Property<int>("Attend")
                        .HasColumnType("int");

                    b.Property<float>("Salary")
                        .HasColumnType("real");

                    b.ToTable("Employees", t =>
                        {
                            t.HasCheckConstraint("EmailValidation", "[Email] like '%[a-zA-z0-9.]@__%.__%' and [Email] not like '%[-+/*]%'")
                                .HasName("EmailValidation1");

                            t.HasCheckConstraint("NidValidation", "len([NId]) = 14")
                                .HasName("NidValidation1");
                        });
                });

            modelBuilder.Entity("Hotel_System.Models.FeedBack", b =>
                {
                    b.HasOne("Hotel_System.Models.Client", "Client")
                        .WithMany("FeedBacks")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Hotel_System.Models.Payment", b =>
                {
                    b.HasOne("Hotel_System.Models.Client", "Client")
                        .WithMany("Payments")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Hotel_System.Models.Reservation", b =>
                {
                    b.HasOne("Hotel_System.Models.Client", "Client")
                        .WithMany("Reservation")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel_System.Models.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel_System.Models.Room", "Room")
                        .WithMany("Reservations")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Payment");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Hotel_System.Models.Client", b =>
                {
                    b.HasOne("Hotel_System.Models.MemberShip", "MemberShip")
                        .WithMany()
                        .HasForeignKey("MemberShipId");

                    b.Navigation("MemberShip");
                });

            modelBuilder.Entity("Hotel_System.Models.Room", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Hotel_System.Models.Client", b =>
                {
                    b.Navigation("FeedBacks");

                    b.Navigation("Payments");

                    b.Navigation("Reservation");
                });
#pragma warning restore 612, 618
        }
    }
}