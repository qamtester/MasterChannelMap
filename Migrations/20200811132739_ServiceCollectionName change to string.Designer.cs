﻿// <auto-generated />
using MasterChannelMap.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MasterChannelMap.Migrations
{
    [DbContext(typeof(MasterChannelMapContext))]
    [Migration("20200811132739_ServiceCollectionName change to string")]
    partial class ServiceCollectionNamechangetostring
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MasterChannelMap.Model.CallSign", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CallLetters")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ChannelListingID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("CallSign");
                });

            modelBuilder.Entity("MasterChannelMap.Model.ChannelListing", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CallSignID")
                        .HasColumnType("int");

                    b.Property<string>("ChannelMapName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServiceCollectionID")
                        .HasColumnType("int");

                    b.Property<int>("TunerPosition")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("ChannelListing");
                });

            modelBuilder.Entity("MasterChannelMap.Model.ServiceCollection", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ServiceCollectionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ServiceCollection");
                });
#pragma warning restore 612, 618
        }
    }
}
