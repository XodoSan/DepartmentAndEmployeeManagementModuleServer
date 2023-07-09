using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ImprovedDepartmentsRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_DepartmentId",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_DepartmentId",
                table: "Employees",
                newName: "IX_Employees_DepartmentId");

            migrationBuilder.AddColumn<Guid>(
                name: "ParentDepartmentId",
                table: "Departments",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name", "ParentDepartmentId" },
                values: new object[,]
                {
                    { new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860170"), "Отдел по обслуживанию клиентов", null },
                    { new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860171"), "Производственный отдел", null },
                    { new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860172"), "Бухгалтерия", null },
                    { new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860165"), "Отдел закупок", new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860171") },
                    { new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860166"), "Отдел проверки качества", new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860171") },
                    { new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860167"), "Инженерный отдел", new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860171") },
                    { new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860168"), "Отдел продаж", new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860170") },
                    { new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860169"), "Отдел логистики", new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860170") }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "FIO" },
                values: new object[,]
                {
                    { new Guid("c82bf146-ee8f-4acc-a055-d1da786a217d"), new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860170"), "Зубов Дмитрий Дмитриевич" },
                    { new Guid("c82bf146-ee8f-4acc-a055-d1da786a263d"), new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860172"), "Куренков Алексей Владимирович" },
                    { new Guid("c82bf146-ee8f-4acc-a055-d1da786a264d"), new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860172"), "Володин Кирилл Ильич" },
                    { new Guid("c82bf146-ee8f-4acc-a055-d1da786a268d"), new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860171"), "Зубов Семён Антонович" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name", "ParentDepartmentId" },
                values: new object[,]
                {
                    { new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860161"), "Отдел розничных продаж", new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860168") },
                    { new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860162"), "Отдел оптовых продаж", new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860168") },
                    { new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860163"), "Склад", new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860169") },
                    { new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860164"), "Отдел доставки", new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860169") }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "FIO" },
                values: new object[,]
                {
                    { new Guid("c82bf146-ee8f-4acc-a055-d1da786a211d"), new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860169"), "Зубов Семён Алексеевич" },
                    { new Guid("c82bf146-ee8f-4acc-a055-d1da786a216d"), new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860168"), "Зубов Алексей Дмитриевич" },
                    { new Guid("c82bf146-ee8f-4acc-a055-d1da786a218d"), new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860167"), "Зубов Владимир Семёнович" },
                    { new Guid("c82bf146-ee8f-4acc-a055-d1da786a219d"), new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860167"), "Борисов Борис Борисович" },
                    { new Guid("c82bf146-ee8f-4acc-a055-d1da786a265d"), new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860165"), "Козлов Кузьма Леонидович" },
                    { new Guid("c82bf146-ee8f-4acc-a055-d1da786a266d"), new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860166"), "Дубов Илларион Кузьмич" },
                    { new Guid("c82bf146-ee8f-4acc-a055-d1da786a267d"), new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860167"), "Зубов Семён Владиславович" },
                    { new Guid("c82bf146-ee8f-4acc-a055-d1da786a210d"), new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860163"), "Зубов Семён Андреевич" },
                    { new Guid("c82bf146-ee8f-4acc-a055-d1da786a212d"), new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860161"), "Зубов Семён Дмитриевич" },
                    { new Guid("c82bf146-ee8f-4acc-a055-d1da786a213d"), new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860161"), "Зубов Семён Евгеньевич" },
                    { new Guid("c82bf146-ee8f-4acc-a055-d1da786a214d"), new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860162"), "Зубов Семён Валерьевич" },
                    { new Guid("c82bf146-ee8f-4acc-a055-d1da786a215d"), new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860162"), "Зубов Семён Валерьянович" },
                    { new Guid("c82bf146-ee8f-4acc-a055-d1da786a269d"), new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860164"), "Зубов Семён Денисович" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ParentDepartmentId",
                table: "Departments",
                column: "ParentDepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Departments_ParentDepartmentId",
                table: "Departments",
                column: "ParentDepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Departments_ParentDepartmentId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_ParentDepartmentId",
                table: "Departments");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c82bf146-ee8f-4acc-a055-d1da786a210d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c82bf146-ee8f-4acc-a055-d1da786a211d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c82bf146-ee8f-4acc-a055-d1da786a212d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c82bf146-ee8f-4acc-a055-d1da786a213d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c82bf146-ee8f-4acc-a055-d1da786a214d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c82bf146-ee8f-4acc-a055-d1da786a215d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c82bf146-ee8f-4acc-a055-d1da786a216d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c82bf146-ee8f-4acc-a055-d1da786a217d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c82bf146-ee8f-4acc-a055-d1da786a218d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c82bf146-ee8f-4acc-a055-d1da786a219d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c82bf146-ee8f-4acc-a055-d1da786a263d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c82bf146-ee8f-4acc-a055-d1da786a264d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c82bf146-ee8f-4acc-a055-d1da786a265d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c82bf146-ee8f-4acc-a055-d1da786a266d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c82bf146-ee8f-4acc-a055-d1da786a267d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c82bf146-ee8f-4acc-a055-d1da786a268d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c82bf146-ee8f-4acc-a055-d1da786a269d"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860161"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860162"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860163"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860164"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860165"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860166"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860167"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860172"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860168"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860169"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860171"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860170"));

            migrationBuilder.DropColumn(
                name: "ParentDepartmentId",
                table: "Departments");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employee",
                newName: "IX_Employee_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_DepartmentId",
                table: "Employee",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
