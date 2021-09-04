﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Property<int>("AppUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AcademicPlus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("AppUserType")
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Arts")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Athletics")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BestEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BestPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassYear")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("DreamJob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EmpNum")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ExtraCurricular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("GPA")
                        .HasColumnType("nvarchar(5)");

                    b.Property<DateTime>("GradDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkPlus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AppUserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("API.Entities.College", b =>
                {
                    b.Property<int>("CollegeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<string>("CollegeLocation")
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("CollegeName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CollegeNickname")
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CollegeId");

                    b.HasIndex("AppUserId");

                    b.ToTable("College");
                });

            modelBuilder.Entity("API.Entities.EmpType", b =>
                {
                    b.Property<int>("EmpTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<string>("EmpTypeName")
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("EmpTypeId");

                    b.HasIndex("AppUserId");

                    b.ToTable("EmpType");
                });

            modelBuilder.Entity("API.Entities.HomeCity", b =>
                {
                    b.Property<int>("HomeCityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<string>("HomeCityName")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("HomeCityId");

                    b.HasIndex("AppUserId");

                    b.ToTable("HomeCity");
                });

            modelBuilder.Entity("API.Entities.Major", b =>
                {
                    b.Property<int>("MajorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<string>("MajorName")
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("MajorId");

                    b.HasIndex("AppUserId");

                    b.ToTable("Major");
                });

            modelBuilder.Entity("API.Entities.Photo", b =>
                {
                    b.Property<int>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HrUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMainHr")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMainLogo")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMainStudent")
                        .HasColumnType("bit");

                    b.Property<string>("LogoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublicId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhotoId");

                    b.HasIndex("AppUserId");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("API.Entities.Position", b =>
                {
                    b.Property<int>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ApplyDeadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("ApplyUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HowToApply")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("HrContact")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("HrContactTitle")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("HrEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LookingFor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionLocation")
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("PositionName")
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("PositionType")
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Positioninfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PositionId");

                    b.HasIndex("AppUserId");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("API.Entities.College", b =>
                {
                    b.HasOne("API.Entities.AppUser", "AppUser")
                        .WithMany("Colleges")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("API.Entities.EmpType", b =>
                {
                    b.HasOne("API.Entities.AppUser", "AppUser")
                        .WithMany("EmpTypes")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("API.Entities.HomeCity", b =>
                {
                    b.HasOne("API.Entities.AppUser", "AppUser")
                        .WithMany("HomeCities")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("API.Entities.Major", b =>
                {
                    b.HasOne("API.Entities.AppUser", "AppUser")
                        .WithMany("Majors")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("API.Entities.Photo", b =>
                {
                    b.HasOne("API.Entities.AppUser", "AppUser")
                        .WithMany("Photos")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("API.Entities.Position", b =>
                {
                    b.HasOne("API.Entities.AppUser", "AppUser")
                        .WithMany("Positions")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Navigation("Colleges");

                    b.Navigation("EmpTypes");

                    b.Navigation("HomeCities");

                    b.Navigation("Majors");

                    b.Navigation("Photos");

                    b.Navigation("Positions");
                });
#pragma warning restore 612, 618
        }
    }
}
