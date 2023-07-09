using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(x => x.Department)
                .WithMany(x => x.Employees)
                .HasForeignKey(x => x.DepartmentId);

            modelBuilder.Entity<Department>()
                .HasOne(x => x.ParentDepartment)
                .WithMany(x => x.ChildDepartments)
                .HasForeignKey(x => x.ParentDepartmentId);

            modelBuilder.Entity<Employee>().HasData(new List<Employee>()
            {
                new() { Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a263d"), FIO = "Куренков Алексей Владимирович", DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860172") },
                new() { Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a264d"), FIO = "Володин Кирилл Ильич", DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860172") },
                new() { Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a265d"), FIO = "Козлов Кузьма Леонидович", DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860165") },
                new() { Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a266d"), FIO = "Дубов Илларион Кузьмич", DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860166") },
                new() { Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a267d"), FIO = "Зубов Семён Владиславович", DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860167") },
                new() { Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a268d"), FIO = "Зубов Семён Антонович", DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860171") },
                new() { Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a269d"), FIO = "Зубов Семён Денисович", DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860164") },
                new() { Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a210d"), FIO = "Зубов Семён Андреевич", DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860163") },
                new() { Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a211d"), FIO = "Зубов Семён Алексеевич", DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860169") },
                new() { Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a212d"), FIO = "Зубов Семён Дмитриевич", DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860161") },
                new() { Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a213d"), FIO = "Зубов Семён Евгеньевич", DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860161") },
                new() { Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a214d"), FIO = "Зубов Семён Валерьевич", DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860162") },
                new() { Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a215d"), FIO = "Зубов Семён Валерьянович", DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860162") },
                new() { Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a216d"), FIO = "Зубов Алексей Дмитриевич", DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860168") },
                new() { Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a217d"), FIO = "Зубов Дмитрий Дмитриевич", DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860170") },
                new() { Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a218d"), FIO = "Зубов Владимир Семёнович", DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860167") },
                new() { Id = new Guid("c82bf146-ee8f-4acc-a055-d1da786a219d"), FIO = "Борисов Борис Борисович", DepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860167") },
            });

            modelBuilder.Entity<Department>().HasData(new List<Department>()
            {
                new() { Id = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860161"), Name = "Отдел розничных продаж", ParentDepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860168") },
                new() { Id = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860162"), Name = "Отдел оптовых продаж", ParentDepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860168") },
                new() { Id = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860163"), Name = "Склад", ParentDepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860169") },
                new() { Id = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860164"), Name = "Отдел доставки", ParentDepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860169") },
                new() { Id = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860165"), Name = "Отдел закупок", ParentDepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860171") },
                new() { Id = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860166"), Name = "Отдел проверки качества", ParentDepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860171") },
                new() { Id = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860167"), Name = "Инженерный отдел", ParentDepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860171") },
                new() { Id = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860168"), Name = "Отдел продаж", ParentDepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860170") },
                new() { Id = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860169"), Name = "Отдел логистики", ParentDepartmentId = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860170") },
                new() { Id = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860170"), Name = "Отдел по обслуживанию клиентов" },
                new() { Id = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860171"), Name = "Производственный отдел" },
                new() { Id = new Guid("dbf40cdb-71d7-46da-bdc3-735e8b860172"), Name = "Бухгалтерия" },
            });
        }   
    }
}