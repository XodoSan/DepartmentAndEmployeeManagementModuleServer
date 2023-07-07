﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20230707171454_AddedSubdivisionsRelationships")]
    partial class AddedSubdivisionsRelationships
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860161"),
                            Name = "Отдел розничных продаж"
                        },
                        new
                        {
                            Id = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860162"),
                            Name = "Отдел оптовых продаж"
                        },
                        new
                        {
                            Id = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860163"),
                            Name = "Склад"
                        },
                        new
                        {
                            Id = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860164"),
                            Name = "Отдел доставки"
                        },
                        new
                        {
                            Id = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860165"),
                            Name = "Отдел закупок"
                        },
                        new
                        {
                            Id = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860166"),
                            Name = "Отдел проверки качества"
                        },
                        new
                        {
                            Id = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860167"),
                            Name = "Инженерный отдел"
                        },
                        new
                        {
                            Id = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860168"),
                            Name = "Отдел продаж"
                        },
                        new
                        {
                            Id = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860169"),
                            Name = "Отдел логистики"
                        },
                        new
                        {
                            Id = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860170"),
                            Name = "Отдел по обслуживанию клиентов"
                        },
                        new
                        {
                            Id = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860171"),
                            Name = "Производственный отдел"
                        },
                        new
                        {
                            Id = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860172"),
                            Name = "Бухгалтерия"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uuid");

                    b.Property<string>("FIO")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a263d"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860172"),
                            FIO = "Куренков Алексей Владимирович"
                        },
                        new
                        {
                            Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a264d"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860172"),
                            FIO = "Володин Кирилл Ильич"
                        },
                        new
                        {
                            Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a265d"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860165"),
                            FIO = "Козлов Кузьма Леонидович"
                        },
                        new
                        {
                            Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a266d"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860166"),
                            FIO = "Дубов Илларион Кузьмич"
                        },
                        new
                        {
                            Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a267d"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860167"),
                            FIO = "Зубов Семён Владиславович"
                        },
                        new
                        {
                            Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a268d"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860171"),
                            FIO = "Зубов Семён Антонович"
                        },
                        new
                        {
                            Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a269d"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860164"),
                            FIO = "Зубов Семён Денисович"
                        },
                        new
                        {
                            Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a210d"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860163"),
                            FIO = "Зубов Семён Андреевич"
                        },
                        new
                        {
                            Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a211d"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860169"),
                            FIO = "Зубов Семён Алексеевич"
                        },
                        new
                        {
                            Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a212d"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860161"),
                            FIO = "Зубов Семён Дмитриевич"
                        },
                        new
                        {
                            Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a213d"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860161"),
                            FIO = "Зубов Семён Евгеньевич"
                        },
                        new
                        {
                            Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a214d"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860162"),
                            FIO = "Зубов Семён Валерьевич"
                        },
                        new
                        {
                            Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a215d"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860162"),
                            FIO = "Зубов Семён Валерьянович"
                        },
                        new
                        {
                            Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a216d"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860168"),
                            FIO = "Зубов Алексей Дмитриевич"
                        },
                        new
                        {
                            Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a217d"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860170"),
                            FIO = "Зубов Дмитрий Дмитриевич"
                        },
                        new
                        {
                            Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a218d"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860167"),
                            FIO = "Зубов Владимир Семёнович"
                        },
                        new
                        {
                            Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a219d"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860167"),
                            FIO = "Борисов Борис Борисович"
                        });
                });

            modelBuilder.Entity("Domain.Entities.ReferenceDepartment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ParentDepartmentId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("ParentDepartmentId");

                    b.ToTable("ReferenceDepartment");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ef56c9fb-889d-4dbb-98db-27883d8cb0e0"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860168"),
                            ParentDepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860170")
                        },
                        new
                        {
                            Id = new Guid("ef56c9fb-889d-4dbb-98db-27883d8cb0e1"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860169"),
                            ParentDepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860170")
                        },
                        new
                        {
                            Id = new Guid("ef56c9fb-889d-4dbb-98db-27883d8cb0e2"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860167"),
                            ParentDepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860171")
                        },
                        new
                        {
                            Id = new Guid("ef56c9fb-889d-4dbb-98db-27883d8cb0e3"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860166"),
                            ParentDepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860171")
                        },
                        new
                        {
                            Id = new Guid("ef56c9fb-889d-4dbb-98db-27883d8cb0e4"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860165"),
                            ParentDepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860171")
                        },
                        new
                        {
                            Id = new Guid("ef56c9fb-889d-4dbb-98db-27883d8cb0e5"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860162"),
                            ParentDepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860168")
                        },
                        new
                        {
                            Id = new Guid("ef56c9fb-889d-4dbb-98db-27883d8cb0e6"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860161"),
                            ParentDepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860168")
                        },
                        new
                        {
                            Id = new Guid("ef56c9fb-889d-4dbb-98db-27883d8cb0e7"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860163"),
                            ParentDepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860169")
                        },
                        new
                        {
                            Id = new Guid("ef56c9fb-889d-4dbb-98db-27883d8cb0e8"),
                            DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860164"),
                            ParentDepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860169")
                        });
                });

            modelBuilder.Entity("Domain.Entities.Employee", b =>
                {
                    b.HasOne("Domain.Entities.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Domain.Entities.ReferenceDepartment", b =>
                {
                    b.HasOne("Domain.Entities.Department", "Department")
                        .WithMany("ChildDepartments")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Department", "ParentDepartment")
                        .WithMany("Departments")
                        .HasForeignKey("ParentDepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("ParentDepartment");
                });

            modelBuilder.Entity("Domain.Entities.Department", b =>
                {
                    b.Navigation("ChildDepartments");

                    b.Navigation("Departments");

                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
