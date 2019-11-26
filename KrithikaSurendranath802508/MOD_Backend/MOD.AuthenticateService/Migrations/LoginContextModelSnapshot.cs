﻿// <auto-generated />
using System;
using MOD.AuthenticateService.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MOD.AuthenticateService.Migrations
{
    [DbContext(typeof(LoginContext))]
    partial class LoginContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MOD.AuthenticateService.Models.Mentor", b =>
                {
                    b.Property<int>("Mid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Mactive")
                        .HasColumnType("bit");

                    b.Property<bool>("Mavailability")
                        .HasColumnType("bit");

                    b.Property<int>("Mexperience")
                        .HasColumnType("int");

                    b.Property<string>("Mmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mnumber")
                        .HasColumnType("int");

                    b.Property<string>("Mpassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mskills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mtimeslot")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Mid");

                    b.ToTable("Mentor");
                });

            modelBuilder.Entity("MOD.AuthenticateService.Models.Payment", b =>
                {
                    b.Property<int>("Pid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Mentor_Amount")
                        .HasColumnType("int");

                    b.Property<int>("Mid")
                        .HasColumnType("int");

                    b.Property<int?>("TrainingTid")
                        .HasColumnType("int");

                    b.Property<int>("Uid")
                        .HasColumnType("int");

                    b.Property<int>("amount")
                        .HasColumnType("int");

                    b.HasKey("Pid");

                    b.HasIndex("Mid");

                    b.HasIndex("TrainingTid");

                    b.HasIndex("Uid");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("MOD.AuthenticateService.Models.Skills", b =>
                {
                    b.Property<int>("Sid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("STOC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sduration")
                        .HasColumnType("int");

                    b.Property<double>("Sfee")
                        .HasColumnType("float");

                    b.Property<string>("Sname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Sid");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("MOD.AuthenticateService.Models.Training", b =>
                {
                    b.Property<int>("Tid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Mid")
                        .HasColumnType("int");

                    b.Property<string>("Progress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sid")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Uid")
                        .HasColumnType("int");

                    b.Property<string>("rating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("timeslot")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Tid");

                    b.HasIndex("Mid");

                    b.HasIndex("Sid");

                    b.HasIndex("Uid");

                    b.ToTable("Training");
                });

            modelBuilder.Entity("MOD.AuthenticateService.Models.User", b =>
                {
                    b.Property<int>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Uactive")
                        .HasColumnType("bit");

                    b.Property<string>("Umail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Unumber")
                        .HasColumnType("int");

                    b.Property<string>("Upassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Uid");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MOD.AuthenticateService.Models.Payment", b =>
                {
                    b.HasOne("MOD.AuthenticateService.Models.Mentor", "Mentor")
                        .WithMany()
                        .HasForeignKey("Mid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MOD.AuthenticateService.Models.Training", null)
                        .WithMany("Payments")
                        .HasForeignKey("TrainingTid");

                    b.HasOne("MOD.AuthenticateService.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("Uid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MOD.AuthenticateService.Models.Training", b =>
                {
                    b.HasOne("MOD.AuthenticateService.Models.Mentor", "Mentor")
                        .WithMany()
                        .HasForeignKey("Mid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MOD.AuthenticateService.Models.Skills", "Skills")
                        .WithMany()
                        .HasForeignKey("Sid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MOD.AuthenticateService.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("Uid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
