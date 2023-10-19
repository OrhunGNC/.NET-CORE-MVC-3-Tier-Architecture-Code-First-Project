﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using coreData.Data;

namespace coreData.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("coreModel.Model.Kid", b =>
                {
                    b.Property<int>("KidId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.HasKey("KidId");

                    b.HasIndex("PersonelId");

                    b.ToTable("Kids");
                });

            modelBuilder.Entity("coreModel.Model.Personel", b =>
                {
                    b.Property<int>("PersonelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Bonus")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShiftStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaskksId")
                        .HasColumnType("int");

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.HasKey("PersonelId");

                    b.HasIndex("TaskksId");

                    b.HasIndex("TitleId");

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("coreModel.Model.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TaskksId")
                        .HasColumnType("int");

                    b.HasKey("ProjectId");

                    b.HasIndex("TaskksId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("coreModel.Model.Taskks", b =>
                {
                    b.Property<int>("TaskksId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TaskkDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaskkName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaskkPoint")
                        .HasColumnType("int");

                    b.HasKey("TaskksId");

                    b.ToTable("Taskkss");
                });

            modelBuilder.Entity("coreModel.Model.Titles", b =>
                {
                    b.Property<int>("TitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TitleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TitleId");

                    b.ToTable("Title");
                });

            modelBuilder.Entity("coreModel.Model.Units", b =>
                {
                    b.Property<int>("UnitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumbofEmployee")
                        .HasColumnType("int");

                    b.Property<int>("TaskksId")
                        .HasColumnType("int");

                    b.Property<string>("UnitName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UnitId");

                    b.HasIndex("TaskksId");

                    b.ToTable("Unit");
                });

            modelBuilder.Entity("coreModel.Model.Kid", b =>
                {
                    b.HasOne("coreModel.Model.Personel", "Personel")
                        .WithMany()
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("coreModel.Model.Personel", b =>
                {
                    b.HasOne("coreModel.Model.Taskks", "Taskks")
                        .WithMany()
                        .HasForeignKey("TaskksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("coreModel.Model.Titles", "Title")
                        .WithMany()
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Taskks");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("coreModel.Model.Project", b =>
                {
                    b.HasOne("coreModel.Model.Taskks", "Taskks")
                        .WithMany()
                        .HasForeignKey("TaskksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Taskks");
                });

            modelBuilder.Entity("coreModel.Model.Units", b =>
                {
                    b.HasOne("coreModel.Model.Taskks", "Taskks")
                        .WithMany()
                        .HasForeignKey("TaskksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Taskks");
                });
#pragma warning restore 612, 618
        }
    }
}
