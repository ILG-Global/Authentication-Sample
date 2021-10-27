﻿// <auto-generated />
using System;
using AuthenticationSample.BackEnd.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AuthenticationSample.BackEnd.Web.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211027024153_ownermaster-ownerlogin")]
    partial class ownermasterownerlogin
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuthenticationSample.BackEnd.Web.Entities.LoginType", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Code");

                    b.ToTable("LoginType");
                });

            modelBuilder.Entity("AuthenticationSample.BackEnd.Web.Entities.OwnerLogin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailOrMobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<string>("LoginTypeCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OwnerMasterID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("LoginTypeCode");

                    b.HasIndex("OwnerMasterID");

                    b.ToTable("OwnerLogin");
                });

            modelBuilder.Entity("AuthenticationSample.BackEnd.Web.Entities.OwnerMaster", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("OwnerMaster");
                });

            modelBuilder.Entity("AuthenticationSample.BackEnd.Web.Entities.OwnerLogin", b =>
                {
                    b.HasOne("AuthenticationSample.BackEnd.Web.Entities.LoginType", "LoginType")
                        .WithMany()
                        .HasForeignKey("LoginTypeCode");

                    b.HasOne("AuthenticationSample.BackEnd.Web.Entities.OwnerMaster", "OwnerMaster")
                        .WithMany("OwnerLogins")
                        .HasForeignKey("OwnerMasterID");

                    b.Navigation("LoginType");

                    b.Navigation("OwnerMaster");
                });

            modelBuilder.Entity("AuthenticationSample.BackEnd.Web.Entities.OwnerMaster", b =>
                {
                    b.Navigation("OwnerLogins");
                });
#pragma warning restore 612, 618
        }
    }
}
