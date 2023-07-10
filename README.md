# DepartmentAndEmployeeManagementModuleServer :zap:

Проект представляет собой обыкновенное API для общения с клиентом и передачи ему данных о подразделениях и сотрудниках, которые в них работают.
Использованные технологии: ASP.NET Core 6.0, EF Core (npgSql), AutoMapper, EF Core Tools(Migrations), PostgreSQL.
Приложение написано в N-layer архитектуре и с применением паттерна MVC.

Инструкция к развёртыванию приложения:
1) Клонировать репозиторий "DepartmentAndEmployeeManagementModuleServer".
2) Создать в проекте "DepartmentAndEmployeeManagementModule" файл "appsettings.json" и добавить туда строку подключения к базе Postgres: 
 {
     "ConnectionStrings": {
       "DepartmentAndEmployee": "Your connection string"
     }
 }
3) В Postgres создать базу, скрипт для создания: "CREATE DATABASE departmentandemployee;"
4) Открыть консоль диспетчера пакетов, ввести команду "Update-Database", чтобы применить к базе имеющиеся миграции

Билдить UI-приложение необязательно, так как проект запускается с уже готовыми файлами билда, находящимся в папке wwwroot 

5) Запускаем приложение и наслаждаемся:)
