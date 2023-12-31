﻿// <auto-generated />
using System;
using LIAMockupMVC2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LIAMockupMVC2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231208134645_MaddeCreate")]
    partial class MaddeCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LIAMockupMVC2.Models.Answer", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnswerId"));

                    b.Property<int?>("AnswerNum")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("AnswerText")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("FK_QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("FK_UserGroupId")
                        .HasColumnType("int");

                    b.HasKey("AnswerId");

                    b.HasIndex("FK_QuestionId");

                    b.HasIndex("FK_UserGroupId");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            AnswerId = 1,
                            AnswerText = "Inte så jättebra, jag är trött",
                            FK_QuestionId = 1,
                            FK_UserGroupId = 1
                        },
                        new
                        {
                            AnswerId = 2,
                            AnswerText = "Svår men rolig",
                            FK_QuestionId = 2,
                            FK_UserGroupId = 3
                        },
                        new
                        {
                            AnswerId = 3,
                            AnswerText = "Hur hanterar man jobbiga kunder bäst?",
                            FK_QuestionId = 3,
                            FK_UserGroupId = 2
                        });
                });

            modelBuilder.Entity("LIAMockupMVC2.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupId"));

                    b.Property<int>("FK_OrgId")
                        .HasColumnType("int");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("GroupId");

                    b.HasIndex("FK_OrgId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            GroupId = 1,
                            FK_OrgId = 1,
                            GroupName = "NET22"
                        },
                        new
                        {
                            GroupId = 2,
                            FK_OrgId = 2,
                            GroupName = "Kassa"
                        },
                        new
                        {
                            GroupId = 3,
                            FK_OrgId = 3,
                            GroupName = "Fiberavdelningen"
                        });
                });

            modelBuilder.Entity("LIAMockupMVC2.Models.Organization", b =>
                {
                    b.Property<int>("OrgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrgId"));

                    b.Property<string>("Field")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("OrgName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("OrgId");

                    b.ToTable("Organizations");

                    b.HasData(
                        new
                        {
                            OrgId = 1,
                            Field = "School",
                            OrgName = "Edugrade"
                        },
                        new
                        {
                            OrgId = 2,
                            Field = "Store",
                            OrgName = "Interflora"
                        },
                        new
                        {
                            OrgId = 3,
                            Field = "Industrial",
                            OrgName = "Hexatronic"
                        });
                });

            modelBuilder.Entity("LIAMockupMVC2.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionId"));

                    b.Property<int?>("QuestionNum")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("QuestionText")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("QuestionId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            QuestionId = 1,
                            QuestionText = "Hur mår du idag?"
                        },
                        new
                        {
                            QuestionId = 2,
                            QuestionText = "Hur kändes lektionen idag?"
                        },
                        new
                        {
                            QuestionId = 3,
                            QuestionText = "Vad önskar du ska tas upp på nästa APT-möte?"
                        });
                });

            modelBuilder.Entity("LIAMockupMVC2.Models.RelationalTables.UserGroup", b =>
                {
                    b.Property<int>("UserGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserGroupId"));

                    b.Property<int>("FK_GroupId")
                        .HasColumnType("int");

                    b.Property<int>("FK_UserId")
                        .HasColumnType("int");

                    b.HasKey("UserGroupId");

                    b.HasIndex("FK_GroupId");

                    b.HasIndex("FK_UserId");

                    b.ToTable("UserGroups");

                    b.HasData(
                        new
                        {
                            UserGroupId = 1,
                            FK_GroupId = 2,
                            FK_UserId = 1
                        },
                        new
                        {
                            UserGroupId = 2,
                            FK_GroupId = 3,
                            FK_UserId = 2
                        },
                        new
                        {
                            UserGroupId = 3,
                            FK_GroupId = 1,
                            FK_UserId = 3
                        });
                });

            modelBuilder.Entity("LIAMockupMVC2.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "user33@gmail.com",
                            Password = "heyhopp33",
                            UserName = "user0033"
                        },
                        new
                        {
                            UserId = 2,
                            Email = "user44@gmail.com",
                            Password = "heyhopp44",
                            UserName = "user0044"
                        },
                        new
                        {
                            UserId = 3,
                            Email = "user55@gmail.com",
                            Password = "heyhopp55",
                            UserName = "user0055"
                        });
                });

            modelBuilder.Entity("LIAMockupMVC2.Models.Answer", b =>
                {
                    b.HasOne("LIAMockupMVC2.Models.Question", "Questions")
                        .WithMany()
                        .HasForeignKey("FK_QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LIAMockupMVC2.Models.RelationalTables.UserGroup", "UserGroups")
                        .WithMany()
                        .HasForeignKey("FK_UserGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Questions");

                    b.Navigation("UserGroups");
                });

            modelBuilder.Entity("LIAMockupMVC2.Models.Group", b =>
                {
                    b.HasOne("LIAMockupMVC2.Models.Organization", "Organizations")
                        .WithMany("Groups")
                        .HasForeignKey("FK_OrgId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organizations");
                });

            modelBuilder.Entity("LIAMockupMVC2.Models.RelationalTables.UserGroup", b =>
                {
                    b.HasOne("LIAMockupMVC2.Models.Group", "Groups")
                        .WithMany()
                        .HasForeignKey("FK_GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LIAMockupMVC2.Models.User", "Users")
                        .WithMany()
                        .HasForeignKey("FK_UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Groups");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("LIAMockupMVC2.Models.Organization", b =>
                {
                    b.Navigation("Groups");
                });
#pragma warning restore 612, 618
        }
    }
}
