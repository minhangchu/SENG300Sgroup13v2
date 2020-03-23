﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SENG300Scholarships.Data;

namespace SENG300Scholarships.Migrations
{
    [DbContext(typeof(ScholarshipsContext))]
    partial class ScholarshipsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("SENG300Scholarships.Models.Scholarship", b =>
                {
                    b.Property<int>("ScholarshipID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("GPA")
                        .HasColumnType("REAL");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("UploadPath")
                        .HasColumnType("TEXT");

                    b.Property<int>("amount")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("deadline")
                        .HasColumnType("TEXT");

                    b.Property<string>("duration")
                        .HasColumnType("TEXT");

                    b.Property<string>("major")
                        .HasColumnType("TEXT");

                    b.Property<string>("org")
                        .HasColumnType("TEXT");

                    b.Property<string>("scope")
                        .HasColumnType("TEXT");

                    b.Property<int>("value")
                        .HasColumnType("INTEGER");

                    b.HasKey("ScholarshipID");

                    b.ToTable("Scholarship");
                });

            modelBuilder.Entity("SENG300Scholarships.Models.Submission", b =>
                {
                    b.Property<int>("SubmissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ScholarshipID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Student")
                        .HasColumnType("TEXT");

                    b.HasKey("SubmissionId");

                    b.HasIndex("ScholarshipID");

                    b.ToTable("Submission");
                });

            modelBuilder.Entity("SENG300Scholarships.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("SENG300Scholarships.Models.Submission", b =>
                {
                    b.HasOne("SENG300Scholarships.Models.Scholarship", null)
                        .WithMany("Submissions")
                        .HasForeignKey("ScholarshipID");
                });
#pragma warning restore 612, 618
        }
    }
}
