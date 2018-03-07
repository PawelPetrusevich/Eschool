﻿// <auto-generated />
using ESchool.Common.Enums;
using ESchool.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace ESchool.DataAccess.Migrations
{
    [DbContext(typeof(ESchoolContext))]
    partial class ESchoolContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ESchool.Common.Model.Institution.CityDbModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CityName");

                    b.Property<DateTime>("CreatersDate");

                    b.Property<int>("CreatorId");

                    b.Property<DateTime?>("ModifierDate");

                    b.Property<int?>("ModifierId");

                    b.HasKey("Id");

                    b.ToTable("CityDbModel");
                });

            modelBuilder.Entity("ESchool.Common.Model.Institution.InstitutionDbModel", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("CityId");

                    b.Property<DateTime>("CreatersDate");

                    b.Property<int>("CreatorId");

                    b.Property<DateTime?>("ModifierDate");

                    b.Property<int?>("ModifierId");

                    b.Property<string>("SchoolAdress");

                    b.Property<int>("SchoolNumber");

                    b.HasKey("Id");

                    b.ToTable("InstutionDbModels");
                });

            modelBuilder.Entity("ESchool.Common.Model.SubjectOfInstuctions.SubjectOfInstructionsDbModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatersDate");

                    b.Property<int>("CreatorId");

                    b.Property<string>("InstructionName");

                    b.Property<DateTime?>("ModifierDate");

                    b.Property<int?>("ModifierId");

                    b.HasKey("Id");

                    b.ToTable("SubjectOfInstructionsDbModels");
                });

            modelBuilder.Entity("ESchool.Common.Model.Users.AccauntDbModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatersDate");

                    b.Property<int>("CreatorId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("Loggin");

                    b.Property<DateTime?>("ModifierDate");

                    b.Property<int?>("ModifierId");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("AccauntDbModels");

                    b.HasDiscriminator<string>("Discriminator").HasValue("AccauntDbModel");
                });

            modelBuilder.Entity("ESchool.Common.Model.Users.AccauntSettingsDbModel", b =>
                {
                    b.Property<int>("AccauntId");

                    b.Property<int?>("Age");

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Patronymic");

                    b.Property<int>("SchoolId");

                    b.HasKey("AccauntId");

                    b.ToTable("AccauntSettingsDbModels");
                });

            modelBuilder.Entity("ESchool.Common.Model.Users.LearnerDbModel", b =>
                {
                    b.HasBaseType("ESchool.Common.Model.Users.AccauntDbModel");

                    b.Property<int>("ClassId");

                    b.ToTable("LearnerDbModel");

                    b.HasDiscriminator().HasValue("LearnerDbModel");
                });

            modelBuilder.Entity("ESchool.Common.Model.Users.TeacherDbModel", b =>
                {
                    b.HasBaseType("ESchool.Common.Model.Users.AccauntDbModel");

                    b.Property<int>("ClassId")
                        .HasColumnName("TeacherDbModel_ClassId");

                    b.Property<int>("TeacherStatus");

                    b.ToTable("TeacherDbModel");

                    b.HasDiscriminator().HasValue("TeacherDbModel");
                });

            modelBuilder.Entity("ESchool.Common.Model.Institution.InstitutionDbModel", b =>
                {
                    b.HasOne("ESchool.Common.Model.Institution.CityDbModel", "City")
                        .WithMany("InstitutionsCollection")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ESchool.Common.Model.Users.AccauntSettingsDbModel", b =>
                {
                    b.HasOne("ESchool.Common.Model.Users.AccauntDbModel", "Accaunt")
                        .WithOne("AccauntSettings")
                        .HasForeignKey("ESchool.Common.Model.Users.AccauntSettingsDbModel", "AccauntId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
