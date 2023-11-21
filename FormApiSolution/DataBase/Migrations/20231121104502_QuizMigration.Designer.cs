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
    [Migration("20231121104502_QuizMigration")]
    partial class QuizMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DataBase.Model.AdminPanel", b =>
                {
                    b.Property<long>("Id_Admin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT")
                        .HasColumnName("id_admin");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id_Admin"));
                    NpgsqlPropertyBuilderExtensions.HasIdentityOptions(b.Property<long>("Id_Admin"), 1L, null, null, null, null, null);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("login");

                    b.Property<string>("Note")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue("Note about this account")
                        .HasColumnName("note");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("password");

                    b.HasKey("Id_Admin");

                    b.ToTable("admin_panel");
                });

            modelBuilder.Entity("DataBase.Model.ClickUpRequiredDataModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));
                    NpgsqlPropertyBuilderExtensions.HasIdentityOptions(b.Property<long>("Id"), 1L, null, null, null, null, null);

                    b.Property<string>("AdditionalInformation")
                        .HasColumnType("TEXT")
                        .HasColumnName("additional_information");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("DATE")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("email");

                    b.Property<string>("English_Level")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("english_level");

                    b.Property<string>("Experience")
                        .HasColumnType("TEXT")
                        .HasColumnName("experience");

                    b.Property<string>("FinishedProject")
                        .HasColumnType("TEXT")
                        .HasColumnName("finished_project");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("full_name");

                    b.Property<string>("GithubAccount")
                        .HasColumnType("TEXT")
                        .HasColumnName("github_account");

                    b.Property<string>("GoalOfAcademyParticipation")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("goal_of_academy_participation");

                    b.Property<string>("GraphicInspitation")
                        .HasColumnType("TEXT")
                        .HasColumnName("graphic_inspiration");

                    b.Property<string>("LearningGoals")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("learning_goals");

                    b.Property<string>("NameOfUniversityOrOccupation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("phone_number");

                    b.Property<DateTime?>("PracticesEnd")
                        .IsRequired()
                        .HasColumnType("DATE")
                        .HasColumnName("practices_end");

                    b.Property<DateTime?>("PracticesStart")
                        .IsRequired()
                        .HasColumnType("DATE")
                        .HasColumnName("practices_start");

                    b.Property<string>("ProficientGraphicTools")
                        .HasColumnType("TEXT")
                        .HasColumnName("proficient_graphic_tools");

                    b.Property<string>("ProgrammingLangugages")
                        .HasMaxLength(256)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("programming_languages");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("clickup_required_data");
                });

            modelBuilder.Entity("DataBase.Model.DropFilesModel", b =>
                {
                    b.Property<long>("Id_File")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT")
                        .HasColumnName("id_file");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id_File"));
                    NpgsqlPropertyBuilderExtensions.HasIdentityOptions(b.Property<long>("Id_File"), 1L, null, null, null, null, null);

                    b.Property<long?>("ClickUp_Id")
                        .HasColumnType("BIGINT")
                        .HasColumnName("click_up_id");

                    b.Property<byte[]>("FileData")
                        .IsRequired()
                        .HasColumnType("BYTEA")
                        .HasColumnName("file_data");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("file_name");

                    b.Property<string>("FileSize")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("file_size");

                    b.HasKey("Id_File");

                    b.HasIndex("ClickUp_Id")
                        .IsUnique();

                    b.ToTable("drop_files");
                });

            modelBuilder.Entity("DataBase.Model.School", b =>
                {
                    b.Property<long>("Id_School")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT")
                        .HasColumnName("id_school");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<long>("Id_School"));
                    NpgsqlPropertyBuilderExtensions.HasIdentityOptions(b.Property<long>("Id_School"), 1L, null, null, null, null, null);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("name");

                    b.HasKey("Id_School");

                    b.ToTable("schools");
                });

            modelBuilder.Entity("DataBase.Model.Test", b =>
                {
                    b.Property<long>("Id_Test")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT")
                        .HasColumnName("id_test");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id_Test"));
                    NpgsqlPropertyBuilderExtensions.HasIdentityOptions(b.Property<long>("Id_Test"), 1L, null, null, null, null, null);

                    b.Property<string>("CorrectAnswer")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("correct_answer");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("question");

                    b.HasKey("Id_Test");

                    b.ToTable("tests");
                });

            modelBuilder.Entity("DataBase.Model.TestAnswer", b =>
                {
                    b.Property<long>("Id_TestAnswer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT")
                        .HasColumnName("id_test_answer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id_TestAnswer"));
                    NpgsqlPropertyBuilderExtensions.HasIdentityOptions(b.Property<long>("Id_TestAnswer"), 1L, null, null, null, null, null);

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("answer");

                    b.Property<long>("Test_Id")
                        .HasColumnType("BIGINT")
                        .HasColumnName("test_id");

                    b.HasKey("Id_TestAnswer");

                    b.HasIndex("Test_Id");

                    b.ToTable("test_answers");
                });

            modelBuilder.Entity("DataBase.Model.DropFilesModel", b =>
                {
                    b.HasOne("DataBase.Model.ClickUpRequiredDataModel", "clickUpRequiredDataModel")
                        .WithOne("DropFilesModel")
                        .HasForeignKey("DataBase.Model.DropFilesModel", "ClickUp_Id");

                    b.Navigation("clickUpRequiredDataModel");
                });

            modelBuilder.Entity("DataBase.Model.TestAnswer", b =>
                {
                    b.HasOne("DataBase.Model.Test", "Test")
                        .WithMany("Answers")
                        .HasForeignKey("Test_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Test");
                });

            modelBuilder.Entity("DataBase.Model.ClickUpRequiredDataModel", b =>
                {
                    b.Navigation("DropFilesModel");
                });

            modelBuilder.Entity("DataBase.Model.Test", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}