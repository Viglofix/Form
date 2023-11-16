﻿// <auto-generated />
using System;
using DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataBase.Migrations
{
    [DbContext(typeof(FormDbContext))]
    [Migration("20231106171403_SpecializationRelationShipMigration")]
    partial class SpecializationRelationShipMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DataBase.Model.ClickUpRequiredDataModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<long>("Id"));
                    NpgsqlPropertyBuilderExtensions.HasIdentityOptions(b.Property<long>("Id"), 1L, null, null, null, null, null);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("DATE")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("email");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("full_name");

                    b.Property<string>("PhoneNumeber")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("phone_number");

                    b.Property<long?>("Specialization_Id")
                        .HasColumnType("BIGINT")
                        .HasColumnName("specialization_id");

                    b.HasKey("Id");

                    b.HasIndex("Specialization_Id")
                        .IsUnique();

                    b.ToTable("clickUp_required_data");
                });

            modelBuilder.Entity("DataBase.Model.SpecizalizationModel", b =>
                {
                    b.Property<long>("Id_Specialization")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id_Specialization"));
                    NpgsqlPropertyBuilderExtensions.HasIdentityOptions(b.Property<long>("Id_Specialization"), 1L, null, null, null, null, null);

                    b.Property<string>("Specialization_Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("specialization_name");

                    b.HasKey("Id_Specialization");

                    b.ToTable("specizalizations");
                });

            modelBuilder.Entity("DataBase.Model.ClickUpRequiredDataModel", b =>
                {
                    b.HasOne("DataBase.Model.SpecizalizationModel", "Specialization")
                        .WithOne("clickUpRequiredDataModel")
                        .HasForeignKey("DataBase.Model.ClickUpRequiredDataModel", "Specialization_Id");

                    b.Navigation("Specialization");
                });

            modelBuilder.Entity("DataBase.Model.SpecizalizationModel", b =>
                {
                    b.Navigation("clickUpRequiredDataModel");
                });
#pragma warning restore 612, 618
        }
    }
}