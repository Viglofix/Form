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
    [Migration("20231107181032_PracticeRelationShipUpdte")]
    partial class PracticeRelationShipUpdte
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
                        .HasMaxLength(64)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("full_name");

                    b.Property<string>("GithubAccount")
                        .HasColumnType("TEXT")
                        .HasColumnName("github_account");

                    b.Property<string>("PhoneNumeber")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("phone_number");

                    b.Property<long?>("Specialization_Id")
                        .HasColumnType("BIGINT")
                        .HasColumnName("specialization_id");

                    b.Property<long?>("Status_Id")
                        .HasColumnType("BIGINT")
                        .HasColumnName("status_id");

                    b.HasKey("Id");

                    b.HasIndex("Specialization_Id");

                    b.HasIndex("Status_Id");

                    b.ToTable("clickup_required_data");
                });

            modelBuilder.Entity("DataBase.Model.SpecializationModel", b =>
                {
                    b.Property<long>("Id_Specialization")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT")
                        .HasColumnName("id_specialization");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id_Specialization"));
                    NpgsqlPropertyBuilderExtensions.HasIdentityOptions(b.Property<long>("Id_Specialization"), 1L, null, null, null, null, null);

                    b.Property<string>("Specialization_Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("specialization_name");

                    b.HasKey("Id_Specialization");

                    b.ToTable("specializations");
                });

            modelBuilder.Entity("DataBase.Model.StatusOfRecruiterModel", b =>
                {
                    b.Property<long>("Id_StatusOfRecruiter")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT")
                        .HasColumnName("id_status_of_recruiter");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<long>("Id_StatusOfRecruiter"));
                    NpgsqlPropertyBuilderExtensions.HasIdentityOptions(b.Property<long>("Id_StatusOfRecruiter"), 1L, null, null, null, null, null);

                    b.Property<DateTime?>("EndDateOfPractice")
                        .IsRequired()
                        .HasColumnType("DATE")
                        .HasColumnName("end_date_of_practice");

                    b.Property<string>("NameOfTheUniversity")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("name_of_the_university");

                    b.Property<DateTime?>("StartDateOfPractice")
                        .IsRequired()
                        .HasColumnType("DATE")
                        .HasColumnName("start_date_of_practice");

                    b.Property<long?>("TypeOfPracticeModel_Id")
                        .HasColumnType("BIGINT")
                        .HasColumnName("type_of_practice_id");

                    b.HasKey("Id_StatusOfRecruiter");

                    b.HasIndex("TypeOfPracticeModel_Id");

                    b.ToTable("status_of_recruiter");
                });

            modelBuilder.Entity("DataBase.Model.TypeOfPracticeModel", b =>
                {
                    b.Property<long>("Id_TypeOfPractice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT")
                        .HasColumnName("id_type_of_practice");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<long>("Id_TypeOfPractice"));
                    NpgsqlPropertyBuilderExtensions.HasIdentityOptions(b.Property<long>("Id_TypeOfPractice"), 1L, null, null, null, null, null);

                    b.Property<string>("TypeOfPracticeName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("id_type_of_practice_name");

                    b.HasKey("Id_TypeOfPractice");

                    b.ToTable("TypeOfPracticeModel");
                });

            modelBuilder.Entity("DataBase.Model.ClickUpRequiredDataModel", b =>
                {
                    b.HasOne("DataBase.Model.SpecializationModel", "Specialization")
                        .WithMany("clickUpRequiredDataModel")
                        .HasForeignKey("Specialization_Id");

                    b.HasOne("DataBase.Model.StatusOfRecruiterModel", "Status")
                        .WithMany("clickUpRequiredDataModel")
                        .HasForeignKey("Status_Id");

                    b.Navigation("Specialization");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("DataBase.Model.StatusOfRecruiterModel", b =>
                {
                    b.HasOne("DataBase.Model.TypeOfPracticeModel", "TypeOfPracticeModel")
                        .WithMany("StatusOfRecruiterModels")
                        .HasForeignKey("TypeOfPracticeModel_Id");

                    b.Navigation("TypeOfPracticeModel");
                });

            modelBuilder.Entity("DataBase.Model.SpecializationModel", b =>
                {
                    b.Navigation("clickUpRequiredDataModel");
                });

            modelBuilder.Entity("DataBase.Model.StatusOfRecruiterModel", b =>
                {
                    b.Navigation("clickUpRequiredDataModel");
                });

            modelBuilder.Entity("DataBase.Model.TypeOfPracticeModel", b =>
                {
                    b.Navigation("StatusOfRecruiterModels");
                });
#pragma warning restore 612, 618
        }
    }
}
