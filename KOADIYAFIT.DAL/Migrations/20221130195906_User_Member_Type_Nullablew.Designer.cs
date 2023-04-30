﻿// <auto-generated />
using System;
using KOADIYAFIT.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KOADIYAFIT.DAL.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20221130195906_User_Member_Type_Nullablew")]
    partial class User_Member_Type_Nullablew
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FoodUser", b =>
                {
                    b.Property<int>("FoodsFoodId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("FoodsFoodId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("FoodUser");
                });

            modelBuilder.Entity("KOADIYAFIT.DATA.Entities.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodId"), 1L, 1);

                    b.Property<int>("Calorie")
                        .HasColumnType("int");

                    b.Property<byte[]>("FoodImage")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MealType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PortionSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FoodId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("KOADIYAFIT.DATA.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<double>("BMI")
                        .HasColumnType("float");

                    b.Property<string>("DiabetType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("MemberType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.Property<string>("WeightStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("KOADIYAFIT.DATA.Entities.UserMeal", b =>
                {
                    b.Property<int>("UserMealId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserMealId"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<string>("MealType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Portion")
                        .HasColumnType("int");

                    b.Property<int>("TotalCalorie")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserMealId");

                    b.HasIndex("FoodId");

                    b.HasIndex("UserId");

                    b.ToTable("UserMeals");
                });

            modelBuilder.Entity("FoodUser", b =>
                {
                    b.HasOne("KOADIYAFIT.DATA.Entities.Food", null)
                        .WithMany()
                        .HasForeignKey("FoodsFoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KOADIYAFIT.DATA.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KOADIYAFIT.DATA.Entities.UserMeal", b =>
                {
                    b.HasOne("KOADIYAFIT.DATA.Entities.Food", "Food")
                        .WithMany("UserMeals")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KOADIYAFIT.DATA.Entities.User", "User")
                        .WithMany("UserMeals")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("User");
                });

            modelBuilder.Entity("KOADIYAFIT.DATA.Entities.Food", b =>
                {
                    b.Navigation("UserMeals");
                });

            modelBuilder.Entity("KOADIYAFIT.DATA.Entities.User", b =>
                {
                    b.Navigation("UserMeals");
                });
#pragma warning restore 612, 618
        }
    }
}
