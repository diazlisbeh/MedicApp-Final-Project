﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Sqlite;
using SQLitePCL;
using Microsoft.Extensions.Configuration;

namespace DataAccess
{
   
    public class DBcont:DbContext
    {
        private string _database = Environment.CurrentDirectory + "\\database.db";
        IConfiguration configuration;
       
        public virtual DbSet<consultas>? consultas { get; set; }
        public virtual DbSet<empleados>? empleados { get; set; }
        public virtual DbSet<Medico>? medicos { get; set; }
        public virtual DbSet<pacientes>? pacientes { get; set; }
        public virtual DbSet<periodo_vacaciones>? periodo_vacaciones { get; set; }
        public virtual DbSet<sustitutos>? sustitutos { get; set; }
        public virtual DbSet<tipo_empleado>? tipo_empleado { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"DataSource='{_database}'");
           /* optionsBuilder.UseSqlite(configuration.GetConnectionString("Connection"));*/
            //SQLitePCL.Batteries.Init();
        }
    }
}